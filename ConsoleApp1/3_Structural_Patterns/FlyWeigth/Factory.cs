using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.FlyWeigth
{
    public class Factory
    {
        Dictionary<string, IPlayer> _players = new Dictionary<string, IPlayer>();
        public int GetNumberOfInstances() 
        {
            return _players.Count;
        }

        public IPlayer GetPlayer(string key) 
        {
            IPlayer player = null;
            if (_players.ContainsKey(key))
            {
                player = _players[key];
            }
            else 
            {
                switch (key)
                {
                    case "Terrorist":
                        player = new Terrorist();
                        break;
                    case "CounterTerrorist":
                        player = new CounterTerrorist();
                        break;
                    default:
                        break;
                }

                _players.Add(key, player);
            }

            return player;
        }
    }
}
