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
            Player p = new Player("Sonya", 6, 70);
            Console.WriteLine($"Игрок: {p.Name}, уровень: {p.Level}, здоровье: {p.Health}, жив: {(p.IsAlive ? "да" : "нет")}");
            p.TakeDamage(30);
            p.TakeDamage(40);
            p.Level = 0;
        }
    }
}
