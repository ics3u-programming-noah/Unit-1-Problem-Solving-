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
            this.lblAreaAnswer.Hide();
        }

        private void LblPerimeterAnswer_Click(object sender, EventArgs e)
        {
            this.lblPerimeterAnswer.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double length, width, perimeter, area;

            length = double.Parse(txtLength.Text);

            width = double.Parse(txtWidth.Text);

            area = length * width;

            perimeter = length + width + length + width;

            this.lblAreaAnswer.Show();

            this.lblPerimeterAnswer.Show();

            this.lblAreaAnswer.Text = Convert.ToString(area) + " m²";

            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " m";
        }
    }
}
