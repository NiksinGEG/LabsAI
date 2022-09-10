using System;

namespace Lab2
{
    public static class BeautyViewExtention
    {
        //Галочка
        private const char CheckMark = '\u2713';
        //Крестик
        private const char Cross = '\u2718';
        public static string ToBeautyString(this DigitVector vector)
        {
            string res = string.Empty;
            for(int i = vector.Size() - 1; i >= 0; i--)
            {
                Int32 mask = 1 << i;
                res += ((mask & vector.Vector) > 0) ? CheckMark : Cross;
            }
            return res;
        }
    }
}
