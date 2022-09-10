using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class BeautyViewExtention
    {
        //Галочка
        private const char CheckMark = '\u2713';
        //Крестик
        private const char Cross = '\u2718';
        public static string ToBeautyString(this IVector vector)
        {
            DigitVector digVec = vector as DigitVector;
            string res = string.Empty;
            for(int i = digVec.Size() - 1; i >= 0; i--)
            {
                Int32 mask = 1 << i;
                res += ((mask & digVec.Vector) > 0) ? CheckMark : Cross;
            }
            return res;
        }
    }
}
