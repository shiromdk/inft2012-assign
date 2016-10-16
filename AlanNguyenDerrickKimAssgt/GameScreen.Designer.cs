namespace AlanNguyenDerrickKimAssgt
{
    partial class GameScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.objectiveLabel = new System.Windows.Forms.Label();
            this.player1CumulativeScore = new System.Windows.Forms.Label();
            this.player2CumulativeScore = new System.Windows.Forms.Label();
            this.player1RunningScore = new System.Windows.Forms.Label();
            this.player2RunninglScore = new System.Windows.Forms.Label();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.dicePictureBox = new System.Windows.Forms.PictureBox();
            this.passButton = new System.Windows.Forms.Button();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.turnHistoryButton = new System.Windows.Forms.Button();
            this.playerTurnLabel = new System.Windows.Forms.Label();
            this.exitGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Groan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player One";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player Two";
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameLabel.Location = new System.Drawing.Point(46, 175);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(149, 18);
            this.player1NameLabel.TabIndex = 3;
            this.player1NameLabel.Text = "PlayerNameLabel";
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameLabel.Location = new System.Drawing.Point(583, 175);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(149, 18);
            this.player2NameLabel.TabIndex = 4;
            this.player2NameLabel.Text = "PlayerNameLabel";
            // 
            // objectiveLabel
            // 
            this.objectiveLabel.AutoSize = true;
            this.objectiveLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectiveLabel.Location = new System.Drawing.Point(278, 73);
            this.objectiveLabel.Name = "objectiveLabel";
            this.objectiveLabel.Size = new System.Drawing.Size(229, 24);
            this.objectiveLabel.TabIndex = 5;
            this.objectiveLabel.Text = "First player to N wins!";
            // 
            // player1CumulativeScore
            // 
            this.player1CumulativeScore.AutoSize = true;
            this.player1CumulativeScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1CumulativeScore.Location = new System.Drawing.Point(47, 244);
            this.player1CumulativeScore.Name = "player1CumulativeScore";
            this.player1CumulativeScore.Size = new System.Drawing.Size(157, 17);
            this.player1CumulativeScore.TabIndex = 6;
            this.player1CumulativeScore.Text = "Cumulative Score: N";
            // 
            // player2CumulativeScore
            // 
            this.player2CumulativeScore.AutoSize = true;
            this.player2CumulativeScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2CumulativeScore.Location = new System.Drawing.Point(584, 244);
            this.player2CumulativeScore.Name = "player2CumulativeScore";
            this.player2CumulativeScore.Size = new System.Drawing.Size(157, 17);
            this.player2CumulativeScore.TabIndex = 7;
            this.player2CumulativeScore.Text = "Cumulative Score: N";
            // 
            // player1RunningScore
            // 
            this.player1RunningScore.AutoSize = true;
            this.player1RunningScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1RunningScore.Location = new System.Drawing.Point(46, 227);
            this.player1RunningScore.Name = "player1RunningScore";
            this.player1RunningScore.Size = new System.Drawing.Size(140, 17);
            this.player1RunningScore.TabIndex = 8;
            this.player1RunningScore.Text = "Running Score : N";
            // 
            // player2RunninglScore
            // 
            this.player2RunninglScore.AutoSize = true;
            this.player2RunninglScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2RunninglScore.Location = new System.Drawing.Point(584, 227);
            this.player2RunninglScore.Name = "player2RunninglScore";
            this.player2RunninglScore.Size = new System.Drawing.Size(136, 17);
            this.player2RunninglScore.TabIndex = 9;
            this.player2RunninglScore.Text = "Running Score: N";
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceButton.Location = new System.Drawing.Point(221, 128);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(173, 43);
            this.rollDiceButton.TabIndex = 10;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // dicePictureBox
            // 
            this.dicePictureBox.Location = new System.Drawing.Point(221, 177);
            this.dicePictureBox.Name = "dicePictureBox";
            this.dicePictureBox.Size = new System.Drawing.Size(342, 218);
            this.dicePictureBox.TabIndex = 11;
            this.dicePictureBox.TabStop = false;
            // 
            // passButton
            // 
            this.passButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passButton.Location = new System.Drawing.Point(392, 128);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(171, 43);
            this.passButton.TabIndex = 12;
            this.passButton.Text = "Pass Turn";
            this.passButton.UseVisualStyleBackColor = true;
            this.passButton.Click += new System.EventHandler(this.passButton_Click);
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLabel.Location = new System.Drawing.Point(318, 505);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(164, 18);
            this.TurnLabel.TabIndex = 13;
            this.TurnLabel.Text = "It is currently turn 1";
            // 
            // turnHistoryButton
            // 
            this.turnHistoryButton.Location = new System.Drawing.Point(356, 535);
            this.turnHistoryButton.Name = "turnHistoryButton";
            this.turnHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.turnHistoryButton.TabIndex = 14;
            this.turnHistoryButton.Text = "Turn History";
            this.turnHistoryButton.UseVisualStyleBackColor = true;
            this.turnHistoryButton.Click += new System.EventHandler(this.turnHistoryButton_Click);
            // 
            // playerTurnLabel
            // 
            this.playerTurnLabel.AutoSize = true;
            this.playerTurnLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurnLabel.Location = new System.Drawing.Point(318, 477);
            this.playerTurnLabel.Name = "playerTurnLabel";
            this.playerTurnLabel.Size = new System.Drawing.Size(155, 18);
            this.playerTurnLabel.TabIndex = 15;
            this.playerTurnLabel.Text = "It is Player X\'s turn";
            // 
            // exitGameButton
            // 
            this.exitGameButton.Location = new System.Drawing.Point(321, 427);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(152, 23);
            this.exitGameButton.TabIndex = 16;
            this.exitGameButton.Text = "Exit to Main Menu";
            this.exitGameButton.UseVisualStyleBackColor = true;
            this.exitGameButton.Click += new System.EventHandler(this.exitGameButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.playerTurnLabel);
            this.Controls.Add(this.turnHistoryButton);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.dicePictureBox);
            this.Controls.Add(this.rollDiceButton);
            this.Controls.Add(this.player2RunninglScore);
            this.Controls.Add(this.player1RunningScore);
            this.Controls.Add(this.player2CumulativeScore);
            this.Controls.Add(this.player1CumulativeScore);
            this.Controls.Add(this.objectiveLabel);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameScreen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dicePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.Label objectiveLabel;
        private System.Windows.Forms.Label player1CumulativeScore;
        private System.Windows.Forms.Label player2CumulativeScore;
        private System.Windows.Forms.Label player1RunningScore;
        private System.Windows.Forms.Label player2RunninglScore;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.PictureBox dicePictureBox;
        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Button turnHistoryButton;
        private System.Windows.Forms.Label playerTurnLabel;
        private System.Windows.Forms.Button exitGameButton;
    }
}