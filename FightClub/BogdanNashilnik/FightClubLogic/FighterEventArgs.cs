using System;

namespace FightClubLogic
{
    public class FighterEventArgs : EventArgs
    {
        private string name;
        private int hp;
        private int maxHP;
        private int damageTaken;
        private BodyPart blockedPart;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int HP
        {
            get
            {
                return hp;
            }
        }
        public int MaxHP
        {
            get
            {
                return maxHP;
            }
        }
        public BodyPart Blocked
        {
            get
            {
                return blockedPart;
            }
        }
        public int DamageTaken
        {
            get
            {
                return damageTaken;
            }
        }

        public FighterEventArgs(Fighter fighter)
        {
            this.name = fighter.Name;
            this.hp = fighter.HP;
            this.maxHP = fighter.MaxHP;
            this.blockedPart = fighter.Blocked;
            this.damageTaken = 0;
        }
        public FighterEventArgs(Fighter fighter, int damageTaken) : this(fighter)
        {
            this.damageTaken = damageTaken;
        }
    }
}
