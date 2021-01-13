using System;

namespace ConsoleApp1._2_Creational_Patterns.Prototype.DeepCopy
{
    [Serializable]
    public class CategoryDeepCopyDemo
    {
        public string Name { get; set; }
        public CategoryDeepCopyDemo(string name)
        {
            Name = name;
        }

    }
}