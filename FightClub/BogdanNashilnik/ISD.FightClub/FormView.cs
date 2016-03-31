using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace ISD.FightClub
{
    public partial class FormView : Form
    {
        private Presenter presenter;
        private BindingSource bindingBattle = new BindingSource();
        public FormView()
        {
            InitializeComponent();
            log.Text = "";

            presenter = new Presenter(this);
            presenter.InitializeNewBattle(Presenter.CreateFighterScorpion(), Presenter.CreateFighterNoobSaibot(), true);
        }


        public void InitializeGUI()
        {
            bindingBattle.DataSource = presenter;

            labelLeftFighter.DataBindings.Add("Text", bindingBattle, "Battle.Fighter1.Name");
            labelHPLeftFighter.DataBindings.Add("Text", bindingBattle, "Battle.Fighter1.HPFormatted");
            progressBarLeftFighter.DataBindings.Add("Maximum", bindingBattle, "Battle.Fighter1.MaxHP");
            progressBarLeftFighter.DataBindings.Add("Value", bindingBattle, "Battle.Fighter1.HP");
            TrySetImage(pictureBoxLeftFighter, presenter.Battle.Fighter1.ImagePath);

            labelRightFighter.DataBindings.Add("Text", bindingBattle, "Battle.Fighter2.Name");
            labelHPRightFighter.DataBindings.Add("Text", bindingBattle, "Battle.Fighter2.HPFormatted");
            progressBarRightFighter.DataBindings.Add("Maximum", bindingBattle, "Battle.Fighter2.MaxHP");
            progressBarRightFighter.DataBindings.Add("Value", bindingBattle, "Battle.Fighter2.HP");
            TrySetImage(pictureBoxRightFighter, presenter.Battle.Fighter2.ImagePath);
            pictureBoxRightFighter.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            labelRoundCount.DataBindings.Add("Text", bindingBattle, "Battle.Round");
            labelAction.DataBindings.Add("Text", bindingBattle, "WhatToDo");
            
            bindingBattle.CurrentItemChanged += BindingBattle_CurrentChanged;
        }
        private void TrySetImage(PictureBox pb, string imagePath)
        {
            try
            {
                pb.Image = Image.FromFile(imagePath);
            }
            catch
            {
                pb.Image = pb.ErrorImage;
            }
        }

        private void BindingBattle_CurrentChanged(object sender, EventArgs e)
        {
            List<string> logList = ((Presenter)((BindingSource)sender).Current).Log;

            log.Items.Clear();
            foreach (string logItem in logList)
            {
                log.Items.Add(logItem);
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
            presenter.InitializeNewBattle(Presenter.CreateFighterScorpion(), Presenter.CreateFighterNoobSaibot(), false);
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
