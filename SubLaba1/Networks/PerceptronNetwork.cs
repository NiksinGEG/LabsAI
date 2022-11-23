using SubLaba1.Helpers;
using SubLaba1.Neurons;

namespace SubLaba1.Networks
{
    public class PerceptronNetwork
    {
        private IEnumerable<BipolarNeuron> neurons;

        private int inputSize;

        public EventHandler<int>? OnLearnStep { get; set; }

        public EventHandler? OnLearnEnd { get; set; }

        public PerceptronNetwork(int inputSize, int neuronsCount)
        {
            this.inputSize = inputSize;

            var neurons = new List<BipolarNeuron>();
            for (int i = 0; i < neuronsCount; i++)
            {
                var neuron = new BipolarNeuron();
                InitNeuronInputs(neuron, inputSize);
                neurons.Add(neuron);
            }
            this.neurons = neurons;
        }

        public void Fit(IEnumerable<(IEnumerable<double>, IEnumerable<double>)> trainData, int maxEpoch)
        {
            int epoch = 0;
            while (epoch < maxEpoch)
            {
                foreach (var dataItem in trainData)
                {
                    var inputs = dataItem.Item1;
                    var expectedOutput = dataItem.Item2;

                    if (inputs.Count() != inputSize || expectedOutput.Count() != neurons.Count())
                        throw new Exception("Входы или выходы тренировочных данных были неверной длины");

                    foreach (var n in neurons) SetInputs(n, inputs); //Установили входы всем нейронам
                    if (!Same(neurons.Select(n => n.Calc()), expectedOutput)) // Если выходы нейронов отличаются от требуемых
                    {
                        neurons.Zipp(expectedOutput, (neuron, output) =>
                        {
                            foreach (var inp in neuron.Inputs)
                                inp.Weight += inp.Neuron.Calc() * output;
                        });
                    }
                }

                // Проверка условия останова
                bool stop = true;
                foreach (var dataItem in trainData)
                {
                    var inputs = dataItem.Item1;
                    var expectedOut = dataItem.Item2;
                    foreach (var n in neurons) SetInputs(n, inputs);
                    stop &= Same(neurons.Select(x => x.Calc()), expectedOut);
                }
                if (stop) break;
                epoch++;
                OnLearnStep?.Invoke(this, epoch);
            }
            OnLearnEnd?.Invoke(this, new EventArgs());
        }

        public IEnumerable<double> Guess(IEnumerable<double> inputs)
        {
            if (inputs.Count() != inputSize) throw new Exception($"Неверное количество входов (было {inputs.Count()}, ожидалось {inputSize}");
            foreach (var n in neurons) SetInputs(n, inputs);
            return neurons.Select(x => x.Calc());
        }

        private void InitNeuronInputs(Neuron neuron, int inputSize)
        {
            neuron.Inputs = new List<NeuronBinding>();
            //Добавление начальных инпутов
            for (int i = 0; i < inputSize; i++)
            {
                neuron.Inputs.Add(new NeuronBinding(new InputNeuron(0), 0));
            }
            // Добавляем вес смещения, вход которого - всегда 1
            neuron.Inputs.Add(new NeuronBinding(new InputNeuron(1), 0));
        }

        // Установка входов нейрона
        private void SetInputs(Neuron neuron, IEnumerable<double> inputs)
        {
            inputs.Zipp(neuron.Inputs, (input, bind) => bind.Neuron.Input = input);
        }

        private bool Same(IEnumerable<double> collection1, IEnumerable<double> collection2)
        {
            if (collection1.Count() != collection2.Count()) throw new Exception("Коллекции были разного размера");

            bool flag = true;
            collection1.Zipp(collection2, (item1, item2) =>
            {
                flag &= Math.Abs(item1 - item2) < 0.001;
            });
            return flag;
        }
    }
}
