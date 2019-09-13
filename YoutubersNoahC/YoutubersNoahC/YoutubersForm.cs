using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubersNoahC
{
    public partial class frmYoutubers : Form
    {
        public frmYoutubers()
        {
            InitializeComponent();
        }

        private void MniPewdiepie_Click(object sender, EventArgs e)
        {
            this.lblName.Text = "Pewdiepie";
        }
    }
}
