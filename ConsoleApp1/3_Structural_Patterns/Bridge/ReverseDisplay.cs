using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Bridge
{
    public class ReverseDisplay : IDisplayFormatter
    {
        public void Display(string text)
        {
            Console.WriteLine(text.Reverse().ToArray());
        }
    }
}
