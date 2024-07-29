using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module10
{
    class Calculation : ICalcInt, ICalcDouble, ILogger
    {
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"{message}");
        }

        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{message}");
        }

        int ICalcInt.Calc()
        {
            try
            {
                Console.WriteLine("Введите первое число");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine($"Результат: {x + y}");
                Event("Сложены два числа. Резуьтат операции успешен");
                return x + y;
                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Error(ex.Message);
                Console.WriteLine(ex.Message);
                return 0;

            }

        }

        double ICalcDouble.Calc() ///реализация интерфейса если два числа double
        {
            try
            {
                Console.WriteLine("Введите первое число");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine($"Результат: {x + y}");
                Event("Сложены два числа. Резуьтат операции успешен");
                return x + y;
                
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
                Error(ex.Message);
            }
        }


    }
}
