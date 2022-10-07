﻿using Lab4.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Helpers
{
    public static class TrainDataSaver
    {
        public static void Save(string filename, TrainDataModel model)
        {
            using(StreamWriter sw = new StreamWriter(filename, true))
            {
                var sb = new StringBuilder();
                foreach(var num in model.Inputs)
                {
                    sb.Append($"{num},");
                }
                sb.Append(model.Number.ToString());
                sw.WriteLine(sb.ToString());
            }
        }

        public static List<TrainDataModel> FromFile(string filename)
        {
            var res = new List<TrainDataModel>();
            using(StreamReader sr = new StreamReader(filename))
            {
                while(!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Trim().Split(',');
                    var model = new TrainDataModel();
                    for(int i = 0; i < line.Length; i++)
                    {
                        if (i == line.Length - 1)
                            model.Number = int.Parse(line[i]);
                        else
                            model.Inputs.Append(int.Parse(line[i]));
                    }
                    res.Add(model);
                }
            }
            return res;
        }
    }
}
