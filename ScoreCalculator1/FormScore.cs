using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator1
{
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Add button is adding and averaging scores
        {
            
            int scoreTotal = 0;//Zero value is passed to score total variable to start adding.
            int  scoreCounts = 1;// staring count at 1
            int scoreAverage;
            int score = 0;

            if (Int32.TryParse(txtScore.Text, out score)) { 
               scoreTotal = (int) scoreTotal + score;//cast to integer 
                txtScoreTotal.Text = scoreTotal.ToString();// convert text to string by using ToStsring method
               scoreAverage =  (int)scoreTotal /scoreCounts;
                txtAverage.Text = scoreAverage.ToString();
               scoreCounts++;
            }
            else
            {
                MessageBox.Show("Enter only number", "Error");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClearScore_Click(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                  {
                this.Close();//to end application
                  }

        }
    }
}
