using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Builder
{
    public class Sandwich
    {
        public string Bread { get; set; }
        public string Veggies { get; set; }
        public string Protein { get; set; }
        public string Condiments { get; set; }
        public string Cheese { get; set; }
        public Sandwich() 
        { 
        }
        public Sandwich(string bread, string veggies, string protein, string condiments, string cheese)
        {
            Bread = bread;
            Veggies = veggies;
            Protein = protein;
            Condiments = condiments;
            Cheese = cheese;
        }
    }
}
