namespace Cosco.LinAlg
{
    public class Matrix
    {
        public enum VectorTypes
        {
            Column,
            Row
        }

        protected double[,] data;

        public int M { get; }

        public int N { get; }

        /// <summary>
        /// Создание матрицы, размера m строк на n столбцов, инициализированной значениями по умолчанию.
        /// </summary>
        public Matrix(int m, int n)
        {
            if (m <= 0 || n <= 0)
                throw new Exception($"Попытка создания матрицы некорректной размерности: {m}x{n}");
            M = m;
            N = n;
            data = new double[m, n];
        }

        /// <summary>
        /// Создание матрицы по двумерному массиву.
        /// </summary>
        public Matrix(double[,] matr)
        {
            M = matr.GetLength(0);
            N = matr.GetLength(1);
            data = new double[M, N];
            ForIJ((i, j) => data[i, j] = matr[i, j]);
        }

        /// <summary>
        /// Копирование матрицы.
        /// </summary>
        public Matrix(Matrix matr)
        {
            M = matr.M;
            N = matr.N;
            data = new double[M, N];
            ForIJ((i, j) => data[i, j] = matr[i, j]);
        }

        /// <summary>
        /// Создание вектора (одномерной матрицы).
        /// </summary>
        /// <param name="arr">Массив (вектор)</param>
        /// <param name="type">Определяет, будет ли вектор строкой или столбцом</param>
        public Matrix(double[] arr, VectorTypes type = VectorTypes.Row)
        {
            if (type == VectorTypes.Row)
            {
                M = 1;
                N = arr.Length;
                data = new double[M, N];
                ForIJ((i, j) => data[i, j] = arr[j]);
            }
            else
            {
                N = 1;
                M = arr.Length;
                data = new double[M, N];
                ForIJ((i, j) => data[i, j] = arr[i]);
            }
        }

        public double this[int i, int j]
        {
            get => data[i, j];
            set => data[i, j] = value;
        }

        /// <summary>
        /// Функция высшего порядка для вызова действия во вложенном цикле по i и j
        /// </summary>
        /// <param name="func">Выполняемая функция</param>
        public void ForIJ(Action<int, int> func)
        {
            for (var i = 0; i < M; i++)
                for (var j = 0; j < N; j++)
                    func(i, j);
        }

        /// <summary>
        /// Определитель матрицы. Для неквадратной матрицы возвращает NaN.
        /// </summary>
        public double Determinant()
        {
            if (N != M || N == 0 || M == 0) return double.NaN;
            if (N == 1) return data[0, 0];
            if (N == 2) return data[0, 0] * data[1, 1] - data[0, 1] * data[1, 0];
            double res = 0;
            for (int i = 0; i < N; i++)
            {
                var mult = data[1, i] * Minor(1, i);
                if (i % 2 != 0) mult = -mult;
                res += mult;
            }
            return res;
        }

