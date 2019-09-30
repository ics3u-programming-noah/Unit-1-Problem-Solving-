namespace pizzacostnoah
{
    partial class PizzaCostForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblnotaxanswer = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtdiameter = new System.Windows.Forms.TextBox();
            this.lbltaxanswer = new System.Windows.Forms.Label();
            this.lblnotax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(0, 79);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(503, 29);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Enter the diameter of the pizza (in inches):";
            this.lblQuestion.Click += new System.EventHandler(this.LblQuestion_Click);
            // 
            // lblnotaxanswer
            // 
            this.lblnotaxanswer.AutoSize = true;
            this.lblnotaxanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotaxanswer.Location = new System.Drawing.Point(561, 308);
            this.lblnotaxanswer.Name = "lblnotaxanswer";
            this.lblnotaxanswer.Size = new System.Drawing.Size(59, 31);
            this.lblnotaxanswer.TabIndex = 1;
            this.lblnotaxanswer.Text = "???";
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltax.Location = new System.Drawing.Point(26, 384);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(271, 31);
            this.lbltax.TabIndex = 2;
            this.lbltax.Text = "The cost (with tax) is:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(361, 186);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(198, 54);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtdiameter
            // 
            this.txtdiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiameter.Location = new System.Drawing.Point(567, 79);
            this.txtdiameter.Name = "txtdiameter";
            this.txtdiameter.Size = new System.Drawing.Size(195, 40);
            this.txtdiameter.TabIndex = 4;
            // 
            // lbltaxanswer
            // 
            this.lbltaxanswer.AutoSize = true;
            this.lbltaxanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaxanswer.Location = new System.Drawing.Point(561, 384);
            this.lbltaxanswer.Name = "lbltaxanswer";
            this.lbltaxanswer.Size = new System.Drawing.Size(59, 31);
            this.lbltaxanswer.TabIndex = 5;
            this.lbltaxanswer.Text = "???";
            // 
            // lblnotax
            // 
            this.lblnotax.AutoSize = true;
            this.lblnotax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotax.Location = new System.Drawing.Point(26, 308);
            this.lblnotax.Name = "lblnotax";
            this.lblnotax.Size = new System.Drawing.Size(309, 31);
            this.lblnotax.TabIndex = 6;
            this.lblnotax.Text = "The cost (without tax) is:";
            // 
            // PizzaCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnotax);
            this.Controls.Add(this.lbltaxanswer);
            this.Controls.Add(this.txtdiameter);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbltax);
            this.Controls.Add(this.lblnotaxanswer);
            this.Controls.Add(this.lblQuestion);
            this.Name = "PizzaCostForm";
            this.Text = "Pizza Cost By Noah.C";
            this.Load += new System.EventHandler(this.PizzaCostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblnotaxanswer;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtdiameter;
        private System.Windows.Forms.Label lbltaxanswer;
        private System.Windows.Forms.Label lblnotax;
    }
}

