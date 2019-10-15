namespace YoutubersNoahC
{
    partial class frmYoutubers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniYoutubers = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPewdiepie = new System.Windows.Forms.ToolStripMenuItem();
            this.mniJacksepticeye = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMarkiplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMrBeast = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grbYoutuber = new System.Windows.Forms.GroupBox();
            this.picYoutuber = new System.Windows.Forms.PictureBox();
            this.lblsubcount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbYoutuber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picYoutuber)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniYoutubers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniYoutubers
            // 
            this.mniYoutubers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPewdiepie,
            this.mniJacksepticeye,
            this.mniMarkiplier,
            this.mniMrBeast});
            this.mniYoutubers.Name = "mniYoutubers";
            this.mniYoutubers.Size = new System.Drawing.Size(72, 20);
            this.mniYoutubers.Text = "Youtubers";
            // 
            // mniPewdiepie
            // 
            this.mniPewdiepie.Name = "mniPewdiepie";
            this.mniPewdiepie.Size = new System.Drawing.Size(145, 22);
            this.mniPewdiepie.Text = "Pewdiepie";
            this.mniPewdiepie.Click += new System.EventHandler(this.MniPewdiepie_Click);
            // 
            // mniJacksepticeye
            // 
            this.mniJacksepticeye.Name = "mniJacksepticeye";
            this.mniJacksepticeye.Size = new System.Drawing.Size(145, 22);
            this.mniJacksepticeye.Text = "Jacksepticeye";
            this.mniJacksepticeye.Click += new System.EventHandler(this.MniJacksepticeye_Click);
            // 
            // mniMarkiplier
            // 
            this.mniMarkiplier.Name = "mniMarkiplier";
            this.mniMarkiplier.Size = new System.Drawing.Size(145, 22);
            this.mniMarkiplier.Text = "Markiplier";
            this.mniMarkiplier.Click += new System.EventHandler(this.MniMarkiplier_Click);
            // 
            // mniMrBeast
            // 
            this.mniMrBeast.Name = "mniMrBeast";
            this.mniMrBeast.Size = new System.Drawing.Size(145, 22);
            this.mniMrBeast.Text = "Mr Beast";
            this.mniMrBeast.Click += new System.EventHandler(this.MniMrBeast_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(-9, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(214, 52);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Youtuber";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(-6, 131);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(178, 37);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Information";
            this.lblInfo.Click += new System.EventHandler(this.LblInfo_Click);
            // 
            // grbYoutuber
            // 
            this.grbYoutuber.Controls.Add(this.picYoutuber);
            this.grbYoutuber.Controls.Add(this.lblsubcount);
            this.grbYoutuber.Controls.Add(this.lblName);
            this.grbYoutuber.Controls.Add(this.lblInfo);
            this.grbYoutuber.Location = new System.Drawing.Point(0, 85);
            this.grbYoutuber.Name = "grbYoutuber";
            this.grbYoutuber.Size = new System.Drawing.Size(800, 318);
            this.grbYoutuber.TabIndex = 3;
            this.grbYoutuber.TabStop = false;
            this.grbYoutuber.Text = "Youtube Info";
            // 
            // picYoutuber
            // 
            this.picYoutuber.Image = global::YoutubersNoahC.Properties.Resources.youtube_logo;
            this.picYoutuber.Location = new System.Drawing.Point(485, 29);
            this.picYoutuber.Name = "picYoutuber";
            this.picYoutuber.Size = new System.Drawing.Size(303, 283);
            this.picYoutuber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYoutuber.TabIndex = 4;
            this.picYoutuber.TabStop = false;
            // 
            // lblsubcount
            // 
            this.lblsubcount.AutoSize = true;
            this.lblsubcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubcount.Location = new System.Drawing.Point(-6, 225);
            this.lblsubcount.Name = "lblsubcount";
            this.lblsubcount.Size = new System.Drawing.Size(260, 37);
            this.lblsubcount.TabIndex = 3;
            this.lblsubcount.Text = "September, 2019";
            // 
            // frmYoutubers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbYoutuber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmYoutubers";
            this.Text = "Youtubers by Noah.C";
            this.Load += new System.EventHandler(this.frmYoutubers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbYoutuber.ResumeLayout(false);
            this.grbYoutuber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picYoutuber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniYoutubers;
        private System.Windows.Forms.ToolStripMenuItem mniPewdiepie;
        private System.Windows.Forms.ToolStripMenuItem mniJacksepticeye;
        private System.Windows.Forms.ToolStripMenuItem mniMarkiplier;
        private System.Windows.Forms.ToolStripMenuItem mniMrBeast;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grbYoutuber;
        private System.Windows.Forms.Label lblsubcount;
        private System.Windows.Forms.PictureBox picYoutuber;
    }
}

