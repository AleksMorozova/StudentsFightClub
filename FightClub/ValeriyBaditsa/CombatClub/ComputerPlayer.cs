using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClub
{
    class  ComputerPlayer : Player
    {
        //new public int Hp;
        private Random rndm = new Random();
        private int numberBodyPart;
        
        public ComputerPlayer(string name, int hp) 
             : base (name, hp)
        {            
            numberBodyPart = rndm.Next(3);
            Blocked = (BodyParts)numberBodyPart;            
        }

        
        public void GetHit()
        {
            numberBodyPart = rndm.Next(3);
            Attacked = (BodyParts)numberBodyPart;           
        }

        // рандомный выбор защищаемой части тела
        public void SetBlock()
        {
            numberBodyPart = rndm.Next(3);
            Blocked = (BodyParts)numberBodyPart;
        }
    }
}
