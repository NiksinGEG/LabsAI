using System;
using System.Collections.Generic;

namespace Lab4.NeurNet
{
    public class Neuron
    {
        public ICollection<NeuronBinding> Inputs { get; set; }
        public ICollection<Neuron> Outputs { get; set; }
        public double FreeWeight { get; set; }

        public Neuron(double freeWeight)
        {
            Inputs = new List<NeuronBinding>();
            Outputs = new List<Neuron>();
            FreeWeight = freeWeight;
        }
        public double InputSumm()
        {
            double res = 0;
            foreach(var inp in Inputs)
            {
                res += (inp.Neuron?.Calc() ?? 0) + inp.Weight;
            }
            res += FreeWeight;
            return res;
        }

        private double Sigmoid(double x)
        {
            return 1.0 / (1 + Math.Exp(-x));
        }

        public double Calc()
        {
            return Sigmoid(InputSumm());
        }
    }
}
