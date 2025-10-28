using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Book
    {
        private string title;
         public string Title
         {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Ошибка: название не может быть пустым.");

                }
                else
                {
                    title = value;
                }
            }
         }
        public int Pages { get; set; } = 1;

        public bool IsLong
        {
            get { return Pages > 300; }
        }
        public Book (string titleb)
        {
            title = titleb;
        }
        public void Info()
        {
            Console.WriteLine($"Книга: {Title}, страниц: {Pages}, длинная: {(IsLong ? "да" : "нет")}");
        }

    }
}
