namespace Lab2
{
    /// <summary>
    /// Интерфейс вектора для алгоритма APT1
    /// </summary>
    public interface IVector
    {
        /// <summary>
        /// Получить размер вектора
        /// </summary>
        /// <returns>Размер вектора</returns>
        int Size();
        /// <summary>
        /// Побитовое "И"
        /// </summary>
        /// <param name="vec">Операнд</param>
        /// <returns>Результат логического "И" с векотором vec</returns>
        IVector And(IVector vec);

        /// <summary>
        /// Значимость вектора, в частности - число ненулевых разрядов
        /// </summary>
        /// <returns>Значимость вектора</returns>
        double Normal();
    }
}
