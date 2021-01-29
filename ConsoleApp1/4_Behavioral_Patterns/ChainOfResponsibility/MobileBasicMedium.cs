using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.ChainOfResponsibility
{
    public class MobileBasicMedium : ISpecification<Mobile>
    {
        public bool IsSatisfied(Mobile item)
        {
            return item.Type == MobileType.Basic || item.Type == MobileType.Medium;
        }
    }
}
