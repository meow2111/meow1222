using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Рублю мечом!");
        }
    }
}