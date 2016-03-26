using System;
using System.Drawing;
using System.Windows.Forms;
using FightClubLogic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ISD.FightClub
{
    public partial class FormView : Form, IView
    {
        Presenter presenter;
        public FormView()
        {
            InitializeComponent();
            log.Text = "";

            presenter = new Presenter(this);
            StartNewGame();
        }

        private void StartNewGame()
        {
            presenter.InitializeNewBattle(Presenter.CreateFighterScorpion(), Presenter.CreateFighterNoobSaibot());
            this.log.Items.Clear();
        }
        public void InitializeGUI(Fighter fighter1, Fighter fighter2)
        {
            SetFighterGUI(fighter1, pictureBoxLeftFighter, labelLeftFighter, labelHPLeftFighter, progressBarLeftFighter, GuiPosition.Left);
            SetFighterGUI(fighter2, pictureBoxRightFighter, labelRightFighter, labelHPRightFighter, progressBarRightFighter, GuiPosition.Right);
            Subscribe();
            this.Battle_RoundChanged(presenter.Battle);
            this.Battle_RoundHalfChanged(presenter.Battle);
        }
        public void EndGame(Fighter winner)
        {
            MessageBox.Show("Победил " + winner.Name + "!");
            Application.Exit();
        }
        private void Subscribe()
        {
            presenter.Logging += Presenter_Logging;

            presenter.Battle.RoundChanged += Battle_RoundChanged;
            presenter.Battle.RoundHalfChanged += Battle_RoundHalfChanged;

            presenter.Battle.Fighter1.Wound += Fighter1_Wound;
            presenter.Battle.Fighter2.Wound += Fighter2_Wound;
        }

        private void SetFighterGUI(FightClubLogic.Fighter fighter, PictureBox pb, Label lbName, Label lbHP, ProgressBar hpBar, GuiPosition pos)
        {
            lbName.Text = fighter.Name;
            lbHP.Text = fighter.HP.ToString() + "/" + fighter.MaxHP.ToString();
            hpBar.Maximum = fighter.MaxHP;
            hpBar.Value = fighter.HP;
            try
            {
                pb.Image = Image.FromFile(fighter.ImagePath);
                if (pos == GuiPosition.Right)
                {
                    pb.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
            }
            catch
            {
                pb.Image = pb.ErrorImage;
            }
        }

        private void Fighter2_Wound(FightClubLogic.Fighter sender, int damage)
        {
            progressBarRightFighter.Value = sender.HP;
            labelHPRightFighter.Text = sender.HP + "/" + sender.MaxHP;
        }
        private void Fighter1_Wound(FightClubLogic.Fighter sender, int damage)
        {
            progressBarLeftFighter.Value = sender.HP;
            labelHPLeftFighter.Text = sender.HP + "/" + sender.MaxHP;
        }
        private void Battle_RoundChanged(FightClubLogic.Battle sender)
        {
            labelRound.Text = "Раунд " + sender.Round;
        }
        private void Presenter_Logging(string data)
        {
            log.Items.Add(data + "\n");
        }
        private void Battle_RoundHalfChanged(FightClubLogic.Battle sender)
        {
            if (sender.RoundHalf == RoundHalf.Attack)
            {
                labelAction.Text = "Куда будем бить?";
            }
            else
            {
                labelAction.Text = "Что будем защищать?";
            }
        }
        private void buttonHead_Click(object sender, EventArgs e)
        {
            presenter.Action(BodyPart.Head);
        }
        private void buttonBody_Click(object sender, EventArgs e)
        {
            presenter.Action(BodyPart.Body);
        }
        private void buttonLegs_Click(object sender, EventArgs e)
        {
            presenter.Action(BodyPart.Legs);
        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.Logging -= Presenter_Logging;
            StartNewGame();
        }
        private void сохранитьБойВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialogSaveBattle.ShowDialog();
            if (saveFileDialogSaveBattle.FileName != "")
            {
                using (FileStream fs = (System.IO.FileStream)saveFileDialogSaveBattle.OpenFile())
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, presenter);
                }
            }
        }
        private void загрузитьБойИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogOpenBattle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fs = (System.IO.FileStream)openFileDialogOpenBattle.OpenFile())
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    try
                    {
                        Presenter loadedPresenter = (Presenter)bf.Deserialize(fs);
                        this.log.Items.Clear();
                        presenter.Logging -= Presenter_Logging;
                        presenter.InitializeLoadedBattle(loadedPresenter);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно загрузить бой.");
                    }
                }
            }
        }
    }
}
