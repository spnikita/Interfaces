using System;

namespace Interfaces.Task2
{
    /// <summary>
    /// Логгер
    /// </summary>
    internal class Logger : ILogger
    {
        /// <inheritdoc />
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(message);
        }

        /// <inheritdoc />
        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(message);
        }
    }
}
