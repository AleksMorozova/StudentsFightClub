using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClub
{
    interface IPlayer
    {
        string Name { get; set; }
        int Hp { get; set; }
        bool Attacker { get; set; }
        BodyParts ReturnAttackPartBody();
        void GetHit(BodyParts bodyPartAttack);
        void SetBlock(BodyParts bodyPartBlock);
        event EventHandler<PlayerEventArgs> Block;
        event EventHandler<PlayerEventArgs> Wound;
        event EventHandler<PlayerEventArgs> Death;
    }
}
