using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class ProgramConfig
    {
        public const string Version = "2.0";
        public const string Developer = "Компания IT";

        public static void ShowInfo ()
        {
            Console.WriteLine("Программа: Калькулятор");
            Console.WriteLine("Версия:" + Version);
            Console.WriteLine("Автор:" + Developer);

        }
    }
}
