/*
 * Created by: Noah Colbourne
 * Created on: 5-Oct-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Area and Perimeter
 * This program Will use the user's length and width
 * input to calculate the area and perimeter of the rectangle.
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

namespace AreaPerNoahC
{
    public partial class frmAreaPer : Form
    {
        public frmAreaPer()
        {
            InitializeComponent();
        }

        private void LblAreaAnswer_Click(object sender, EventArgs e)
        {
            
        }

        private void LblPerimeterAnswer_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
           //This declares these variables as doubles
            double length, width, perimeter, area;

            //This declares the vaiable "length" as whatever is written
            //in the length text box and converts it to a double. 
            length = double.Parse(txtLength.Text);

            //This declares the vaiable "width" as whatever is written
            //in the width text box and converts it to a double. 
            width = double.Parse(txtWidth.Text);

            //This is declaring the variable "area" as whatever 
            //the length times the width is.
            area = length * width;

            //This is declaring the variable "perimeter" as whatever
            //the lenth plus width plus length plus width is.
            perimeter = length + width + length + width;

            //This will show the label once the button is clicked.
            this.lblAreaAnswer.Show();
           
            //This will show the label once the button is clicked.
            this.lblPerimeterAnswer.Show();

            //This makes the area answer label display the area answer in 
            //text once it is converted to string.
            this.lblAreaAnswer.Text = Convert.ToString(area) + " m²";

            //This makes the perimeter answer label display the perimeter 
            //answer in text once it is converted to string.
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " m";
        }

        private void frmAreaPer_Load(object sender, EventArgs e)
        {
            // This will hide the label when the program is started.
            this.lblAreaAnswer.Hide();

            //This will hide the label when the program is started.
            this.lblPerimeterAnswer.Hide();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
