using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.NeurNet
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
