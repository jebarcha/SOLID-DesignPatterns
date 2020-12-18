using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Decorator
{
    public class Filtered: ICoffe
    {
        public string GetDescription()
        {
            return "Filtrado simple";
        }
        public double GetCost()
        {
            return 5.65;
        }
    }
}
