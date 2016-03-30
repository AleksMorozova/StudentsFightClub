using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        // - GetHit, SetBlock methods should be virtual and must be overriden in CompPlayer class
        // 
        public override void GetHit(BodyPart part, int damage)
        {
            Debug.WriteLine("BotGetHit");
            
            base.GetHit(part, damage);
        }

        public override void SetBlock(BodyPart part)
        {
            Debug.WriteLine("BotSetBlock");
            
                base.SetBlock(part);
            
        }
    }
}
