namespace FightClubLogic
{
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
            this.maxHP = maxHP;
            this.hp = maxHP;
            this.damage = damage;
            this.SetBlock(BodyPart.Head);
        }
        public Fighter(string name, int maxHP, int damage, string imagePath) : this(name, maxHP, damage)
        {
            this.imagePath = imagePath;
        }

        public void GetHit(BodyPart bodyPart, int damage)
        {
            if (bodyPart == this.blocked)
            {
                this.Block(this);
            }
            else
            {
                this.hp -= damage;
                this.Wound(this, damage);
            }
            if (this.hp <= 0)
            {
                this.Death(this);
            }
        }
        public void SetBlock(BodyPart bodyPart)
        {
            this.blocked = bodyPart;
        }
    }
}
