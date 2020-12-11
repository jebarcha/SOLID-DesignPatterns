using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Visitor
{
    public class Circle : Shape
    {
        public int Radius { get;  }
        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
