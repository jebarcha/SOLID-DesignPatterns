using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Decorator
{
    public class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(ICoffe coffe) : base(coffe)
        {
            _name = "Milk";
            _price = 0.25;
        }

    }
}
