using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.FlyWeigth
{
    public static class StaticDemo
    {
        public static string[] playerType = { "Terrorist", "CounterTerrorist" };
        public static string[] weapons = { "Ak47", "Gut Knife", "M17", "Granade" };

        public static string GetPlayerRandom() 
        {
            Random r = new Random();

            int rad = r.Next(playerType.Length);
            return playerType[rad];
        }
        public static string GetWeaponRandom()
        {
            Random r = new Random();

            int rad = r.Next(weapons.Length);
            return weapons[rad];
        }

    }
}
