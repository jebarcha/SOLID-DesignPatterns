using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Facade
{
    public class HomeController
    {
        private WifiController _wifiController = new WifiController();
        private AirConditionerController _airController = new AirConditionerController();
        private LightController _lightController = new LightController();

        public void TurnOn()
        {
            _wifiController.TurnOn();
            _airController.TurnOn();
            _lightController.TurnOn();
        }
        public void TurnOff()
        {
            _wifiController.TurnOff();
            _airController.TurnOff();
            _lightController.TurnOff();
        }
    }
}
