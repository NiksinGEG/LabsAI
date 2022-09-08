using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class APT1
    {
        /// <summary>
        /// Бета-параметр
        /// </summary>
        public double Beta { get; set; }

        /// <summary>
        /// Параметр внимательности
        /// </summary>
        public double Mindfulness { get; set; }

        /// <summary>
        /// Набор векторов-прототипов
        /// </summary>
        private List<IVector> _prototypes;

        public APT1(double beta, double mindfulness)
        {
            Beta = beta;
            Mindfulness = mindfulness;
            _prototypes = new List<IVector>();
        }

        //TODO: реализовать метод кластеризации
        public IEnumerable<Tuple<IVector, IEnumerable<IVector>>> Clasterisate(IEnumerable<IVector> attributes)
        {
            throw new NotImplementedException();
        }
    }
}
