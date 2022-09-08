using System;

namespace Lab1Framework
{
    public class NQueenSolver : FireOptimizer<int>
    {
        public float Alpha { get; set; }

        public NQueenSolver(int n, float temperature, float minTemperature, int steps, float alpha)
            : base(n, temperature, minTemperature, steps)
        {
            Alpha = alpha;
        }

        public void Initialize()
        {
            Solution = new int[N];
            for (int i = 0; i < N; i++) Solution[i] = i;
        }

        public override float CountEnergy(int[] solution)
        {
            float res = 0;
            for (int i = 0; i < solution.Length; i++)
                res += CountEnergyOf(solution, i);
            return res;
        }

        private float CountEnergyOf(int[] arr, int i)
        {
            float res = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (i == j) continue;
                if (Math.Abs(arr[j] - arr[i]) == Math.Abs(j - i)) res++;
            }
            return res;
        }

        public override float DownTemperature(float temperature)
        {
            return temperature * Alpha;
        }
    }
}
