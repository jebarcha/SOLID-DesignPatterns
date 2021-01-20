using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Bridge.Demo2
{
    public abstract class Employee
    {
        public string Name { get; set; }
        private IContactType _contactType;

        public Employee(IContactType contactType)
        {
            _contactType = contactType;
        }
        public override string ToString()
        {
            return $"{Name} has been contacted by {_contactType.Type}";
        }

    }
}
