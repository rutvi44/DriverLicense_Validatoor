namespace WinFormsApp1
{
    partial class txtDateofBirth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtLicNumber = new System.Windows.Forms.TextBox();
            this.lblLicNumber = new System.Windows.Forms.Label();
            this.btnCheckDriver = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver Information Checker";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(248, 221);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(532, 218);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 27);
            this.txtName.TabIndex = 3;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(248, 274);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(192, 20);
            this.lblDob.TabIndex = 4;
            this.lblDob.Text = "Date of birth (dd/mm/yyyy)";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(532, 327);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(244, 27);
            this.textHeight.TabIndex = 7;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(248, 327);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(84, 20);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height(cm)";
            // 
            // txtLicNumber
            // 
            this.txtLicNumber.Location = new System.Drawing.Point(532, 375);
            this.txtLicNumber.Name = "txtLicNumber";
            this.txtLicNumber.Size = new System.Drawing.Size(244, 27);
            this.txtLicNumber.TabIndex = 9;
            // 
            // lblLicNumber
            // 
            this.lblLicNumber.AutoSize = true;
            this.lblLicNumber.Location = new System.Drawing.Point(248, 382);
            this.lblLicNumber.Name = "lblLicNumber";
            this.lblLicNumber.Size = new System.Drawing.Size(278, 20);
            this.lblLicNumber.TabIndex = 8;
            this.lblLicNumber.Text = "Licence Number(1 leading char, 14 digit)";
            // 
            // btnCheckDriver
            // 
            this.btnCheckDriver.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckDriver.Location = new System.Drawing.Point(403, 454);
            this.btnCheckDriver.Name = "btnCheckDriver";
            this.btnCheckDriver.Size = new System.Drawing.Size(240, 66);
            this.btnCheckDriver.TabIndex = 10;
            this.btnCheckDriver.Text = "Check Driver";
            this.btnCheckDriver.UseVisualStyleBackColor = true;
            this.btnCheckDriver.Click += new System.EventHandler(this.btn_DriverCheck);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(403, 565);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(41, 20);
            this.error.TabIndex = 11;
            this.error.Text = "Error";
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(532, 274);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(244, 27);
            this.txtDob.TabIndex = 12;
            // 
            // txtDateofBirth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 667);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.error);
            this.Controls.Add(this.btnCheckDriver);
            this.Controls.Add(this.txtLicNumber);
            this.Controls.Add(this.lblLicNumber);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "txtDateofBirth";
            this.Text = "Driver Info Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblName;
        private TextBox txtName;
        private Label lblDob;
        private TextBox textHeight;
        private Label lblHeight;
        private TextBox txtLicNumber;
        private Label lblLicNumber;
        private Button btnCheckDriver;
        private Label error;
        private TextBox txtDob;
    }
}