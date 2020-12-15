using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Adapter
{
    public static class ProductDataProvider
    {
        public static List<Product> GetData() =>
            new List<Product>
            {
                new Product("IPhone", 5000),
                new Product("Xiami Mi 2", 100),
                new Product("Samsung s9", 4000)
            };

    }
}
