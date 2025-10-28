using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Car
    {
        
        
            private int speed;
            public int Speed
            {
                get { return speed; }
                set
                {
                    if (value < 0 || value > 300)
                    {
                        Console.WriteLine("Скорость не может привышать 300! ");
                    }
                    speed = value;
                }
            }
            public string Model { get; set; } = "Unknown";
            public Car(string model, int speed)
            {
                this.Model = model;
                this.Speed = speed;
            }
            public void Drive()
            {
                Console.WriteLine($"{Model} едет со скоростью  {speed} км/ч.");
            }
        
        
    }

}

