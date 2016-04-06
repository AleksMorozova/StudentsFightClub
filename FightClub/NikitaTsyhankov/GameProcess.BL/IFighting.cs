using GameProcess.BL.Fighters;
using System.Collections.Generic;

namespace GameProcess.BL
{
    public interface IFighting
    {
        IFighter Player1
        {
            get;
        }
        ICPUFighter Player2
        {
            get;
        }
        int Round
        {
            get;
        }
        List<string> Log
        {
            get;
        }
        void MakeStep(BodyParts _part);
        void AddToLog(string item);
    }
}
