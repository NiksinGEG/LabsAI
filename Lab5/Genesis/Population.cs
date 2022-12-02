namespace Lab5.Genesis
{
    public class Population
    {
        public IEnumerable<Chromosome> Generation { get; set; }

        /// <summary>
        /// Максимальное значение в хромосоме. Все значения хромосом будут принадлежать промежутку [0..MaxValue-1]
        /// </summary>
        public int MaxValue { get; set; }

        private readonly Random _rnd;

        public Population(int size, int maxValue, int rowsCount, int colsCount)
        {
            _rnd = new Random();
            MaxValue = maxValue;
            var generation = new List<Chromosome>();
            for (int i = 0; i < size; i++) generation.Add(new Chromosome(rowsCount, colsCount, maxValue));
            Generation = generation.ToArray();
        }


        /// <summary>
        /// Получить лучшую хромосому в поколении
        /// </summary>
        /// <returns>Лучшая хромосома</returns>
        public Chromosome BestChromosome()
        {
            var best = Generation.First();
            foreach (var c in Generation)
                if (c.Fitness() > best.Fitness())
                    best = c;
            return best;
        }

        /// <summary>
        /// Получить следующее поколение на основе текущего
        /// </summary>
        /// <param name="crossCoeff"></param>
        /// <param name="mutationPercent"></param>
        public void MakeNextGeneration(double crossCoeff, int mutationPercent)
        {
            var parents = Selection();
            var newGen = GetNewGeneration(parents, crossCoeff);
            Mutate(newGen, mutationPercent);
            Generation = newGen;
        }

        /// <summary>
        /// Селекция - отбор пар хромосом-родителей.
        /// </summary>
        /// <returns>Список пар хромосом-родителей</returns>
        private IEnumerable<(Chromosome father, Chromosome mother)> Selection()
        {
            var n = Generation.Count();
            var pairs = new List<(Chromosome, Chromosome)>();
            var totalFitness = Generation.Select(x => x.Fitness()).Sum();
            var bounds = new List<(int min, int max)>();
            foreach (var chromo in Generation)
            {
                var length = (int)(((double)chromo.Fitness() / (double)totalFitness) * 100);
                var newBound = (bounds.LastOrDefault().max, bounds.LastOrDefault().max + length);
                bounds.Add(newBound);
            }
            var lastMin = bounds.Last().min;
            bounds.Remove(bounds.Last());
            bounds.Add((lastMin, 100));

            for (int i = 0; i < n; i++)
            {
                var val = _rnd.Next(100);
                var index1 = IndexOfBound(bounds, val);
                val = _rnd.Next(100);
                var index2 = IndexOfBound(bounds, val);
                if (index2 == index1) index2 = (index2 + 1) % bounds.Count;
                pairs.Add((Generation.ElementAt(index1), Generation.ElementAt(index2)));
            }

            return pairs;
        }

        /// <summary>
        /// Получить новое поколение по парам предыдущего
        /// </summary>
        /// <param name="parents">Пары хромосом-родителей</param>
        /// <param name="crossCoeff">Коэффициент скрещивания. 0 - потомок идентичен первому родителю, 1 - второму.</param>
        /// <returns>Поколение дочерних хромосом</returns>
        private IEnumerable<Chromosome> GetNewGeneration(IEnumerable<(Chromosome father, Chromosome mother)> parents, double crossCoeff)
        {
            var res = new List<Chromosome>();
            foreach (var pair in parents) res.Add(pair.father.Crossover(pair.mother, crossCoeff));
            return res.ToArray();
        }

        /// <summary>
        /// Мутирует хромосомы с вероятностью p
        /// </summary>
        /// <param name="chromosomes">Хромосомы подлежащие мутированию</param>
        /// <param name="p">Вероятность мутации хромосомы (в %)</param>
        private void Mutate(IEnumerable<Chromosome> chromosomes, int p)
        {
            foreach (var c in chromosomes)
                if (_rnd.Next(100) < p) c.Mutate();
        }

        private int IndexOfBound(IEnumerable<(int min, int max)> bounds, int value)
        {
            int i = 0;
            foreach (var bound in bounds)
            {
                if (value >= bound.min && value < bound.max) return i;
                i++;
            }
            if (value == bounds.Last().max) return bounds.Count() - 1;
            throw new Exception($"Значение {value} не попало ни в один промежуток");
        }
    }
}
