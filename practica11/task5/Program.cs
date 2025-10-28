using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(1000, 20);
            p.Name = "Ноутбук";
            p.Show();
            p.Discount = 10;
            p.Show();
            p.Price = -500;
            p.Show();
        }
    }
}
