using GameProcess.BL.Fighters;
using System;
using System.Collections.Generic;

namespace GameProcess.BL
{
    [Serializable]
    public class Logic : IFighting
    {
        public IFighter Player1 { get; private set; }
        public ICPUFighter Player2 { get; private set; }
        public int Round { get; private set; }
        private List<string> _log = new List<string>();
        public List<string> Log
        {
            get { return _log; }
        }

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
        public void AddToLog(string item)
        {
            _log.Add(item);
        }
    }
}
