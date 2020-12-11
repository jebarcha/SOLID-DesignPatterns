using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Visitor
{
    public class ShapePrint : IShapeVisitor
    {
        StringBuilder sb = new StringBuilder();

        //public static void Print(Shape shape, StringBuilder sb)
        //{
        //    if (shape is Circle)
        //    {
        //        sb.AppendLine("<circulo>");
        //        sb.AppendLine($"<radio value={((Circle)shape).Radius} />");
        //        sb.AppendLine("</circulo>");
        //    }
        //    if (shape is Square)
        //    {
        //        sb.AppendLine("<cuadrado>");
        //        sb.AppendLine($"<tamanio value={((Square)shape).Size} />");
        //        sb.AppendLine("</cuadrado>");
        //    }
        //    if (shape is JoinShape jp)
        //    {
        //        sb.AppendLine("<figuras>");
        //        Print(jp.Left, sb);
        //        Print(jp.Right, sb);
        //        sb.AppendLine("</figuras>");
        //    }

        //}

        public void Visit(Square square)
        {
            sb.AppendLine("<cuadrado>");
            sb.AppendLine($"<tamanio value={square.Size} />");
            sb.AppendLine("</cuadrado>");
        }

        public void Visit(Circle circle)
        {
            sb.AppendLine("<circulo>");
            sb.AppendLine($"<radio value={circle.Radius} />");
            sb.AppendLine("</circulo>");
        }

        public void Visit(JoinShape joinShapes)
        {
            sb.AppendLine("<figuras>");
            joinShapes.Left.Accept(this);
            joinShapes.Right.Accept(this);
            sb.AppendLine("</figuras>");
        }

        public override string ToString() => sb.ToString();
    }

}
