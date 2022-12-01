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

        public int Weigh()
        {
            var res = 0;
            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColsCount; j++)
                    res += WeighOf(i, j);
            return res;
        }

        public Chromosome Cross(Chromosome other, double p)
        {
            var arr1 = this.ToArray();
            var arr2 = other.ToArray();

            if (arr1.Length != arr2.Length) throw new Exception("Хромосомы были разной длины");

            for (int i = 0; i < arr1.Length; i++)
                if (_rnd.NextDouble() <= p) arr1[i] = arr2[i];

            return new Chromosome(AsMatrix(arr1, RowsCount, ColsCount));
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

        public int[] ToArray()
        {
            return AsArray(Value);
        }

        private int WeighOf(int i, int j)
        {
            var val = Value[i, j];
            int res = 0;

            if (j > 0 && Value[i, j - 1] == val) res++;
            if (j < ColsCount && Value[i, j + 1] == val) res++;
            if ((i + j) % 2 == 0 && i > 0 && Value[i - 1, j] == val) res++;
            if ((i + j) % 2 != 0 && i < RowsCount && Value[i + 1, j] == val) res++;
            return res;
        }

        private int[] AsArray(int[,] matrix)
        {
            var m = matrix.GetLength(0);
            var n = matrix.GetLength(1);

            var res = new int[m * n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    res[i * n + j] = matrix[i, j];
            return res;
        }

        private int[,] AsMatrix(int[] array, int rowsCount, int colsCount)
        {
            if (array.Length != rowsCount * colsCount) throw new Exception("Размерности не соответствуют массиву");

            var res = new int[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < colsCount; j++)
                    res[i, j] = array[i * colsCount + j];
            return res;
        }
    }
}
