using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Strategy
{
    public interface IListFormatStrategy
    {
        void Start(StringBuilder sb);
        void AddItems(StringBuilder sb, string item);
        void End(StringBuilder sb);
    }
}
