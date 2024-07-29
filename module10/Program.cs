// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace module10
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберитие тип для сложения двух чисел, где int - 1; double - 2");
            byte num = byte.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Сложение двух целых чиел типа integer: ");
                    ICalcInt calc1 = new Calculation();
                    int result1 = calc1.Calc();
                    break;
                case 2:
                    Console.WriteLine("Сложение двух целых чиел типа double: ");
                    ICalcDouble calc2 = new Calculation();
                    double result2 = calc2.Calc();
                    break;
              
                default:
                    Calculation calc = new Calculation();
                    calc.Error("Вы ввели неправильное число!!!!");
                break;
            }

        }
    }


    
 }



 
        





