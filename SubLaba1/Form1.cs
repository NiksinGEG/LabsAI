using SubLaba1.Models;
using SubLaba1.Helpers;

namespace SubLaba1
{
    public partial class MainForm : Form
    {
        private readonly PictureInput _pictInput;
        private Perceptron perceptron;
        private Task learningTask;
        private CancellationTokenSource learningCancelToken;

        public MainForm()
        {
            InitializeComponent();
            int pictureSize = 8;
            _pictInput = new PictureInput(MainCanvas, pictureSize);
            learningCancelToken = new CancellationTokenSource();
            perceptron = new Perceptron(pictureSize * pictureSize);
            perceptron.OnLearnStep += OnLearnStep;
            perceptron.OnLearnEnd += OnLearnEnd;
        }

        private void AddTrainBtn_Click(object sender, EventArgs e)
        {
            var newData = new TrainDataModel()
            {
                Number = int.Parse(NumberComboBox.Text) == 0 ? 1 : -1,
                Inputs = MapPixels(_pictInput.Pixels)
            };
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
            if (learningTask != null && learningTask.Status == TaskStatus.Running)
            {
                learningCancelToken.Cancel();
                LearnBtn.Text = "Начать обучение";
                return;
            }
            var maxEpoch = (int)MaxIterationsNud.Value;
            progressBar.Maximum = maxEpoch;
            progressBar.Minimum = 0;
            progressBar.Value = 0;

            var data = this.GetLearnData(FileNameInput.Text);
            LearnBtn.Text = "Остановить обучение";
            learningTask = Task.Factory.StartNew(() =>
            {
                perceptron.Fit(data, maxEpoch);
            }, learningCancelToken.Token);
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            var inputs = MapPixels(_pictInput.Pixels).Select(x => (double)x);
            var answer = perceptron.Guess(inputs);
            AnswerLbl.Text = (answer < 0 ? 5 : 0).ToString();
        }

        private IEnumerable<(IEnumerable<double>, double)> GetLearnData(string filename)
        {
            var dataModels = TrainDataSaver.FromFile(filename);
            var res = new List<(IEnumerable<double>, double)>();
            foreach (var model in dataModels)
            {
                res.Add((model.Inputs.Select(x => (double)x), model.Number));
            }
            return res;
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