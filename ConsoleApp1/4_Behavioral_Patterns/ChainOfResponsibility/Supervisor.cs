using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.ChainOfResponsibility
{
    public class Supervisor : Handler
    {
        public Supervisor(ISpecification<Mobile> specification) : base(specification)
        {
        }

        public override void HandleRequest(Mobile mobile)
        {
            if (CanHandle(mobile)) 
            {
                Console.WriteLine($"Order of {mobile} done by {this.GetType().Name}");
            }
            else
            {
                _sucesor.HandleRequest(mobile);
            }
        }
        public bool CanHandle(Mobile mobile) 
        {
            return _specification.IsSatisfied(mobile); // mobile.Type == MobileType.Medium;
        }
    }
}
