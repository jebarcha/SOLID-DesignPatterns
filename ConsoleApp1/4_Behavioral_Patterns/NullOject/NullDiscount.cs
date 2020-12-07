using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.NullOject
{
    public class NullDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return productCost;
        }
    }
}
