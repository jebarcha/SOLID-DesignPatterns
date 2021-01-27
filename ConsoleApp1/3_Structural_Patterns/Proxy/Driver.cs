using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Proxy
{
    public class Driver
    {
        private int _age;
        private bool _hasLicence;
        public Driver(int age, bool hasLicence)
        {
            _age = age;
            _hasLicence = hasLicence;
        }

        internal bool CanDrive() => _age >= 18 && _hasLicence;
    }
}
