namespace WindowsFormsApp1
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtloginPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtloginPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLoginEmail);
            this.panel1.Location = new System.Drawing.Point(406, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 443);
            this.panel1.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Tomato;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(84, 313);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(382, 50);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Admin Login";
            // 
            // txtloginPassword
            // 
            this.txtloginPassword.Location = new System.Drawing.Point(84, 248);
            this.txtloginPassword.Multiline = true;
            this.txtloginPassword.Name = "txtloginPassword";
            this.txtloginPassword.PasswordChar = '*';
            this.txtloginPassword.Size = new System.Drawing.Size(382, 33);
            this.txtloginPassword.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone number Or Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.Location = new System.Drawing.Point(84, 160);
            this.txtLoginEmail.Multiline = true;
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(382, 33);
            this.txtLoginEmail.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1186, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "User Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 694);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtloginPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoginEmail;
        private System.Windows.Forms.Button button1;
    }
}