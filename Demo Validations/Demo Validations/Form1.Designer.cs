namespace Demo_Validations
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
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnPhone = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbCnic = new System.Windows.Forms.TextBox();
            this.btnCnic = new System.Windows.Forms.Button();
            this.lblCnic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(28, 38);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone Number";
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(140, 61);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(75, 23);
            this.btnPhone.TabIndex = 1;
            this.btnPhone.Text = "Validate";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(112, 35);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(138, 20);
            this.tbPhone.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(111, 141);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(139, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(140, 167);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEmail.TabIndex = 4;
            this.btnEmail.Text = "Validate";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // tbCnic
            // 
            this.tbCnic.Location = new System.Drawing.Point(111, 246);
            this.tbCnic.Name = "tbCnic";
            this.tbCnic.Size = new System.Drawing.Size(141, 20);
            this.tbCnic.TabIndex = 8;
            // 
            // btnCnic
            // 
            this.btnCnic.Location = new System.Drawing.Point(140, 272);
            this.btnCnic.Name = "btnCnic";
            this.btnCnic.Size = new System.Drawing.Size(75, 23);
            this.btnCnic.TabIndex = 7;
            this.btnCnic.Text = "Validate";
            this.btnCnic.UseVisualStyleBackColor = true;
            this.btnCnic.Click += new System.EventHandler(this.btnCnic_Click);
            // 
            // lblCnic
            // 
            this.lblCnic.AutoSize = true;
            this.lblCnic.Location = new System.Drawing.Point(30, 249);
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(32, 13);
            this.lblCnic.TabIndex = 6;
            this.lblCnic.Text = "CNIC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 352);
            this.Controls.Add(this.tbCnic);
            this.Controls.Add(this.btnCnic);
            this.Controls.Add(this.lblCnic);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.lblPhone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbCnic;
        private System.Windows.Forms.Button btnCnic;
        private System.Windows.Forms.Label lblCnic;
    }
}

