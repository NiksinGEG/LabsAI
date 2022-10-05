using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.NeurNet
{
    public class NeuronNetwork
    {
        public ICollection<ICollection<Neuron>> Layers;

        public NeuronNetwork()
        {
            Layers = new List<ICollection<Neuron>>();
        }

        public NeuronNetwork AddStraightLayer(int size)
        {
            var neurons = new List<Neuron>();
            List<Neuron> last = null;
            if (Layers.Count() > 0)
                last = Layers.Last().ToList();
            for(int i = 0; i < size; i++)
            {
                var newNeu = new Neuron(1);
                if(last != null)
                {
                    foreach(var n in last)
                    {
                        newNeu.Inputs.Add(new NeuronBinding(n, 1));
                    }
                }
                neurons.Add(newNeu);
            }
            Layers.Add(neurons);
            return this;
        }

        public void Fit(IEnumerable<(IEnumerable<double>, IEnumerable<double>)> data)
        {
            var frontLayer = Layers.First();
            var lastLayer = Layers.Last();
            foreach(var tupl in data)
            {
                foreach (var n in frontLayer)
                {
                    n.Inputs.Clear();
                    foreach (var inp in tupl.Item1)
                    {
                        n.Inputs.Add(new NeuronBinding(null, inp));
                    }
                }
                if (tupl.Item2.Count() != Layers.Last().Count())
                    throw new Exception("Размеры обучающих выходов и выходов нейронной сети должны совпадать");

                var res = lastLayer.Select(n => n.Calc());
                var errors = new List<double>();
                for (int i = 0; i < res.Count(); i++)
                    errors.Add(tupl.Item2.ElementAt(i) - res.ElementAt(i));

            }
        }
    }
}
