using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.FluentBuilder.Demo2
{
    public sealed class Car
    {
        public string Name;
        public string Model;

        public override string ToString() => $"My car is {Name}, Model: {Model}";
    }

    public class CarBuilder
    {
        private readonly Car _car;
        private CarBuilder()
        {
            _car = new Car();
        }
        public static CarBuilder CreateNew()
        {
            return new CarBuilder();
        }
        public CarBuilder AddName(string name)
        {
            _car.Name = name;
            return this;
        }
        public CarBuilder AddModel(string model)
        {
            _car.Model = model;
            return this;
        }
        public Car Build()
        {
            return _car;
        }

    }

}
