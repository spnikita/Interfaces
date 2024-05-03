using System;

namespace Interfaces.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            
            ICalculator calculator = new Calculator(logger);

            logger.Event("\tКонсольный мини-калькулятор, складывающий два числа.");

            while (true)
            {
                Console.WriteLine();
                logger.Event("Введите первое слагаемое: ");
                var firstTerm = ReadNumber(logger);

                logger.Event("Введите второе слагаемое: ");
                var secondTerm = ReadNumber(logger);                

                try
                {
                    var sum = calculator.Sum(firstTerm, secondTerm);

                    logger.Event($"Сумма: {sum}");
                }
                catch (OverflowException)
                { }

                logger.Event("Для выхода нажмите 'x', для продолжения - любую другую клавишу.");
                var exit = Console.ReadLine();
                if (exit != "x")
                    continue;

                logger.Event("Работа завершена.");
                break;
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Считать число с консоли
        /// </summary>
        /// <param name="logger">Логгер</param>
        /// <returns>Число</returns>
        private static int ReadNumber(ILogger logger)
        {
            while (true)
            {
                try
                {
                    var number = Convert.ToInt32(Console.ReadLine());

                    return number;
                }
                catch (Exception ex) when (ex is FormatException || ex is OverflowException)
                {
                    logger.Error($"Ошибка чтения данных. {ex.Message}");
                    logger.Event("Повторите попытку.");
                    logger.Event("Введите число: ");
                    continue;
                }
            }
        }
    }
}