        /// <summary>
        /// Дополнительный минор к элементу m-й строки n-го столбца. Для неквадратных матриц возвращает NaN.
        /// </summary>
        public double Minor(int m, int n)
        {
            if (N != M || N == 0 || M == 0) return double.NaN;

            var minorMatr = new Matrix(M - 1, N - 1);
            int row = 0;
            int col = 0;
            for (int i = 0; i < M; i++)
            {
                if (i != m)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (j != n)
                            minorMatr[row, col++] = data[i, j];
                    }
                }
                row++;
                col = 0;
            }
            return minorMatr.Determinant();
        }

        /// <summary>
        /// Получить транспонированную матрицу (текущая не изменяется).
        /// </summary>
        public Matrix Transpose()
        {
            var res = new Matrix(N, M);
            ForIJ((i, j) => res[j, i] = data[i, j]);
            return res;
        }

        /// <summary>
        /// Скалярное произведение
        /// </summary>
        public double Dot(Matrix matr)
        {
            var ex = new Exception($"Несоответствие размерностей: {M}x{N} и {matr.M}x{matr.N}");

            if ((M == 1 || N == 1) && (matr.M == 1 || matr.N == 1)) // Если имеем дело с векторами (строку можно скалярно умножить на столбец)
            {
                var left = this;
                var right = matr;

                if (N == 1) left = Transpose();
                if (matr.N == 1) right = matr.Transpose();

                if (left.N != right.N) throw ex;

                double res = 0;
                for (int i = 0; i < left.N; i++)
                    res += left[0, i] * right[0, i];
                return res;
            }
            else // Если матрицы (должно быть чёткое соблюдение размерностей)
            {
                if (N != matr.N || M != matr.M) throw ex;

                double res = 0;
                ForIJ((i, j) => res += data[i, j] * matr[i, j]);
                return res;
            }
        }

        /// <summary>
        /// Меняет местами строки с указанными индексами
        /// </summary>
        public Matrix ExchangeRows(int i1, int i2)
        {
            var temp = new double[N];
            for (int i = 0; i < N; i++)
            {
                temp[i] = data[i1, i];
                data[i1, i] = data[i2, i];
            }
            for (int i = 0; i < N; i++) data[i2, i] = temp[i];
            return this;
        }

        /// <summary>
        /// Меняет местами столбцы с указанными индексами
        /// </summary>
        public Matrix ExchangeColumns(int i1, int i2)
        {
            var temp = new double[M];
            for (int i = 0; i < M; i++)
            {
                temp[i] = data[i, i1];
                data[i, i1] = data[i, i2];
            }
            for (int i = 0; i < M; i++) data[i, i2] = temp[i];
            return this;
        }

        /// <summary>
        /// Матричное умножение
        /// </summary>
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.N != b.M) throw new Exception($"Неверное количество строк/столбцов матриц. Строк в первой было {a.M}, столбцов во второй было {b.N}");

            var res = new Matrix(a.M, b.N);
            res.ForIJ((i, j) =>
            {
                double summ = 0;
                for (int k = 0; k < a.N; k++)
                    summ += a[i, k] * b[k, j];
                res[i, j] = summ;
            });
            return res;
        }

        /// <summary>
        /// Скалирование матрицы
        /// </summary>
        public static Matrix operator *(Matrix a, int value)
        {
            var res = new Matrix(a.M, a.N);
            res.ForIJ((i, j) => res[i, j] *= value);
            return res;
        }

        /// <summary>
        /// Умножение матрицы на вектор-столбец
        /// </summary>
        public static double[] operator *(Matrix a, double[] vector)
        {
            var res = new double[a.M];
            a.ForIJ((i, j) => res[i] += a[i, j] * vector[j]);
            return res;
        }

        /// <summary>
        /// Поэлементное инвертирование значений матрицы
        /// </summary>
        public static Matrix operator -(Matrix a)
        {
            var res = new Matrix(a.M, a.N);
            res.ForIJ((i, j) => res[i, j] = -a[i, j]);
            return res;
        }

        /// <summary>
        /// Поэлементное сложение матриц
        /// </summary>
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.M != b.M || a.N != b.N) throw new Exception($"Размеры матриц различны: {a.M}x{a.N} и {b.M}x{b.N}");

            var res = new Matrix(a.M, a.N);
            res.ForIJ((i, j) => res[i, j] = a[i, j] + b[i, j]);
            return res;
        }

        /// <summary>
        /// Поэлементное вычитание матриц
        /// </summary>
        public static Matrix operator -(Matrix a, Matrix b)
        {
            return a + (-b);
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.M != b.M) return false;
            if (a.N != b.N) return false;
            for (int i = 0; i < a.M; i++)
                for (int j = 0; j < a.N; j++)
                    if (a[i, j] != b[i, j]) return false;
            return true;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj) => base.Equals(obj);

        public override int GetHashCode() => base.GetHashCode();
    }
}
