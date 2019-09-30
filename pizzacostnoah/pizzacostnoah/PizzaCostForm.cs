/*
 * Created by: Noah Colbourne
 * Created on: 26-Sep-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - Name of Program
 * This program will calculate the cost (before and after tax) 
 * of a pizza based on the diameter of the pizza. 
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

namespace pizzacostnoah
{
    public partial class PizzaCostForm : Form
    {
        public PizzaCostForm()
        {
            InitializeComponent();
        }

        private void PizzaCostForm_Load(object sender, EventArgs e)
        {
            //This will hide the the questions for the answers and the answers.
            this.lblnotax.Hide();
            this.lbltax.Hide();
            this.lblnotaxanswer.Hide();
            this.lbltaxanswer.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //This will show the the questions for the answers and the answers.
            this.lblnotax.Show();
            this.lbltax.Show();
            this.lblnotaxanswer.Show();
            this.lbltaxanswer.Show();

            //This declares these variables as doubles.
            double diameter, costbeforetax, costaftertax;

            // This makes the variable diameter become the text box.
            diameter = double.Parse(txtdiameter.Text);

            //this makes the variable costbeforetx become the equation for price without tax.
            costbeforetax = (0.75 + 0.99 + (0.5 * diameter));

            //This makes the varirbale costaftertax become the equation for price with tax.
            costaftertax = ((0.75 + 0.99 + 0.5 * diameter)*1.13);

            //This makes the answer label for cost without tax display the answer for cost without tax.
            this.lblnotaxanswer.Text = String.Format("${0:0.00}", costbeforetax);

            //This makes the answer label for cost with tax display the answer for cost with tax.
            this.lbltaxanswer.Text = String.Format("${0:0.00}", costaftertax);

        }

        private void LblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
