namespace SubLaba1.Neurons
{
    public class InputNeuron : Neuron
    {
        public override double Activation(double x)
        {
            return Input;
        }

        public override double ActivationDerivative(double x) => throw new NotImplementedException();

        public InputNeuron(double input)
        {
            Input = input;
            Inputs = new List<NeuronBinding>();
            Outputs = new List<NeuronBinding>();
        }
    }
}
