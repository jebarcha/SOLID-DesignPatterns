using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PizzaFactory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            WriteLine($"Prepararando: {Name}");
            WriteLine($"Colocando masa: {Dough}");
            WriteLine($"Agregando salsa: {Sauce}");
            WriteLine($"Agregando Capas: {string.Join(",", Toppings)}");

        }
        public void Bake() => WriteLine($"Cocinar por 20 min");
        public void Cut() => WriteLine($"Pizza fue cortada en partes iguales");
        public void Box() => WriteLine($"Pizza colocada en caja oficial");

    }

    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(TypeOfPizza type);

        public Pizza OrderPizza(TypeOfPizza type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }
    }

    public enum TypeOfPizza
    {
        Pepperoni,
        Neapolitan,
        California
    }
    public class NYPizzaStore : PizzaStore
    {
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
                CreateInstance(Type.GetType($"PizzaFactory.NY{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));

        }

    }

    public class FLPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            return (Pizza)Activator.
                 CreateInstance(Type.GetType($"PizzaFactory.FL{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }

    }


    internal class NYPepperoniPizza : Pizza
    {
        public NYPepperoniPizza()
        {
            Name = "Pepperoni";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }

    internal class NYCaliforniaPizza : Pizza
    {
        public NYCaliforniaPizza()
        {
            Name = "california";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }

    internal class NYNapolitanPizza : Pizza
    {
        public NYNapolitanPizza()
        {
            Name = "Napolitana";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }


    #region Florida Pizza
    internal class FLPepperoniPizza : Pizza
    {
        public FLPepperoniPizza()
        {
            Name = "Pepperoni";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }

    internal class FLCaliforniaPizza : Pizza
    {
        public FLCaliforniaPizza()
        {
            Name = "california";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }

    internal class FLNeapolitanPizza : Pizza
    {
        public FLNeapolitanPizza()
        {
            Name = "Napolitana";
            Dough = "delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso mozarella");
        }
    }

    #endregion

}
