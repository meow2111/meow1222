using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Developer : Employee
    {
        private string language {  get; set; }
        public Developer (string name, string position, int salary, string acceptDate, string language) : base(name, position, salary, acceptDate)
        {
            this.language = language;
        }
        public void WriteCode ()
        {
            Console.WriteLine ($"Разработчик {Name} пишет код на {language}...");
        }
    }
}
