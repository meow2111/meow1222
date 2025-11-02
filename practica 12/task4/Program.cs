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
           
                Book book1 = new Book("123-456", "C# для начинающих", "Петров");
                Book book2 = new Book("789-012", "Базы данных", "Сидорова");

                book1.ShowInfo();
                book2.ShowInfo();

               
                book1.Name = "C# для профессионалов";

                
        }
    }
}
