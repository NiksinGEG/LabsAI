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

        private (string letter, double[] outputs)[] valuesDict = new (string, double[])[]
        {
            ("Д", new double[] { 1, 0 }),
            ("И", new double[] { 0, 1 })
        };

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
            return valuesDict.Select(x => x.letter);
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
            return valuesDict[i].letter;
        }

        private IEnumerable<(IEnumerable<double>, IEnumerable<double>)> GetDataByModel(IEnumerable<TrainDataModel> models)
        {
            var res = new List<(IEnumerable<double>, IEnumerable<double>)>();
            foreach (var m in models)
            {
                res.Add((m.Inputs.Select(x => (double)x), valuesDict[m.Number].outputs));
            }
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
