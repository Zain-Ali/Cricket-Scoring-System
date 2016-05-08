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


        private void scoringSystem_Load(object sender, EventArgs e)
        {}

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
            //Adding TextBox
            TextBox playerBox = new TextBox();
           // playerBox.Text = " ";

            Point textBoxPosition = new Point(20 + playerCounter, 55 * playerCounter);
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
            count = int.Parse(wideBallLabel.Text);
            count++;
            wideBallLabel.Text = count.ToString();
        }

        private void noBall_Click_1(object sender, EventArgs e)
        {
            count = int.Parse(noBallLabel.Text);
            count++;
            noBallLabel.Text = count.ToString();
        }
    }
}
