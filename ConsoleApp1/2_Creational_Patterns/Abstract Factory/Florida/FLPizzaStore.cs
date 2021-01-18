using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Abstract_Factory
{
    public class FLPizzaStore : PizzaStore
    {
        IPizzaIngredientFactory ingredientFactory = new FLPizzaIngredientFactory();
        public override Pizza CreatePizza(TypeOfPizza type)
        {

            return (Pizza)Activator.
                CreateInstance(Type.GetType($"ConsoleApp1._2_Creational_Patterns.Abstract_Factory.{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"), ingredientFactory);

        }

    }
}
