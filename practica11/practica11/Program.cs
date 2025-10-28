using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car ("Lada", 150);
            c.Drive();

            c.Speed = 400;
            c.Drive();

            c.Speed = -5;
            c.Drive();

        }
    }
}
