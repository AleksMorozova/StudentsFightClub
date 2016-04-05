using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combats
{
    public enum BodyPart
    {
        Head = 1,
        Body = 2,
        Legs = 3
    }
    public delegate void SomeHappened(Player sender, PlayerEventArgs result);

     interface IFighter
    {
         event SomeHappened Block;
         event SomeHappened Wound;
         event SomeHappened Death;

         int HP { get;  }
         string Name { get;  }
        BodyPart Blocked { get;  }
        int Damage { get;  }

        void GetHit(BodyPart part,int damage);
        void SetBlock(BodyPart part);
    }
}
