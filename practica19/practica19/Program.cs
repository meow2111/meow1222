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
            List<string> names = new List<string>();
            names.Add("Анна");
            names.Add("Анна"); //дубликат
            names.Add("Никита");
            names.Add("Никита");//дубликат
            names.Add("Саша");
            names.Add("Саша");//дубликат
            names.Add("Егор");
            Console.WriteLine("Исходный список:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            List<string> deleteDublicat = new List<string>();
            foreach (string name in names)
            {
                bool found = false;
                foreach (string deleteDublicates in deleteDublicat)
                {
                    if (deleteDublicates == name)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    deleteDublicat.Add(name);
                }
            }
            Console.WriteLine("Список без дубликатов:");
            foreach (string name in deleteDublicat)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
