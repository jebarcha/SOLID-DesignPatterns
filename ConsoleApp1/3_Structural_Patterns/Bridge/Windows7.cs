using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Bridge
{
    public class Windows7: ReaderApp
    {
        public Windows7(IDisplayFormatter displayFormatter): base(displayFormatter)
        { 
        }
        public override void Display()
        {
            _displayFormatter.Display("Application used from Windows 7 \n " + Text);
        }
    }
}
