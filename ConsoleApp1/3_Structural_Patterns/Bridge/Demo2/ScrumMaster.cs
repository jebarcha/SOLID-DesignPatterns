using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Bridge.Demo2
{
    public class ScrumMaster : Employee
    {
        public ScrumMaster(IContactType contactType) : base(contactType)
        {
            Name = "ScrumMaster";
        }
    }
}
