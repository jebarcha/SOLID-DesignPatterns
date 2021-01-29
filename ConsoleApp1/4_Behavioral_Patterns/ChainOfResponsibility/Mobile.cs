using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.ChainOfResponsibility
{
    public class Mobile
    {
        public Mobile(MobileType type, double price, string name)
        {
            Type = type;
            Price = price;
            Name = name;
        }

        public MobileType Type { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        public override string ToString() 
        {
            return $"Name:{Name}, Category:{Type}, Price:{Price} ";
        }

    }
}
