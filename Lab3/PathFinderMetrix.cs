namespace Lab3
{
    /// <summary>
    /// Параметры муравьиного алгоритма
    /// </summary>
    public struct PathFinderMetrix
    {
        /// <summary>
        /// Вес фермента (обозначается 'a') - чем больше, тем больше влияние кол-ва фермента на выбор пути
        /// </summary>
        public double FermentWeight;

        /// <summary>
        /// Коэффициент эвристики (обозначается 'b') - чем больше, тем больше влияние длины пути на выбор
        /// </summary>
        public double Heuristic;

        /// <summary>
        /// Коэффициент летучести (обозначается 'r') - число от 0 до 1 - чем больше, тем быстрее фермент накапливается и испаряется
        /// </summary>
        public double Volatility;
    }
}
