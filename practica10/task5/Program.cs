using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Мурзик", 9);
            c1.makeSound();
            c1.Meow();
            Cat c2 = new Cat("Барсик");
            c2.makeSound();
            c2.Meow();
        }
    }
}
