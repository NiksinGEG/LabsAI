using SubLaba1.Models;
using SubLaba1.Networks;

namespace SubLaba1.Controllers
{
    public class HopfieldController : INetworkController
    {
        public bool IsLearnRunning => false;

        public EventHandler<int>? OnLearnStep { get; set; }
        public EventHandler? OnLearnEnd { get; set; }

        private IMainForm _form;

        private int _size;

        private HopfieldNetwork? _net;

        public HopfieldController(int inputSize, IMainForm form)
        {
            _form = form;
            _size = inputSize;
        }

        public void CancelLearning()
        {
            
        }

        public IEnumerable<string> GetGuessableData()
        {
            return new string[0];
        }

        public TrainDataModel GetSavingModel(IEnumerable<int> pixels, string value)
        {
            return new TrainDataModel()
            {
                Inputs = pixels.Select(px => px > 0 ? 1 : -1),
                Number = 12321
            };
        }

        public string Guess(IEnumerable<int> pixels)
        {
            var data = pixels.Select(x => (double)(x > 0 ? 1 : -1));
            var res = _net?.Guess(data, x => x > 0 ? 1 : -1) ?? throw new Exception("ABOBA");
            pixels = res.Select(x => x > 0 ? 1 : 0);
            var size = _form.PictureInput.Size;
            int i = 0;
            int j = 0;
            foreach (var px in pixels)
            {
                if (j == size)
                {
                    j = 0;
                    i++;
                }
                _form.PictureInput.Pixels[i, j++] = px;
            }
            _form.PictureInput.Draw();
            return "";
        }

        public void StartLearning(IEnumerable<TrainDataModel> trainData, double learnFactor, int maxEpoch)
        {
            var data = trainData.Select(x => x.Inputs.Select(y => (double)y));
            _net = new HopfieldNetwork(_size, data);
            _net.Fit();
            OnLearnEnd?.Invoke(this, new EventArgs());
        }
    }
}
