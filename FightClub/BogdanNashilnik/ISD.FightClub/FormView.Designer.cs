namespace ISD.FightClub
{
    partial class FormView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarLeftFighter = new System.Windows.Forms.ProgressBar();
            this.pictureBoxLeftFighter = new System.Windows.Forms.PictureBox();
            this.panelLeftFighter = new System.Windows.Forms.Panel();
            this.labelHPLeftFighter = new System.Windows.Forms.Label();
            this.labelLeftFighter = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHPRightFighter = new System.Windows.Forms.Label();
            this.labelRightFighter = new System.Windows.Forms.Label();
            this.progressBarRightFighter = new System.Windows.Forms.ProgressBar();
            this.pictureBoxRightFighter = new System.Windows.Forms.PictureBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.log = new System.Windows.Forms.ListBox();
            this.labelAction = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.buttonLegs = new System.Windows.Forms.Button();
            this.buttonBody = new System.Windows.Forms.Button();
            this.buttonHead = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьБойИзФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьБойВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogSaveBattle = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogOpenBattle = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftFighter)).BeginInit();
            this.panelLeftFighter.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightFighter)).BeginInit();
            this.panelControl.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarLeftFighter
            // 
            this.progressBarLeftFighter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.progressBarLeftFighter.Location = new System.Drawing.Point(225, 4);
            this.progressBarLeftFighter.Name = "progressBarLeftFighter";
            this.progressBarLeftFighter.Size = new System.Drawing.Size(107, 20);
            this.progressBarLeftFighter.TabIndex = 2;
            this.progressBarLeftFighter.Value = 100;
            // 
            // pictureBoxLeftFighter
            // 
            this.pictureBoxLeftFighter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLeftFighter.Location = new System.Drawing.Point(6, 87);
            this.pictureBoxLeftFighter.Name = "pictureBoxLeftFighter";
            this.pictureBoxLeftFighter.Size = new System.Drawing.Size(326, 459);
            this.pictureBoxLeftFighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLeftFighter.TabIndex = 0;
            this.pictureBoxLeftFighter.TabStop = false;
            // 
            // panelLeftFighter
            // 
            this.panelLeftFighter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeftFighter.Controls.Add(this.labelHPLeftFighter);
            this.panelLeftFighter.Controls.Add(this.labelLeftFighter);
            this.panelLeftFighter.Controls.Add(this.progressBarLeftFighter);
            this.panelLeftFighter.Controls.Add(this.pictureBoxLeftFighter);
            this.panelLeftFighter.Location = new System.Drawing.Point(12, 27);
            this.panelLeftFighter.Name = "panelLeftFighter";
            this.panelLeftFighter.Size = new System.Drawing.Size(335, 549);
            this.panelLeftFighter.TabIndex = 3;
            // 
            // labelHPLeftFighter
            // 
            this.labelHPLeftFighter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelHPLeftFighter.AutoSize = true;
            this.labelHPLeftFighter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHPLeftFighter.Location = new System.Drawing.Point(152, 4);
            this.labelHPLeftFighter.Name = "labelHPLeftFighter";
            this.labelHPLeftFighter.Size = new System.Drawing.Size(67, 20);
            this.labelHPLeftFighter.TabIndex = 3;
            this.labelHPLeftFighter.Text = "100/100";
            // 
            // labelLeftFighter
            // 
            this.labelLeftFighter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLeftFighter.AutoSize = true;
            this.labelLeftFighter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeftFighter.Location = new System.Drawing.Point(3, 4);
            this.labelLeftFighter.Name = "labelLeftFighter";
            this.labelLeftFighter.Size = new System.Drawing.Size(101, 20);
            this.labelLeftFighter.TabIndex = 1;
            this.labelLeftFighter.Text = "FighterName";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelHPRightFighter);
            this.panel2.Controls.Add(this.labelRightFighter);
            this.panel2.Controls.Add(this.progressBarRightFighter);
            this.panel2.Controls.Add(this.pictureBoxRightFighter);
            this.panel2.Location = new System.Drawing.Point(689, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 552);
            this.panel2.TabIndex = 4;
            // 
            // labelHPRightFighter
            // 
            this.labelHPRightFighter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelHPRightFighter.AutoSize = true;
            this.labelHPRightFighter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHPRightFighter.Location = new System.Drawing.Point(152, 6);
            this.labelHPRightFighter.Name = "labelHPRightFighter";
            this.labelHPRightFighter.Size = new System.Drawing.Size(67, 20);
            this.labelHPRightFighter.TabIndex = 6;
            this.labelHPRightFighter.Text = "100/100";
            // 
            // labelRightFighter
            // 
            this.labelRightFighter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRightFighter.AutoSize = true;
            this.labelRightFighter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRightFighter.Location = new System.Drawing.Point(3, 6);
            this.labelRightFighter.Name = "labelRightFighter";
            this.labelRightFighter.Size = new System.Drawing.Size(101, 20);
            this.labelRightFighter.TabIndex = 1;
            this.labelRightFighter.Text = "FighterName";
            // 
            // progressBarRightFighter
            // 
            this.progressBarRightFighter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.progressBarRightFighter.Location = new System.Drawing.Point(225, 6);
            this.progressBarRightFighter.Name = "progressBarRightFighter";
            this.progressBarRightFighter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBarRightFighter.Size = new System.Drawing.Size(107, 20);
            this.progressBarRightFighter.TabIndex = 2;
            this.progressBarRightFighter.Value = 100;
            // 
            // pictureBoxRightFighter
            // 
            this.pictureBoxRightFighter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRightFighter.Location = new System.Drawing.Point(6, 87);
            this.pictureBoxRightFighter.Name = "pictureBoxRightFighter";
            this.pictureBoxRightFighter.Size = new System.Drawing.Size(326, 462);
            this.pictureBoxRightFighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRightFighter.TabIndex = 0;
            this.pictureBoxRightFighter.TabStop = false;
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.log);
            this.panelControl.Controls.Add(this.labelAction);
            this.panelControl.Controls.Add(this.labelRound);
            this.panelControl.Controls.Add(this.buttonLegs);
            this.panelControl.Controls.Add(this.buttonBody);
            this.panelControl.Controls.Add(this.buttonHead);
            this.panelControl.Location = new System.Drawing.Point(353, 24);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(330, 552);
            this.panelControl.TabIndex = 5;
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.log.FormattingEnabled = true;
            this.log.Location = new System.Drawing.Point(7, 343);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(320, 212);
            this.log.TabIndex = 6;
            // 
            // labelAction
            // 
            this.labelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAction.AutoSize = true;
            this.labelAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAction.Location = new System.Drawing.Point(3, 58);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(146, 20);
            this.labelAction.TabIndex = 4;
            this.labelAction.Text = "Куда будем бить?";
            // 
            // labelRound
            // 
            this.labelRound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRound.AutoSize = true;
            this.labelRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRound.Location = new System.Drawing.Point(3, 6);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(68, 20);
            this.labelRound.TabIndex = 3;
            this.labelRound.Text = "Раунд 1";
            // 
            // buttonLegs
            // 
            this.buttonLegs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLegs.Location = new System.Drawing.Point(3, 251);
            this.buttonLegs.Name = "buttonLegs";
            this.buttonLegs.Size = new System.Drawing.Size(324, 79);
            this.buttonLegs.TabIndex = 2;
            this.buttonLegs.Text = "Ноги";
            this.buttonLegs.UseVisualStyleBackColor = true;
            this.buttonLegs.Click += new System.EventHandler(this.buttonLegs_Click);
            // 
            // buttonBody
            // 
            this.buttonBody.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBody.Location = new System.Drawing.Point(3, 166);
            this.buttonBody.Name = "buttonBody";
            this.buttonBody.Size = new System.Drawing.Size(324, 79);
            this.buttonBody.TabIndex = 1;
            this.buttonBody.Text = "Тело";
            this.buttonBody.UseVisualStyleBackColor = true;
            this.buttonBody.Click += new System.EventHandler(this.buttonBody_Click);
            // 
            // buttonHead
            // 
            this.buttonHead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHead.Location = new System.Drawing.Point(3, 81);
            this.buttonHead.Name = "buttonHead";
            this.buttonHead.Size = new System.Drawing.Size(324, 79);
            this.buttonHead.TabIndex = 0;
            this.buttonHead.Text = "Голова";
            this.buttonHead.UseVisualStyleBackColor = true;
            this.buttonHead.Click += new System.EventHandler(this.buttonHead_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.загрузитьБойИзФайлаToolStripMenuItem,
            this.сохранитьБойВФайлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // загрузитьБойИзФайлаToolStripMenuItem
            // 
            this.загрузитьБойИзФайлаToolStripMenuItem.Name = "загрузитьБойИзФайлаToolStripMenuItem";
            this.загрузитьБойИзФайлаToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.загрузитьБойИзФайлаToolStripMenuItem.Text = "Загрузить бой из файла";
            this.загрузитьБойИзФайлаToolStripMenuItem.Click += new System.EventHandler(this.загрузитьБойИзФайлаToolStripMenuItem_Click);
            // 
            // сохранитьБойВФайлToolStripMenuItem
            // 
            this.сохранитьБойВФайлToolStripMenuItem.Name = "сохранитьБойВФайлToolStripMenuItem";
            this.сохранитьБойВФайлToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.сохранитьБойВФайлToolStripMenuItem.Text = "Сохранить бой в файл";
            this.сохранитьБойВФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьБойВФайлToolStripMenuItem_Click);
            // 
            // saveFileDialogSaveBattle
            // 
            this.saveFileDialogSaveBattle.FileName = "battle.btl";
            this.saveFileDialogSaveBattle.Filter = "Битва|*btl*";
            // 
            // openFileDialogOpenBattle
            // 
            this.openFileDialogOpenBattle.Filter = "Битва|*btl*";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 588);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLeftFighter);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1052, 600);
            this.Name = "FormView";
            this.Text = "Бойцовский клуб";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftFighter)).EndInit();
            this.panelLeftFighter.ResumeLayout(false);
            this.panelLeftFighter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightFighter)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBarLeftFighter;
        private System.Windows.Forms.PictureBox pictureBoxLeftFighter;
        private System.Windows.Forms.Panel panelLeftFighter;
        private System.Windows.Forms.Label labelLeftFighter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRightFighter;
        private System.Windows.Forms.ProgressBar progressBarRightFighter;
        private System.Windows.Forms.PictureBox pictureBoxRightFighter;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonHead;
        private System.Windows.Forms.Button buttonLegs;
        private System.Windows.Forms.Button buttonBody;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.Label labelHPLeftFighter;
        private System.Windows.Forms.Label labelHPRightFighter;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьБойИзФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьБойВФайлToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveBattle;
        private System.Windows.Forms.OpenFileDialog openFileDialogOpenBattle;
    }
}

