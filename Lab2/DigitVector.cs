using System;

namespace Lab2
{
    public class DigitVector : IVector
    {
        public Int32 Vector { get; set; }

        private int _size;

        public DigitVector(Int32 digitVector, int size)
        {
            Vector = digitVector;
            _size = size;
        }

        public DigitVector(int[] intVector, int size)
        {
            Vector = 0;
            if (intVector.Length > 32)
                throw new Exception("Попытка записи вектора слишком большой длины");
            for(int i = 0; i < size; i++)
            {
                Vector <<= 1;
                Vector += intVector[i] == 0 ? 0 : 1;
            }
            _size = size;
        }
        public IVector And(IVector vec)
        {
            return new DigitVector(Vector & ((DigitVector)vec).Vector, _size);
        }

        public double Normal()
        {
            double res = 0;
            for(int i = 0; i < 32; i++)
            {
                Int32 mask = 1 << i;
                mask &= Vector;
                if (mask != 0) res += 1;
            }
            return res;
        }

        public int Size()
        {
            return _size;
        }

        public override bool Equals(object obj)
        {
            if (obj is DigitVector)
            {
                return Vector == ((DigitVector)obj).Vector;
            }
            return base.Equals(obj);
        }
    }
}
