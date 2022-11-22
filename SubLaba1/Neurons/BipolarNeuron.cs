namespace SubLaba1.Neurons
{
    public class BipolarNeuron : Neuron
    {
        public override double Activation(double x)
        {
            return x > 0 ? 1 : -1;
        }

        public override double ActivationDerivative(double x) => throw new NotImplementedException();

        public BipolarNeuron()
        {
            Inputs = new List<NeuronBinding>();
            Outputs = new List<NeuronBinding>();
        }
    }
}
