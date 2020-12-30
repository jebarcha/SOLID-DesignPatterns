using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Strategy
{
    public class TextProcessor
    {
        private StringBuilder sb = new StringBuilder();
        private IListFormatStrategy _listStrategy;

        public TextProcessor(OutputFormat format) 
        {
            // use Reflection
            //_listStrategy = (IListFormatStrategy)
            //    Activator.CreateInstance(Type.GetType($"ConsoleApp1._4_Behavioral_Patterns.Strategy.{Enum.GetName(typeof(OutputFormat), format)}"));

            var formatType = Enum.GetName(typeof(OutputFormat), format);
            var instanceType = Type.GetType($"ConsoleApp1._4_Behavioral_Patterns.Strategy.{formatType}");

            _listStrategy = (IListFormatStrategy) Activator.CreateInstance(instanceType);
        }

        //public void SetOutputFormat(OutputFormat format) 
        //{
        //    switch (format)
        //    {
        //        case OutputFormat.NumberList:
        //            _listStrategy = new NumberList();
        //            break;
        //        case OutputFormat.Html:
        //            _listStrategy = new Html();
        //            break;
        //        default:
        //            break;
        //    }
        //}

        public void AppendList(IEnumerable<string> items) 
        {
            _listStrategy.Start(sb);
            foreach (var item in items)
            {
                _listStrategy.AddItems(sb, item);
            }
            _listStrategy.End(sb);
        }

        public StringBuilder Clear() => sb.Clear();
        public override string ToString() => sb.ToString();
        //public override string ToString()
        //{
        //    return sb.ToString();
        //}

    }
}
