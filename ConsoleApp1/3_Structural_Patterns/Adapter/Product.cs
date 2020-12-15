using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Adapter
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {
        }
    }
}
