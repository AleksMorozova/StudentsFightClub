using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_Fight_club
{
    [Serializable]
    class GameProcess
    {
        private Player user;
        private Player computer;
        private Player defender;
        private List<string> log;

        [field: NonSerialized]
        public event PlayerEvents FightOver;

        public int UserHP { get { return user.Hp; } }
        public int ComputerHP { get { return computer.Hp; } }
        public string Defender { get { return defender.Name; } }
        public List<string> Log { get { return log; } }

        public GameProcess()
        {
            user = new Player("User");
            computer = new Player("Computer");
            defender = computer;

            user.Wound += WriteToLogWounded;
            user.Blocked += WriteToLogBlocked;
            user.Death += WriteToLogDeath;
            computer.Wound += WriteToLogWounded;
            computer.Blocked += WriteToLogBlocked;
            computer.Death += WriteToLogDeath;

            log = new List<string>();
            log.Add("Fight!");
        }
        private void ChangeAttacker()
        {
            if (defender == user)
                defender = computer;
            else
                defender = user;
        }
        public void Round(BodyPart choosenBodyPart)
        {
            if (defender == user)
            {
                defender.SetBlock(choosenBodyPart);
                defender.GetHit(defender.GetRandomBodyPart());
            }
            else
            {
                defender.SetBlock(defender.GetRandomBodyPart());
                defender.GetHit(choosenBodyPart);
            }
            ChangeAttacker();
        }

        private void WriteToLogWounded(string name, int health)
        {
            string roundResult = name + " wounded! HP: " + health.ToString();
            log.Add(roundResult);
        }
        private void WriteToLogDeath(string name, int health)
        {
            string roundResult = name + " is dead!";
            log.Add(roundResult);
            if (FightOver != null)
                FightOver(name, health);
        }
        private void WriteToLogBlocked(string name, int health)
        {
            string roundResult = name + " blocked punch! HP: " + health.ToString();
            log.Add(roundResult);
        }
        public void Reset()
        {
            user.ResetHealth();
            computer.ResetHealth();
            defender = computer;

            user.Wound += WriteToLogWounded;
            user.Blocked += WriteToLogBlocked;
            user.Death += WriteToLogDeath;
            computer.Wound += WriteToLogWounded;
            computer.Blocked += WriteToLogBlocked;
            computer.Death += WriteToLogDeath;

            log = new List<string>();
            log.Add("Fight!");
        }
    }
}
