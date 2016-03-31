using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClub
{     
    enum BodyParts {head, body, legs};

    class Player
    {    
        public delegate void Del(object sender, PlayerEventArgs args);        
        const int startHp = 10;

        public string Name { get; set; }
        public BodyParts Blocked { get; set; }
        public int Hp {get; set;}      
        int Damage { get; set; }
        public bool Attacker { get; set; }
        public BodyParts Attacked { get; set; }
        
        //public Player(string name)
        //{
        //    this.Name = name;
        //    Hp = startHp;            
        //    this.Attacker = true;
        //}

        public Player(string name, int hp)
        {
            this.Name = name;
            this.Hp = hp;
            this.Attacker = true;
        }

        //public void BlockEvent(PlayerEventArgs e)
        //{
        //    if (Block != null)
        //        Block(this,e);
        //}

        //public void WoundEvent(PlayerEventArgs e)
        //{
        //    if (Wound != null)
        //        Wound(this, e);
        //}

        //public void DeathEvent(PlayerEventArgs e)
        //{
        //    if (Death != null)
        //       Death(this, e);
        //}

        public bool CompareParts(Player player, ComputerPlayer compPlayer)
        {
            return player.Blocked == compPlayer.Blocked;
        }

        public void GetHit(BodyParts bodyPartAttack)
        {
            Attacked = bodyPartAttack;            
        }

        public void SetBlock(BodyParts bodyPartBlock)
        {
            Blocked = bodyPartBlock;            
        }
        
        //public event Del Block;
        //public event Del Wound;
        //public event Del Death;
        public event EventHandler<PlayerEventArgs> Block;
        public event EventHandler<PlayerEventArgs> Wound;
        public event EventHandler<PlayerEventArgs> Death;

        public void OnBlock()
        {           
            if (Block != null)
            {
                Block(this, new PlayerEventArgs(this.Name, this.Hp));                
            }
        }

        public void OnWound()
        {          
            if (Wound != null)
            {
                Wound(this, new PlayerEventArgs(this.Name, this.Hp));               
            }
        }

        public void OnDeath()
        {
            if (Death != null)
            {
                Death(this, new PlayerEventArgs(this.Name, this.Hp));
            }
        }
    }
}
