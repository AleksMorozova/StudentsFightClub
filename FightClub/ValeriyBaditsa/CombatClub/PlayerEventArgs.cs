using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClub
{
    public class PlayerEventArgs : EventArgs
    {
        public string name { get; private set; }
        public int Hp { get; private set; }

        public PlayerEventArgs(string name, int hp)
        {
            this.name = name;
            this.Hp = hp;
        }
    }
}
