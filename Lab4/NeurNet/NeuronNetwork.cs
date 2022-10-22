using System;
using System.Collections.Generic;
using System.Linq;
using Lab4.Helpers;

namespace Lab4.NeurNet
{
    public class NeuronNetwork
    {
        public ICollection<ICollection<Neuron>> Layers;

        public event EventHandler<LearnDataModel> OnLearnStep;

        private readonly Random _rnd;

        public NeuronNetwork()
        {
            Layers = new List<ICollection<Neuron>>();
            _rnd = new Random();
        }

        private double RndWeigh()
        {
            return _rnd.NextDouble() - 0.5;
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
                if (last == null)
                {
                    var newNeu = new InputNeuron();
                    neurons.Add(newNeu);
                }
                else
                {
                    var newNeu = new LayerNeuron();
                    newNeu.Inputs = last.Select(n => new NeuronBinding(n, RndWeigh())).ToList();
                    neurons.Add(newNeu);
                }
            }
            last?.ForEach(l => l.Outputs = neurons.Select(n => new NeuronBinding(n, 0)).ToList());
            Layers.Add(neurons);
            return this;
        }

        /// <summary>
        /// Обучить ИНС
        /// </summary>
        /// <param name="data">Тренировочные данные, пары типа "Входы - ожидаемые выходы"</param>
        public void Fit(IEnumerable<(IEnumerable<double>, IEnumerable<double>)> data, double learnFactor, int epoch)
        {
            for(int i = 0; i < epoch; i++)
            {
                foreach (var trainData in data)
                {
                    if (trainData.Item1.Count() != Layers.First().Count())
                        throw new Exception("Размерность данных не соответствует размерности первого слоя нейронной сети");
                    //Вводим входящие данные как выходы первого слоя
                    Layers.First().Zipp(trainData.Item1, (x, y) => x.Input = y);

                    //Подсчёт ошибок
                    //TODO: подумать как сделать красиво, потому что Reverse() это O(N), но и обращение к i-му элему списка это O(N)
                    var reversedLayers = Layers.Reverse();
                    foreach (var layer in reversedLayers)
                    {
                        if (layer == Layers.Last())
                        {
                            layer.Zipp(trainData.Item2, (x, y) => x.Cost = y - x.Calc());
                        }
                        else
                        {
                            layer.ToList().ForEach(n => n.CalcAndSetCost());
                        }
                    }

                    //Пересчёт весов связей
                    foreach (var layer in reversedLayers) //Ай
                    {
                        foreach (var neuron in layer) //Йяй
                        {
                            var p = neuron.Potential();
                            foreach (var inp in neuron.Inputs) //Йяй
                            {
                                inp.Weight += learnFactor * neuron.Cost * neuron.ActivationDerivative(p) * inp.Neuron.Calc();
                            }
                        }
                    }
                }

                OnLearnStep?.Invoke(this, new LearnDataModel()
                {
                    Epoch = i,
                    MaxEpoch = epoch
                });
            }
        }

        /// <summary>
        /// Получить результат по входным данным
        /// </summary>
        /// <param name="inputs">Входные данные</param>
        /// <returns>Выходные значения последнего слоя ФНС</returns>
        public IEnumerable<double> Output(IEnumerable<double> inputs)
        {
            Layers.First().Zipp(inputs, (x, y) => x.Input = y);
            return Layers.Last().Select(neuron => neuron.Calc());
        }
    }
}
