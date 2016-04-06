using System;
using FightClubLogic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ISD.FightClub
{
    [Serializable]
    public class Presenter : INotifyPropertyChanged, IPresenter
    {
        private Battle battle;
        [NonSerialized]
        private IView view;
        private ILoggable log;
        public event PropertyChangedEventHandler PropertyChanged;

        public ILoggable Log
        {
            get
            {
                return log;
            }
        }
        public Battle Battle
        {
            get
            {
                return battle;
            }
        }
        public string WhatToDo
        {
            get
            {
                return this.battle.RoundHalf == RoundHalf.HumanAttack ? "Куда будем бить?" : "Что будем защищать?";
            }
        }

        public Presenter(IView view, ILoggable log, Fighter fighter1, Fighter fighter2)
        {
            this.view = view;
            this.view.Presenter = (IPresenter)this;
            this.log = log;
            this.battle = new Battle(fighter1, fighter2);
            this.SubscribeToFightersEvents();
            BindingSource bs = new BindingSource();
            bs.DataSource = this;
            view.SetBindings(bs);
            this.Log.Add("Битва началась " + DateTime.Now + ".");
            this.NotifyPropertyChanged();
        }
        public void ResetBattle(Fighter fighter1, Fighter fighter2)
        {
            this.battle = new Battle(fighter1, fighter2);
            this.SubscribeToFightersEvents();
            this.log.Clear();
            this.Log.Add("Битва началась " + DateTime.Now + ".");
            this.NotifyPropertyChanged();
        }
        public void LoadBattle(IPresenter presenter)
        {
            this.battle = presenter.Battle;
            this.SubscribeToFightersEvents();
            this.log = presenter.Log;
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
            this.Log.Add("Боец " + eventArgs.Name + " погиб.");
            this.Log.Add("Бой закончился " + DateTime.Now + " за " + this.battle.Round + " раундов.");
            this.Log.Save();

            this.NotifyPropertyChanged();
            string winner = (sender == this.battle.Fighter1) ? this.battle.Fighter2.Name : this.battle.Fighter1.Name;
            this.view.EndGame(winner);
        }
        private void Fighter_Wound(object sender, EventArgs e)
        {
            FighterEventArgs eventArgs = (FighterEventArgs)e;
            this.Log.Add("Бойцу " + eventArgs.Name + " нанесли " + eventArgs.DamageTaken + " урона. Текущее здоровье: " +
                    eventArgs.HP + "/" + eventArgs.MaxHP + ".");
        }
        private void Fighter_Block(object sender, EventArgs e)
        {
            FighterEventArgs eventArgs = (FighterEventArgs)e;
            this.Log.Add(eventArgs.Name + " заблокировал удар в " + eventArgs.Blocked + ".");
        }
        
        public void Action(BodyPart bodyPart)
        {
            this.battle.Action(bodyPart);
            this.NotifyPropertyChanged();
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
