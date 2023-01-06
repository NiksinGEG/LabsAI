using SubLaba1.Helpers;
using SubLaba1.Models;
using SubLaba1.Networks;

namespace SubLaba1.Controllers
{
    internal class Lab5BController : INetworkController
    {
        public bool IsLearnRunning => learningTask != null && learningTask.Status == TaskStatus.Running;

        public EventHandler<int>? OnLearnStep { get; set; }
        public EventHandler? OnLearnEnd { get; set; }

        private NeuronNetwork network;
        private Task? learningTask;
        private CancellationTokenSource learningCancelToken;

        public string[] values = new string[] { "Д", "И" };

        public Lab5BController(int inputSize)
        {
            learningCancelToken = new CancellationTokenSource();
            network = new NeuronNetwork()
                .AddStraightLayer(inputSize) // Входной
                .AddStraightLayer(inputSize / 2) // Скрытый
                .AddStraightLayer(2); // Выходной
            network.OnLearnStep += HandleStep;
            network.OnLearnEnd += HandleEnd;
        }
        public IEnumerable<string> GetGuessableData()
        {
            return values;
        }

        public TrainDataModel GetSavingModel(IEnumerable<int> pixels, string value)
        {
            int num = 0;
            while (values[num] != value) num++;
            return new TrainDataModel()
            {
                Inputs = pixels,
                Number = num
            };
        }

        public void CancelLearning()
        {
            if (IsLearnRunning)
            {
                network.IsStopped = true;
            }
        }

        public void StartLearning(IEnumerable<TrainDataModel> trainData, double learnFactor, int maxEpoch)
        {
            if (IsLearnRunning) throw new Exception("Обучение уже запущено");
            network.IsStopped = false;

            var data = GetDataByModel(trainData);

            learningTask = Task.Factory.StartNew(() =>
            {
                network.Fit(data, learnFactor, maxEpoch);
            }, learningCancelToken.Token);
        }

        public string Guess(IEnumerable<int> pixels)
        {
            var inputs = pixels.Select(x => (double)x);
            var answer = network.Output(inputs);
            var i = answer.IndexOf(answer.Max());
            return values[i];
        }

        private IEnumerable<(IEnumerable<double>, IEnumerable<double>)> GetDataByModel(IEnumerable<TrainDataModel> models)
        {
            var res = new List<(IEnumerable<double>, IEnumerable<double>)>();
            foreach (var m in models)
            {
                res.Add((m.Inputs.Select(x => (double)x), OutputsByIndex(m.Number)));
            }
            return res;
        }

        private IEnumerable<double> OutputsByIndex(int index)
        {
            var res = new double[values.Length];
            for (int i = 0; i < values.Length; i++) res[i] = i == index ? 1 : 0;
            return res;
        }

        private void HandleStep(object? s, int e)
        {
            OnLearnStep?.Invoke(s, e);
        }

        private void HandleEnd(object? s, EventArgs e)
        {
            OnLearnEnd?.Invoke(s, e);
        }
    }
}
