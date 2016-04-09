using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISD_Course_Fight_club
{
    public partial class MainForm : Form
    {
        const string SaveFileName = @"SavedFight.bin";
        private GameProcess gameProcess;
        public MainForm()
        {
            InitializeComponent();
            gameProcess = new GameProcess();

            bindingSourceViewer.DataSource = gameProcess;
            bindingSourceViewer.CurrentItemChanged += UpdateLog;
            progressBarCompPlayerHP.DataBindings.Add("Value", bindingSourceViewer, "ComputerHP");
            progressBarPlayerHP.DataBindings.Add("Value", bindingSourceViewer, "UserHP");
            actionLabel.DataBindings.Add("Text", bindingSourceViewer, "Status");

            gameProcess.FightOver += GameOver;
        }

        private void UpdateLog(object sender, EventArgs e)
        {
            logShow.Clear();
            logShow.Lines = gameProcess.Log.ToArray();
        }

        private void GameOver(string name, int health)
        {
            LockButtons();
            string message = name + " is dead.\nWant save log?";
            if (MessageBox.Show(message, "GameOver!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                SaveLogToFile();
            }
        }

        private void SaveLogToFile()
        {
            string logFileName = DateTime.Now.ToString();
            logFileName = logFileName.Replace(' ', '_');
            logFileName = logFileName.Replace(':', '_');
            logFileName = logFileName.Replace('.', '_');
            logFileName += ".txt";
            File.WriteAllLines(logFileName, gameProcess.Log.ToArray());
            MessageBox.Show("Your file is saved as '" + logFileName + "'", "Done.", MessageBoxButtons.OK);
        }

        private void LockButtons()
        {
            buttonBody.Enabled = false;
            buttonHead.Enabled = false;
            buttonLegs.Enabled = false;
        }
        private void UnLockButtons()
        {
            buttonBody.Enabled = true;
            buttonHead.Enabled = true;
            buttonLegs.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonHead_Click(object sender, EventArgs e)
        {
            gameProcess.Round(BodyPart.Head);
        }

        private void buttonBody_Click(object sender, EventArgs e)
        {
            gameProcess.Round(BodyPart.Body);
        }

        private void buttonLegs_Click(object sender, EventArgs e)
        {
            gameProcess.Round(BodyPart.Legs);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameProcess = new GameProcess();
            bindingSourceViewer.DataSource = gameProcess;
            gameProcess.FightOver += GameOver;
            UnLockButtons();
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Stream SaveFileStream = File.Create(SaveFileName))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, gameProcess);
            }
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(SaveFileName))
            {
                using (Stream SaveFileStream = File.OpenRead(SaveFileName))
                {
                    BinaryFormatter deserializer = new BinaryFormatter();
                    gameProcess = (GameProcess)deserializer.Deserialize(SaveFileStream);
                    bindingSourceViewer.DataSource = gameProcess;
                }
                gameProcess.FightOver += GameOver;
                UnLockButtons();
            }
            
        }
    }
}
