using System;

namespace Interfaces.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tКонсольный мини-калькулятор, складывающий два числа.");

            ICalculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine();
                Console.Write("Введите первое слагаемое: ");
                var firstTerm = ReadNumber();

                Console.Write("Введите второе слагаемое: ");
                var secondTerm = ReadNumber();               

                try
                {
                    var sum = calculator.Sum(firstTerm, secondTerm);

                    Console.WriteLine("Сумма: {0}", sum);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Ошибка сложения чисел: {0}", ex.Message);
                }                                

                Console.WriteLine("Для выхода нажмите 'x', для продолжения - любую другую клавишу.");
                var exit = Console.ReadLine();
                if (exit != "x")
                    continue;

                Console.WriteLine("Работа завершена.");
                break;
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Считать число с консоли
        /// </summary>
        /// <returns>Число</returns>
        private static int ReadNumber()
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
                    Console.WriteLine("Ошибка чтения данных. {0}", ex.Message);
                    Console.WriteLine("Повторите попытку.");
                    Console.Write("Введите число: ");
                    continue;
                }
            }
        }
    }
}
