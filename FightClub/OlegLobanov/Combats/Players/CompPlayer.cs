﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Combats
{
     public class CompPlayer:Player
    {
        public CompPlayer(string name, int hp, int damage) : base(name, hp, damage) { }
        

        // - GetHit, SetBlock methods should be virtual and must be overriden in CompPlayer class
        public override void GetHit(BodyPart part, int damage)
        {
            Debug.WriteLine("BotGetHit");

            base.GetHit(part, damage);
        }

         // part will be ignored
        public override void SetBlock(BodyPart part)
        {
            Debug.WriteLine("BotSetBlock");

            EasyRandDefence();
            
        }
        
    }
}
