using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Decorator
{
    public abstract class CondimentDecorator : ICoffe
    {
        ICoffe _coffe;
        protected double _price = 0.0;
        protected string _name;
        protected CondimentDecorator(ICoffe coffe)
        {
            _coffe = coffe;
        }

        public double GetCost()
        {
            return _coffe.GetCost() + _price;
        }

        public string GetDescription()
        {
            return $"{_coffe.GetDescription()}/{_name}";
        }
    }
}
