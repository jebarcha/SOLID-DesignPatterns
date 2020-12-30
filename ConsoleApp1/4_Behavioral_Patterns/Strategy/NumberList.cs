using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1._4_Behavioral_Patterns.Strategy
{
    public class NumberList : IListFormatStrategy
    {
        public void Start(StringBuilder sb)
        {
        }
        public void AddItems(StringBuilder sb, string item)
        {
            var itemNumber = Regex.Matches(sb.ToString(), Environment.NewLine).Count + 1;
            sb.AppendLine($"{itemNumber} {item}");
        }

        public void End(StringBuilder sb)
        {
        }

    }
}
