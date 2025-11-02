using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class ObjectCounter
    {
        private static int counter = 0;
        public ObjectCounter() 
        {
            counter++;
            Console.WriteLine("Создан новый обьект!");
        }
        public static void ShowCounter ()
        {
            Console.WriteLine("Кол-во обьектов:" + counter);
        }
    }
}
