namespace CombatClub
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHead = new System.Windows.Forms.Button();
            this.buttonBody = new System.Windows.Forms.Button();
            this.buttonLegs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarPlayer = new System.Windows.Forms.ProgressBar();
            this.progressBarComputer = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelCompPlayer = new System.Windows.Forms.Label();
            this.labelPlayerHP = new System.Windows.Forms.Label();
            this.labelCompPlayerHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHead
            // 
            this.buttonHead.Location = new System.Drawing.Point(278, 91);
            this.buttonHead.Name = "buttonHead";
            this.buttonHead.Size = new System.Drawing.Size(150, 32);
            this.buttonHead.TabIndex = 0;
            this.buttonHead.UseVisualStyleBackColor = true;
            this.buttonHead.Click += new System.EventHandler(this.buttonHead_Click);
            // 
            // buttonBody
            // 
            this.buttonBody.Location = new System.Drawing.Point(278, 147);
            this.buttonBody.Name = "buttonBody";
            this.buttonBody.Size = new System.Drawing.Size(150, 32);
            this.buttonBody.TabIndex = 1;
            this.buttonBody.UseVisualStyleBackColor = true;
            this.buttonBody.Click += new System.EventHandler(this.buttonBody_Click);
            // 
            // buttonLegs
            // 
            this.buttonLegs.Location = new System.Drawing.Point(278, 205);
            this.buttonLegs.Name = "buttonLegs";
            this.buttonLegs.Size = new System.Drawing.Size(150, 32);
            this.buttonLegs.TabIndex = 2;
            this.buttonLegs.UseVisualStyleBackColor = true;
            this.buttonLegs.Click += new System.EventHandler(this.buttonLegs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 157);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(482, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 157);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // progressBarPlayer
            // 
            this.progressBarPlayer.Location = new System.Drawing.Point(26, 53);
            this.progressBarPlayer.Maximum = 500;
            this.progressBarPlayer.Name = "progressBarPlayer";
            this.progressBarPlayer.Size = new System.Drawing.Size(187, 21);
            this.progressBarPlayer.Step = 1;
            this.progressBarPlayer.TabIndex = 7;
            // 
            // progressBarComputer
            // 
            this.progressBarComputer.Location = new System.Drawing.Point(482, 53);
            this.progressBarComputer.Name = "progressBarComputer";
            this.progressBarComputer.Size = new System.Drawing.Size(178, 21);
            this.progressBarComputer.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 249);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(634, 160);
            this.listBox1.TabIndex = 9;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(23, 37);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(0, 13);
            this.labelPlayer.TabIndex = 10;
            // 
            // labelCompPlayer
            // 
            this.labelCompPlayer.AutoSize = true;
            this.labelCompPlayer.Location = new System.Drawing.Point(625, 37);
            this.labelCompPlayer.Name = "labelCompPlayer";
            this.labelCompPlayer.Size = new System.Drawing.Size(0, 13);
            this.labelCompPlayer.TabIndex = 11;
            // 
            // labelPlayerHP
            // 
            this.labelPlayerHP.AutoSize = true;
            this.labelPlayerHP.Location = new System.Drawing.Point(178, 37);
            this.labelPlayerHP.Name = "labelPlayerHP";
            this.labelPlayerHP.Size = new System.Drawing.Size(0, 13);
            this.labelPlayerHP.TabIndex = 12;
            // 
            // labelCompPlayerHP
            // 
            this.labelCompPlayerHP.AutoSize = true;
            this.labelCompPlayerHP.Location = new System.Drawing.Point(479, 37);
            this.labelCompPlayerHP.Name = "labelCompPlayerHP";
            this.labelCompPlayerHP.Size = new System.Drawing.Size(0, 13);
            this.labelCompPlayerHP.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 421);
            this.Controls.Add(this.labelCompPlayerHP);
            this.Controls.Add(this.labelPlayerHP);
            this.Controls.Add(this.labelCompPlayer);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBarComputer);
            this.Controls.Add(this.progressBarPlayer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLegs);
            this.Controls.Add(this.buttonBody);
            this.Controls.Add(this.buttonHead);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Combat club";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHead;
        private System.Windows.Forms.Button buttonBody;
        private System.Windows.Forms.Button buttonLegs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarPlayer;
        private System.Windows.Forms.ProgressBar progressBarComputer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelCompPlayer;
        private System.Windows.Forms.Label labelPlayerHP;
        private System.Windows.Forms.Label labelCompPlayerHP;
    }
}

