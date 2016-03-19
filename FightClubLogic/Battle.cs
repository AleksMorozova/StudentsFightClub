using System;

namespace FightClubLogic
{
    public class Battle
    {
        private Fighter fighter1;
        private Fighter fighter2;
        private int round = 1;
        private RoundHalf roundHalf = RoundHalf.Attack;
        private Random rng = new Random();
        public delegate void RoundChange(Battle sender);
        public event RoundChange RoundChanged;
        public event RoundChange RoundHalfChanged;

        public Fighter Fighter1
        {
            get
            {
                return fighter1;
            }
        }
        public Fighter Fighter2
        {
            get
            {
                return fighter2;
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
            this.fighter1 = fighter1;
            this.fighter2 = fighter2;
        }

        public void Action(BodyPart bodyPartAttack, BodyPart bodyPartDefend)
        {
            this.fighter2.SetBlock(bodyPartDefend);
            this.fighter2.GetHit(bodyPartAttack, fighter1.Damage);
            Fighter temp = this.fighter1;
            this.fighter1 = this.fighter2;
            this.fighter2 = temp;
            if (this.roundHalf == RoundHalf.Attack)
            {
                this.roundHalf = RoundHalf.Defend;
                this.RoundHalfChanged(this);
            }
            else
            {
                this.roundHalf = RoundHalf.Attack;
                this.RoundHalfChanged(this);
                this.round++;
                this.RoundChanged(this);
            }
        }
        public void AttackCPU(BodyPart bodyPartAttack)
        {
            this.Action(bodyPartAttack, GenerateBodyPart());
        }
        public void DefendFromCPU(BodyPart bodyPartDefend)
        {
            this.Action(GenerateBodyPart(), bodyPartDefend);
        }
        private BodyPart GenerateBodyPart()
        {
            int totalBodyParts = Enum.GetValues(typeof(BodyPart)).Length;
            return (BodyPart)rng.Next(0, totalBodyParts);
        }
    }
}
