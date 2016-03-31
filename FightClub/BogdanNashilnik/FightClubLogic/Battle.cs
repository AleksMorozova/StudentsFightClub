using System;

namespace FightClubLogic
{
    [Serializable]
    public class Battle
    {
        private Fighter humanFighter;
        private CPUFighter cpuFighter;
        private int round;
        private RoundHalf roundHalf = RoundHalf.HumanAttack;
        private Random rng = new Random();

        public Fighter Fighter1
        {
            get
            {
                return humanFighter;
            }
        }
        public CPUFighter Fighter2
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

        public Battle(Fighter fighter1, CPUFighter fighter2)
        {
            this.humanFighter = fighter1;
            this.cpuFighter = fighter2;
            this.round = 1;
        }

        public void Action(BodyPart bodyPart)
        {
            if (this.roundHalf == RoundHalf.HumanAttack)
            {
                this.cpuFighter.SetBlock();
                this.cpuFighter.GetHit(bodyPart, humanFighter.Damage);
                this.roundHalf = RoundHalf.CPUAttack;
            }
            else
            {
                this.humanFighter.SetBlock(bodyPart);
                this.humanFighter.GetHit(cpuFighter.GenerateBodyPart(), cpuFighter.Damage);
                this.roundHalf = RoundHalf.HumanAttack;
                this.round++;
            }
        }

        public void LoadBattle(Battle battle)
        {
            this.round = battle.round;
            this.humanFighter = battle.Fighter1;
            this.cpuFighter = battle.Fighter2;
            this.roundHalf = battle.RoundHalf;
        }
    }
}
