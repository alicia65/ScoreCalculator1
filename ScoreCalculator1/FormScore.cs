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
        //class variables use in the program
        int scoreTotal = 0;//Zero value is passed to score total variable to start adding.
        int scoreCounts = 1;// start counting at value 1 which is passed to scoreCounts
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
            
            int scoreAverage;
            int score = 0;

            if (Int32.TryParse(txtScore.Text, out score)) {
                scoreTotal = (int)scoreTotal + score;//cast to integer 
                txtScoreTotal.Text = scoreTotal.ToString();// convert text to string by using ToStsring method
                scoreAverage = (int)scoreTotal / scoreCounts;//to get average scores: cast scoreTotal to integer 
                //first and then divide by score counts
                txtAverage.Text = scoreAverage.ToString("n1");//convert text to string by using ToString method 
                scoreCounts++;//add count
            }
            else
            {
                MessageBox.Show("Enter only number", "Error");//display text to inform user to enter numbers
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtScoreCount.Text, out scoreCounts))

                txtScoreCount.Text = scoreCounts.ToString();//ToString method converts text scores to integer
                 
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClearScore_Click(object sender, EventArgs e)
        { 
            //Following textboxes clear data by using clear() method
            txtScore.Clear();
            txtScoreTotal.Clear();
            txtScoreCount.Clear();
            txtAverage.Clear();
            txtScoreTotal.Text = "0";
            txtScoreCount.Text = "0";
            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                  {
                this.Close();//to end application or close program
                  }

        }
    }
}
