using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Proxy
{
    public class CarProxy : ICar
    {
        private Car _car = new Car();
        private Driver _driver;

        public CarProxy(Driver driver)
        {
            _driver = driver;
        }

        public void Drive()
        {
            if (_driver.CanDrive())
            {
                _car.Drive();
            }
            else 
            {
                Console.WriteLine("This driver cannot drive a car");
            }
        }
    }
}
