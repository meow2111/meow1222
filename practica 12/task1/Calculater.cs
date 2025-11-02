using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace practica_12
{
    internal class  Calculater
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Raznost (double a, double b)
        {
            return a - b;
        }
        public static double Umnog (double a, double b)
        {
            return a * b;
        }
        public static double Delen (double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка, делить на ноль нельзя.");
            }
                return a / b;
            
        }

    }
}
