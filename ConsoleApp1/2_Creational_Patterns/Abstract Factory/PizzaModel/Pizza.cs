using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Abstract_Factory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected IDough Dough;
        protected ISauce Sauce;
        protected List<IVeggie> Veggies = new List<IVeggie>();
        protected ICheese Cheese;

        public abstract void Prepare();
        public void Bake() => Console.WriteLine($"Cocinar por 20 min");
        public void Cut() => Console.WriteLine($"Pizza fue cortada en partes iguales");
        public void Box() => Console.WriteLine($"Pizza colocada en caja oficial");


    }
}
