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
            this.CricketScoringBoardLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.noBallLabel = new System.Windows.Forms.Label();
            this.wideBallLabel = new System.Windows.Forms.Label();
            this.noBall = new System.Windows.Forms.Button();
            this.wideBall = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPlayer
            // 
            this.addPlayer.Location = new System.Drawing.Point(173, 139);
            this.addPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(80, 25);
            this.addPlayer.TabIndex = 9;
            this.addPlayer.Text = "Add Player";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click_1);
            // 
            // CricketScoringBoardLabel
            // 
            this.CricketScoringBoardLabel.AutoSize = true;
            this.CricketScoringBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CricketScoringBoardLabel.Location = new System.Drawing.Point(283, -1);
            this.CricketScoringBoardLabel.Name = "CricketScoringBoardLabel";
            this.CricketScoringBoardLabel.Size = new System.Drawing.Size(278, 31);
            this.CricketScoringBoardLabel.TabIndex = 10;
            this.CricketScoringBoardLabel.Text = "Cricket Scoring Board";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Player Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "2nd Innings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.addPlayer);
            this.tabPage2.Controls.Add(this.wideBall);
            this.tabPage2.Controls.Add(this.noBall);
            this.tabPage2.Controls.Add(this.wideBallLabel);
            this.tabPage2.Controls.Add(this.noBallLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1st Innings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // noBallLabel
            // 
            this.noBallLabel.AutoSize = true;
            this.noBallLabel.Location = new System.Drawing.Point(387, 245);
            this.noBallLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noBallLabel.Name = "noBallLabel";
            this.noBallLabel.Size = new System.Drawing.Size(13, 13);
            this.noBallLabel.TabIndex = 8;
            this.noBallLabel.Text = "0";
            // 
            // wideBallLabel
            // 
            this.wideBallLabel.AutoSize = true;
            this.wideBallLabel.Location = new System.Drawing.Point(387, 184);
            this.wideBallLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wideBallLabel.Name = "wideBallLabel";
            this.wideBallLabel.Size = new System.Drawing.Size(13, 13);
            this.wideBallLabel.TabIndex = 7;
            this.wideBallLabel.Text = "0";
            // 
            // noBall
            // 
            this.noBall.Location = new System.Drawing.Point(306, 239);
            this.noBall.Margin = new System.Windows.Forms.Padding(2);
            this.noBall.Name = "noBall";
            this.noBall.Size = new System.Drawing.Size(69, 24);
            this.noBall.TabIndex = 6;
            this.noBall.Text = "No Ball";
            this.noBall.UseVisualStyleBackColor = true;
            this.noBall.Click += new System.EventHandler(this.noBall_Click_1);
            // 
            // wideBall
            // 
            this.wideBall.Location = new System.Drawing.Point(306, 178);
            this.wideBall.Margin = new System.Windows.Forms.Padding(2);
            this.wideBall.Name = "wideBall";
            this.wideBall.Size = new System.Drawing.Size(69, 24);
            this.wideBall.TabIndex = 5;
            this.wideBall.Text = "Wide Ball";
            this.wideBall.UseVisualStyleBackColor = true;
            this.wideBall.Click += new System.EventHandler(this.wideBall_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(119, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 586);
            this.tabControl1.TabIndex = 12;
            // 
            // scoringSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 601);
            this.Controls.Add(this.CricketScoringBoardLabel);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "scoringSystem";
            this.Text = "Score Board";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.scoringSystem_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.Label CricketScoringBoardLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button wideBall;
        private System.Windows.Forms.Button noBall;
        private System.Windows.Forms.Label wideBallLabel;
        private System.Windows.Forms.Label noBallLabel;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

