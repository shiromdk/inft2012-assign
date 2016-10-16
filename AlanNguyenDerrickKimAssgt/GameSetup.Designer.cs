namespace AlanNguyenDerrickKimAssgt
{
    partial class GameSetup
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
            this.vsPlayerbutton = new System.Windows.Forms.Button();
            this.vsCpuButton = new System.Windows.Forms.Button();
            this.vsCpuPanel = new System.Windows.Forms.Panel();
            this.cpuGameScore = new System.Windows.Forms.NumericUpDown();
            this.DifficultyGroup = new System.Windows.Forms.GroupBox();
            this.easy = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.hard = new System.Windows.Forms.RadioButton();
            this.vsCpuBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.startCpuGame = new System.Windows.Forms.Button();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.twoPlayerPanel = new System.Windows.Forms.Panel();
            this.totalValue2p = new System.Windows.Forms.NumericUpDown();
            this.backButton2p = new System.Windows.Forms.Button();
            this.start2p = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p2Name = new System.Windows.Forms.TextBox();
            this.p1Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gameSetupPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.vsCpuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuGameScore)).BeginInit();
            this.DifficultyGroup.SuspendLayout();
            this.twoPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalValue2p)).BeginInit();
            this.gameSetupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsPlayerbutton
            // 
            this.vsPlayerbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsPlayerbutton.Location = new System.Drawing.Point(295, 233);
            this.vsPlayerbutton.Name = "vsPlayerbutton";
            this.vsPlayerbutton.Size = new System.Drawing.Size(195, 60);
            this.vsPlayerbutton.TabIndex = 0;
            this.vsPlayerbutton.Text = "1P vs 2P";
            this.vsPlayerbutton.UseVisualStyleBackColor = true;
            this.vsPlayerbutton.Click += new System.EventHandler(this.vsPlayerbutton_Click);
            // 
            // vsCpuButton
            // 
            this.vsCpuButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsCpuButton.Location = new System.Drawing.Point(295, 167);
            this.vsCpuButton.Name = "vsCpuButton";
            this.vsCpuButton.Size = new System.Drawing.Size(195, 60);
            this.vsCpuButton.TabIndex = 1;
            this.vsCpuButton.Text = "1P vs CPU";
            this.vsCpuButton.UseVisualStyleBackColor = true;
            this.vsCpuButton.Click += new System.EventHandler(this.vsCpuButton_Click);
            // 
            // vsCpuPanel
            // 
            this.vsCpuPanel.Controls.Add(this.cpuGameScore);
            this.vsCpuPanel.Controls.Add(this.DifficultyGroup);
            this.vsCpuPanel.Controls.Add(this.vsCpuBack);
            this.vsCpuPanel.Controls.Add(this.label3);
            this.vsCpuPanel.Controls.Add(this.label2);
            this.vsCpuPanel.Controls.Add(this.scoreLabel);
            this.vsCpuPanel.Controls.Add(this.startCpuGame);
            this.vsCpuPanel.Controls.Add(this.playerNameTextBox);
            this.vsCpuPanel.Controls.Add(this.label1);
            this.vsCpuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsCpuPanel.Location = new System.Drawing.Point(0, 0);
            this.vsCpuPanel.Name = "vsCpuPanel";
            this.vsCpuPanel.Size = new System.Drawing.Size(784, 561);
            this.vsCpuPanel.TabIndex = 2;
            this.vsCpuPanel.Visible = false;
            // 
            // cpuGameScore
            // 
            this.cpuGameScore.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.cpuGameScore.Location = new System.Drawing.Point(329, 257);
            this.cpuGameScore.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cpuGameScore.Name = "cpuGameScore";
            this.cpuGameScore.Size = new System.Drawing.Size(120, 20);
            this.cpuGameScore.TabIndex = 12;
            // 
            // DifficultyGroup
            // 
            this.DifficultyGroup.Controls.Add(this.easy);
            this.DifficultyGroup.Controls.Add(this.normal);
            this.DifficultyGroup.Controls.Add(this.hard);
            this.DifficultyGroup.Location = new System.Drawing.Point(254, 326);
            this.DifficultyGroup.Name = "DifficultyGroup";
            this.DifficultyGroup.Size = new System.Drawing.Size(276, 56);
            this.DifficultyGroup.TabIndex = 11;
            this.DifficultyGroup.TabStop = false;
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.Location = new System.Drawing.Point(6, 19);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(65, 22);
            this.easy.TabIndex = 7;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Checked = true;
            this.normal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normal.Location = new System.Drawing.Point(91, 19);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(83, 22);
            this.normal.TabIndex = 8;
            this.normal.TabStop = true;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.Location = new System.Drawing.Point(194, 19);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(65, 22);
            this.hard.TabIndex = 9;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // vsCpuBack
            // 
            this.vsCpuBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.vsCpuBack.Location = new System.Drawing.Point(396, 417);
            this.vsCpuBack.Name = "vsCpuBack";
            this.vsCpuBack.Size = new System.Drawing.Size(152, 53);
            this.vsCpuBack.TabIndex = 10;
            this.vsCpuBack.Text = "Back";
            this.vsCpuBack.UseVisualStyleBackColor = true;
            this.vsCpuBack.Click += new System.EventHandler(this.vsCpuBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Difficulty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "Setting up vs CPU Game";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(318, 230);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(148, 18);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Enter Total Score";
            this.scoreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // startCpuGame
            // 
            this.startCpuGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCpuGame.Location = new System.Drawing.Point(236, 417);
            this.startCpuGame.Name = "startCpuGame";
            this.startCpuGame.Size = new System.Drawing.Size(154, 53);
            this.startCpuGame.TabIndex = 2;
            this.startCpuGame.Text = "Start Game";
            this.startCpuGame.UseVisualStyleBackColor = true;
            this.startCpuGame.Click += new System.EventHandler(this.startCpuGame_Click);
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameTextBox.Location = new System.Drawing.Point(286, 186);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(213, 26);
            this.playerNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Player Name";
            // 
            // twoPlayerPanel
            // 
            this.twoPlayerPanel.Controls.Add(this.totalValue2p);
            this.twoPlayerPanel.Controls.Add(this.backButton2p);
            this.twoPlayerPanel.Controls.Add(this.start2p);
            this.twoPlayerPanel.Controls.Add(this.label7);
            this.twoPlayerPanel.Controls.Add(this.label6);
            this.twoPlayerPanel.Controls.Add(this.label5);
            this.twoPlayerPanel.Controls.Add(this.p2Name);
            this.twoPlayerPanel.Controls.Add(this.p1Name);
            this.twoPlayerPanel.Controls.Add(this.label4);
            this.twoPlayerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoPlayerPanel.Location = new System.Drawing.Point(0, 0);
            this.twoPlayerPanel.Name = "twoPlayerPanel";
            this.twoPlayerPanel.Size = new System.Drawing.Size(784, 561);
            this.twoPlayerPanel.TabIndex = 13;
            this.twoPlayerPanel.Visible = false;
            this.twoPlayerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.twoPlayerPanel_Paint);
            // 
            // totalValue2p
            // 
            this.totalValue2p.Location = new System.Drawing.Point(332, 319);
            this.totalValue2p.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.totalValue2p.Name = "totalValue2p";
            this.totalValue2p.Size = new System.Drawing.Size(120, 20);
            this.totalValue2p.TabIndex = 9;
            // 
            // backButton2p
            // 
            this.backButton2p.Location = new System.Drawing.Point(396, 388);
            this.backButton2p.Name = "backButton2p";
            this.backButton2p.Size = new System.Drawing.Size(157, 55);
            this.backButton2p.TabIndex = 8;
            this.backButton2p.Text = "Back";
            this.backButton2p.UseVisualStyleBackColor = true;
            this.backButton2p.Click += new System.EventHandler(this.backButton2p_Click);
            // 
            // start2p
            // 
            this.start2p.Location = new System.Drawing.Point(235, 388);
            this.start2p.Name = "start2p";
            this.start2p.Size = new System.Drawing.Size(155, 55);
            this.start2p.TabIndex = 7;
            this.start2p.Text = "Start Game";
            this.start2p.UseVisualStyleBackColor = true;
            this.start2p.Click += new System.EventHandler(this.start2p_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label7.Location = new System.Drawing.Point(317, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Game Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label6.Location = new System.Drawing.Point(319, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Player Two Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Player One Name";
            // 
            // p2Name
            // 
            this.p2Name.Location = new System.Drawing.Point(283, 218);
            this.p2Name.Name = "p2Name";
            this.p2Name.Size = new System.Drawing.Size(219, 20);
            this.p2Name.TabIndex = 2;
            // 
            // p1Name
            // 
            this.p1Name.Location = new System.Drawing.Point(283, 166);
            this.p1Name.Name = "p1Name";
            this.p1Name.Size = new System.Drawing.Size(219, 20);
            this.p1Name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "Two Player Game";
            // 
            // gameSetupPanel
            // 
            this.gameSetupPanel.Controls.Add(this.label8);
            this.gameSetupPanel.Controls.Add(this.backToMainMenu);
            this.gameSetupPanel.Controls.Add(this.vsPlayerbutton);
            this.gameSetupPanel.Controls.Add(this.vsCpuButton);
            this.gameSetupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSetupPanel.Location = new System.Drawing.Point(0, 0);
            this.gameSetupPanel.Name = "gameSetupPanel";
            this.gameSetupPanel.Size = new System.Drawing.Size(784, 561);
            this.gameSetupPanel.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(463, 55);
            this.label8.TabIndex = 3;
            this.label8.Text = "Select Game Mode";
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.backToMainMenu.Location = new System.Drawing.Point(295, 304);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(195, 63);
            this.backToMainMenu.TabIndex = 2;
            this.backToMainMenu.Text = "Back";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // GameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.twoPlayerPanel);
            this.Controls.Add(this.vsCpuPanel);
            this.Controls.Add(this.gameSetupPanel);
            this.Name = "GameSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameSetup";
            this.Load += new System.EventHandler(this.GameSetup_Load);
            this.vsCpuPanel.ResumeLayout(false);
            this.vsCpuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuGameScore)).EndInit();
            this.DifficultyGroup.ResumeLayout(false);
            this.DifficultyGroup.PerformLayout();
            this.twoPlayerPanel.ResumeLayout(false);
            this.twoPlayerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalValue2p)).EndInit();
            this.gameSetupPanel.ResumeLayout(false);
            this.gameSetupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vsPlayerbutton;
        private System.Windows.Forms.Button vsCpuButton;
        private System.Windows.Forms.Panel vsCpuPanel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button startCpuGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button vsCpuBack;
        private System.Windows.Forms.GroupBox DifficultyGroup;
        private System.Windows.Forms.NumericUpDown cpuGameScore;
        private System.Windows.Forms.Button backButton2p;
        private System.Windows.Forms.Button start2p;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p2Name;
        private System.Windows.Forms.TextBox p1Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel twoPlayerPanel;
        private System.Windows.Forms.Panel gameSetupPanel;
        private System.Windows.Forms.NumericUpDown totalValue2p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backToMainMenu;
    }
}