using SubLaba1.Models;
using SubLaba1.Networks;

namespace SubLaba1.Controllers
{
    public class Lab1Controller : INetworkController
    {
        private Perceptron perceptron;
        private Task? learningTask;
        private CancellationTokenSource learningCancelToken;

        public EventHandler<int>? OnLearnStep { get; set; }
        public EventHandler? OnLearnEnd { get; set; }
        public bool IsLearnRunning => learningTask != null && learningTask.Status == TaskStatus.Running;

        public Lab1Controller(int inputSize)
        {
            perceptron = new Perceptron(inputSize);
            perceptron.OnLearnStep += HandleLearnStep;
            perceptron.OnLearnEnd += HandleLearnEnd;
            learningCancelToken = new CancellationTokenSource();
        }

        public TrainDataModel GetSavingModel(IEnumerable<int> pixels, string number)
        {
            return new TrainDataModel()
            {
                Inputs = pixels.Select(x => x > 0 ? 1 : -1),
                Number = int.Parse(number) == 0 ? 1 : -1
            };
        }

        public IEnumerable<string> GetGuessableData()
        {
            return new string[] { "0", "5" };
        }

        public void StartLearning(IEnumerable<TrainDataModel> trainData, double _, int maxEpoch)
        {
            if (IsLearnRunning) throw new Exception("Обучение уже запущено");

            var data = GetDataByModel(trainData);

            learningTask = Task.Factory.StartNew(() =>
            {
                perceptron.Fit(data, maxEpoch);
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
            var answer = perceptron.Guess(inputs);
            return (answer < 0 ? 5 : 0).ToString();
        }

        private IEnumerable<(IEnumerable<double>, double)> GetDataByModel(IEnumerable<TrainDataModel> model)
        {
            var res = new List<(IEnumerable<double>, double)>();
            foreach (var m in model)
            {
                res.Add((m.Inputs.Select(x => (double)x), m.Number));
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
    }
}
