using System;
using static System.Console;

namespace ConsoleApp1._2_Creational_Patterns.Abstract_Factory
{
    internal class ReggianoCheese : ICheese
    {
        public ReggianoCheese() 
        {
            WriteLine("Agregando el queso parmesano");
        }
    }
}