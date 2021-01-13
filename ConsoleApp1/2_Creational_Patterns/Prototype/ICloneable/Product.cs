using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.ICloneable
{
    public class Product: System.ICloneable
    {
        public Product(string name, Category category)
        {
            Name = name;
            Category = category;
        }
        public string Name { get; set; }
        public Category Category { get; set; }

        public object Clone()
        {
            return new Product(Name, (Category)Category.Clone());
        }

        public override string ToString()
        {
            return $"Product: {Name}, Category: {Category.Name}";
        }
    }

}
