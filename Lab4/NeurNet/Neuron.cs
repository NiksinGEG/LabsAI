using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4.NeurNet
{
    public class Neuron
    {
        /// <summary>
        /// Входные сигналы с весами
        /// </summary>
        public ICollection<NeuronBinding> Inputs { get; set; }

        /// <summary>
        /// Выходные сигналы с костами
        /// </summary>
        public ICollection<NeuronBinding> Outputs { get; set; }

        /// <summary>
        /// Вес смещения нейрона
        /// </summary>
        public double FreeWeight { get; set; }

        /// <summary>
        /// Ошибка
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Функция активации
        /// </summary>
        public Func<double, double> Activation { get; set; }

        /// <summary>
        /// Производная функции активации
        /// </summary>
        public Func<double, double> ActivationDerivative { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="activation">Функция активации</param>
        /// <param name="activationDerivative">Производная функции активации</param>
        public Neuron(Func<double, double> activation, Func<double, double> activationDerivative)
        {
            Inputs = new List<NeuronBinding>();
            Outputs = new List<NeuronBinding>();
            FreeWeight = 0;
            Activation = activation;
            ActivationDerivative = activationDerivative;
        }

        /// <summary>
        /// Подсчитать сумму входных сигналов
        /// </summary>
        public double Potential()
        {
            double res = 0;
            foreach(var inp in Inputs)
            {
                res += (inp.Neuron?.Calc() ?? 0) + inp.Weight;
            }
            res += FreeWeight;
            return res;
        }

        /// <summary>
        /// Подсчитать итоговый выход нейрона
        /// </summary>
        public double Calc()
        {
            return Activation(Potential());
        }

        /// <summary>
        /// Подсчитать ошибку (кост) для данного нейрона, исходя из костов в <see cref="Outputs"/>
        /// </summary>
        public double CalcCost()
        {
            return Outputs.Select(o => o.Neuron?.Inputs.First(i => i.Neuron == this).Weight * o.Neuron?.Cost ?? 0).Sum();
        }

        /// <summary>
        /// Подсчитать ошибку (кост) для данного нейрона, исходя из костов в <see cref="Outputs"/> и запомнить его в <see cref="Cost"/>
        /// </summary>
        public void CalcAndSetCost()
        {
            Cost = CalcCost();
        }
    }
}
