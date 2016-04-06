namespace ISD_Course_Fight_club
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonHead = new System.Windows.Forms.Button();
            this.buttonBody = new System.Windows.Forms.Button();
            this.buttonLegs = new System.Windows.Forms.Button();
            this.logShow = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.progressBarPlayerHP = new System.Windows.Forms.ProgressBar();
            this.progressBarCompPlayerHP = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHead
            // 
            this.buttonHead.Location = new System.Drawing.Point(152, 50);
            this.buttonHead.Name = "buttonHead";
            this.buttonHead.Size = new System.Drawing.Size(75, 23);
            this.buttonHead.TabIndex = 0;
            this.buttonHead.Text = "Head";
            this.buttonHead.UseVisualStyleBackColor = true;
            this.buttonHead.Click += new System.EventHandler(this.buttonHead_Click);
            // 
            // buttonBody
            // 
            this.buttonBody.Location = new System.Drawing.Point(152, 79);
            this.buttonBody.Name = "buttonBody";
            this.buttonBody.Size = new System.Drawing.Size(75, 23);
            this.buttonBody.TabIndex = 1;
            this.buttonBody.Text = "Body";
            this.buttonBody.UseVisualStyleBackColor = true;
            this.buttonBody.Click += new System.EventHandler(this.buttonBody_Click);
            // 
            // buttonLegs
            // 
            this.buttonLegs.Location = new System.Drawing.Point(152, 108);
            this.buttonLegs.Name = "buttonLegs";
            this.buttonLegs.Size = new System.Drawing.Size(75, 23);
            this.buttonLegs.TabIndex = 2;
            this.buttonLegs.Text = "Legs";
            this.buttonLegs.UseVisualStyleBackColor = true;
            this.buttonLegs.Click += new System.EventHandler(this.buttonLegs_Click);
            // 
            // logShow
            // 
            this.logShow.Location = new System.Drawing.Point(13, 150);
            this.logShow.Multiline = true;
            this.logShow.Name = "logShow";
            this.logShow.ReadOnly = true;
            this.logShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logShow.Size = new System.Drawing.Size(356, 84);
            this.logShow.TabIndex = 4;
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(12, 134);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(31, 13);
            this.Log.TabIndex = 5;
            this.Log.Text = "Log: ";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(66, 63);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(26, 13);
            this.playerLabel.TabIndex = 6;
            this.playerLabel.Text = "You";
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Location = new System.Drawing.Point(276, 60);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(52, 13);
            this.computerLabel.TabIndex = 7;
            this.computerLabel.Text = "Computer";
            // 
            // progressBarPlayerHP
            // 
            this.progressBarPlayerHP.Location = new System.Drawing.Point(13, 79);
            this.progressBarPlayerHP.Name = "progressBarPlayerHP";
            this.progressBarPlayerHP.Size = new System.Drawing.Size(133, 23);
            this.progressBarPlayerHP.TabIndex = 8;
            // 
            // progressBarCompPlayerHP
            // 
            this.progressBarCompPlayerHP.Location = new System.Drawing.Point(233, 79);
            this.progressBarCompPlayerHP.Name = "progressBarCompPlayerHP";
            this.progressBarCompPlayerHP.Size = new System.Drawing.Size(136, 23);
            this.progressBarCompPlayerHP.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveGameToolStripMenuItem.Text = "Save game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadGameToolStripMenuItem.Text = "Load game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionLabel.Location = new System.Drawing.Point(160, 31);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(51, 16);
            this.actionLabel.TabIndex = 11;
            this.actionLabel.Text = "label1";
            this.actionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 241);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.progressBarCompPlayerHP);
            this.Controls.Add(this.progressBarPlayerHP);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.logShow);
            this.Controls.Add(this.buttonLegs);
            this.Controls.Add(this.buttonBody);
            this.Controls.Add(this.buttonHead);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Fight Club";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHead;
        private System.Windows.Forms.Button buttonBody;
        private System.Windows.Forms.Button buttonLegs;
        private System.Windows.Forms.TextBox logShow;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.ProgressBar progressBarPlayerHP;
        private System.Windows.Forms.ProgressBar progressBarCompPlayerHP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
    }
}

