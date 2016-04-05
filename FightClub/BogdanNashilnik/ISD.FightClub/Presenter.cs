using System;
using System.Text;
using FightClubLogic;
using System.IO;
using System.Collections.Generic;

namespace ISD.FightClub
{
    [Serializable]
    public class Presenter : ILogable
    {
        private Battle battle;
        [NonSerialized]
        private IView view;
        private List<string> log = new List<string>();
        [field: NonSerialized]
        public event Log Logging;

        public Battle Battle
        {
            get
            {
                return battle;
            }
        }
        public List<string> Log
        {
            get
            {
                return log;
            }
        }
        
        public Presenter(IView view)
        {
            this.view = view;
        }
        public void InitializeNewBattle(Fighter fighter1, Fighter fighter2)
        {
            this.battle = new Battle(fighter1, fighter2);
            this.Subscribe();
            view.InitializeGUI(fighter1, fighter2);
            this.AddToLog("Битва началась " + DateTime.Now + ".");
        }
        public void InitializeLoadedBattle(Presenter presenter)
        {
            this.battle = presenter.battle;
            this.Subscribe();
            view.InitializeGUI(this.Battle.Fighter1, this.battle.Fighter2);
            this.log.Clear();
            foreach (string logRecord in presenter.log)
            {
                this.AddToLog(logRecord);
            }
        }

        private void Subscribe()
        {
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

            Fighter winner = (sender == this.battle.Fighter1) ? this.battle.Fighter2 : this.battle.Fighter1;
            view.EndGame(winner);
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
            this.log.Add(data);
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
                    sr.Write("\n");
                    foreach (string logRecord in this.log)
                    {
                        sr.Write("\n" + logRecord);
                    }
                }
            }
        }
    }
}
