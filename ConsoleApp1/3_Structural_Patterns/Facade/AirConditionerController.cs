using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Facade
{
    public class AirConditionerController
    {
        public void TurnOn()
        {
            Console.WriteLine("Air Conditioner is On");
        }
        public void TurnOff()
        {
            Console.WriteLine("Air Conditioner is Off");
        }
    }
}
