using GameProcess.BL;
using System.Collections.Generic;

namespace FightingClub_Nikita
{
    public interface IManager
    {
        void SaveLog(List<string> _log);
        void SaveGame(IFighting _process);
        IFighting LoadGame();
    }
}
