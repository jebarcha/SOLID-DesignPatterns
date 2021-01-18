using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Abstract_Factory
{
    public class NYPizzaStore : PizzaStore
    {
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            //switch (name)
            //{
            //    case "pepperoni":
            //        return new NYPepperoniPizza();
            //    case "Neapolitan":
            //        return new NYNeapolitanPizza();
            //    case "California":
            //        return new NYCaliforniaPizza();
            //    default:
            //        return null;

            //}

            return (Pizza)Activator.
                CreateInstance(Type.GetType($"ConsoleApp1._2_Creational_Patterns.Abstract_Factory.{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"), ingredientFactory);

        }

    }
}
