using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Composite
{
    public class CompositeProduct : Product
    {
        List<Product> _products = new List<Product>();
        public CompositeProduct(string name): base(name, 0)
        {
        }

        public override void Add(Product product)
        {
            _products.Add(product);
        }
        public override void Remove(Product product)
        {
            _products.Remove(product);
        }

        public override string GetPrice()
        {
            return $"The price of {Name} is {_products.Sum(o => o.Price).ToString("N2")}";
        }

    }
}
