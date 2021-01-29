using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler _sucesor;
        protected ISpecification<Mobile> _specification;

        protected Handler(ISpecification<Mobile> specification) 
        {
            _specification = specification;
        }
        public void SetSucesor(Handler sucesor) 
        {
            this._sucesor = sucesor;
        }
        public abstract void HandleRequest(Mobile mobile);

    }
}
