namespace Cricket_Scoreing_System
{
    partial class scoringSystem
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
            this.addPlayer = new System.Windows.Forms.Button();
            this.noBallLabel = new System.Windows.Forms.Label();
            this.wideBallLabel = new System.Windows.Forms.Label();
            this.noBall = new System.Windows.Forms.Button();
            this.wideBall = new System.Windows.Forms.Button();
            this.CricketScoringBoardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPlayer
            // 
            this.addPlayer.Location = new System.Drawing.Point(224, 87);
            this.addPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(80, 25);
            this.addPlayer.TabIndex = 9;
            this.addPlayer.Text = "Add Player";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click_1);
            // 
            // noBallLabel
            // 
            this.noBallLabel.AutoSize = true;
            this.noBallLabel.Location = new System.Drawing.Point(554, 297);
            this.noBallLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noBallLabel.Name = "noBallLabel";
            this.noBallLabel.Size = new System.Drawing.Size(13, 13);
            this.noBallLabel.TabIndex = 8;
            this.noBallLabel.Text = "0";
            // 
            // wideBallLabel
            // 
            this.wideBallLabel.AutoSize = true;
            this.wideBallLabel.Location = new System.Drawing.Point(554, 252);
            this.wideBallLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wideBallLabel.Name = "wideBallLabel";
            this.wideBallLabel.Size = new System.Drawing.Size(13, 13);
            this.wideBallLabel.TabIndex = 7;
            this.wideBallLabel.Text = "0";
            // 
            // noBall
            // 
            this.noBall.Location = new System.Drawing.Point(452, 292);
            this.noBall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noBall.Name = "noBall";
            this.noBall.Size = new System.Drawing.Size(69, 24);
            this.noBall.TabIndex = 6;
            this.noBall.Text = "No Ball";
            this.noBall.UseVisualStyleBackColor = true;
            // 
            // wideBall
            // 
            this.wideBall.Location = new System.Drawing.Point(452, 247);
            this.wideBall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wideBall.Name = "wideBall";
            this.wideBall.Size = new System.Drawing.Size(69, 24);
            this.wideBall.TabIndex = 5;
            this.wideBall.Text = "Wide Ball";
            this.wideBall.UseVisualStyleBackColor = true;
            this.wideBall.Click += new System.EventHandler(this.wideBall_Click_1);
            // 
            // CricketScoringBoardLabel
            // 
            this.CricketScoringBoardLabel.AutoSize = true;
            this.CricketScoringBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CricketScoringBoardLabel.Location = new System.Drawing.Point(272, 9);
            this.CricketScoringBoardLabel.Name = "CricketScoringBoardLabel";
            this.CricketScoringBoardLabel.Size = new System.Drawing.Size(278, 31);
            this.CricketScoringBoardLabel.TabIndex = 10;
            this.CricketScoringBoardLabel.Text = "Cricket Scoring Board";
            // 
            // scoringSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 601);
            this.Controls.Add(this.CricketScoringBoardLabel);
            this.Controls.Add(this.addPlayer);
            this.Controls.Add(this.noBallLabel);
            this.Controls.Add(this.wideBallLabel);
            this.Controls.Add(this.noBall);
            this.Controls.Add(this.wideBall);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "scoringSystem";
            this.Text = "Score Board";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.scoringSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.Label noBallLabel;
        private System.Windows.Forms.Label wideBallLabel;
        private System.Windows.Forms.Button noBall;
        private System.Windows.Forms.Button wideBall;
        private System.Windows.Forms.Label CricketScoringBoardLabel;
    }
}

