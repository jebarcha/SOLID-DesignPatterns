using System;

namespace ConsoleApp1._2_Creational_Patterns.ICloneable
{
    public class Category : System.ICloneable
    {
        public string Name { get; set; }
        public Category(string name)
        {
            Name = name;
        }
        public object Clone()
        {
            return new Category(Name);
        }
    }
}