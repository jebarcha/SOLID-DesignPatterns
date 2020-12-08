using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Facade
{
    public class WifiController
    {
        public void TurnOn() 
        {
            Console.WriteLine("Wifi is On");
        }
        public void TurnOff() 
        {
            Console.WriteLine("Wifi is Off");
        }
    }
}
