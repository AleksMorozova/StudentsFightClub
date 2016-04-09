namespace Combats
{
    partial class Combats
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.HeadButton = new System.Windows.Forms.Button();
            this.BodyButton = new System.Windows.Forms.Button();
            this.LegsButton = new System.Windows.Forms.Button();
            this.firstPlayerLabel = new System.Windows.Forms.Label();
            this.secondPlayerLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.secondPlayerBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.firstPlayerBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(255, 21);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(117, 29);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "label1";
            this.statusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // HeadButton
            // 
            this.HeadButton.Location = new System.Drawing.Point(258, 76);
            this.HeadButton.Name = "HeadButton";
            this.HeadButton.Size = new System.Drawing.Size(114, 32);
            this.HeadButton.TabIndex = 1;
            this.HeadButton.Text = "Head";
            this.HeadButton.UseVisualStyleBackColor = true;
            this.HeadButton.Click += new System.EventHandler(this.HeadButton_Click);
            // 
            // BodyButton
            // 
            this.BodyButton.Location = new System.Drawing.Point(258, 114);
            this.BodyButton.Name = "BodyButton";
            this.BodyButton.Size = new System.Drawing.Size(114, 32);
            this.BodyButton.TabIndex = 2;
            this.BodyButton.Text = "Body";
            this.BodyButton.UseVisualStyleBackColor = true;
            this.BodyButton.Click += new System.EventHandler(this.BodyButton_Click);
            // 
            // LegsButton
            // 
            this.LegsButton.Location = new System.Drawing.Point(258, 152);
            this.LegsButton.Name = "LegsButton";
            this.LegsButton.Size = new System.Drawing.Size(114, 32);
            this.LegsButton.TabIndex = 3;
            this.LegsButton.Text = "Legs";
            this.LegsButton.UseVisualStyleBackColor = true;
            this.LegsButton.Click += new System.EventHandler(this.LegsButton_Click);
            // 
            // firstPlayerLabel
            // 
            this.firstPlayerLabel.AutoSize = true;
            this.firstPlayerLabel.Location = new System.Drawing.Point(14, 16);
            this.firstPlayerLabel.Name = "firstPlayerLabel";
            this.firstPlayerLabel.Size = new System.Drawing.Size(35, 13);
            this.firstPlayerLabel.TabIndex = 4;
            this.firstPlayerLabel.Text = "label2";
            // 
            // secondPlayerLabel
            // 
            this.secondPlayerLabel.AutoSize = true;
            this.secondPlayerLabel.Location = new System.Drawing.Point(178, 16);
            this.secondPlayerLabel.Name = "secondPlayerLabel";
            this.secondPlayerLabel.Size = new System.Drawing.Size(35, 13);
            this.secondPlayerLabel.TabIndex = 5;
            this.secondPlayerLabel.Text = "label3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.HeadButton);
            this.splitContainer1.Panel1.Controls.Add(this.statusLabel);
            this.splitContainer1.Panel1.Controls.Add(this.BodyButton);
            this.splitContainer1.Panel1.Controls.Add(this.LegsButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.logBox);
            this.splitContainer1.Size = new System.Drawing.Size(626, 413);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.secondPlayerBar);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.secondPlayerLabel);
            this.panel2.Location = new System.Drawing.Point(388, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 234);
            this.panel2.TabIndex = 7;
            // 
            // secondPlayerBar
            // 
            this.secondPlayerBar.Location = new System.Drawing.Point(23, 16);
            this.secondPlayerBar.Name = "secondPlayerBar";
            this.secondPlayerBar.Size = new System.Drawing.Size(142, 23);
            this.secondPlayerBar.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Combats.Properties.Resources.player2;
            this.pictureBox2.Location = new System.Drawing.Point(23, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.firstPlayerBar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.firstPlayerLabel);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 234);
            this.panel1.TabIndex = 6;
            // 
            // firstPlayerBar
            // 
            this.firstPlayerBar.ForeColor = System.Drawing.Color.Maroon;
            this.firstPlayerBar.Location = new System.Drawing.Point(65, 16);
            this.firstPlayerBar.Name = "firstPlayerBar";
            this.firstPlayerBar.Size = new System.Drawing.Size(142, 23);
            this.firstPlayerBar.TabIndex = 0;
            this.firstPlayerBar.Value = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Combats.Properties.Resources.player1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(0, 0);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(626, 135);
            this.logBox.TabIndex = 0;
            // 
            // Combats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 437);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Combats";
            this.Text = "Combats";
            this.Load += new System.EventHandler(this.Combats_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button HeadButton;
        private System.Windows.Forms.Button BodyButton;
        private System.Windows.Forms.Button LegsButton;
        private System.Windows.Forms.Label firstPlayerLabel;
        private System.Windows.Forms.Label secondPlayerLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar secondPlayerBar;
        private System.Windows.Forms.ProgressBar firstPlayerBar;
        private System.Windows.Forms.ListBox logBox;
    }
}

