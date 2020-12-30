using ConsoleApp1._4_Behavioral_Patterns.NullOject;
using ConsoleApp1._4_Behavioral_Patterns.State;
using ConsoleApp1._4_Behavioral_Patterns.Strategy;
using ConsoleApp1._4_Behavioral_Patterns.Strategy.Demo2;
using ConsoleApp1._4_Behavioral_Patterns.Visitor;
using ConsoleApp1._4_Behavioral_Patterns.Visitor.Demo2;
using System;
using System.Text;
using Circle = ConsoleApp1._4_Behavioral_Patterns.Visitor.Circle;
using Square = ConsoleApp1._4_Behavioral_Patterns.Visitor.Square;

namespace ConsoleApp1._4_Behavioral_Patterns
{
    internal static class Behavioral
    {
        internal static void NullObject()
        {
            Console.WriteLine("Behavioral - Null Object Pattern Demo");
            Console.WriteLine("-------------------------------------");
            var studentOrder = new Order(new StudentDiscount(), 50);
            studentOrder.GetDiscount();

            var friendOrder = new Order(new FriendDiscount(), 100);
            friendOrder.GetDiscount();

            //var noDiscountOrder = new Order(null, 100);
            var noDiscountOrder = new Order(new NullDiscount(), 100);
            noDiscountOrder.GetDiscount();

            var order = new Order();
            var orderByProduct = order.GetOrderByProductName("Product 1");
            if (orderByProduct != null)
            {
                Console.WriteLine($"La orden es {orderByProduct}");
            }

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Null Object - Demo2");
            NullObjectDemo2();


        }
        private static void NullObjectDemo2() 
        {
            Console.WriteLine("Behavioral - Null Object Pattern Demo2");
            Console.WriteLine("--------------------------------------");

            var mobile = new NullOject.Demo2.MobileRepository();
            var result = mobile.GetMobileByName("samsung");
            Console.WriteLine(result);

            var resultNull = mobile.GetMobileByName("");
            Console.WriteLine(resultNull);

        }

        internal static void Visitor() 
        {
            Console.WriteLine("Behavioral - Visitor Pattern Demo");
            Console.WriteLine("-------------------------------------");

            var shapes = new JoinShape(
                left: new Circle(3),
                right: new Square(4));

            var sb = new StringBuilder();

            var print = new ShapePrint();
            print.Visit(shapes);
            Console.WriteLine(print);

            Console.WriteLine(sb);

            // Visitor Demo 2:-----------------------------
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Behavioral - Visitor Pattern Demo 2");
            Console.WriteLine("-------------------------------------");
            VisitorDemo2();
            //---------------------------------------------
        }

        private static void VisitorDemo2() 
        {
            var expr1 = new Number(10);
            var expr2 = new Number(20);
            var addition = new AdditionExpression(expr1, expr2);
            var expression = new ExpressionPrinter();
            expression.Visit(addition);
            Console.WriteLine(expression);
        }

        internal static void State() 
        {
            Console.WriteLine("Behavioral - State Pattern Demo");
            Console.WriteLine("-------------------------------------");

            var state = CallState.Colagado;

            while (true) 
            {
                Console.WriteLine($"The telephone is currently in {state}");
                Console.WriteLine("Select an option");

                for (var i = 0; i < PhoneCalls.Rules[state].Count; i++) 
                {
                    var (t, _) = PhoneCalls.Rules[state][i];
                    Console.WriteLine($"{i}. {t}");
                }

                var userInput = Console.ReadLine();
                if (String.IsNullOrEmpty(userInput)) 
                { 
                    return;
                }

                int input = int.Parse(userInput);

                var (_, s) = PhoneCalls.Rules[state][input];
                state = s;
            }
        }

        internal static void Strategy() 
        {
            var list = new[] { "C#", "Java", "Angular", "React", "Javascript", "CSS", "HTML" };
            //var tp = new TextProcessor();
            //tp.SetOutputFormat(OutputFormat.NumberList);
            var tp = new TextProcessor(OutputFormat.NumberList);
            tp.AppendList(list);
            Console.WriteLine(tp);
            tp.Clear();

            //tp.SetOutputFormat(OutputFormat.Html);
            tp = new TextProcessor(OutputFormat.Html);
            tp.AppendList(list);
            Console.WriteLine(tp);
            tp.Clear();

            // Strategy Demo 2:-----------------------------
            StrategyDemo2();
        }
        private static void StrategyDemo2() 
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Strategy pattern - demo 2");
            var context = new Context(new Strategy.Demo2.Circle());
            Console.WriteLine(context.Draw());

            context = new Context(new Strategy.Demo2.Square());
            Console.WriteLine(context.Draw());
        }
    }
}
