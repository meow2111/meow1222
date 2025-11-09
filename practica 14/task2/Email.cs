using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Email : Message
    {
        public override void Send()
        {
            Console.WriteLine("Email отправлен.");
        }
    }
}
