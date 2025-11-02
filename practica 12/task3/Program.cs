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
            ObjectCounter.ShowCounter();
            ObjectCounter c1 = new ObjectCounter();
            ObjectCounter c2 = new ObjectCounter();

            ObjectCounter.ShowCounter();
            ObjectCounter c3 = new ObjectCounter();

            ObjectCounter.ShowCounter();

        }
    }
}
