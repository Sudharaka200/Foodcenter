namespace WindowsFormsApp1
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtnewAccountPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewAccountEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewAccountPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOldAccountLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 157);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Center";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(370, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Red;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(503, 520);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(382, 50);
            this.btnSignUp.TabIndex = 12;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtnewAccountPhoneNumber
            // 
            this.txtnewAccountPhoneNumber.Location = new System.Drawing.Point(503, 367);
            this.txtnewAccountPhoneNumber.Multiline = true;
            this.txtnewAccountPhoneNumber.Name = "txtnewAccountPhoneNumber";
            this.txtnewAccountPhoneNumber.Size = new System.Drawing.Size(382, 33);
            this.txtnewAccountPhoneNumber.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone number";
            // 
            // txtNewAccountEmail
            // 
            this.txtNewAccountEmail.Location = new System.Drawing.Point(503, 279);
            this.txtNewAccountEmail.Multiline = true;
            this.txtNewAccountEmail.Name = "txtNewAccountEmail";
            this.txtNewAccountEmail.Size = new System.Drawing.Size(382, 33);
            this.txtNewAccountEmail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone number Or Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(497, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Create Your Account";
            // 
            // txtNewAccountPassword
            // 
            this.txtNewAccountPassword.Location = new System.Drawing.Point(503, 459);
            this.txtNewAccountPassword.Multiline = true;
            this.txtNewAccountPassword.Name = "txtNewAccountPassword";
            this.txtNewAccountPassword.PasswordChar = '*';
            this.txtNewAccountPassword.Size = new System.Drawing.Size(382, 33);
            this.txtNewAccountPassword.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // btnOldAccountLogin
            // 
            this.btnOldAccountLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOldAccountLogin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOldAccountLogin.FlatAppearance.BorderSize = 0;
            this.btnOldAccountLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldAccountLogin.Location = new System.Drawing.Point(669, 592);
            this.btnOldAccountLogin.Name = "btnOldAccountLogin";
            this.btnOldAccountLogin.Size = new System.Drawing.Size(216, 50);
            this.btnOldAccountLogin.TabIndex = 15;
            this.btnOldAccountLogin.Text = "Login";
            this.btnOldAccountLogin.UseVisualStyleBackColor = false;
            this.btnOldAccountLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(505, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "I have a Account";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 694);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOldAccountLogin);
            this.Controls.Add(this.txtNewAccountPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtnewAccountPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewAccountEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtnewAccountPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewAccountEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewAccountPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOldAccountLogin;
        private System.Windows.Forms.Label label6;
    }
}