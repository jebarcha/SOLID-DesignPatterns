using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.FlyWeigth.Demo2
{
    public class ShapesDemo
    {
    }
    public interface IShape
    {
        string Print();
    }

    public class Rectangle : IShape
    {
        public string Print()
        {
            return "Imprimiendo rectangulo";

        }
    }

    public class Circle : IShape
    {
        public string Print()
        {
            return "Imprimiendo circulo";
        }
    }


    public class ShapeObjectFactory
    {
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public int TotalObjectsCreated
        {
            get { return shapes.Count; }
        }

        public IShape GetShape(string ShapeName)
        {
            IShape shape = null;
            if (shapes.ContainsKey(ShapeName))
            {
                shape = shapes[ShapeName];
            }
            else
            {
                switch (ShapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        shapes.Add("Rectangle", shape);
                        break;
                    case "Circle":
                        shape = new Circle();
                        shapes.Add("Circle", shape);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }
            return shape;
        }
    }
}
