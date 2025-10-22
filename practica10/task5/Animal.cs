using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Animal
    {
        private string name;
        
        public Animal (string Name)
        {
            name = Name;
        }
        public void makeSound()
        {
            Console.WriteLine($"{name} издает звук.");
        }
        public string getName()
        {
            return name;
        }

    }
    class Cat : Animal
    {
        private int lives;
        public Cat(string Name, int Lives) : base(Name)
        {
            if (lives >= 1 && lives <= 9)
            {
                lives = Lives;
            }
            else
            {
                lives = 9;

            }

        }


        public Cat(string Name) : base(Name)
        {
            lives = 9;
        }
        public void Meow()
        {
            if (lives > 1)
            {
                lives--;
            }
            Console.WriteLine($"{getName()} мяукнул, осталось жизней:{lives}.");


        }
    }

    
}
