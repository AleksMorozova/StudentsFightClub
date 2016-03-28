using GameProcess.BL;
using System;
using System.IO;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
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

        public void SaveGame(IFighting _process)
        {

        }
        public IFighting LoadGame()
        {
            return null;
        }
    }
}