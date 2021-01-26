using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Composite
{
    public class SimpleProduct : Product
    {
        public SimpleProduct(string name, int price) : base(name, price)
        {
        }

        public override void Add(Product product)
        {
            // Operation cannot do because the element is below the hierarchy
        }
        public override void Remove(Product product)
        {
            // Operation cannot do because the element is below the hierarchy
        }

        public override string GetPrice()
        {
            return ($"The price of {Name} is {Price.ToString("N2")}");
        }

    }
}
