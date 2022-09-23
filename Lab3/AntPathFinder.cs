using System;
using System.Collections.Generic;
using Lab3.Events;

namespace Lab3
{
    public class AntPathFinder
    {
        public Edge[,] Graph { get; set; }

        public PathFinderMetrix Metrix { get; set; }

        public event EventHandler<GraphEventArgs> OnIterationEnd;

        public AntPathFinder(double[,] vertices, PathFinderMetrix metrix)
        {
            Graph = new Edge[vertices.GetLength(0), vertices.GetLength(0)];
            for(int i = 0; i < vertices.GetLength(0); i++)
                for(int j = 0; j < vertices.GetLength(0); j++)
                {
                    Graph[i, j].Length = vertices[i, j];
                    Graph[i, j].Ferment = 0.5;
                }
            Metrix = metrix;
        }

        public int[] FindPath()
        {
            double bestWayLen = double.NaN;
            int[] bestWay = null;

            for(int i = 0; i < Metrix.MaxIterations; i++)
            {
                var colony = InitColony();

                //Дадим каждому муравью колонии пройти по графу
                foreach (var ant in colony)
                {
                    while (ant.Walk(Graph, Metrix.FermentWeight, Metrix.Heuristic) != -1) { }

                    if (double.IsNaN(bestWayLen) || ant.WayLength < bestWayLen)
                    {
                        bestWay = ant.Way.ToArray();
                        bestWayLen = ant.WayLength;
                    }
                }

                //Пересчёт фермента
                foreach (var ant in colony)
                {
                    LeaveFerment(ant);
                }
                FermentEvaporation();

                OnIterationEnd?.Invoke(this, new GraphEventArgs(i, bestWayLen));
            }

            return bestWay;
        }

        /// <summary>
        /// Увеличить фермент на графе исходя из оставленного муравьём ant
        /// </summary>
        /// <param name="ant">Муравейка</param>
        private void LeaveFerment(Ant ant)
        {
            var ferAmount = ant.FermentAmount();

            //На каждой пройденной муравьём грани увеличили кол-во фермента
            var way = ant.Way.ToArray();
            for (int i = 0; i < way.Length; i++)
            {
                if (i != way.Length - 1)
                {
                    Graph[way[i], way[i + 1]].Ferment = ferAmount + Graph[way[i], way[i + 1]].Ferment * Metrix.Volatility;
                    Graph[way[i + 1], way[i]].Ferment = Graph[way[i], way[i + 1]].Ferment;
                }
                else
                {
                    Graph[way[i], way[0]].Ferment = ferAmount + Graph[way[i], way[0]].Ferment * Metrix.Volatility;
                    Graph[way[0], way[i]].Ferment = Graph[way[i], way[0]].Ferment;
                }
            }
        }

        /// <summary>
        /// Инициализация муравьёв в каждой вершине согласно параметрам алгоритма
        /// </summary>
        /// <returns>Колония муравьёув</returns>
        private List<Ant> InitColony()
        {
            List<Ant> colony = new List<Ant>();
            for (int i = 0; i < Graph.GetLength(0); i++)
                for (int j = 0; j < Metrix.ColonySize; j++)
                    colony.Add(new Ant(i, Metrix.Strength));
            return colony;
        }

        /// <summary>
        /// Испарение фермента
        /// </summary>
        private void FermentEvaporation()
        {
            for (int i = 0; i < Graph.GetLength(0); i++)
                for (int j = 0; j < Graph.GetLength(0); j++)
                    if (i != j)
                        Graph[i, j].Ferment *= 1 - Metrix.Volatility;
        }
    }
}
