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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.mniPewdiepie.Size = new System.Drawing.Size(180, 22);
            this.mniPewdiepie.Text = "Pewdiepie";
            this.mniPewdiepie.Click += new System.EventHandler(this.MniPewdiepie_Click);
            // 
            // mniJacksepticeye
            // 
            this.mniJacksepticeye.Name = "mniJacksepticeye";
            this.mniJacksepticeye.Size = new System.Drawing.Size(180, 22);
            this.mniJacksepticeye.Text = "Jacksepticeye";
            // 
            // mniMarkiplier
            // 
            this.mniMarkiplier.Name = "mniMarkiplier";
            this.mniMarkiplier.Size = new System.Drawing.Size(180, 22);
            this.mniMarkiplier.Text = "Markiplier";
            // 
            // mniMrBeast
            // 
            this.mniMrBeast.Name = "mniMrBeast";
            this.mniMrBeast.Size = new System.Drawing.Size(180, 22);
            this.mniMrBeast.Text = "Mr Beast";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(228, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(228, 166);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblInfo);
            this.groupBox1.Location = new System.Drawing.Point(185, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 226);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmYoutubers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmYoutubers";
            this.Text = "Youtubers by Noah.C";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

