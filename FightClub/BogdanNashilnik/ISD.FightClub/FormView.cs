using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace ISD.FightClub
{
    public partial class FormView : Form, IView
    {
        private IPresenter presenter;

        public IPresenter Presenter
        {
            get
            {
                return this.presenter;
            }

            set
            {
                this.presenter = value;
            }
        }

        public FormView()
        {
            InitializeComponent();
            listBoxLog.Text = "";
        }

        public void SetBindings(BindingSource binding)
        {
            labelLeftFighter.DataBindings.Add("Text", binding, "Battle.Fighter1.Name");
            labelHPLeftFighter.DataBindings.Add("Text", binding, "Battle.Fighter1.HPFormatted");
            progressBarLeftFighter.DataBindings.Add("Maximum", binding, "Battle.Fighter1.MaxHP");
            progressBarLeftFighter.DataBindings.Add("Value", binding, "Battle.Fighter1.HP");
            TrySetImage(pictureBoxLeftFighter, presenter.Battle.Fighter1.ImagePath);

            labelRightFighter.DataBindings.Add("Text", binding, "Battle.Fighter2.Name");
            labelHPRightFighter.DataBindings.Add("Text", binding, "Battle.Fighter2.HPFormatted");
            progressBarRightFighter.DataBindings.Add("Maximum", binding, "Battle.Fighter2.MaxHP");
            progressBarRightFighter.DataBindings.Add("Value", binding, "Battle.Fighter2.HP");
            TrySetImage(pictureBoxRightFighter, presenter.Battle.Fighter2.ImagePath);
            pictureBoxRightFighter.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            labelRoundCount.DataBindings.Add("Text", binding, "Battle.Round");
            labelAction.DataBindings.Add("Text", binding, "WhatToDo");
            
            binding.CurrentItemChanged += BindingBattle_CurrentChanged;
        }
        public void EndGame(string winnerName)
        {
            MessageBox.Show("Победил " + winnerName + "!");
            Application.Exit();
        }
        private void SavePresenter()
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
        private void LoadPresenter()
        {
            if (openFileDialogOpenBattle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (FileStream fs = (System.IO.FileStream)openFileDialogOpenBattle.OpenFile())
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    try
                    {
                        IPresenter loadedPresenter = (IPresenter)bf.Deserialize(fs);
                        presenter.LoadBattle(loadedPresenter);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно загрузить бой.");
                    }
                }
            }
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
            List<string> logList = ((IPresenter)((BindingSource)sender).Current).Log.ToList();

            listBoxLog.Items.Clear();
            foreach (string logItem in logList)
            {
                listBoxLog.Items.Add(logItem);
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
            Creator fighterCreator = new MortalCombatCreator();
            presenter.ResetBattle(fighterCreator.CreateFighter(), fighterCreator.CreateCPUFighter());
        }
        private void сохранитьБойВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePresenter();
        }
        private void загрузитьБойИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPresenter();
        }

    }
}
