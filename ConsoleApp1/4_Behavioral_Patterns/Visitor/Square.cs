using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Visitor
{
    public class Square: Shape
    {
        public int Size { get;  }
        public Square(int size)
        {
            this.Size = size;
        }

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
