using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Visitor.Demo2
{
    public interface IExpressionVisitor
    {
        void Visit(Number value);
        void Visit(AdditionExpression ae);
    }

    public abstract class Expression
    {
        public abstract void Accept(IExpressionVisitor visitor);
    }

    public class Number : Expression
    {
        public readonly int Value;

        public Number(int value)
        {
            Value = value;
        }

        public override void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class AdditionExpression : Expression
    {
        public readonly Expression LeftValue, RightValue;

        public AdditionExpression(Expression leftValue, Expression rightValue)
        {
            LeftValue = leftValue;
            RightValue = rightValue;
        }

        public override void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }



    public class ExpressionPrinter : IExpressionVisitor
    {
        private StringBuilder sb = new StringBuilder();

        public void Visit(Number value)
        {
            sb.Append(value.Value);
        }

        public void Visit(AdditionExpression addition)
        {
            addition.LeftValue.Accept(this);
            sb.Append("+");
            addition.RightValue.Accept(this);
        }


        public override string ToString() => sb.ToString();
    }
}
