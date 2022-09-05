using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Оптимизатор методом отжига
    /// </summary>
    /// <typeparam name="T">Тип элементов массива</typeparam>
    public class FireOptimizer<T>
    {
        public int N { get; }

        public T[] Solution { get; set; }

        public float Temperature { get; set; }

        private float MaxTemperature;

        private float MinTemperature;

        private int Steps;

        private Random _rnd;

        /// <summary>
        /// Конструктор оптимизатора
        /// </summary>
        /// <param name="n">Размерность массива решения</param>
        public FireOptimizer(int n, float temperature, float minTemperature, int steps)
        {
            this.N = n;
            this.Solution = new T[n];
            MaxTemperature = temperature;
            MinTemperature = minTemperature;
            Steps = steps;
            _rnd = new Random();
        }

        /// <summary>
        /// Инициализация начального состояния
        /// </summary>
        /// <param name="initializator">Функция инициализации очередного элемента массива</param>
        public void Initialize(Func<T> initializator)
        {
            for(int i = 0; i < N; i++)
            {
                Solution[i] = initializator();
            }
        }

        public void Initialize(T[] initSolution)
        {
            if (initSolution.Length != N)
                throw new Exception("Попытка инициализации массивом неверной длины!");
            Solution = initSolution;
        }

        /// <summary>
        /// Получить оптимальное решение методом отжига
        /// </summary>
        /// <param name="countEnergy">Функция подсчёта энергии решения</param>
        /// <param name="downTemperature">Функция понижения температуры</param>
        /// <returns>Оптимальное решение, аналогичное переменной Solution</returns>
        public T[] GetSolution(Func<T[], float> countEnergy, Func<float, float> downTemperature)
        {
            Temperature = MaxTemperature;
            while(Temperature > MinTemperature)
            {
                for(int i = 0; i < Steps; i++)
                {
                    var newSolution = ShuffleSolution();
                    ChooseSolution(countEnergy, newSolution);
                }
                Temperature = downTemperature(Temperature);
            }
            return Solution;
        }

        //TODO: понять, как определять, было ли помещено значение в i-й элемент массива res
        private T[] ShuffleSolution()
        {
            var res = new T[N];
            for(int i = 0; i < N; i++)
            {
                int index = _rnd.Next(N);
                while (res[index] != null) index = _rnd.Next(N); //вот тут
                res[index] = Solution[i];
            }
            return res;
        }

        private void ChooseSolution(Func<T[], float> countEnergy, T[] newSolution)
        {
            var currEnergy = countEnergy(Solution);
            var newEnergy = countEnergy(newSolution);
            if(newEnergy < currEnergy)
            {
                Solution = newSolution;
            }
            else
            {
                var deltaEnergy = newEnergy - currEnergy;
                var p = Math.Exp(-deltaEnergy / Temperature) * 100;
                int randNum = _rnd.Next(101);
                if(randNum <= p) Solution = newSolution;
            }
        }
    }
}
