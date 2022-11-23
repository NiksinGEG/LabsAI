using SubLaba1.Helpers;
using SubLaba1.Neurons;

namespace SubLaba1.Networks
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

                    SetInputs(perceptron, item.Item1);

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
                    SetInputs(perceptron, item.Item1);

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

            SetInputs(perceptron, inputs);

            return perceptron.Calc();
        }

        // Установка входов нейрона
        private void SetInputs(Neuron neuron, IEnumerable<double> inputs)
        {
            inputs.Zipp(neuron.Inputs, (input, bind) => bind.Neuron.Input = input);
        }
    }
}
