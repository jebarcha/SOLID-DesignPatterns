using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Bridge.Demo2
{
    public class PhoneCall : IContactType
    {
        public string Type => "phone";
    }
}
