using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.NeurNet
{
    public class InputNeuron : Neuron
    {
        public override double Activation(double x)
        {
            return Input;
        }

        public override double ActivationDerivative(double x)
        {
            return 0;
        }

        public InputNeuron()
        {
            Inputs = new List<NeuronBinding>();
            Outputs = new List<NeuronBinding>();
        }
    }
}
