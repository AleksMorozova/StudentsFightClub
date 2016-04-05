using GameProcess.BL;
using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace FightingClub_Nikita
{
    [Serializable]
    public class FileManager : IManager
    {
        public void SaveLog(List<string> _log)
        {
            try
            {
                StreamWriter w = File.AppendText("log.txt");
                w.WriteLine();
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                        DateTime.Now.ToLongDateString());
                foreach (string item in _log)
                {
                    w.WriteLine(item);
                }
                w.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SaveGame(IFighting _process)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Battle|*btl*";
            sfd.FileName = "SavedGame.btl";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream FileStream = File.Create(sfd.FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(FileStream, _process);
                FileStream.Close();
            }
        }
        public IFighting LoadGame()
        {
            IFighting _process = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Battle|*btl*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream FileStream = File.OpenRead(ofd.FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                try
                {
                    _process = (IFighting)deserializer.Deserialize(FileStream);
                    MessageBox.Show("Game loaded.");
                }
                catch
                {
                    MessageBox.Show("Can't load game. Try again.");
                }
                FileStream.Close();
            }
            return _process;
        }
    }
}