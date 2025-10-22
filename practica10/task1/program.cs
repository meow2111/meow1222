using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Вона и мир", 1200);
            Book b2 = new Book("1984", 100);
            Book b3 = new Book();

            b1.read();
            b2.read();
            b3.read();

            Console.ReadLine();
        }
    }
}
