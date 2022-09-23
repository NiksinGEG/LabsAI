using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3.Graphs
{
    public class Graph
    {
        public ICollection<Vertice> Vertices { get; set; }

        public Graph()
        {
            Vertices = new List<Vertice>();
        }

        public double[,] ToMatrix()
        {
            int n = Vertices.Count();
            double[,] res = new double[n, n];
            for(int i = 0; i < n; i++)
                for(int j = 0; j < n; j++)
                {
                    if (i == j)
                        continue;
                    var xi = Vertices.ElementAt(i).X;
                    var yi = Vertices.ElementAt(i).Y;
                    var xj = Vertices.ElementAt(j).X;
                    var yj = Vertices.ElementAt(j).Y;
                    var length = Math.Sqrt(Math.Pow(xi - xj, 2) + Math.Pow(yi - yj, 2));
                    res[i, j] = length;
                    res[j, i] = length;
                }
            return res;
        }
    }
}
