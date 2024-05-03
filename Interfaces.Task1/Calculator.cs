using System;

namespace Interfaces.Task1
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    internal class Calculator : ICalculator
    {
        /// <inheritdoc/>        
        public int Sum(int a, int b)
        {
            return checked(a + b);
        }
    }
}
