using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Singleton
{
    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> _capitals = new Dictionary<string, int>();
        private SingletonDataContainer()
        {
            Console.WriteLine("New Instance of SingletonDataContainer");

            var elements = File.ReadAllLines("C:\\MisCursos\\DesignPatterns\\Udemy-RodrigoMorales\\DesignPatternsDemo\\ConsoleApp1\\bin\\Debug\\netcoreapp3.1\\capitals.txt");
            for (int i = 0; i < elements.Length; i += 2)
            {
                _capitals.Add(elements[i], int.Parse(elements[i + 1]));
            }
        }
        //private static SingletonDataContainer instance = new SingletonDataContainer();
        //public static SingletonDataContainer Instance => instance;
        
        // using Lazy:
        private static Lazy<SingletonDataContainer> instance = new Lazy<SingletonDataContainer>(() => new SingletonDataContainer());
        public static SingletonDataContainer Instance => instance.Value;


        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }
}
