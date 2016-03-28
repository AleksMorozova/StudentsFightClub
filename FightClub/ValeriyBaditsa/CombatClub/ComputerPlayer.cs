using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClub
{
    class ComputerPlayer : Player
    {
        //new public int Hp;
        private Random rndm = new Random();
        private int numberBodyPart;
        public ComputerPlayer() { }
        public ComputerPlayer(string name) 
             : base (name)
        {            
            numberBodyPart = rndm.Next(3);
            Blocked = (BodyParts)numberBodyPart;
            Hp = 100;
        }

        
        public void GetHit()
        {
            numberBodyPart = rndm.Next(3);
            Attacked = (BodyParts)numberBodyPart;
            //if (((BodyParts)numberBodyPart == this.Blocked))
            //    BlockEvent(new EventsArgs(this.Name, Player.Hp));
            //else
            //    if ((BodyParts)numberBodyPart != this.Blocked)
            //    {
            //        if (Player.Hp > 0)
            //        {
            //            Player.Hp--;
            //            WoundEvent(new EventsArgs(this.Name, Player.Hp));
            //        }
            //        else DeathEvent(new EventsArgs(this.Name, Player.Hp));
            //    }
        }

        // рандомный выбор защищаемой части тела
        public void SetBlock()
        {
            numberBodyPart = rndm.Next(3);
            Blocked = (BodyParts)numberBodyPart;
        }
    }
}
