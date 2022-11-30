using SubLaba1.Helpers;
using SubLaba1.Controllers;

namespace SubLaba1
{
    public partial class MainForm : Form
    {
        private readonly PictureInput _pictInput;
        private INetworkController controller;

        public MainForm()
        {
            InitializeComponent();

            int pictureSize = 8;
            _pictInput = new PictureInput(MainCanvas, pictureSize);

            controller = new Lab2Controller(pictureSize * pictureSize);
            controller.OnLearnStep += OnLearnStep;
            controller.OnLearnEnd += OnLearnEnd;

            NumberComboBox.Items.Clear();
            var gusssableData = controller.GetGuessableData();
            foreach (var data in gusssableData) NumberComboBox.Items.Add(data);
        }

        private void AddTrainBtn_Click(object sender, EventArgs e)
        {
            var inputs = MapPixels(_pictInput.Pixels);
            var newData = controller.GetSavingModel(inputs, NumberComboBox.Text);
            try
            {
                TrainDataSaver.Save(FileNameInput.Text, newData);
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить данные в указанный файл!", "Ошибка");
            }
        }

        private void FileChosingBtn_Click(object sender, EventArgs e)
        {
            var dialogRes = openFileDialog.ShowDialog();
            if (dialogRes != DialogResult.OK) return;
            FileNameInput.Text = openFileDialog.FileName;
        }

        private void LearnBtn_Click(object sender, EventArgs e)
        {
            if (controller.IsLearnRunning)
            {
                controller.CancelLearning();
                LearnBtn.Text = "Начать обучение";
                return;
            }

            var maxEpoch = (int)MaxIterationsNud.Value;
            var factor = (double)LearnFactorNud.Value;
            var data = TrainDataSaver.FromFile(FileNameInput.Text);
            
            progressBar.Maximum = maxEpoch;
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            LearnBtn.Text = "Остановить обучение";

            try
            {
                controller.StartLearning(data, factor, maxEpoch);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось начать обучение. Ошибка:" + Environment.NewLine + ex.Message, "ОШИБКА");
            }
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            var inputs = MapPixels(_pictInput.Pixels);
            AnswerLbl.Text = controller.Guess(inputs);
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            _pictInput.Reset();
            _pictInput.Draw();
        }

        private void OnLearnStep(object? sender, int epoch)
        {
            progressBar.Invoke(() =>
            {
                progressBar.Value = epoch;
            });
        }

        private void OnLearnEnd(object? sender, EventArgs e)
        {
            progressBar.Invoke(() =>
            {
                progressBar.Value = progressBar.Maximum;
            });
            LearnBtn.Invoke(() =>
            {
                LearnBtn.Text = "Начать обучение";
            });
        }

        private IEnumerable<int> MapPixels(double[,] pixels)
        {
            var res = new List<int>();
            int size = pixels.GetLength(0);
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    res.Add(pixels[i, j] > 0 ? 1 : 0);
            return res;
        }
    }
}