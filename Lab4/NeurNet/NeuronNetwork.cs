using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4.NeurNet
{
    public class NeuronNetwork
    {
        public ICollection<ICollection<Neuron>> Layers;

        public event EventHandler<LearnDataModel> OnLearnStep;

        public NeuronNetwork()
        {
            Layers = new List<ICollection<Neuron>>();
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
                    newNeu.Inputs = last.Select(n => new NeuronBinding(n, 0.5)).ToList() ?? new List<NeuronBinding>();
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
                    for (int j = 0; j < trainData.Item1.Count(); j++)
                    {
                        Layers.First().ElementAt(j).Input = trainData.Item1.ElementAt(j);
                    }

                    //Подсчёт ошибок
                    //TODO: подумать как сделать красиво, потому что Reverse() это O(N), но и обращение к i-му элему списка это O(N)
                    var reversedLayers = Layers.Reverse();
                    foreach (var layer in reversedLayers)
                    {
                        if (layer == Layers.Last())
                        {
                            if (layer.Count() != trainData.Item2.Count()) throw new Exception("Количество классов на выходе нейросети не равно количеству тренировочных классов!");
                            //layer.Zip(trainData.Item2, (n, res) => n.Cost = res - n.Calc());
                            for(int j = 0; j < layer.Count(); j++)
                            {
                                var neuron = layer.ElementAt(j);
                                neuron.Cost = trainData.Item2.ElementAt(j) - neuron.Calc();
                            }
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
                            foreach (var inp in neuron.Inputs) //Йяй
                            {
                                inp.Weight += learnFactor * neuron.Cost * neuron.ActivationDerivative(neuron.Potential()) * inp.Neuron.Calc();
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
            if(inputs.Count() != Layers.First().Count())
                throw new Exception("Размерность данных не соответствует размерности первого слоя нейронной сети");
            for(int i = 0; i < inputs.Count(); i++)
            {
                Layers.First().ElementAt(i).Input = inputs.ElementAt(i);
            }
            return Layers.Last().Select(neuron => neuron.Calc());
        }
    }
}
