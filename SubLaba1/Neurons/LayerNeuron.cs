namespace SubLaba1.Neurons
{
    public class LayerNeuron : Neuron
    {
        public override double Activation(double x)
        {
            return 1.0 / (1 + Math.Exp(-x));
        }

        public override double ActivationDerivative(double x)
        {
            return Activation(x) * (1 - Activation(x));
        }

        public LayerNeuron()
        {
            Inputs = new List<NeuronBinding>();
            Outputs = new List<NeuronBinding>();
        }
    }
}
