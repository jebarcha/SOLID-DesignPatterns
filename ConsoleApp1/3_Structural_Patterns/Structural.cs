using ConsoleApp1._3_Structural_Patterns.Adapter;
using ConsoleApp1._3_Structural_Patterns.Bridge;
using ConsoleApp1._3_Structural_Patterns.Bridge.Demo2;
using ConsoleApp1._3_Structural_Patterns.Composite;
using ConsoleApp1._3_Structural_Patterns.Decorator;
using ConsoleApp1._3_Structural_Patterns.Decorator.Demo2;
using ConsoleApp1._3_Structural_Patterns.Facade;
using ConsoleApp1._3_Structural_Patterns.Facade.Demo2;
using ConsoleApp1._3_Structural_Patterns.FlyWeigth;
using ConsoleApp1._3_Structural_Patterns.Proxy;
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

            ReaderApp appWindows7 = new Windows7(new NormalDisplay()) { Text = "This is a demo of Bridge" };
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
        internal static void Composite()
        {
            Console.WriteLine("Composite Pattern Demo");
            Console.WriteLine("----------------------------");

            Composite.Product ram = new Composite.SimpleProduct("RAM 16 gb", 1000);
            Composite.Product processor = new Composite.SimpleProduct("Intel Core i7", 2000);
            Composite.Product videoCard = new Composite.SimpleProduct("nVideo gtx 1050", 500);
            Composite.Product keyboard = new Composite.SimpleProduct("Perfo X keyb", 1000);
            Composite.Product mouse = new Composite.SimpleProduct("Dell x", 100);
            Composite.Product rig = new Composite.SimpleProduct("Tower hp", 2500);
            Composite.Product led = new Composite.SimpleProduct("Led lg", 4000);

            Composite.Product gamingKit = new CompositeProduct("Basic Gamer Computer");
            gamingKit.Add(ram);
            gamingKit.Add(processor);
            gamingKit.Add(videoCard);
            gamingKit.Add(keyboard);
            gamingKit.Add(mouse);
            gamingKit.Add(rig);
            gamingKit.Add(led);

            Console.WriteLine(gamingKit.GetPrice());


        }
        internal static void FlyWeight()
        {
            Console.WriteLine("FlyWeight Pattern Demo");
            Console.WriteLine("----------------------------");

            var factory = new FlyWeigth.Factory();

            for (int i = 0; i < 10; i++)
            {
                IPlayer p = factory.GetPlayer(StaticDemo.GetPlayerRandom());
                p.AssignWeapon(StaticDemo.GetWeaponRandom());
                p.Mission();
            }

            Console.WriteLine(factory.GetNumberOfInstances());
        }

        internal static void Proxy()
        {
            Console.WriteLine("Proxy Pattern Demo");
            Console.WriteLine("----------------------------");

            ICar car = new CarProxy(new Driver(17, true));
            car.Drive();

            Console.WriteLine("");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Proxy Pattern Demo 2");
            Console.WriteLine("----------------------------");
            var person = new ProxyPerson(new Person(0));
            Console.WriteLine(person.Eat());

        }
    }

}
