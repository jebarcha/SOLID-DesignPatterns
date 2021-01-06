using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Builder
{
    public class CheeseBurger : SandwichBuilder
    {
        public CheeseBurger() 
        {
            _sandwich = new Sandwich();
        }
        public override void AddBread()
        {
            _sandwich.Bread = "White bread";
        }

        public override void AddCheese()
        {
            _sandwich.Cheese = "Chedar";
        }

        public override void AddCondiments()
        {
            _sandwich.Condiments = "Mayonese";
        }

        public override void AddProtein()
        {
            _sandwich.Protein = "Vacuno";
        }

        public override void AddVeggies()
        {
            _sandwich.Protein = "";
        }
    }
}
