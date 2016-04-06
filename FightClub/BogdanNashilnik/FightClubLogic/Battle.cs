using System;

namespace FightClubLogic
{
    [Serializable]
    public class Battle
    {
        private Fighter humanFighter;
        private Fighter cpuFighter;
        private int round = 1;
        private RoundHalf roundHalf = RoundHalf.HumanAttack;
        private Random rng = new Random();

        public Fighter Fighter1
        {
            get
            {
                return humanFighter;
            }
        }
        public Fighter Fighter2
        {
            get
            {
                return cpuFighter;
            }
        }
        public int Round
        {
            get
            {
                return round;
            }
        }
        public RoundHalf RoundHalf
        {
            get
            {
                return roundHalf;
            }
        }

        public Battle(Fighter fighter1, Fighter fighter2)
        {
            this.humanFighter = fighter1;
            this.cpuFighter = fighter2;
        }

        public void Action(BodyPart bodyPart)
        {
            if (this.roundHalf == RoundHalf.HumanAttack)
            {
                (this.cpuFighter as CPUFighter).SetBlock();
                this.cpuFighter.GetHit(bodyPart, humanFighter.Damage);
                this.roundHalf = RoundHalf.CPUAttack;
            }
            else
            {
                this.humanFighter.SetBlock(bodyPart);
                this.humanFighter.GetHit((this.cpuFighter as CPUFighter).GenerateBodyPart(), cpuFighter.Damage);
                this.roundHalf = RoundHalf.HumanAttack;
                this.round++;
            }
        }
    }
}
