namespace Game2048
{
    partial class Game2048
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2048));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBoxName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxRealName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxScore = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxRealScore = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxTOR = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItemRules = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 410);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxName,
            this.toolStripTextBoxRealName,
            this.toolStripTextBoxScore,
            this.toolStripTextBoxRealScore,
            this.toolStripMenuItemRestart,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBoxName
            // 
            this.toolStripTextBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBoxName.Name = "toolStripTextBoxName";
            this.toolStripTextBoxName.ReadOnly = true;
            this.toolStripTextBoxName.Size = new System.Drawing.Size(73, 23);
            this.toolStripTextBoxName.Text = "Имя игрока:";
            // 
            // toolStripTextBoxRealName
            // 
            this.toolStripTextBoxRealName.Name = "toolStripTextBoxRealName";
            this.toolStripTextBoxRealName.Size = new System.Drawing.Size(75, 23);
            this.toolStripTextBoxRealName.Text = "Player";
            this.toolStripTextBoxRealName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxRealName_KeyDown);
            // 
            // toolStripTextBoxScore
            // 
            this.toolStripTextBoxScore.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBoxScore.Name = "toolStripTextBoxScore";
            this.toolStripTextBoxScore.ReadOnly = true;
            this.toolStripTextBoxScore.Size = new System.Drawing.Size(35, 23);
            this.toolStripTextBoxScore.Text = "Счет:";
            // 
            // toolStripTextBoxRealScore
            // 
            this.toolStripTextBoxRealScore.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBoxRealScore.Name = "toolStripTextBoxRealScore";
            this.toolStripTextBoxRealScore.ReadOnly = true;
            this.toolStripTextBoxRealScore.Size = new System.Drawing.Size(48, 23);
            this.toolStripTextBoxRealScore.Text = "0";
            // 
            // toolStripMenuItemRestart
            // 
            this.toolStripMenuItemRestart.Name = "toolStripMenuItemRestart";
            this.toolStripMenuItemRestart.Size = new System.Drawing.Size(99, 23);
            this.toolStripMenuItemRestart.Text = "Начать заново";
            this.toolStripMenuItemRestart.Click += new System.EventHandler(this.toolStripMenuItemRestart_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxTOR,
            this.toolStripMenuItemRules});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 23);
            this.toolStripMenuItem1.Text = "Об игре";
            // 
            // toolStripComboBoxTOR
            // 
            this.toolStripComboBoxTOR.Name = "toolStripComboBoxTOR";
            this.toolStripComboBoxTOR.Size = new System.Drawing.Size(125, 23);
            this.toolStripComboBoxTOR.Text = "Таблица рекордов";
            this.toolStripComboBoxTOR.Click += new System.EventHandler(this.toolStripComboBoxTOR_Click);
            // 
            // toolStripMenuItemRules
            // 
            this.toolStripMenuItemRules.Name = "toolStripMenuItemRules";
            this.toolStripMenuItemRules.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemRules.Text = "Правила игры";
            this.toolStripMenuItemRules.Click += new System.EventHandler(this.toolStripMenuItemRules_Click);
            // 
            // Game2048
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Game2048";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game2048_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxName;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxRealName;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxScore;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxRealScore;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRestart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRules;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTOR;
    }
}

