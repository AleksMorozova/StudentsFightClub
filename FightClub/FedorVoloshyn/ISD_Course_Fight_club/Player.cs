using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_Fight_club
{
    enum BodyPart
    {
        Head,
        Body,
        Legs
    }
        
    public delegate void PlayerEvents(string name, int hp);
    
    [Serializable]
    class Player
    {
        protected string name;
        protected BodyPart blockedPart;
        protected int hp = 100;
        public string Name
        {
            get { return name; }
        }
        public int Hp
        {
            get { return hp; }
        }

        public event PlayerEvents Blocked;
        public event PlayerEvents Wound;
        public event PlayerEvents Death;

        public Player(string Name)
        {
            this.name = Name;
            hp = 100;
        }

        public void GetHit(BodyPart bodyPartToPunch)
        {
            if (bodyPartToPunch != blockedPart)
            {
                hp -= 20;
                if (hp > 0)
                {
                    if (Wound != null)
                        Wound(this.name, this.hp);
                }
                else
                {
                    if (Death != null)
                        Death(this.name, this.hp);
                }
            }
            else
            {
                if (Blocked != null)
                    Blocked(this.name, this.hp);
            }
        }
        public void SetBlock(BodyPart blockedPart)
        {
            this.blockedPart = blockedPart;
        }

        public void ResetHealth()
        {
            this.hp = 100;
        }

        public BodyPart GetRandomBodyPart()
        {
            Random rand = new Random();
            BodyPart bodyPart = BodyPart.Head;

            switch (rand.Next(0, 3))
            {
                case 0: bodyPart = BodyPart.Body;
                    break;
                case 1: bodyPart = BodyPart.Head;
                    break;
                case 2: bodyPart = BodyPart.Legs;
                    break;
            }
            return bodyPart;
        }
    }
    
}
