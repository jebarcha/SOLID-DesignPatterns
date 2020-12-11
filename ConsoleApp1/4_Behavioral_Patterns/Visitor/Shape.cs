using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Visitor
{
    public abstract class Shape
    {
        public abstract void Accept(IShapeVisitor visitor);
        //public abstract void Print(StringBuilder sb);
    }

}
