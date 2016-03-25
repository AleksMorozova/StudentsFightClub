using System;
using System.Text;
using FightClubLogic;
using System.Windows.Forms;
using System.IO;

namespace ISD.FightClub
{
    class Presenter : ILogable
    {
        private Battle battle;
        private StringBuilder log = new StringBuilder();
        public event Log Logging;

        public Battle Battle
        {
            get
            {
                return battle;
            }
        }

        public Presenter(Fighter fighter1, Fighter fighter2)
        {
            this.battle = new Battle(fighter1, fighter2);

            this.battle.Fighter1.Block += Fighter_Block;
            this.battle.Fighter1.Wound += Fighter_Wound;
            this.battle.Fighter1.Death += Fighter_Death;
            this.battle.Fighter2.Block += Fighter_Block;
            this.battle.Fighter2.Wound += Fighter_Wound;
            this.battle.Fighter2.Death += Fighter_Death;
        }

        private void Fighter_Death(Fighter sender)
        {
            this.AddToLog("Боец " + sender.Name + " погиб.");
            this.AddToLog("Бой закончился " + DateTime.Now + " за " + this.battle.Round + " раундов.");
            this.SaveLog();
            string winner;
            if (sender == this.battle.Fighter1)
            {
                winner = this.battle.Fighter2.Name;
            }
            else
            {
                winner = this.battle.Fighter1.Name;
            }
            MessageBox.Show("Победил " + winner + "!");
            Application.Exit();
        }
        private void Fighter_Wound(Fighter sender, int damage)
        {
            this.AddToLog("Бойцу " + sender.Name + " нанесли " + damage + " урона. Текущее здоровье: " + sender.HP + "/" + sender.MaxHP + ".");
        }
        private void Fighter_Block(Fighter sender)
        {
            this.AddToLog(sender.Name + " заблокировал удар в " + sender.Blocked + ".");
        }
        
        public void Action(BodyPart bodyPart)
        {
            if (this.battle.RoundHalf == RoundHalf.Attack)
            {
                this.battle.AttackCPU(bodyPart);
            }
            else
            {
                this.battle.DefendFromCPU(bodyPart);
            }
        }

        public static Fighter CreateFighterNoobSaibot()
        {
            return new Fighter("Noob Saibot", 30, 5, "resources/noobsaibot.png");
        }
        public static Fighter CreateFighterScorpion()
        {
            return new Fighter("Scorpion", 15, 10, "resources/scorpion.png");
        }
        public static Fighter CreateFighter(string name, int maxHP, int damage)
        {
            return new Fighter(name, maxHP, damage);
        }
        public static Fighter CreateFighter(string name, int maxHP, int damage, string imagePath)
        {
            return new Fighter(name, maxHP, damage, imagePath);
        }

        public void AddToLog(string data)
        {
            this.log.Append(data + "\n");
            if (this.Logging != null)
            {
                this.Logging(data);
            }
        }
        public void SaveLog()
        {
            using (FileStream fs = new FileStream("log.txt", FileMode.Append))
            {
                using (StreamWriter sr = new StreamWriter(fs))
                {
                    sr.Write("\n" + this.log);
                }
            }
        }
    }
}
