using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Decorator
{
    public class Expresso: ICoffe
    {
        public string GetDescription() 
        {
            return "Expresso simple";
        }
        public double GetCost() 
        {
            return 3.25;
        }
    }
}
