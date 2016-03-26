using GameProcess;
using GameProcess.Fighters;
using System;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    public partial class MainForm : Form
    {
        public event EventHandler<EventArgsBodyParts> ButHeadClick;
        public event EventHandler<EventArgsBodyParts> ButBodyClick;
        public event EventHandler<EventArgsBodyParts> ButLegClick;

        private StartForm start = new StartForm();
        private EventArgsBodyParts argsPart;

        public MainForm()
        {
            InitializeComponent();
            Application.Run(start);
            NamePlayer1 = start.StartName;

            argsPart = new EventArgsBodyParts();
        }

        public void BlockGame(string _winner)
        {
            lblFinish.Visible = true;
            lblFinish.Text = _winner + " is winner!";
            butHead.Enabled = false;
            butBody.Enabled = false;
            butLeg.Enabled = false;
            //    Вынести в отдельный класс для вывода в файл
            /* File.WriteAllText(System.Environment.GetFolderPath
                  (System.Environment.SpecialFolder.Personal) 
                  + @"\BattleLog.txt",
                  textBoxLog.Text);
              textBoxLog.Text += "Log saved. To open log file press 'File => Open log file'.";
              */
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void openLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //          Вынести в отдельный класс вывода в файл
            /*if (File.Exists(System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal)
                + @"\BattleLog.txt"))
            {
                File.OpenText(System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal) + @"\BattleLog.txt");
            }
            else
                MessageBox.Show("File is not exist.", "File is not created yet.", MessageBoxButtons.OK);
                */
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
        public string NamePlayer2
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
                lblTitle.Text = (value) ? "Atack!" : "Block!";
            }
        }
        public int Rounds
        {
            set
            {
                lblRounds.Text = value.ToString();
            }
        }
        public string AddLog
        {
            set
            {

                textBoxLog.AppendText(value + "\n");
            }
        }
        #endregion
    }
}

