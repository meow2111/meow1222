using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food[] lunch = { new Pizza(), new Burger(), new Food() };
            foreach (var f in lunch)
            {
                f.Eat();
            }
            Console.ReadLine();
        }
    }
}
