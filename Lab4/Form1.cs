using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab4.Helpers;
using Lab4.Models;
using Lab4.NeurNet;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public IEnumerable<double> Picture { get; set; }
        private readonly PictureInput _pinp;
        private readonly NeuronNetwork _network;

        public Form1()
        {
            InitializeComponent();
            _pinp = new PictureInput(mainCanvas, 8);

            _network = new NeuronNetwork();
            _network.AddStraightLayer(_pinp.Size * _pinp.Size)
                .AddStraightLayer(_pinp.Size)
                .AddStraightLayer(10);
        }

        public LearnViewModel GetFromView()
        {
            return new LearnViewModel()
            {
                Epoch = (int)epochNud.Value,
                LearnFactor = (double)learnFactorNud.Value,
            };
        }

        public void SetLearnData(LearnViewModel model)
        {
            this.mainPb.Maximum = model.LearnProgressMax;
            this.mainPb.Value = model.LearnProgress;
        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            var dialogRes = openFileDialog.ShowDialog();
            if (dialogRes != DialogResult.OK) return;
            filenamePb.Text = openFileDialog.FileName;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var trainModel = new TrainDataModel();
            trainModel.Number = (int)numberNud.Value;
            trainModel.Inputs = MapPixels(_pinp.Pixels, _pinp.Size).Select(x => x > 0.5 ? 1 : 0);
            try
            {
                TrainDataSaver.Save(filenamePb.Text, trainModel);
                statusLbl.Text = "Добавлено в файл!";
            }
            catch
            {
                statusLbl.Text = "Не удается сохранить данные в указанный файл!";
            }
        }

        delegate void SmthWithString(string s);

        private void UpdateStatus(string status)
        {
            statusLbl.Text = status;
        }

        private void learnBtn_Click(object sender, EventArgs e)
        {
            var trainModels = new List<TrainDataModel>();
            try
            {
                trainModels = TrainDataSaver.FromFile(filenamePb.Text);
            }
            catch
            {
                statusLbl.Text = "Не удалось считать данные для обучения";
            }

            statusLbl.Text = "Подготовка обучающих данных";
            var trainData = trainModels.Select(x => (x.Inputs.Select(y => (double)y), OutputsByNumber(x.Number)));
            statusLbl.Text = "Обучение...";
            SmthWithString func = UpdateStatus;
            var learnTask = Task.Factory.StartNew(() =>
            {
                _network.Fit(trainData, (double)learnFactorNud.Value, (int)epochNud.Value);
                statusLbl.Invoke(func, "Обучение завершено!");
            });
        }

        private IEnumerable<double> OutputsByNumber(int number)
        {
            var res = new double[10];
            for (int i = 0; i < 10; i++) res[i] = 0;
            res[number] = 1;
            return res;
        }

        private IEnumerable<double> MapPixels(double[,] pixels, int size)
        {
            var res = new List<double>();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    res.Add(pixels[i, j]);
            return res;
        }

        private int NumberByOutputs(IEnumerable<double> outs)
        {
            double max = double.NaN;
            int index = -1;
            int i = 0;
            foreach (var o in outs)
            {
                if(double.IsNaN(max) || o > max)
                {
                    max = o;
                    index = i;
                }
                ++i;
            }
            return index;
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            var inputs = MapPixels(_pinp.Pixels, _pinp.Size);
            var outs = _network.Output(inputs);
            int res = NumberByOutputs(outs);
            mainLbl.Text = res.ToString();
        }
    }
}
