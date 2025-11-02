using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.5;
            double num2 = 2.5;
            double num3 = 0;

            Console.WriteLine($"Сложение: {num1} + {num2} = {Calculater.Sum(num1, num2)}");
            Console.WriteLine($"Вычитание: {num1} + {num2} = {Calculater.Raznost(num1, num2)}");
            Console.WriteLine($"Умножение: {num1} + {num2} = {Calculater.Umnog(num1, num2)}");
            Console.WriteLine($"Деление: {num1} + {num2} = {Calculater.Delen(num1, num2)}");
            Console.WriteLine($"Деление: {num1} + {num2} = {Calculater.Delen(num1, num3)}");



        }
    }
}
