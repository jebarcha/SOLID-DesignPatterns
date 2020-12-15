using ConsoleApp1._3_Structural_Patterns.Adapter;
using ConsoleApp1._3_Structural_Patterns.Facade;
using ConsoleApp1._3_Structural_Patterns.Facade.Demo2;
using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp1._3_Structural_Patterns.Adapter.Demo2.AdapterDemo2;

namespace ConsoleApp1._3_Structural_Patterns
{
    internal static class Structural
    {
        internal static void Facade()
        {
            Console.WriteLine("Structural - Facade Pattern Demo");
            Console.WriteLine("-------------------------------------");

            //Without facade:
            //WifiController wifiController = new WifiController();
            //AirConditionerController airController = new AirConditionerController();
            //LightController lightController = new LightController();

            //Console.WriteLine("Coming home...");
            //wifiController.TurnOn();
            //airController.TurnOn();
            //lightController.TurnOn();

            //Console.WriteLine("Leave home...");
            //wifiController.TurnOff();
            //airController.TurnOff();
            //lightController.TurnOff();

            //With facade:*******************************
            Console.WriteLine("Coming home...");
            HomeController homeController = new HomeController();
            homeController.TurnOn();

            Console.WriteLine("Leave home...");
            homeController.TurnOff();

            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Demo 2:");
            Facade_Demo2();
        }
        private static void Facade_Demo2() 
        {
            RunningApp music = new RunningApp();
            Console.WriteLine("Start running - TurnOn Music");
            music.GoRunning();
            Console.WriteLine("Complete running - TurnOff Music");
            music.CompleteRunning();
        }

        internal static void Adapter() 
        {
            //Console.WriteLine(new JsonConverter().GetJson());

            var xmlConverter = new XmlConverter();
            var adapter = new XmlToJsonAdapter(xmlConverter);
            adapter.ConvertXmlToJson();


            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Demo 2:");
            AdapterDemo2();
        }
        private static void AdapterDemo2() 
        {
            var EuropeanToUSAdapter = new EuropeanToUSAdapter(new EuropeanElectricalConnector());
            var result = EuropeanToUSAdapter.ProvideElectricity();
            Console.WriteLine(result);
        }
    }
}
