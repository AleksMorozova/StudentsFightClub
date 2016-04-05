using System;

namespace GameProcess.Fighters
{
    public class CPUPlayer : Player
    {
        private static Random rnd;

        public CPUPlayer(int _hp)
            : base("CPU",_hp)
        {
            rnd = new Random();
        }

        public BodyParts MakeHit()
        {
            return (BodyParts)rnd.Next(0, 4);
        }

        public void MakeBlock()
        {
            SetBlock((BodyParts)rnd.Next(0,4));
        }
    }
}
