using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Abstract_Factory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheesee()
        {
            return new ReggianoCheese();
        }

        public IDough CreateDough()
        {
            return new IThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie> { new Onion(), new Garlic() };
        }
    }
}
