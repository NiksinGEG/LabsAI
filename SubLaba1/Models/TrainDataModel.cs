namespace SubLaba1.Models
{
    public class TrainDataModel
    {
        public IEnumerable<int> Inputs { get; set; }
        public int Number { get; set; }

        public TrainDataModel()
        {
            Inputs = new List<int>();
        }
    }
}
