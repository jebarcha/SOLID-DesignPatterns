using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Bridge
{
    public abstract class ReaderApp
    {
        public string Text { get; set; }
        protected IDisplayFormatter _displayFormatter;
        public ReaderApp(IDisplayFormatter displayFormatter) 
        {
            _displayFormatter = displayFormatter;
        }

        public abstract void Display();
    }
}
