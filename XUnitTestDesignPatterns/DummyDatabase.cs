using ConsoleApp1._2_Creational_Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestDesignPatterns
{
    public class DummyDatabase : ISingletonContainer
    {
        public int GetPopulation(string name)
        {
            return new Dictionary<string, int>
            {
                ["Mexico"]=7000,
                ["Torreon"]=222
            }[name];
        }
    }
}
