using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Bridge
{
    public class Windows10: ReaderApp
    {
        public Windows10(IDisplayFormatter displayFormatter) : base(displayFormatter)
        {
        }

        public override void Display()
        {
            _displayFormatter.Display("Application used from Windows 10 \n " + Text);
        }
    }
}
