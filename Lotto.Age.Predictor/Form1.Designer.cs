namespace Lotto.Age.Predictor
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mnCalDob = new System.Windows.Forms.MonthCalendar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mnCalDob);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lbldob);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(31, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(23, 73);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(66, 13);
            this.lbldob.TabIndex = 1;
            this.lbldob.Text = "Date of Birth";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 39);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 2;
            // 
            // mnCalDob
            // 
            this.mnCalDob.Location = new System.Drawing.Point(150, 73);
            this.mnCalDob.Name = "mnCalDob";
            this.mnCalDob.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(526, 336);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 382);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar mnCalDob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSubmit;
    }
}

