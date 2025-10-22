using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(3.5,7.2);
            p1.print();

            p1.move(3, -10);
            p1.print();

            point p2 = new point(150, -200);
            p2.print();

            Console.ReadLine();

        }
    }
}
