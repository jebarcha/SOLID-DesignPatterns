using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Abstract_Factory
{
    internal class CaliforniaPizza: Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;
        public CaliforniaPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            Name = "California";
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
