using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatClub
{
    public partial class Form1 : Form
    {      
        Game game;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // использовать сендер
            buttonHead.Enabled = true;
            buttonBody.Enabled = true;
            buttonLegs.Enabled = true;

            game = new Game("Валерий", "Компьютер",
                listBox1,
                labelPlayer, labelCompPlayer,
                labelPlayerHP, labelCompPlayerHP,
                buttonHead, buttonBody, buttonLegs,
                progressBarPlayer, progressBarComputer);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            buttonHead.Enabled = false;
            buttonBody.Enabled = false;
            buttonLegs.Enabled = false;           
        }
        
        private void buttonHead_Click(object sender, EventArgs e)
        {                      
            game.LogicGame(BodyParts.head);
        }

        private void buttonBody_Click(object sender, EventArgs e)
        {
            game.LogicGame(BodyParts.body);
        }

        private void buttonLegs_Click(object sender, EventArgs e)
        {
            game.LogicGame(BodyParts.legs);
        }        
    }
}
