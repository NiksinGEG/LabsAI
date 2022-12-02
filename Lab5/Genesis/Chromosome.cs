namespace Lab5.Genesis
{
    public class Chromosome
    {
        public int[,] Value { get; set; }

        private int RowsCount => Value.GetLength(0);
        private int ColsCount => Value.GetLength(1);

        private readonly Random _rnd;

        public Chromosome(int[,] value)
        {
            Value = value;
            _rnd = new Random();
        }

        public Chromosome(int rowsCount, int colsCount, int maxValue)
        {
            _rnd = new Random();
            Value = new int[rowsCount, colsCount];
            for(int i = 0; i < rowsCount; i++)
                for(int j = 0; j < colsCount; j++)
                    Value[i, j] = _rnd.Next(maxValue);
        }

        public int Fitness()
        {
            // Макс кол-во соприкасающихся цветов
            var adjoiningMax = RowsCount * ColsCount * 3;
            adjoiningMax -= 2 * ((int)Math.Ceiling(ColsCount / 2.0) + RowsCount - 2); // У треугов по краям на 1 меньше соприкосновений
            adjoiningMax -= 4; // У треугов по углам ещё на одно меньше

            // Чем меньше соприкосновений - тем выше приспособленность
            return adjoiningMax - Adjoinings();
        }

        public int Adjoinings()
        {
            var res = 0;
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColsCount; j++)
                    res += WeighOf(i, j);
            return res;
        }

        public Chromosome Crossover(Chromosome other, double p)
        {
            if(this.RowsCount != other.RowsCount || this.ColsCount != other.ColsCount)
                throw new Exception("Хромосомы были разной длины");

            var res = new int[RowsCount, ColsCount];

            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColsCount; j++)
                    res[i, j] = (_rnd.NextDouble() <= p) ? other.Value[i, j] : Value[i, j];
            return new Chromosome(res);
        }

        public void Mutate()
        {
            int i1 = _rnd.Next(RowsCount);
            int i2 = _rnd.Next(RowsCount);
            int j1 = _rnd.Next(ColsCount);
            int j2 = _rnd.Next(ColsCount);

            var temp = Value[i1, j1];
            Value[i1, j1] = Value[i2, j2];
            Value[i2, j2] = temp;
        }

        private int WeighOf(int i, int j)
        {
            var val = Value[i, j];
            int res = 0;

            if (j > 0 && Value[i, j - 1] == val) res++;
            if (j < ColsCount-1 && Value[i, j + 1] == val) res++;
            if ((i + j) % 2 == 0 && i > 0 && Value[i - 1, j] == val) res++;
            else if ((i + j) % 2 != 0 && i < RowsCount-1 && Value[i + 1, j] == val) res++;
            return res;
        }
    }
}
