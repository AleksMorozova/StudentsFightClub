using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combats
{
     public class CompPlayer:Player
    {
        public CompPlayer(string name, int hp, int damage) : base(name, hp, damage) { }
        Random rand = new Random(DateTime.Now.Millisecond);
        int maxvalue = Enum.GetValues(typeof(BodyPart)).Length +1;

        public void EasyRandDefence()
        {
            SetBlock((BodyPart)rand.Next(1, maxvalue));
        }
        public BodyPart EasyRandAttack()
        {
            return (BodyPart)rand.Next(1, maxvalue);
        }
    }
}
