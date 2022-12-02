using Lab5.Genesis;

namespace Lab5.Controllers
{
    public class MainController
    {
        private Population _population;

        public int Weigh => _population.BestChromosome().Adjoinings();

        public EventHandler<(int iteration, int weigh)>? OnIterationStep;

        public Color[,] GetSolution(
            Color[] colors,
            int populationSize,
            int rowCount, 
            int colCount, 
            double crossCoeff, 
            int mutationPercent,
            uint maxIterationsWithoutChanges)
        {
            _population = new Population(populationSize, colors.Length, rowCount, colCount);
            int i = 0;
            var best = _population.BestChromosome();
            int worstIters = 0;
            while (true)
            {
                _population.MakeNextGeneration(crossCoeff, mutationPercent);
                if (_population.BestChromosome().Fitness() > best.Fitness())
                {
                    best = _population.BestChromosome();
                    worstIters = 0;
                }
                else worstIters++;
                if (worstIters > maxIterationsWithoutChanges) break;
                i++;
                OnIterationStep?.Invoke(this, (i, Weigh));
            }

            var res = new Color[best.Value.GetLength(0), best.Value.GetLength(1)];
            for (i = 0; i < res.GetLength(0); i++)
                for (int j = 0; j < res.GetLength(1); j++)
                    res[i, j] = colors[best.Value[i, j]];
            return res;
        }
    }
}
