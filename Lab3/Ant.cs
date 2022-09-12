using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Ant
    {
        public int Current { get; set; }
        public List<int> Way { get; set; }
        public double WayLength { get; set; }
        public double Strength { get; set; }

        private Random _rnd;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="initVert">Вершина, в которой появится муравей</param>
        /// <param name="strength">"Сила" фермента муравья (обозначается 'Q')</param>
        public Ant(int initVert, double strength)
        {
            Current = initVert;

            _rnd = new Random();
            Way = new List<int>() { initVert };
            WayLength = 0;
            Strength = strength;
        }

        /// <summary>
        /// Перемещение по графу
        /// </summary>
        /// <param name="graph">Граф</param>
        /// <returns>Номер вершины в которую пошёл муравей, или -1, если идти некуда</returns>
        public int Walk(Edge[,] graph, PathFinderMetrix metrix)
        {
            var probs = new List<Tuple<int, int>>();
            for(int i = 0; i < graph.GetLength(0); i++)
            {
                if(i != Current && !Way.Contains(i))
                {
                    if(probs.Count > 0)
                        probs.Add(new Tuple<int, int>(i, Probability(graph, i, metrix) + probs.Last().Item2));
                    else
                        probs.Add(new Tuple<int, int>(i, Probability(graph, i, metrix)));
                }
            }
            if (!probs.Any()) return -1;

            int randNum = _rnd.Next(101);
            foreach(var prob in probs)
            {
                if(randNum <= prob.Item2)
                {
                    WayLength += graph[Current, prob.Item1].Length;
                    Current = prob.Item1;
                    Way.Add(Current);
                    return Current;
                }
            }

            WayLength += graph[Current, probs.Last().Item1].Length;
            Current = probs.Last().Item1;
            Way.Add(Current);
            return Current;

            throw new Exception($"Число {randNum} не попало в промежуток");
        }

        /// <summary>
        /// Сколько фермента оставит муравей при текущей длине его пути
        /// </summary>
        /// <returns>Количество оставляемого фермента</returns>
        public double FermentAmount()
        {
            return Strength / WayLength;
        }

        private int Probability(Edge[,] graph, int next, PathFinderMetrix metrix)
        {
            double summ = 0;
            for(int i = 0; i < graph.GetLength(0); i++)
            {
                if(i != Current && !Way.Contains(i))
                {
                    summ += Math.Pow(graph[Current, i].Ferment, metrix.FermentWeight) * Math.Pow(1.0 / graph[Current, i].Length, metrix.Heuristic);
                }
            }
            double prob = Math.Pow(graph[Current, next].Ferment, metrix.FermentWeight) * Math.Pow(1.0 / graph[Current, next].Length, metrix.Heuristic);
            return (int)(prob / summ * 100);
        }
    }
}
