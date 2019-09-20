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
            this.lblAnswer.Hide();

            this.lblAnswerQ.Hide();

        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            this.lblAnswer.Show();

            this.lblAnswerQ.Show();

            double radius, circumference;

            radius = double.Parse(txtRadius.Text);

            circumference = 2 * Math.PI * radius;

            this.lblAnswer.Text = Convert.ToString(circumference) + " cm ";
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
