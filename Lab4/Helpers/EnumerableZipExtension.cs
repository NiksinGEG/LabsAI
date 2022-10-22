using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Helpers
{
    public static class EnumerableZipExtension
    {
        public static void Zipp<Tcol1, Tcol2>(this IEnumerable<Tcol1> col1, IEnumerable<Tcol2> col2, Action<Tcol1, Tcol2> func)
        {
            if (col1.Count() != col2.Count())
                throw new Exception("Collections are different size");
            var iter1 = col1.GetEnumerator();
            var iter2 = col2.GetEnumerator();
            for(; iter1.MoveNext() && iter2.MoveNext();)
            {
                func(iter1.Current, iter2.Current);
            }
        }
    }
}
