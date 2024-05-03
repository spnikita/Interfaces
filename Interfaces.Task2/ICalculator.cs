namespace Interfaces.Task2
{
    /// <summary>
    /// Определяет метод сложения двух целочисленных значений
    /// </summary>
    internal interface ICalculator
    {
        /// <summary>
        /// Сложить два целочисленных значения
        /// </summary>
        /// <param name="a">Первое слагаемое</param>
        /// <param name="b">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        int Sum(int a, int b);
    }
}
