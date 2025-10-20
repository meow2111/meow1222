using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1
{
     class Person
    {
        private int age;
        private string name;
        public Person(int ageHuman, string nameHuman)
        {
            name = nameHuman;
            if (ageHuman >= 0 && ageHuman <= 120)
            {
                age = ageHuman;
            }
            else
            {
                Console.WriteLine("Ошибка: возраст должен быть от 0 до 120");
            }

        }
        public void SayHello()
        {
            {
                Console.WriteLine($"привет, меня зовут {name}, мне {age} лет(год)");
            }
        }
    }
}