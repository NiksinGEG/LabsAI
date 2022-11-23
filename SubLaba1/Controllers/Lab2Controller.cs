using SubLaba1.Models;
using SubLaba1.Networks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubLaba1.Controllers
{
    public class Lab2Controller : INetworkController
    {
        public bool IsLearnRunning => learningTask != null && learningTask.Status == TaskStatus.Running;

        public EventHandler<int>? OnLearnStep { get; set; }
        public EventHandler? OnLearnEnd { get; set; }

        private PerceptronNetwork network;
        private Task? learningTask;
        private CancellationTokenSource learningCancelToken;

        /// <summary>
        /// Связка буквы с ожидаемыми для неё выходами нейронки<br/>
        /// В файле как значение сохраняется индекс (0..4) записи этого словаря
        /// </summary>
        private (string, double[])[] valuesDict = new (string, double[])[]
        {
            ("д", new double[] { 1, -1, -1, -1, -1 }),
            ("и", new double[] { -1, 1, -1, -1, -1 }),
            ("о", new double[] { -1, -1, 1, -1, -1 }),
            ("р", new double[] { -1, -1, -1, 1, -1 }),
            ("е", new double[] { -1, -1, -1, -1, 1 })
        };

        public Lab2Controller(int inputSize)
        {
            network = new PerceptronNetwork(inputSize, valuesDict.Length);
            network.OnLearnStep += HandleLearnStep;
            network.OnLearnEnd += HandleLearnEnd;
            learningCancelToken = new CancellationTokenSource();
        }

        public IEnumerable<string> GetGuessableData()
        {
            return valuesDict.Select(x => x.Item1);
        }

        public TrainDataModel GetSavingModel(IEnumerable<int> pixels, string value)
        {
            int num = 0;
            while (valuesDict[num].Item1 != value) num++;
            return new TrainDataModel()
            {
                Inputs = pixels,
                Number = num
            };
        }

        public void StartLearning(IEnumerable<TrainDataModel> trainData, int maxEpoch)
        {
            if (IsLearnRunning) throw new Exception("Обучение уже запущено");

            var data = GetDataByModel(trainData);

            learningTask = Task.Factory.StartNew(() =>
            {
                network.Fit(data, maxEpoch);
            }, learningCancelToken.Token);
        }

        public void CancelLearning()
        {
            if (IsLearnRunning)
            {
                learningCancelToken.Cancel();
            }
        }

        public string Guess(IEnumerable<int> pixels)
        {
            var inputs = pixels.Select(x => (double)x);
            var answer = network.Guess(inputs);
            var i = IndexOfClosest(answer, 1);
            return valuesDict[i].Item1;
        }

        private IEnumerable<(IEnumerable<double>, IEnumerable<double>)> GetDataByModel(IEnumerable<TrainDataModel> model)
        {
            var res = new List<(IEnumerable<double>, IEnumerable<double>)>();
            foreach (var m in model)
            {
                res.Add((m.Inputs.Select(x => (double)x), valuesDict[m.Number].Item2));
            }
            return res;
        }

        private void HandleLearnStep(object? sender, int epoch)
        {
            OnLearnStep?.Invoke(sender, epoch);
        }

        private void HandleLearnEnd(object? sender, EventArgs e)
        {
            OnLearnEnd?.Invoke(sender, e);
        }

        private int IndexOfClosest(IEnumerable<double> inputs, double value)
        {
            int resIndex = 0;
            double minDelta = double.NaN;
            int i = 0;
            foreach (var inp in inputs)
            {
                var delta = Math.Abs(value - inp);
                if (double.IsNaN(minDelta) || delta < minDelta)
                {
                    resIndex = i;
                    minDelta = delta;
                }
            }
            return resIndex;
        }
    }
}
