using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4.NeurNet
{
    public abstract class Neuron
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
        /// Ошибка
        /// </summary>
        public double Cost { get; set; }

        public double Input { get; set; }

        /// <summary>
        /// Функция активации
        /// </summary>
        public abstract double Activation(double x);

        /// <summary>
        /// Производная функции активации
        /// </summary>
        public abstract double ActivationDerivative(double x);

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="activation">Функция активации</param>
        /// <param name="activationDerivative">Производная функции активации</param>
        /*public Neuron()
        {
            Inputs = new List<NeuronBinding>();
            Outputs = new List<NeuronBinding>();
        }*/

        /// <summary>
        /// Подсчитать сумму входных сигналов
        /// </summary>
        public double Potential()
        {
            double res = 0;
            foreach(var inp in Inputs)
            {
                res += (inp.Neuron?.Calc() ?? 0) * inp.Weight;
            }
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
