﻿using System;

namespace GameProcess.Fighters
{
    interface IPlayer
    {
        int HealthPoints
        {
            get;
        }
        string Name
        {
            get; set;
        }
        void GetHit(BodyParts _hited, int _dmg);
        void SetBlock(BodyParts _blocked);
        event EventHandler<EventArgsFighter> Block;
        event EventHandler<EventArgsFighter> Wound;
        event EventHandler<EventArgsFighter> Death;
    }

    public class Player: IPlayer
    {
        #region Variables
        private EventArgsFighter args;
        public event EventHandler<EventArgsFighter> Block;
        public event EventHandler<EventArgsFighter> Wound;
        public event EventHandler<EventArgsFighter> Death;

        private BodyParts _blocked;
        private string _name;
        private int _hp;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public int HealthPoints
        {
            get { return _hp; }
            private set
            {
                _hp = value;
                args.HP = value;
                if (_hp < 0)
                {
                    _hp = 0;
                    if (Death != null) Death(this, args);
                }
            }
        }
        #endregion

        public Player(String _name, int _hp)
        {
            args = new EventArgsFighter();
            Name = _name;
            args.Name = _name;
            HealthPoints = _hp;
            args.HP = HealthPoints;
        }

        public void GetHit(BodyParts _hited, int _dmg)
        {
            if (_hited == _blocked)
            {
                if (Block != null) Block(this, args);
            }
            else
            {
                HealthPoints -= _dmg;
                args.HP = HealthPoints;
                if (Wound != null && 0 != HealthPoints) Wound(this, args);
            }
        }

        public void SetBlock(BodyParts _blocked)
        {
            this._blocked = _blocked;
        }
    }
}
