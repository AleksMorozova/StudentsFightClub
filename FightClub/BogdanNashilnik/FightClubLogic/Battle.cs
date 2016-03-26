using System;

namespace FightClubLogic
{
    [Serializable]
    public class Battle
    {
        private Fighter attacker;
        private Fighter defender;
        private int round = 1;
        private RoundHalf roundHalf = RoundHalf.Attack;
        private Random rng = new Random();
        public delegate void RoundChange(Battle sender);
        [field: NonSerialized]
        public event RoundChange RoundChanged;
        [field: NonSerialized]
        public event RoundChange RoundHalfChanged;

        public Fighter Fighter1
        {
            get
            {
                if (this.roundHalf == RoundHalf.Attack)
                {
                    return attacker;
                }
                else
                {
                    return defender;
                }
            }
        }
        public Fighter Fighter2
        {
            get
            {
                if (this.roundHalf == RoundHalf.Attack)
                {
                    return defender;
                }
                else
                {
                    return attacker;
                }
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
            this.attacker = fighter1;
            this.defender = fighter2;
        }

        public void Action(BodyPart bodyPartAttack, BodyPart bodyPartDefend)
        {
            this.defender.SetBlock(bodyPartDefend);
            this.defender.GetHit(bodyPartAttack, attacker.Damage);
            Fighter swapFighters = this.attacker;
            this.attacker = this.defender;
            this.defender = swapFighters;
            if (this.roundHalf == RoundHalf.Attack)
            {
                this.roundHalf = RoundHalf.Defend;
                if (this.RoundHalfChanged != null)
                {
                    this.RoundHalfChanged(this);
                }
            }
            else
            {
                this.roundHalf = RoundHalf.Attack;
                if (this.RoundHalfChanged != null)
                {
                    this.RoundHalfChanged(this);
                }
                this.round++;
                if (this.RoundChanged != null)
                {
                    this.RoundChanged(this); 
                }
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
