﻿namespace Lab4.NeurNet
{
    public class NeuronBinding
    {
        public Neuron Neuron { get; set; }
        public double Weight { get; set; }

        public NeuronBinding(Neuron n, double w)
        {
            Neuron = n;
            Weight = w;
        }
    }
}
