using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
