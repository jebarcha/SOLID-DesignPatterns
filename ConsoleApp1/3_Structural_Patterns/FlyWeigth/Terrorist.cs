using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.FlyWeigth
{
    public class Terrorist : IPlayer
    {
        private string _task;
        private string _weapon;

        public Terrorist()
        {
            _task = "Put bomb";
        }

        public void AssignWeapon(string weapon)
        {
            _weapon = weapon;
        }

        public void Mission()
        {
            Console.WriteLine($"The terrorist with weapon {_weapon} has the task {_task}");
        }
    }
}
