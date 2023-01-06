using SubLaba1.LinAlg;

namespace SubLaba1.Networks
{
    public class HopfieldNetwork
    {
        private Matrix Weighs;

        private IEnumerable<IEnumerable<double>> Prototypes;

        public HopfieldNetwork(int dataSize, IEnumerable<IEnumerable<double>> prototypes) 
        {
            Weighs = new Matrix(dataSize, dataSize);
            Weighs.ForIJ((i, j) => Weighs[i, j] = 0);
            Prototypes = prototypes;
        }

        public void Fit()
        {
            foreach (var data in Prototypes)
                Weighs.ForIJ((i, j) => Weighs[i, j] += data.ElementAt(i) * data.ElementAt(j));

            Weighs.ForIJ((i, j) =>
            {
                if (i == j) Weighs[i, j] = 0;
            });

            Weighs.ForIJ((i, j) => Weighs[i, j] /= Weighs.N);
        }

        public IEnumerable<double> Guess(IEnumerable<double> inputs, Func<double, double> activationFunc)
        {
            int n = inputs.Count();
            if (n != Weighs.N)
                throw new Exception($"Неверная размерность входного вектора: было {n}, ожидалось {Weighs.N}");

            var inputsAsColVec = new Matrix(inputs.ToArray(), Matrix.VectorTypes.Column);
            var Y1 = Weighs * inputsAsColVec;
            Y1.ForIJ((i, j) => Y1[i, j] = activationFunc(Y1[i, j]));

            var Y2 = Weighs * Y1;
            Y2.ForIJ((i, j) => Y2[i, j] = activationFunc(Y2[i, j]));

            while (Y1.Dot(Y2) < inputs.Count() - 0.1)
            {
                Y1 = Y2;
                Y2 = Weighs * Y1;
                Y2.ForIJ((i, j) => Y2[i, j] = activationFunc(Y2[i, j]));
            }

            var res = Prototypes.First();
            double maxDot = double.NaN;
            foreach (var prot in Prototypes)
            {
                var protAsVec = new Matrix(prot.ToArray());
                double dot = Y2.Dot(protAsVec);
                if (double.IsNaN(maxDot) || dot > maxDot)
                {
                    res = prot;
                    maxDot = dot;
                }
            }

            return res ?? throw new Exception("res was null");
        }
    }
}
