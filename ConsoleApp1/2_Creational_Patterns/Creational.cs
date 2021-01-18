using ConsoleApp1._2_Creational_Patterns.Builder;
using ConsoleApp1._2_Creational_Patterns.FactoryMethod;
using ConsoleApp1._2_Creational_Patterns.FluentBuilder.Demo2;
using ConsoleApp1._2_Creational_Patterns.Prototype.DeepCopy;
//using ConsoleApp1._2_Creational_Patterns.ICloneable;
using ConsoleApp1._2_Creational_Patterns.Singleton;
using PizzaFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns
{
    public static class Creational
    {
        internal static void Builder()
        {
            Console.WriteLine("Creational - Builder Pattern Demo");
            Console.WriteLine("-------------------------------------");

            //var sandwich = new Sandwich("white", "tomatoe", "", "salt", "manchego");
            //Console.WriteLine(sandwich);

            var sandwich = new SandwichAssembly(new CheeseBurger());
            sandwich.Assemble();
            Console.WriteLine($"{sandwich.GetSandwich.Bread} {sandwich.GetSandwich.Cheese} {sandwich.GetSandwich.Condiments} {sandwich.GetSandwich.Protein} {sandwich.GetSandwich.Veggies}");

            Console.WriteLine("");
            FluentBuilder();
        }
        internal static void FluentBuilder() 
        {
            Console.WriteLine("Creational - Fluent Builder Pattern Demo");
            Console.WriteLine("-------------------------------------");
            var builder = new FluentBuilder.SandwichBuilder()
                    .WithMeat()
                    .WithCheeseChedar()
                    .WithMayonnaiseAndMustard();
            Console.WriteLine($"{builder.Sandwich.Bread} {builder.Sandwich.Cheese} {builder.Sandwich.Condiments} {builder.Sandwich.Protein} {builder.Sandwich.Veggies}");

            // Fluent Builder Demo 2
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Creational - Fluent Builder Pattern Demo 2");
            Console.WriteLine("-------------------------------------");
            Car car = CarBuilder
                .CreateNew()
                .AddName("Ford")
                .AddModel("Focus")
                .Build();
            Console.WriteLine(car.ToString());
        }

        internal static void Singleton() 
        {
            Console.WriteLine("Creational - Singleton Pattern Demo");
            Console.WriteLine("-------------------------------------");

            //var capitals = new SingletonDataContainer();
            var capitals = SingletonDataContainer.Instance;
            var capitals2 = SingletonDataContainer.Instance;
            var capitals3 = SingletonDataContainer.Instance;
            Console.WriteLine($"La cantidad de habitantes de Londres es: {capitals.GetPopulation("London")}");
        }

        internal static void Prototype_ICloneable_Demo() 
        {
            Console.WriteLine("Creational - Prototype Pattern Demo - with: IClonable");
            Console.WriteLine("-------------------------------------");

            var notebook1 = new _2_Creational_Patterns.ICloneable.Product("MacBook Pro", new _2_Creational_Patterns.ICloneable.Category("Computers"));
            //var iphone = notebook1;
            var iphone = (_2_Creational_Patterns.ICloneable.Product)notebook1.Clone();
            iphone.Name = "IPhone";
            iphone.Category.Name = "CellPhones";

            Console.WriteLine(notebook1);
            Console.WriteLine(iphone);
        }
        internal static void Prototype_DeepCopy_Demo()
        {
            Console.WriteLine("Creational - Prototype Pattern Demo - with: DeepCopy");
            Console.WriteLine("-------------------------------------");

            //var notebook1 = new _2_Creational_Patterns.ICloneable.Product("MacBook Pro", new _2_Creational_Patterns.ICloneable.Category("Computers"));
            var notebook1 = new ConsoleApp1._2_Creational_Patterns.Prototype.DeepCopy.ProductDeepCopyDemo
                    ("MacBook Pro", 
                      new ConsoleApp1._2_Creational_Patterns.Prototype.DeepCopy.CategoryDeepCopyDemo("Computers"));
            var cellPhone = notebook1.DeepCopy();
            cellPhone.Name = "IPhone1";
            cellPhone.Category.Name = "CellPhones1";

            Console.WriteLine(notebook1);
            Console.WriteLine(cellPhone);


        }
        internal static void FactoryMethod() 
        {
            Console.WriteLine("Creational - Factory Method Pattern Demo");
            Console.WriteLine("----------------------------------------");

            //var user = new User("Jose", "jose@mail.com", "USA");
            var user = User.Factory.CreateWithDefaultCountry("Jose", "jose@email.com");
            Console.WriteLine($"Name:{user.Name}, Email:{user.Email}, Country:{user.Country}");

            //---------------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Creational - Factory Method Pattern Demo - Pizza Factory");
            Console.WriteLine("--------------------------------------------------------");

            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.OrderPizza(TypeOfPizza.Pepperoni);
            Console.WriteLine($"Pizza {pizza.Name} lista para ser entregada.");
        }
        internal static void AbstractFactory() 
        {
            Console.WriteLine("Creational - Abstract Factory Pattern Demo");
            Console.WriteLine("----------------------------------------");

            Console.Write("NY Pizza");
            ConsoleApp1._2_Creational_Patterns.Abstract_Factory.PizzaStore nyStore = new ConsoleApp1._2_Creational_Patterns.Abstract_Factory.NYPizzaStore();
            ConsoleApp1._2_Creational_Patterns.Abstract_Factory.Pizza pizza = nyStore.OrderPizza(ConsoleApp1._2_Creational_Patterns.Abstract_Factory.TypeOfPizza.Pepperoni);
            Console.WriteLine($"Pizza {pizza.Name} lista para ser entregada.");
            Console.WriteLine("----------------------------------------");
            Console.Write("");
            
            Console.Write("FL Pizza");
            ConsoleApp1._2_Creational_Patterns.Abstract_Factory.PizzaStore flStore = new ConsoleApp1._2_Creational_Patterns.Abstract_Factory.FLPizzaStore();
            ConsoleApp1._2_Creational_Patterns.Abstract_Factory.Pizza flPizza = flStore.OrderPizza(ConsoleApp1._2_Creational_Patterns.Abstract_Factory.TypeOfPizza.California);
            Console.WriteLine($"Pizza {flPizza.Name} lista para ser entregada.");
        }
    }
}
