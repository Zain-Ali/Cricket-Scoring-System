using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cricket_Scoreing_System
{
    public partial class scoringSystem : Form
    {
        static int playerCounter = 1;
        int count = 0; // for wide and no ball

        public scoringSystem()
        {
            InitializeComponent();
        }

        private void wideBall_Click(object sender, EventArgs e)
        {
            count++;
            wideBallLabel.Text = count.ToString();
            wideBallLabel.Text = wideBallLabel.Text;
        }

        private void wideBallLabel_Click(object sender, EventArgs e)
        {
        }

        private void noBall_Click(object sender, EventArgs e)
        {
            //count++;
            //noBallLabel.Text = count.ToString();
            int counter = int.Parse(wideBallLabel.Text);
            counter++;
            wideBallLabel.Text = counter.ToString();

            
        }

        private void noBallLabel_Click(object sender, EventArgs e)
        {
        }
        private void scoringSystem_Load(object sender, EventArgs e)
        {

        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            int i = 1;
            TextBox tb = new TextBox();
            tb.Text = " ";

            Point p = new Point(20 + i, 30 * i);
            tb.Location = p;

            this.Controls.Add(tb);
            i++;
        }

        private void addPlayer_Click_1(object sender, EventArgs e)
        {
            //Label
            //Label playerLabel = new Label();
            //playerLabel.Text = " ";

            //Point labelPosition = new Point(playerLabel.Location.X + playerLabel.Width + 30, playerLabel.Location.Y);
            //playerLabel.Location = labelPosition;

            //this.Controls.Add(playerLabel);
            //playerCounter++;


            //Adding TextBox
            TextBox playerBox = new TextBox();
            playerBox.Text = " ";

            Point textBoxPosition = new Point(50 + playerCounter, 30 * playerCounter);
            playerBox.Location = textBoxPosition;

            this.Controls.Add(playerBox);
            playerCounter++;


            //CheckBox
            CheckBox playerCheckBox = new CheckBox();
            playerCheckBox.Text = " ";
            playerCheckBox.Enabled = false;

            Point checkBoxPosition = new Point(playerBox.Location.X + playerBox.Width + 25, playerBox.Location.Y);
            playerCheckBox.Location = checkBoxPosition;

            this.Controls.Add(playerCheckBox);
            playerCounter++;


        }

        private void wideBall_Click_1(object sender, EventArgs e)
        {

        }



    }
}
