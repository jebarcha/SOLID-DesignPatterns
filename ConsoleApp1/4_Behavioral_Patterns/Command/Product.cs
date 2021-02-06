using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Command
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

        public void IncreasePrice(int amount) 
        {
            Console.WriteLine($"Old Price: {Price}");
            Price += amount;
            Console.WriteLine($"The price of {Name} was incremented by {amount}, So the Price now is {Price}");
        }

        public bool DecreasePrice(int amount) 
        {
            if (amount < Price) 
            { 
                Price -= amount;
                Console.WriteLine($"The price of {Name} was decremented by {amount}, So the Price now is {Price}");
                return true;
            }
            return false;
        }
        public override string ToString() => $"The current price of {Name} is {Price}";
    }
}
