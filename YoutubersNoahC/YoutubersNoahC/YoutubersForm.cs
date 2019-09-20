/*
 * Created by: Noah Colbourne
 * Created on: 16-Sep-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - YoutubersFom.cs
 * This program displays the name, real name and sub count of various youtubers.
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
            //This displays the name, real name and sub count of a youtuber.
            this.lblName.Text = "Pewdiepie";
            this.lblInfo.Text = "Name: Felix Kjellberg";
            this.lblsubcount.Text = "Sub Count: 101,441,603";
            this.picYoutuber.Image = Properties.Resources.pewdiepie2;
        }

        private void LblInfo_Click(object sender, EventArgs e)
        {

        }

        private void MniJacksepticeye_Click(object sender, EventArgs e)
        {
            //This displays the name, real name and sub count of a youtuber.
            this.lblName.Text = "Jacksepticeye";
            this.lblInfo.Text = "Name: Seán William McLoughlin";
            this.lblsubcount.Text = "Sub Count: 22,830,342";
            this.picYoutuber.Image = Properties.Resources.jacksepticeye;
        }

        private void MniMarkiplier_Click(object sender, EventArgs e)
        {
            //This displays the name, real name and sub count of a youtuber.
            this.lblName.Text = "Markiplier";
            this.lblInfo.Text = "Name: Mark Edward Fischbach";
            this.lblsubcount.Text = "Sub Count: 24,389,369";
            this.picYoutuber.Image = Properties.Resources.markiplier__1_;
        }

        private void MniMrBeast_Click(object sender, EventArgs e)
        {
            //This displays the name, real name and sub count of a youtuber.
            this.lblName.Text = "Mr. Beast";
            this.lblInfo.Text = "Name: Jimmy Donaldson";
            this.lblsubcount.Text = "Sub Count: 24,262,531";
            this.picYoutuber.Image = Properties.Resources.mrbeast;
        }
    }
}
