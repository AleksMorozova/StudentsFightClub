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
        Controller p; 

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
            label1.Text = "Раунд " + p.Round + "\n" + p.status;
            label2.Text = p.human.HP.ToString();
            label3.Text = p.comp.HP.ToString();

            firstPlayerBar.Value = Convert.ToInt32(((Convert.ToDouble(p.human.HP) / Convert.ToDouble(p.human.MaxHP)) * 100));
            secondPlayerBar.Value = Convert.ToInt32(((Convert.ToDouble(p.comp.HP) / Convert.ToDouble(p.comp.MaxHP)) * 100));
        }
        private void HeadButton_Click(object sender, EventArgs e)
        {
            p.Tick(BodyPart.Head);
            UpdateView();
        }

        private void BodyButton_Click(object sender, EventArgs e)
        {
            p.Tick(BodyPart.Body);
            UpdateView();
        }

        private void LegsButton_Click(object sender, EventArgs e)
        {
            p.Tick(BodyPart.Legs);
            UpdateView();
        }

        void ConnectNewGame()
        {
            
            Player human = new Player("You", 110, 10);
            CompPlayer comp = new CompPlayer("Easy", 80, 12);

            p = new Controller(human,comp);

            

            p.GameEnded += Lock;
            p.Logged += LogToBox;
            UpdateView();
            listBox1.Items.Clear();
            Unlock();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.GameEnded -= Lock;
            p.Logged -= LogToBox;
            ConnectNewGame();
        }

        void LogToBox(string str)
        {
            listBox1.Items.Add(str);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
