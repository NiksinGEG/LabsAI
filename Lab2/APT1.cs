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

        public APT1(double beta, double mindfulness)
        {
            Beta = beta;
            Mindfulness = mindfulness;
        }

        public IEnumerable<Tuple<IVector, IEnumerable<IVector>>> Clasterisate(IEnumerable<IVector> attributes)
        {
            var res = new List<Tuple<IVector, IEnumerable<IVector>>>();
            var stopFlag = false;
            var prototypes = new IVector[attributes.Count()];
            prototypes[0] = attributes.First();
            int protoLen = 1;
            while (!stopFlag)
            {
                var resAttrs = new List<IVector>[attributes.Count()];
                var newPrototypes = Copy(prototypes);
                foreach(var attr in attributes)
                {
                    bool newPrototype = true;
                    for(int i = 0; i < protoLen; i++)
                    {
                        if (Similar(prototypes[i], attr) && Attention(prototypes[i], attr))
                        {
                            newPrototype = false;
                            resAttrs[i].Add(attr);
                            newPrototypes[i] = newPrototypes[i].And(attr);
                        }
                    }
                    if(newPrototype)
                    {
                        newPrototypes[protoLen] = attr;
                        resAttrs[protoLen].Add(attr);
                        protoLen++;
                    }
                }
                if(Equal(prototypes, newPrototypes))
                {
                    for(int i = 0; i < protoLen; i++)
                    {
                        if (resAttrs[i].Count() > 0)
                            res.Add(new Tuple<IVector, IEnumerable<IVector>>(prototypes[i], resAttrs[i]));
                        return res;
                    }
                }
                else
                {
                    prototypes = Copy(newPrototypes);
                }
            }
            return res;
        }

        private IVector[] Copy(IVector[] src)
        {
            var res = new IVector[src.Length];
            for (int i = 0; i < src.Length; i++)
                res[i] = src[i];
            return res;
        }

        private bool Equal(IEnumerable<IVector> list1, IEnumerable<IVector> list2)
        {
            if (list1.Count() != list2.Count())
                return false;
            for (int i = 0; i < list1.Count(); i++)
                if (!list1.ElementAt(i).Equals(list2.ElementAt(i)))
                    return false;
            return true;
        }

        private bool Similar(IVector prototype, IVector attribute)
        {
            return prototype.And(attribute).Normal() / (Beta + prototype.Normal()) > attribute.Normal() / (Beta + attribute.Size());
        }

        private bool Attention(IVector prototype, IVector attribute)
        {
            return prototype.And(attribute).Normal() / attribute.Normal() >= Mindfulness;
        }
    }
}
