namespace Lab3.Events
{
    public class GraphEventArgs
    {
        public int Iterations { get; set; }
        public double Length { get; set; }
        public GraphEventArgs(int iters, double len)
        {
            Iterations = iters;
            Length = len;
        }
    }
}
