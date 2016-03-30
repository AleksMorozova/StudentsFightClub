using System;

namespace FightClubLogic
{
    [Serializable]
    public class Fighter
    {
        private string name;
        private int maxHP;
        private int hp;
        private int damage;
        private BodyPart blocked;
        private string imagePath = null;
        public delegate void HitEvent(Fighter sender);
        public delegate void HitEventWithDamage(Fighter sender, int damage);
        public event HitEvent Block;
        public event HitEventWithDamage Wound;
        public event HitEvent Death;

        public BodyPart Blocked
        {
            get
            {
                return blocked;
            }
        }
        public int Damage
        {
            get
            {
                return damage;
            }
        }
        public int MaxHP
        {
            get
            {
                return maxHP;
            }
        }
        public int HP
        {
            get
            {
                return hp;
            }
        }
        public string HPFormatted
        {
            get
            {
                return this.hp + "/" + this.maxHP;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string ImagePath
        {
            get
            {
                return imagePath;
            }
        }

        public Fighter(string name, int maxHP, int damage)
        {
            this.name = name;
            if (maxHP < 1)
            {
                maxHP = 1;
            }
            this.maxHP = maxHP;
            this.hp = maxHP;
            if (damage < 0)
            {
                damage = 0;
            }
            this.damage = damage;
            this.SetBlock(BodyPart.Head);
        }
        public Fighter(string name, int maxHP, int damage, string imagePath) : this(name, maxHP, damage)
        {
            this.imagePath = imagePath;
        }

        public void GetHit(BodyPart bodyPart, int damage)
        {
            if (damage < 0)
            {
                throw new ArgumentOutOfRangeException("Урон должен быть неотрицательным параметром.");
            }
            if (bodyPart == this.blocked)
            {
                if (this.Block != null)
                {
                    this.Block(this);
                }
            }
            else if (damage < this.hp)
            {
                this.hp -= damage;
                if (this.Wound != null)
                {
                    this.Wound(this, damage);
                }
            }
            else
            {
                this.hp = 0;
                if (this.Wound != null)
                {
                    this.Wound(this, damage);
                }
                if (this.Death != null)
                {
                    this.Death(this);
                }
            }
        }
        public void SetBlock(BodyPart bodyPart)
        {
            this.blocked = bodyPart;
        }
    }
}
