using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Strategy.Demo2
{
    public class StrategyDemoShapes
    {
    }

    public interface IShapeStrategy
    {
        string Draw();
    }

    public class Circle : IShapeStrategy
    {
        public string Draw()
        {
            return "Dibujando circulo";
        }
    }

    public class Square : IShapeStrategy
    {
        public string Draw()
        {
            return "Dibujando cuadrado";
        }
    }

    public class Context
    {

        private IShapeStrategy _shapeStrategy;

        public Context(IShapeStrategy shapeStrategy)
        {
            _shapeStrategy = shapeStrategy;
        }

        public string Draw()
        {
            return _shapeStrategy.Draw();
        }

    }
}
