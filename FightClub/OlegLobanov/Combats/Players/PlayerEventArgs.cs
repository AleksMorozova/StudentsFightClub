using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combats
{
    public class PlayerEventArgs:EventArgs
    {
            public string Name { get; set; }
            public int HP { get; set; }

            public PlayerEventArgs(string name, int hp)
            {
                this.Name = name;
                this.HP = hp;
            }
        
    }
}
