using Cosco.LinAlg;

namespace Cosco
{
    public class CoscoNetwork
    {
        private List<(IEnumerable<double> img, IEnumerable<double> assoc)> Prototypes;

        private Matrix Weighs;

        private int imageSize;
        private int associationSize;

        public CoscoNetwork(int imageSize, int assocSize)
        {
            Prototypes = new List<(IEnumerable<double> img, IEnumerable<double> assoc)>();
            Weighs = new Matrix(assocSize, imageSize);
            this.imageSize = imageSize;
            this.associationSize = assocSize;
        }

        public void AddPrototype(IEnumerable<double> image, IEnumerable<double> association)
        {
            var x = new Matrix(image.ToArray());
            var y = new Matrix(association.ToArray(), Matrix.VectorTypes.Column);
            Weighs += y * x;
            Prototypes.Add((image, association));
        }

        public bool TryAssociate(IEnumerable<double> image, out (IEnumerable<double> img, IEnumerable<double> assoc) prototype)
        {
            var pair = StablePairByImage(image);
            var res = ClosestPrototype(pair.assoc, false);
            if (res == null)
            {
                prototype = pair;
                return false;
            }
            else
            {
                prototype = res.Value;
                return true;
            }
        }

        public bool TryImagine(IEnumerable<double> association, out (IEnumerable<double> img, IEnumerable<double> assoc) prototype)
        {
            var pair = StablePairByAssociation(association);
            var res = ClosestPrototype(pair.img);
            if (res == null)
            {
                prototype = pair;
                return false;
            }
            else
            {
                prototype = res.Value;
                return true;
            }
        }

        public (IEnumerable<double> img, IEnumerable<double> assoc) StablePairByImage(IEnumerable<double> image)
        {
            var x0 = Activate(new Matrix(image.ToArray()));

            var y1 = Activate(x0 * Weighs.Transpose());
            var x1 = Activate(y1 * Weighs);
            var y2 = Activate(x1 * Weighs.Transpose());
            var x2 = Activate(y2 * Weighs);

            while (y1.Dot(y2) < associationSize - 1)
            {
                y1 = y2;
                x1 = x2;
                y2 = Activate(x1 * Weighs.Transpose());
                x2 = Activate(y2 * Weighs);
            }

            return (x2.ToArray(), y2.ToArray());
        }

        public (IEnumerable<double> img, IEnumerable<double> assoc) StablePairByAssociation(IEnumerable<double> association)
        {
            var y0 = Activate(new Matrix(association.ToArray()));

            var x1 = Activate(y0 * Weighs);
            var y1 = Activate(x1 * Weighs.Transpose());
            var x2 = Activate(y1 * Weighs);
            var y2 = Activate(x2 * Weighs.Transpose());
            while (x2.Dot(x1) < imageSize - 1)
            {
                x1 = x2;
                y1 = y2;
                x2 = Activate(y1 * Weighs);
                y2 = Activate(x2 * Weighs.Transpose());
            }

            return (x2.ToArray(), y2.ToArray());
        }

        public (IEnumerable<double> img, IEnumerable<double> assoc)? ClosestPrototype(IEnumerable<double> image, bool fromImg = true, int maxDelta = 5)
        {
            var x = new Matrix(image.ToArray());

            var res = Prototypes.First();
            double max = fromImg ? new Matrix(res.img.ToArray()).Dot(x) : new Matrix(res.assoc.ToArray()).Dot(x);
            foreach (var prot in Prototypes)
            {
                var dot = fromImg ? new Matrix(prot.img.ToArray()).Dot(x) : new Matrix(prot.assoc.ToArray()).Dot(x);
                if (dot > max)
                {
                    max = dot;
                    res = prot;
                }
            }

            return max > image.Count() - maxDelta ? res : null;
        }

        private Matrix Activate(Matrix m)
        {
            m.ForIJ((i, j) => m[i, j] = m[i, j] > 0 ? 1 : -1);
            return m;
        }
    }
}
