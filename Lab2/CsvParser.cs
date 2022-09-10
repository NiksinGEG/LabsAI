using System.Collections.Generic;
using System.IO;

namespace Lab2
{
    public static class CsvParser
    {
        public static List<DigitVector> ParseToDigVec(string csvFileName, bool headerRow = true, char separator = ',')
        {
            var res = new List<DigitVector>();
            using(var sr = new StreamReader(csvFileName))
            {
                while(!sr.EndOfStream)
                {
                    if(headerRow)
                    {
                        sr.ReadLine();
                        headerRow = false;
                        continue;
                    }
                    string[] values = sr.ReadLine().Trim().Split(separator);
                    int[] intVec = new int[values.Length];
                    for (int i = 0; i < values.Length; i++)
                        intVec[i] = int.Parse(values[i].Trim());
                    res.Add(new DigitVector(intVec, intVec.Length));
                }
            }
            return res;
        }
    }
}
