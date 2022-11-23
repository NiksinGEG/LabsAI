using SubLaba1.Models;

namespace SubLaba1.Controllers
{
    public interface INetworkController
    {
        IEnumerable<string> GetGuessableData();

        TrainDataModel GetSavingModel(IEnumerable<int> pixels, string number);

        void StartLearning(IEnumerable<TrainDataModel> trainData, int maxEpoch);

        bool IsLearnRunning { get; }

        void CancelLearning();

        string Guess(IEnumerable<int> pixels);

        EventHandler<int>? OnLearnStep { get; set; }

        EventHandler? OnLearnEnd { get; set; }
    }
}
