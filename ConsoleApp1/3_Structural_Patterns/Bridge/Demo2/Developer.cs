using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Bridge.Demo2
{
    public class Developer : Employee
    {
        public Developer(IContactType contactType) : base(contactType)
        {
            Name = "Developer";
        }
    }
}
