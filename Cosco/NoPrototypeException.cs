namespace Cosco
{
    internal class NoPrototypeException : Exception
    {
        public IEnumerable<double> Image { get; set; }

        public IEnumerable<double> Association { get; set; }

        public NoPrototypeException(IEnumerable<double> img, IEnumerable<double> assoc, string msg) : base(msg)
        {
            Image = img;
            Association = assoc;
        }
    }
}
