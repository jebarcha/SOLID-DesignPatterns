using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Proxy
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("The car is being drived");
        }
    }
}
