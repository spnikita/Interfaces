using System;

namespace Interfaces.Task2
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    internal class Calculator : ICalculator
    {
        /// <summary>
        /// Логгер
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="logger"><inheritdoc cref="_logger" path="/summary"/></param>
        public Calculator(ILogger logger)
        {
            _logger = logger;
        }
        
        /// <inheritdoc/>        
        public int Sum(int a, int b)
        {
            try
            {
                return checked(a + b);
            }
            catch (OverflowException ex)
            {
                _logger.Error($"Ошибка сложения чисел: {ex.Message}");
                throw;
            }                        
        }
    }
}
