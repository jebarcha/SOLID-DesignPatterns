using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Abstract_Factory
{
    internal class PepperoniPizza: Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;
        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            Name = "Pepperoni";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Prepararando: {Name}");
            Dough = _ingredientFactory.CreateDough();
            Cheese = _ingredientFactory.CreateCheesee();
            Sauce = _ingredientFactory.CreateSauce();
            Veggies = _ingredientFactory.CreateVeggies();
        }
    }
}
