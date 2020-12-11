using ConsoleApp1._4_Behavioral_Patterns.NullOject;
using ConsoleApp1._4_Behavioral_Patterns.Visitor;
using ConsoleApp1._4_Behavioral_Patterns.Visitor.Demo2;
using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
