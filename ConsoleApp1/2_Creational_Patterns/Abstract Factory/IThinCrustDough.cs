using System;
using static System.Console;

namespace ConsoleApp1._2_Creational_Patterns.Abstract_Factory
{
    internal class IThinCrustDough : IDough
    {
        public IThinCrustDough()
        {
            WriteLine("Agregando la masa delgada");
        }
    }
}