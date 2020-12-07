using System;
using ConsoleApp1._4_Behavioral_Patterns;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Behavioral.Behavioral_NullObject();
            Behavioral.Behavioral_NullObjectDemo2();

            PauseAndWait();
        }
        private static void PauseAndWait() 
        {
            Console.WriteLine("");
            Console.ReadKey();
        }

    }
}
