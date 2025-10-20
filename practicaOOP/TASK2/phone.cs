using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class phone
    {
        private string Brand;
        private int Battery;
        public phone(string PhoneBrand, int phoneButtery)
        {
            Brand = PhoneBrand;
            if (phoneButtery >= 0 && phoneButtery <= 100)
            {
                Battery = phoneButtery;
            }
            else
            {
                Battery = 0;
                Console.WriteLine("заряд телефона должен быть от 0 до 100");
            }


        }
        public void UsePhone()
        {
            if (Battery > 0)
            {
                Battery -= 10;
                if (Battery < 0)

                    Battery = 0;
                Console.WriteLine($"Телефон{Brand}, заряд {Battery}%.");
            }
            else
            {
                Console.WriteLine($"Телефон {Brand} разряжен!");
            }
        }
    }
}
