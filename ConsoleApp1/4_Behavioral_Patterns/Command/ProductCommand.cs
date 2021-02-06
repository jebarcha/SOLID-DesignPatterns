using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Command
{
    public class ProductCommand : ICommand
    {
        private Product _product;
        private PriceAction _priceAction;
        private int _amount;

        public bool IsCommandExecuted { get; private set; }

        public ProductCommand(Product product, PriceAction priceAction, int amount)
        {
            _product = product;
            _priceAction = priceAction;
            _amount = amount;
        }

        public void Execute()
        {
            if (_priceAction == PriceAction.Increase)
            {
                _product.IncreasePrice(_amount);
                IsCommandExecuted = true;
            }
            else 
            {
                IsCommandExecuted = _product.DecreasePrice(_amount);
            }
        }

        public void Undo()
        {
            if (!IsCommandExecuted) 
            {
                return;
            }

            if (_priceAction == PriceAction.Increase)
            {
                _product.DecreasePrice(_amount);
            }
            else 
            {
                _product.IncreasePrice(_amount);
            }
        }
    }
}
