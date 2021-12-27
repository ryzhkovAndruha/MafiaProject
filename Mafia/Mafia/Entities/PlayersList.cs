using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mafia.Entities
{
    public static class PlayersList
    {
        public static List<Player> Players;

        static PlayersList()
        {
            Players = new List<Player>();
        }
    }
}
