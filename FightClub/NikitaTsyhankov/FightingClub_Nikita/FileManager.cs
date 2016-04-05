using System;
using System.IO;
using GameProcess;
using System.Collections.Generic;

namespace FightingClub_Nikita
{
    interface IManager
    {
        void SaveLog(String _log);
        void SaveGame(Logic _process);
        Logic LoadGame();
    }
    public class FileManager : IManager
    {
        public void SaveLog(String _log)
        {
            using (StreamWriter writer = new StreamWriter(new FileStream("log.txt", FileMode.Append)))
            {
                writer.Write(_log);
            }
        }

        public void SaveGame(Logic _process)
        {

        }
        public Logic LoadGame()
        {
            return null;
        }
    }
}