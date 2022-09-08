namespace Lab1Framework
{
    public class FireParameters
    {
        /// <summary>
        /// Размер решения
        /// </summary>
        public int N { get; set; }

        /// <summary>
        /// Минимальная температура
        /// </summary>
        public float MinTemperature { get; set; }

        /// <summary>
        /// Максимальная температура
        /// </summary>
        public float MaxTemperature { get; set; }

        /// <summary>
        /// Коэффициент уменьшения температуры
        /// </summary>
        public float Alpha { get; set; }

        /// <summary>
        /// Количество шагов без изменения температуры
        /// </summary>
        public int Steps { get; set; }
    }
}
