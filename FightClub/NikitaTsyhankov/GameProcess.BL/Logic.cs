﻿using GameProcess.BL.Fighters;

namespace GameProcess.BL
{
    public class Logic : IFighting
    {
        public Player Player1 { get; private set; }
        public CPUPlayer Player2 { get; private set; }
        public int Round { get; private set; }

        public Logic()
        {
            Player1 = new Player("NoName", ConstantFields.basicHp);
            Player2 = new CPUPlayer(ConstantFields.basicHp);

            Round = 1;
        }

        public void MakeStep(BodyParts _part)
        {
            if (Round % 2 != 0)
            {
                Player2.MakeBlock();
                Player2.GetHit(_part, ConstantFields.basicDamage);
            }
            else
            {
                Player1.SetBlock(_part);
                Player1.GetHit(Player2.MakeHit(), ConstantFields.basicDamage);
            }
            Round++;
        }
    }
}