using System;

namespace GameProcess.BL.Fighters
{
    public interface IFighter
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
}
