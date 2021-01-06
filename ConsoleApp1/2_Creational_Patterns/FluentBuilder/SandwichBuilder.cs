using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.FluentBuilder
{
    public class SandwichBuilder
    {
        protected Sandwich _sandwich = new Sandwich();
        public Sandwich Sandwich
        { 
            get { return _sandwich; }
        }
        public SandwichBuilder WithMeat() 
        {
            _sandwich.Protein = "Carne";
            return this;
        }
        public SandwichBuilder WithCheeseChedar()
        {
            _sandwich.Cheese = "Queso Chedar";
            return this;
        }
        public SandwichBuilder WithMayonnaiseAndMustard()
        {
            _sandwich.Condiments = "Mayonnaise, Mustard";
            return this;
        }
    }
}
