using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Device
    {
        private string brand;

        public Device(string brandName)
        {
            brand = brandName;

        }
        public void PowerOn()
        {
            Console.WriteLine($"{brand} включен.");
        }
        public string getBrand()
        {
            return brand;
        }
    }
    class Laptop : Device
    {
        private int ram;
        private int battery;

        public Laptop(string brandName, int ramSize, int batteryLevel) : base(brandName)
        {
            if (ramSize >= 1 && ramSize <= 64)
            {
                ram = ramSize;
            }
            else
            {
                Console.WriteLine("Ошибка: ОЗУ должно быть от 1 до 64!");
                ram = 1;
            }

            if (batteryLevel >= 0 && batteryLevel <= 100)
            {
                battery = batteryLevel;
            }
            else
            {
                Console.WriteLine("Ошибка: заряд должен быть от 0 до 100!");
                battery = 0;
            }
        }

        public void work()
        {
            Console.WriteLine($"Ноутбук {getBrand()}, ОЗУ: {ram} гб, заряд: {battery}%");
        }

    }
}
