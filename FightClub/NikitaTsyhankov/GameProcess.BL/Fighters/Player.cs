using System;

namespace GameProcess.BL.Fighters
{
    [Serializable]
    public class Player: IFighter
    {
        #region Variables
        [field: NonSerialized]
        public event EventHandler<EventArgsFighter> Block;
        [field: NonSerialized]
        public event EventHandler<EventArgsFighter> Wound;
        [field: NonSerialized]
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
                if (_hp < 0)
                {
                    _hp = 0;
                    if (Death != null) Death(this,
                    new EventArgsFighter(HealthPoints, Name));
                }
            }
        }
        #endregion

        public Player(String _name, int _hp)
        {
            Name = _name;
            HealthPoints = _hp;
        }

        public void GetHit(BodyParts _hited, int _dmg)
        {
            if (_hited == _blocked)
            {
                if (Block != null) Block(this, 
                    new EventArgsFighter(HealthPoints, Name));
            }
            else
            {
                HealthPoints -= _dmg;
                if (Wound != null && 0 != HealthPoints) Wound(this,
                    new EventArgsFighter(HealthPoints, Name));
            }
        }

        public void SetBlock(BodyParts _blocked)
        {
            this._blocked = _blocked;
        }
    }
}
