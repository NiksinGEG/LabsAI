using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosco.LinAlg;

namespace Cosco
{
    public class CoscoNetwork
    {
        private IEnumerable<(IEnumerable<double> img, IEnumerable<double> assoc)> Prototypes;

        private Matrix Weighs;

        public CoscoNetwork(IEnumerable<(IEnumerable<double> img, IEnumerable<double> assoc)> prototypes)
        {
            Prototypes = prototypes;
            Weighs = new Matrix(prototypes.First().assoc.Count(), prototypes.First().img.Count());

            foreach (var prot in prototypes)
            {
                var x = new Matrix(prot.img.ToArray());
                var y = new Matrix(prot.assoc.ToArray(), Matrix.VectorTypes.Column);

                Weighs += y * x;
            }
        }

        public IEnumerable<double> InsurrectImage(IEnumerable<double> image)
        {

        }
    }
}
