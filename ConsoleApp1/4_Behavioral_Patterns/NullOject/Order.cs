using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.NullOject
{
    public class Order
    {
        private IDiscount _discount;
        private double _productPrice;
        public Order(IDiscount discount, double productPrice)
        {
            this._discount = discount;
            this._productPrice = productPrice;
        }
        public Order() 
        { 
        }

        public double GetDiscount() => _discount.CalculateDiscount(_productPrice);
        //public double GetDiscount() 
        //{
        //    return _discount.CalculateDiscount(_productPrice);
        //}
        public Order GetOrderByProductName(string product) => new Order();
    }
}
