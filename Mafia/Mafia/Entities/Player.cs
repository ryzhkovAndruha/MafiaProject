using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mafia.Entities
{
    public enum Role
    {
        Citizen,
        Mafia,
        MafiaDon,
        Detecitve,
        Doctor,
        Maniac,
        Lover,
        
    }
    public class Player
    {
        public int ID { get; set; }
        public string NickName { get; set; }
        public Role Role { get; set; }
        public bool IsAlive { get; set; }


        public Player()
        {
            IsAlive = true;
        }
    }
}
