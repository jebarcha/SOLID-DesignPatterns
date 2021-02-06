using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._4_Behavioral_Patterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
