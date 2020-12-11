using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Visitor
{
    public class JoinShape : Shape
    {
        public Shape Left { get; }
        public Shape Right { get; }
        public JoinShape(Shape left, Shape right)
        {
            this.Left = left;
            this.Right = right;
        }

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
