using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
        class Phone
        {
            private int battery;
            
            public int BatteryLevel
            {
                get { return battery; }
                set
                {
                    if (value < 0 || value > 100)
                    {
                        Console.WriteLine("Уровень заряда должен быть в диапозоне от 0 до 100");
                    }
                    battery = value;
                }
            }
            
            public string Brand { get; init; }
            public Phone(string brand, int initialBattery)
            {
                Brand = brand;
                BatteryLevel = initialBattery;
            }
            public void Use()
            {
                if (battery >= 10)
                {
                    battery -= 10;
                    Console.WriteLine($"{Brand}: заряд {BatteryLevel}%");
                }
                else
                {
                    Console.WriteLine($"{Brand} недостаточно заряда для использования");
                }
            }
        }
    
    
}
