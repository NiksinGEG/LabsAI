using System;

namespace Lab1Framework
{
    /// <summary>
    /// Оптимизатор методом отжига
    /// </summary>
    /// <typeparam name="T">Тип элементов массива</typeparam>
    public abstract class FireOptimizer<T>
    {
        /// <summary>
        /// Размер решения
        /// </summary>
        public int N { get; }

        /// <summary>
        /// Решение
        /// </summary>
        public T[] Solution { get; set; }


        private float _temperature;
        /// <summary>
        /// Текущее значение температуры
        /// </summary>
        public float Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                OnTemperatureChanges?.Invoke(this, new EventArgs());
            }
        }

        private float MaxTemperature;

        private float MinTemperature;

        private int Steps;

        private Random _rnd;

        public event EventHandler OnTemperatureChanges;// { get; set; }

        public event EventHandler OnBadSolutionChoses;// { get; set; }

        /// <summary>
        /// Конструктор оптимизатора
        /// </summary>
        /// <param name="n">Размерность массива решения</param>
        public FireOptimizer(int n, float temperature, float minTemperature, int steps)
        {
            N = n;
            Solution = new T[n];
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
            for (int i = 0; i < N; i++)
            {
                Solution[i] = initializator();
            }
        }

        /// <summary>
        /// Инициализация начального состояния
        /// </summary>
        /// <param name="initSolution">Массив, которым инициализируется состояние</param>
        /// <exception cref="Exception"></exception>
        public void Initialize(T[] initSolution)
        {
            if (initSolution.Length != N)
                throw new Exception("Попытка инициализации массивом неверной длины!");
            Solution = initSolution;
        }

        public abstract float CountEnergy(T[] solution);

        public abstract float DownTemperature(float temperature);

        /// <summary>
        /// Получить оптимальное решение методом отжига
        /// </summary>
        /// <param name="countEnergy">Функция подсчёта энергии решения</param>
        /// <param name="downTemperature">Функция понижения температуры</param>
        /// <returns>Оптимальное решение, аналогичное переменной Solution</returns>
        public T[] GetSolution()
        {
            Temperature = MaxTemperature;
            while (Temperature > MinTemperature)
            {
                T[] bestSolution = null;
                double bestEnergy = double.NaN;
                for (int i = 0; i < Steps; i++)
                {
                    var newSolution = ShuffleSolution();
                    ChooseSolution(newSolution);

                    var newEnergy = CountEnergy(newSolution);
                    if (double.IsNaN(bestEnergy) || newEnergy < bestEnergy)
                    {
                        bestSolution = newSolution;
                        bestEnergy = newEnergy;
                    }
                }
                Temperature = DownTemperature(Temperature);
                Solution = bestSolution;
            }
            return Solution;
        }

        /// <summary>
        /// Получить новое решение случайным перемешиванием текущего
        /// </summary>
        /// <returns>Новое решение</returns>
        private T[] ShuffleSolution()
        {
            var res = new T[N];
            var indexes = new int[N];
            for (int i = 0; i < N; i++)
            {
                indexes[i] = i;
                res[i] = Solution[i];
            }
            for (int i = 0; i < N; i++)
            {
                var curLen = N - i;
                int randInd = _rnd.Next(curLen);
                T temp = res[randInd];
                for (int j = randInd; j < curLen - 1; j++)
                    res[j] = res[j + 1];
                res[curLen - 1] = temp;
            }
            return res;
        }

        /// <summary>
        /// Выбрать новое текущее решение
        /// </summary>
        /// <param name="countEnergy">Функция подсчёта энергии решения</param>
        /// <param name="newSolution">Новое решение</param>
        private void ChooseSolution(T[] newSolution)
        {
            var currEnergy = CountEnergy(Solution);
            var newEnergy = CountEnergy(newSolution);
            if (newEnergy < currEnergy)
            {
                Solution = newSolution;
            }
            else
            {
                var deltaEnergy = newEnergy - currEnergy;
                var p = Math.Exp(-deltaEnergy / Temperature) * 100;
                int randNum = _rnd.Next(101);
                if (randNum <= p)
                {
                    Solution = newSolution;
                    OnBadSolutionChoses?.Invoke(this, new EventArgs());
                }
            }
        }
    }
}
