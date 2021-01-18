using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Abstract_Factory
{
    internal class NapolitanPizza : Pizza
    {
        public NapolitanPizza() 
        {
            Name = "Napolitana";
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
