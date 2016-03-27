using System;
using System.IO;
using GameProcess;
using System.Collections.Generic;
using System.Windows.Forms;

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
            try
            {
                using (StreamWriter w = File.AppendText("log.txt"))
                {
                    w.WriteLine("\n{0} {1}", DateTime.Now.ToLongTimeString(),
                        DateTime.Now.ToLongDateString());
                    w.WriteLine(_log);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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