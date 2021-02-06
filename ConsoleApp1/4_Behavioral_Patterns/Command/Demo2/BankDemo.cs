using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Command.Demo2
{
    class BankDemo
    {
    }
    public enum Action
    {
        Deposit,
        Withdraw
    }

    public class BankCommand
    {
        public Action BalanceAction;
        public int Amount;
        public bool Success;
    }

    public class BankAccount
    {
        public int Balance { get; set; }

        public void Execute(BankCommand c)
        {
            switch (c.BalanceAction)
            {
                case Action.Deposit:
                    Balance += c.Amount;
                    c.Success = true;
                    break;
                case Action.Withdraw:
                    c.Success = Balance >= c.Amount;
                    if (c.Success) Balance -= c.Amount;
                    break;
            }
        }
    }
}
