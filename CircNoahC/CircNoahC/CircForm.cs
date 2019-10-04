/*
 * Created by: Noah Colbourne
 * Created on: 4-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Circumference of a Circle 
 * This program takes the radius a user inputs and will
 * show the circumference of a circle with that radius.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircNoahC
{
    public partial class frmCirc : Form
    {
        public frmCirc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This hides the answer label when the program starts.
            this.lblAnswer.Hide();

            //This hides the qustion label for the answer when the prgram starts.
            this.lblAnswerQ.Hide();

        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //This will show the answer label when the button is clicked.
            this.lblAnswer.Show();

            //This will show the answer question label when the button is clicked.
            this.lblAnswerQ.Show();

            //This declares the variables "radius" and "circumference" as doubles.
            double radius, circumference;

            //this declares the variable "radius" as what ever is written in the text box in double format.
            radius = double.Parse(txtRadius.Text);

            //This declares the variable "circumference" as the math equation to calculate for circumference.
            circumference = 2 * Math.PI * radius;

            //This makes the answer label dsiplay the circumference of the circle that was calculated.
            //(and converts the double back to string)
            this.lblAnswer.Text = Convert.ToString(circumference) + " cm ";
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            //This will close the program if the exit button is clicked.
            this.Close();
        }
    }
}
