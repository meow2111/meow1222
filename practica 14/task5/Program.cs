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
            Player[] team = { new Warrior(), new Archer(), new Player() };

            foreach (var p in team)
                p.Attack();

            Console.ReadLine();
        }
    }
}
