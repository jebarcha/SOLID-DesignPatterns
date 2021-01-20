using ConsoleApp1._3_Structural_Patterns.Adapter;
using ConsoleApp1._3_Structural_Patterns.Bridge;
using ConsoleApp1._3_Structural_Patterns.Bridge.Demo2;
using ConsoleApp1._3_Structural_Patterns.Decorator;
using ConsoleApp1._3_Structural_Patterns.Decorator.Demo2;
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

        internal static void Decorator() 
        {
            var expressoWithMilkAndChocolate = new MilkDecorator(new ChocolateDecorator(new Expresso()));

            Console.WriteLine($"The price of {expressoWithMilkAndChocolate.GetDescription()} is {expressoWithMilkAndChocolate.GetCost()}");

            DecoratorDemo2();
        }

        private static void DecoratorDemo2() 
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Decorator - Demo 2:");
            var x = new PremiumOrder(new SimpleOrder());
            Console.WriteLine(x.GetCost());
        }

        internal static void Bridge() 
        {
            Console.WriteLine("Bridge Pattern Demo");
            Console.WriteLine("----------------------------");

            ReaderApp appWindows7 = new Windows7(new NormalDisplay()) { Text = "This is a demo of Bridge"};
            appWindows7.Display();
            ReaderApp appWindows10 = new Windows10(new NormalDisplay()) { Text = "This is a demo of Bridge" };
            appWindows10.Display();

            Console.WriteLine("");

            ReaderApp appWindows7Reverse = new Windows7(new ReverseDisplay()) { Text = "This is a demo of Bridge" };
            appWindows7Reverse.Display();
            ReaderApp appWindows10Reverse = new Windows10(new ReverseDisplay()) { Text = "This is a demo of Bridge" };
            appWindows10Reverse.Display();

            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("Bridge Pattern Demo 2");
            Console.WriteLine("----------------------------");

            Employee developer = new Developer(new Email());
            Console.WriteLine(developer.ToString());

            Employee scrumMaster = new ScrumMaster(new PhoneCall());
            Console.WriteLine(scrumMaster.ToString());

        }
    }
}
