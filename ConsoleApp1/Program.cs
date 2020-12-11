using System;
using ConsoleApp1._4_Behavioral_Patterns;
using ConsoleApp1._3_Structural_Patterns;

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

            #endregion

            #region Behavioral
            //Behavioral.NullObject();

            Behavioral.Visitor();


            #endregion

            #region Structural
            //Structural.Facade();

            #endregion
        }
        private static void PauseAndWait() 
        {
            Console.WriteLine("");
            Console.ReadKey();
        }

    }
}
