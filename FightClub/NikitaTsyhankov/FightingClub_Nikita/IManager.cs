using GameProcess.BL;
using System;

namespace FightingClub_Nikita
{
    public interface IManager
    {
        void SaveLog(String _log);
        void SaveGame(IFighting _process);
        IFighting LoadGame();
    }
}
