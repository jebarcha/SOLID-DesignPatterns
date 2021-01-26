using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.FlyWeigth
{
    public class CounterTerrorist : IPlayer
    {
        private string _task;
        private string _weapon;

        public CounterTerrorist()
        {
            _task = "Deactivate bomb";
        }

        public void AssignWeapon(string weapon)
        {
            _weapon = weapon;
        }

        public void Mission()
        {
            Console.WriteLine($"The anti-terrorist with weapon {_weapon} has the task {_task}");
        }
    }
}
