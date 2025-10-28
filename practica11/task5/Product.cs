﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Product
    {
        private decimal price;
        private decimal discount;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Цена не может быть отрицательной!");
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }
        }
        public decimal Discount
        {
            get { return discount; }
            set
            {
                if (value < 0)
                {
                    discount = 0;
                }
                else if (value > 100)
                {
                    discount = 100;
                }
                else
                {
                    discount = value;
                }
            }
        }

        public decimal FinalPrice
        {
            get { return Price * (1 - Discount / 100); }
        }
        public string Name { get; init; } = "Без названия";

        public Product(decimal price, decimal discount)
        {
            Price = price;
            Discount = discount;
        }
        public void Show()
        {
            Console.WriteLine($"{Name}: {FinalPrice} (скидка {Discount}%)");
        }
    }
}
