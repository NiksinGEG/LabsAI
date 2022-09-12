namespace Lab3
{
    public class AntPathFinder
    {
        public Edge[,] Graph { get; set; }

        public PathFinderMetrix Metrix { get; set; }

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

        /// <summary>
        /// Путь муравья из вершины startVert по всем остальным вершинам. С каждой итерацией, результат будет улучшаться
        /// </summary>
        /// <param name="startVert">Вершина начала пути</param>
        /// <returns>Лучший путь по всем вершинам</returns>
        public int[] FindPath(int startVert)
        {
            //Инициализировали муравья, он прошёл свой путь
            Ant ant = new Ant(startVert, 5);
            while (ant.Walk(Graph, Metrix) != -1) { }

            var ferAmount = ant.FermentAmount();

            //На каждой пройденной муравьём грани увеличили кол-во фермента
            var way = ant.Way.ToArray();
            for(int i = 0; i < way.Length; i++)
            {
                if(i != way.Length - 1)
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

            //Процедура испарения фермента
            for (int i = 0; i < Graph.GetLength(0); i++)
                for (int j = 0; j < Graph.GetLength(0); j++)
                    if (i != j)
                        Graph[i, j].Ferment *= 1 - Metrix.Volatility;

            return way;
        }
    }
}
