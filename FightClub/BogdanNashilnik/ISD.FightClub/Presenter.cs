using System;
using FightClubLogic;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ISD.FightClub
{
    [Serializable]
    public class Presenter : INotifyPropertyChanged
    {
        private Battle battle;
        [NonSerialized]
        private FormView view;
        private List<string> log;
        public event PropertyChangedEventHandler PropertyChanged;

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
        public string WhatToDo
        {
            get
            {
                return this.battle.RoundHalf == RoundHalf.HumanAttack ? "Куда будем бить?" : "Что будем защищать?";
            }
        }

        public Presenter(FormView view)
        {
            this.view = view;
        }
        public void InitializeNewBattle(Fighter fighter1, CPUFighter fighter2, bool initGUI)
        {
            this.battle = new Battle(fighter1, fighter2);
            log = new List<string>();
            this.SubscribeToFightersEvents();
            if (initGUI)
            {
                view.SetBindings();
            }
            this.AddToLog("Битва началась " + DateTime.Now + ".");
            this.NotifyPropertyChanged();
        }
        public void InitializeLoadedBattle(Presenter presenter)
        {
            this.battle = presenter.battle;
            this.SubscribeToFightersEvents();
            this.log.Clear();
            foreach (string logRecord in presenter.log)
            {
                this.AddToLog(logRecord);
            }
            this.NotifyPropertyChanged();
        }

        private void SubscribeToFightersEvents()
        {
            this.battle.Fighter1.Block += Fighter_Block;
            this.battle.Fighter1.Wound += Fighter_Wound;
            this.battle.Fighter1.Death += Fighter_Death;
            this.battle.Fighter2.Block += Fighter_Block;
            this.battle.Fighter2.Wound += Fighter_Wound;
            this.battle.Fighter2.Death += Fighter_Death;
        }
        private void Fighter_Death(object sender, EventArgs e)
        {
            FighterEventArgs eventArgs = (FighterEventArgs)e;
            this.AddToLog("Боец " + eventArgs.Name + " погиб.");
            this.AddToLog("Бой закончился " + DateTime.Now + " за " + this.battle.Round + " раундов.");
            this.SaveLog();

            Fighter winner = (sender == this.battle.Fighter1) ? this.battle.Fighter2 : this.battle.Fighter1;
            MessageBox.Show("Победил " + winner.Name + "!");
            Application.Exit();
        }
        private void Fighter_Wound(object sender, EventArgs e)
        {
            FighterEventArgs eventArgs = (FighterEventArgs)e;
            this.AddToLog("Бойцу " + eventArgs.Name + " нанесли " + eventArgs.DamageTaken + " урона. Текущее здоровье: " +
                    eventArgs.HP + "/" + eventArgs.MaxHP + ".");
        }
        private void Fighter_Block(object sender, EventArgs e)
        {
            FighterEventArgs eventArgs = (FighterEventArgs)e;
            this.AddToLog(eventArgs.Name + " заблокировал удар в " + eventArgs.Blocked + ".");
        }
        
        public void Action(BodyPart bodyPart)
        {
            this.battle.Action(bodyPart);
            this.NotifyPropertyChanged();
        }

        public static CPUFighter CreateCPUFighter()
        {
            return new CPUFighter("Noob Saibot", 30, 5, "resources/noobsaibot.png");
        }
        public static Fighter CreateFighter()
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

        private void AddToLog(string data)
        {
            this.log.Add(data);
        }
        private void SaveLog()
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
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
