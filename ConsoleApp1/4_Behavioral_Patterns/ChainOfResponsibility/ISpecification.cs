using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.ChainOfResponsibility
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
