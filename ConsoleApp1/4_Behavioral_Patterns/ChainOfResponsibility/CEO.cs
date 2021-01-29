using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.ChainOfResponsibility
{
    public class CEO : Handler
    {
        public CEO(ISpecification<Mobile> specification) : base(specification)
        {
        }

        public override void HandleRequest(Mobile mobile)
        {
            if (CanHandle(mobile)) 
            {
                Console.WriteLine($"Order of {mobile} done by {this.GetType().Name}");
            }
        }
        public bool CanHandle(Mobile mobile) 
        {
            return _specification.IsSatisfied(mobile); //return mobile.Type == MobileType.Premium;
        }
    }
}
