using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class point
    {
        private double x;
        private double y;
        public point (double xValue, double yValue)
        {
            if (x >= -100 && x<= 100)
            {
                x = xValue;
            }
            else
            {
                Console.WriteLine("Ошибка: координта х должна быть от -100 до 100");
                x = 0;
            }
            if (y >= -100 && y <= 100)
            {
                y = yValue;
            }
            else
            {
                Console.WriteLine("Ошибка: координта y должна быть от -100 до 100");
                y = 0;
            }



        }
        public void move (double dx, double dy)
        {
            x += dx;
            y += dy;
            Console.WriteLine($"Точка переместилась, теперь новые координаты ({x}, {y})");
        }
        public void print()
        {
            Console.WriteLine($"Координаты точки: X = {x}, Y = {y}");
        }

    }
}
