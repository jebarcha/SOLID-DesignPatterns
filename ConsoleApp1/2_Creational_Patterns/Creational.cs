using ConsoleApp1._2_Creational_Patterns.Builder;
using ConsoleApp1._2_Creational_Patterns.FluentBuilder.Demo2;
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


    }
}
