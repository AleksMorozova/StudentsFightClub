using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Combats
{
    public partial class Combats : Form
    {
        Controller currentgame; 

        public Combats()
        {
            InitializeComponent();
            ConnectNewGame();
        }

        private void Combats_Load(object sender, EventArgs e)
        {
            
        }

        void Lock()
        {
            HeadButton.Enabled = false;
            BodyButton.Enabled = false;
            LegsButton.Enabled = false;
        }
        void Unlock()
        {
            HeadButton.Enabled = true;
            BodyButton.Enabled = true;
            LegsButton.Enabled = true;
        }
        void UpdateView()
        {
            statusLabel.Text = "Раунд " + currentgame.Round + "\n" + currentgame.status;
            firstPlayerLabel.Text = currentgame.human.HP.ToString();
            secondPlayerLabel.Text = currentgame.comp.HP.ToString();

            firstPlayerBar.Value = Convert.ToInt32(((Convert.ToDouble(currentgame.human.HP) / Convert.ToDouble(currentgame.human.MaxHP)) * 100));
            secondPlayerBar.Value = Convert.ToInt32(((Convert.ToDouble(currentgame.comp.HP) / Convert.ToDouble(currentgame.comp.MaxHP)) * 100));
        }
        private void HeadButton_Click(object sender, EventArgs e)
        {
            currentgame.Tick(BodyPart.Head);
            UpdateView();
        }

        private void BodyButton_Click(object sender, EventArgs e)
        {
            currentgame.Tick(BodyPart.Body);
            UpdateView();
        }

        private void LegsButton_Click(object sender, EventArgs e)
        {
            currentgame.Tick(BodyPart.Legs);
            UpdateView();
        }

        void ConnectNewGame()
        {
            Player human = new Player("You", 110, 10);
            Player comp = new Player("Easy", 80, 12);

            currentgame = new Controller(human,comp);

            currentgame.GameEnded += Lock;
            currentgame.Logged += LogToBox;
            UpdateView();
            logBox.Items.Clear();
            Unlock();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectNewGame();
        }

        void LogToBox(string str)
        {
            logBox.Items.Add(str);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
