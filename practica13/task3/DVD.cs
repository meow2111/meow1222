using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class DVD : LibraryItem
    {
        public int Duration { get; set; }     
        public string Rating { get; set; }    

        public DVD(string title, string author, int year, int duration, string rating)
            : base(title, author, year)
        {
            Duration = duration;
            Rating = rating;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Длительность: {Duration} мин");
            Console.WriteLine($"Рейтинг: {Rating}");
        }
    }
}
