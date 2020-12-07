using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.NullOject
{
    public class StudentDiscount : IDiscount
    {
        public double CalculateDiscount(double productCost)
        {
            return productCost * 0.5;
        }
    }
}
