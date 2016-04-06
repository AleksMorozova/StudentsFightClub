using GameProcess;
using GameProcess.Fighters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    public interface IGameForm
    {
        string NamePlayer1
        {
            get;
            set;
        }
        string NameCPUPlayer
        {
            set;
        }
        bool Title
        {
            set;
        }
        int Rounds
        {
            set;
        }
        string Log
        {
            get;
            set;
        }
        void HPPlayers(int player1, int player2);
        event EventHandler<EventArgsBodyParts> ButHeadClick;
        event EventHandler<EventArgsBodyParts> ButBodyClick;
        event EventHandler<EventArgsBodyParts> ButLegClick;
        event EventHandler ButLoadGameClick;
        event EventHandler ButSaveGameClick;
    }

    public partial class MainForm : Form, IGameForm
    {
        public event EventHandler<EventArgsBodyParts> ButHeadClick;
        public event EventHandler<EventArgsBodyParts> ButBodyClick;
        public event EventHandler<EventArgsBodyParts> ButLegClick;
        public event EventHandler ButLoadGameClick;
        public event EventHandler ButSaveGameClick;

        private StartForm start = new StartForm();
        private EventArgsBodyParts argsPart;

        public MainForm()
        {
            InitializeComponent();
            argsPart = new EventArgsBodyParts();
            start.ShowDialog();
            NamePlayer1 = start.StartName;
        }

        public void BlockGame(string _winner)
        {
            lblFinish.Visible = true;
            lblFinish.Text = _winner + " is winner!";
            butHead.Enabled = false;
            butBody.Enabled = false;
            butLeg.Enabled = false;
            listBoxLog.Items.Add("*Log saved*. Log saved to the root directory");
        }
        #region Events
        private void butHead_Click(object sender, EventArgs e)
        {
            argsPart._part = BodyParts._head;
            if (ButHeadClick != null) ButHeadClick(this, argsPart);
        }

        private void butBody_Click(object sender, EventArgs e)
        {
            argsPart._part = BodyParts._body;
            if (ButBodyClick != null) ButBodyClick(this, argsPart);
        }

        private void butLeg_Click(object sender, EventArgs e)
        {
            argsPart._part = BodyParts._leg;
            if (ButLegClick != null) ButLegClick(this, argsPart);
        }
        private void openLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ButLoadGameClick != null) ButLoadGameClick(this, EventArgs.Empty);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        #endregion

        #region Properties
        public string NamePlayer1
        {
            get
            {
                return lblPlayer1.Text;
            }
            set
            {
                lblPlayer1.Text = value;
            }
        }
        public string NameCPUPlayer
        {
            set
            {
                lblPlayer2.Text = value;
            }
        }
        public void HPPlayers(int player1, int player2)
        {
            lblHPPlayer1.Text = player1.ToString();
            progressBarPlayer1.Value = player1;
            lblHPPlayer2.Text = player2.ToString();
            progressBarPlayer2.Value = player2;
        }
        public bool Title
        {
            set
            {
                lblTitle.Text = (value) ? "Block!" : "Atack!";
            }
        }
        public int Rounds
        {
            set
            {
                lblRounds.Text = value.ToString();
            }
        }
        public string Log
        {
            get { return listBoxLog.Text; }
            set
            {
                listBoxLog.Items.Add(value);
            }
        }
        #endregion
    }
}

