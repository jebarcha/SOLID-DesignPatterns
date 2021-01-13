using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Prototype.DeepCopy
{
    [Serializable]
    public class ProductDeepCopyDemo
    {
        public ProductDeepCopyDemo(string name, CategoryDeepCopyDemo category)
        {
            Name = name;
            Category = category;
        }
        public string Name { get; set; }
        public CategoryDeepCopyDemo Category { get; set; }

        public override string ToString()
        {
            return $"Product: {Name}, Category: {Category.Name}";
        }
    }
}
