using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Facade
{
    public class LightController
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is On");
        }
        public void TurnOff()
        {
            Console.WriteLine("Light is Off");
        }
    }
}
