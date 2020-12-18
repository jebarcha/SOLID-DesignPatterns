using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Decorator.Demo2
{
    public interface IOrder
    {
        double GetCost();
    }

    public class SimpleOrder : IOrder
    {
        public double GetCost()
        {
            return 15;
        }
    }

    public abstract class OrderDecorator : IOrder
    {
        IOrder _order;
        protected double _cost = 0.0;
        protected OrderDecorator(IOrder order)
        {
            _order = order;
        }

        public double GetCost()
        {
            return _order.GetCost() + _cost;
        }

    }

    public class PremiumOrder : OrderDecorator
    {
        public PremiumOrder(IOrder order) : base(order)
        {
            _cost = 10;
        }
    }

}
