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
           Laptop l1 = new Laptop("Dell", 16, 85);
            l1.PowerOn();
            l1.work();
        }
    }
}
