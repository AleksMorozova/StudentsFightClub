using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combats
{
    
    public class Player:IFighter
    {
        
        public event SomeHappened Block;
        public event SomeHappened Wound;
        public event SomeHappened Death;

        public string Name { get; private set; }
        public int HP { get; private set; }
        public int MaxHP { get; private set; }

        public int Damage { get; private set; }
        public BodyPart Blocked { get;  private set; }

        public Player(string name, int hp, int damage)
        {
            this.Name = name;
            this.HP = hp;
            this.MaxHP = hp;
            this.Damage = damage;
            this.SetBlock(BodyPart.Head);
        }

        public virtual void GetHit(BodyPart part, int damage)
        {
            if (Blocked == part)
            {
                if (Block != null)
                {
                    Block(this,new PlayerEventArgs(this.Name,this.HP));
                }
            }
            else
            {
                Hitted(damage);
            }

        }
        
        public virtual void SetBlock(BodyPart part)
        {
            Blocked = part;
        }
        
        protected void Hitted(int damage)
        {
            HP -= damage;
            if (Wound != null)
            {
                Wound(this, new PlayerEventArgs(this.Name, this.HP));
            }

            if (HP <= 0)
            {
                HP = 0;
                if (Death != null)
                {
                    Death(this, new PlayerEventArgs(this.Name, this.HP));
                }
            }
        }

    }
}
