using SubLaba1.Helpers;
using SubLaba1.Neurons;

namespace SubLaba1
{
    public class Perceptron
    {
        private BipolarNeuron perceptron;
        private int inputSize;

        public EventHandler<int>? OnLearnStep { get; set; }

        public EventHandler? OnLearnEnd { get; set; }

        public Perceptron(int inputSize)
        {
            perceptron = new BipolarNeuron();
            this.inputSize = inputSize;

            //Добавление начальных инпутов
            for (int i = 0; i < inputSize; i++)
            {
                perceptron.Inputs.Add(new NeuronBinding(new InputNeuron(0), 0));
            }
            // Добавляем вес смещения, вход которого - всегда 1
            perceptron.Inputs.Add(new NeuronBinding(new InputNeuron(1), 0));
        }

        public void Fit(IEnumerable<(IEnumerable<double>, double)> trainData, int maxEpoch)
        {
            int epoch = 0;
            while (epoch < maxEpoch)
            {
                foreach (var item in trainData)
                {
                    if (item.Item1.Count() != inputSize) throw new Exception("Неверная длина тренировочных данных");
                    // Устанавливаем входы перцептрона
                    item.Item1.Zipp(perceptron.Inputs, (input, bind) => bind.Neuron.Input = input);

                    double output = item.Item2;
                    // Пересчет весов относительно необходимого выхода
                    foreach (var input in perceptron.Inputs)
                    {
                        input.Weight += input.Neuron.Calc() * output;
                    }
                }

                bool stop = true;
                //Проверка условия останова
                foreach (var item in trainData)
                {
                    // Устанавливаем входы перцептрона
                    item.Item1.Zipp(perceptron.Inputs, (input, bind) => bind.Neuron.Input = input);

                    stop &= Math.Abs(perceptron.Calc() - item.Item2) < 0.001;
                    if (!stop) break;
                }

                if (stop) break;
                epoch++;

                OnLearnStep?.Invoke(this, epoch);
            }
            OnLearnEnd?.Invoke(this, new EventArgs());
        }

        public double Guess(IEnumerable<double> inputs)
        {
            if (inputs.Count() != inputSize) throw new Exception("Неверная длина входных данных");

            // Устанавливаем входы перцептрона
            inputs.Zipp(perceptron.Inputs, (input, bind) => bind.Neuron.Input = input);

            return perceptron.Calc();
        }
    }
}
