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
    public partial class MainForm : Form, IMainForm
    {
        public event EventHandler HeadClick; 
        public event EventHandler BodyClick;
        public event EventHandler LegsClick;

        public MainForm()
        {
            InitializeComponent();
            buttonHead.Click += buttonHead_Click;
            buttonBody.Click += buttonBody_Click;
            buttonLegs.Click += buttonLegs_Click;
        }        

        public string LstBox
        {
            set { listBox1.Items.Add(value); }
        }

        public void buttonText(string text)
        {
            buttonHead.Text = text + " head";
            buttonBody.Text = text + " body";
            buttonLegs.Text = text + " legs";
        }

        public void NewValueViewComp(string name, int hp)
        {
            labelCompPlayer.Text = name;
            labelCompPlayerHP.Text = hp.ToString();
            progressBarComputer.Maximum = hp;
            progressBarComputer.Value = hp;
        }

        public void NewValueViewPlayer(string name, int hp)
        {
            labelPlayer.Text = name;
            labelPlayerHP.Text = hp.ToString();
            progressBarPlayer.Maximum = hp;
            progressBarPlayer.Value = hp;
        }

        public void lblSetHpPlayer(int hp)
        {
            labelPlayerHP.Text = hp.ToString();            
            progressBarPlayer.Value = hp;            
        }

        public void lblSetHpComp(int hp)
        {
            labelCompPlayerHP.Text = hp.ToString();
            progressBarComputer.Value = hp;
        }

        public void setName(string namePlayer, string nameComp )
        {
            labelPlayer.Text = namePlayer;
            labelCompPlayer.Text = nameComp;
        }                             
        
        private void buttonHead_Click(object sender, EventArgs e)
        {
             if (BodyClick != null)
                BodyClick(this, EventArgs.Empty);
        }

        void buttonLegs_Click(object sender, EventArgs e)
        {
            if (LegsClick != null)
                LegsClick(this, EventArgs.Empty);
        }

        void buttonBody_Click(object sender, EventArgs e)
        {
            if (BodyClick != null)
                BodyClick(this, EventArgs.Empty);
        }              
                                     
    }
}
