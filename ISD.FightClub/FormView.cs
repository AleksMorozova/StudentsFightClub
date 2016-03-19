using System;
using System.Drawing;
using System.Windows.Forms;

namespace ISD.FightClub
{
    public partial class FormView : Form
    {
        Presenter presenter;
        public FormView()
        {
            InitializeComponent();
            log.Text = "";
            
            presenter = new Presenter(Presenter.CreateFighterNoobSaibot(), Presenter.CreateFighterScorpion());
            SetFighterGUI(pictureBoxLeftFighter, labelLeftFighter, labelHPLeftFighter, progressBarLeftFighter, GuiPosition.Left);
            SetFighterGUI(pictureBoxRightFighter, labelRightFighter, labelHPRightFighter, progressBarRightFighter, GuiPosition.Right);

            presenter.Logging += Presenter_Logging;
            presenter.AddToLog("Битва началась " + DateTime.Now + ".");

            presenter.Battle.RoundChanged += Battle_RoundChanged;
            presenter.Battle.RoundHalfChanged += Battle_RoundHalfChanged;

            presenter.Battle.Fighter1.Wound += Fighter1_Wound;
            presenter.Battle.Fighter2.Wound += Fighter2_Wound;

        }
        public void SetFighterGUI(PictureBox pb, Label lbName, Label lbHP, ProgressBar hpBar, GuiPosition pos)
        {
            if (pos == GuiPosition.Left)
            {
                lbName.Text = presenter.Battle.Fighter1.Name;
                lbHP.Text = presenter.Battle.Fighter1.HP.ToString() + "/" + presenter.Battle.Fighter1.MaxHP.ToString();
                hpBar.Maximum = presenter.Battle.Fighter1.MaxHP;
                hpBar.Value = presenter.Battle.Fighter1.HP;
                try
                {
                    pb.Image = Image.FromFile(presenter.Battle.Fighter1.ImagePath);
                }
                catch
                {
                    pb.Image = pb.ErrorImage;
                }
            }
            else
            {
                lbName.Text = presenter.Battle.Fighter2.Name;
                lbHP.Text = presenter.Battle.Fighter2.HP.ToString() + "/" + presenter.Battle.Fighter2.MaxHP.ToString();
                hpBar.Maximum = presenter.Battle.Fighter2.MaxHP;
                hpBar.Value = presenter.Battle.Fighter2.HP;
                try
                {
                    pb.Image = Image.FromFile(presenter.Battle.Fighter2.ImagePath);
                    pb.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
                catch
                {
                    pb.Image = pb.ErrorImage;
                }
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
    }
}
