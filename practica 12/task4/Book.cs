using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Book
    {
        
        private readonly string ISBN;
        private string Name;
        private string Writer;

       
        public Book(string isbn, string name, string writer)
        {
            ISBN = isbn;
            Name = name;
            Writer = writer;
        }

        // Простой метод вывода
        public void ShowInfo()
        {
            Console.WriteLine($"Книга: {Name}");
            Console.WriteLine($"Автор: {Writer}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine();
        }
    }

    
    

}
