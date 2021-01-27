using System;
using ConsoleApp1._4_Behavioral_Patterns;
using ConsoleApp1._3_Structural_Patterns;
using ConsoleApp1._2_Creational_Patterns;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformDemos();
            PauseAndWait();
        }
        private static void PerformDemos() 
        {
            #region Creational
            //Creational.Builder();
            //Creational.Singleton();
            //Creational.Prototype_ICloneable_Demo();
            //Creational.Prototype_DeepCopy_Demo();
            //Creational.FactoryMethod();
            //Creational.AbstractFactory();

            #endregion

            #region Behavioral
            //Behavioral.NullObject();
            //Behavioral.Visitor();
            //Behavioral.State();
            //Behavioral.Strategy();

            #endregion

            #region Structural
            //Structural.Facade();
            //Structural.Adapter();
            //Structural.Decorator();
            //Structural.Bridge();
            //Structural.Composite();
            //Structural.FlyWeight();
            Structural.Proxy();


            #endregion
        }
        private static void PauseAndWait() 
        {
            Console.WriteLine("");
            Console.ReadKey();
        }

    }
}
