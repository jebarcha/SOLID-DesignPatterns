using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Decorator
{
    public class ChocolateDecorator : CondimentDecorator
    {
        public ChocolateDecorator(ICoffe coffe) : base(coffe)
        {
            _name = "Chocolate";
            _price = 0.45;

        }
    }
}
