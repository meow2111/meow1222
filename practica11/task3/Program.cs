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
            Book b1 = new Book("Война и мир", 1200);
            b1.Info();

            Book b2 = new Book();
            b2.Info();

            Book b3 = new Book("Краткая история", 1 );
            b3.Info();
        }
    }
}
