using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4.NeurNet
{
    public class NeuronNetwork
    {
        public ICollection<ICollection<Neuron>> Layers;

        public double LearnFactor { get; set; }

        public NeuronNetwork(double learnFactor)
        {
            Layers = new List<ICollection<Neuron>>();
            LearnFactor = learnFactor;
        }

        private double Sigmoid(double x)
        {
            return 1.0 / (1 + Math.Exp(-x));
        }

        /// <summary>
        /// Добавить слой размера size с прямыми связями
        /// </summary>
        /// <param name="size">Размер слоя</param>
        /// <returns>Объект ФНС с добавленным слоем, для записи в цепочке</returns>
        public NeuronNetwork AddStraightLayer(int size)
        {
            var neurons = new List<Neuron>();
            var last = Layers?.LastOrDefault()?.ToList();
            for(int i = 0; i < size; i++)
            {
                var newNeu = new Neuron(x => Sigmoid(x), x => Sigmoid(x) * (1 - Sigmoid(x)));
                newNeu.Inputs = last?.Select(n => new NeuronBinding(n, 1)).ToList() ?? new List<NeuronBinding>();
                neurons.Add(newNeu);
            }
            last?.ForEach(l => l.Outputs = neurons.Select(n => new NeuronBinding(n, 0)).ToList());
            Layers.Add(neurons);
            return this;
        }

        /// <summary>
        /// Обучить ФНС
        /// </summary>
        /// <param name="data">Тренировочные данные, пары типа "Входы - ожидаемые выходы"</param>
        public void Fit(IEnumerable<(IEnumerable<double>, IEnumerable<double>)> data)
        {
            foreach(var trainData in data)
            {
                //Вводим входящие данные как фиктивный слой
                Layers.First().ToList().ForEach(n => n.Inputs = trainData.Item1.Select(i => new NeuronBinding(null, i)).ToList());

                //Подсчёт ошибок
                //TODO: подумать как сделать красиво, потому что Reverse() это O(N), но и обращение к i-му элему списка это O(N)
                var reversedLayers = Layers.Reverse();
                foreach(var layer in reversedLayers)
                {
                    if(layer == Layers.Last())
                    {
                        if (layer.Count() != trainData.Item2.Count()) throw new Exception("Количество классов на выходе нейросети не равно количеству тренировочных классов!");
                        layer.Zip(trainData.Item2, (n, res) => n.Cost = res - n.Calc());
                    }
                    else
                    {
                        layer.ToList().ForEach(n => n.CalcAndSetCost());
                    }
                }

                //Пересчёт весов связей
                foreach(var layer in reversedLayers) //Ай
                {
                    foreach(var neuron in layer) //Йяй
                    {
                        foreach(var inp in neuron.Inputs) //Йяй
                        {
                            inp.Weight += LearnFactor * neuron.Cost * neuron.ActivationDerivative(neuron.Potential()) * inp.Neuron.Calc();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Получить результат по входным данным
        /// </summary>
        /// <param name="inputs">Входные данные</param>
        /// <returns>Выходные значения последнего слоя ФНС</returns>
        public IEnumerable<double> Output(IEnumerable<double> inputs)
        {
            Layers.First().ToList().ForEach(n => n.Inputs = inputs.Select(i => new NeuronBinding(null, i)).ToList());
            return Layers.Last().Select(neuron => neuron.Calc());
        }
    }
}
