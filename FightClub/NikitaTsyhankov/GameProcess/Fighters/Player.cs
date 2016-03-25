using System;

namespace GameProcess.Fighters
{
    public class Player
    {
        #region Variables
        private EventArgsFighter args;
        public event EventHandler<EventArgsFighter> Block;
        public event EventHandler<EventArgsFighter> Wound;
        public event EventHandler<EventArgsFighter> Death;

        private BodyParts _blocked;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                args.Name = value;
            }
        }

        private int _hp;
        public int HealthPoints
        {
            get { return _hp; }
            private set
            {
                _hp = value;
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
            args.HP = HealthPoints;
            HealthPoints = _hp;
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
