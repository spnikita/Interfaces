namespace Interfaces.Task2
{
    /// <summary>
    /// Определяет методы логирования
    /// </summary>
    internal interface ILogger
    {
        /// <summary>
        /// Логировать обычное сообщение
        /// </summary>
        /// <param name="message"></param>
        void Event(string message);

        /// <summary>
        /// Логировать ошибку
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);
    }
}
