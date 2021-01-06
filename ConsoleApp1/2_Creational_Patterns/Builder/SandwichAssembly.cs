using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Builder
{
    public class SandwichAssembly
    {
        private SandwichBuilder _sandwichBuilder;
        public SandwichAssembly(SandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder;
        }

        public void Assemble() 
        {
            _sandwichBuilder.AddBread();
            _sandwichBuilder.AddCheese();
            _sandwichBuilder.AddVeggies();
            _sandwichBuilder.AddCondiments();
        }

        public Sandwich GetSandwich
        { 
            get { return _sandwichBuilder.Sandwich; }
        }
    }
}
