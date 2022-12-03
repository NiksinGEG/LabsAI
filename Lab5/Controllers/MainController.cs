using Lab5.Genesis;

namespace Lab5.Controllers
{
    public class MainController
    {
        public int Weigh => _population?.BestChromosome().Adjoinings() ?? -1;

        public bool IsRunning => _solverTask != null && _solverTask.Status == TaskStatus.Running;

        public EventHandler<(int iteration, int weigh)>? OnIterationStep;

        private Population? _population;

        private Color[] _colors = new Color[] { Color.Green, Color.Blue, Color.Orange, Color.Red };

        private Task<Color[,]>? _solverTask;

        private CancellationTokenSource _tokenSource;

        public MainController()
        {
            _tokenSource = new CancellationTokenSource();
        }

        public Color[,] GetSolution(
            int populationSize,
            int rowCount, 
            int colCount, 
            double crossCoeff, 
            int mutationPercent,
            uint maxIterationsWithoutChanges)
        {
            _population = new Population(populationSize, _colors.Length, rowCount, colCount);
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
                if (worstIters > maxIterationsWithoutChanges
                    || _tokenSource.IsCancellationRequested) break;
                i++;

                OnIterationStep?.Invoke(this, (i, Weigh));
            }

            var res = new Color[best.Value.GetLength(0), best.Value.GetLength(1)];
            for (i = 0; i < res.GetLength(0); i++)
                for (int j = 0; j < res.GetLength(1); j++)
                    res[i, j] = _colors[best.Value[i, j]];
            return res;
        }

        public async Task<Color[,]> GetSolutionAsync(
            int populationSize,
            int rowCount,
            int colCount,
            double crossCoeff,
            int mutationPercent,
            uint maxIterationsWithoutChanges)
        {
            _tokenSource = new CancellationTokenSource();
            _solverTask = new Task<Color[,]>(() => 
            {
                return GetSolution(populationSize, rowCount, colCount, crossCoeff, mutationPercent, maxIterationsWithoutChanges);
            }, _tokenSource.Token);
            _solverTask.Start();
            return await _solverTask.WaitAsync(new CancellationTokenSource().Token);
        }

        public void Cancel()
        {
            if(IsRunning) _tokenSource.Cancel();
        }
    }
}
