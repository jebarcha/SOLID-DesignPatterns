using System;
using static System.Console;

namespace ConsoleApp1._2_Creational_Patterns.Abstract_Factory
{
    internal class MarinaraSauce : ISauce
    {
        public MarinaraSauce()
        {
            WriteLine("Agregando la salsa marinara");
        }
    }
}