namespace Regsitration
{
    partial class Login
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.redirectLogin = new System.Windows.Forms.LinkLabel();
            this.handleLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-235, -133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 717);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(535, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 64);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.redirectLogin);
            this.panel2.Controls.Add(this.handleLogin);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.email);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(561, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 380);
            this.panel2.TabIndex = 1;
            // 
            // redirectLogin
            // 
            this.redirectLogin.AutoSize = true;
            this.redirectLogin.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redirectLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.redirectLogin.Location = new System.Drawing.Point(285, 239);
            this.redirectLogin.Name = "redirectLogin";
            this.redirectLogin.Size = new System.Drawing.Size(67, 16);
            this.redirectLogin.TabIndex = 10;
            this.redirectLogin.TabStop = true;
            this.redirectLogin.Text = "Register";
            this.redirectLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.redirectLogin_LinkClicked);
            // 
            // handleLogin
            // 
            this.handleLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.handleLogin.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleLogin.Location = new System.Drawing.Point(-1, 284);
            this.handleLogin.Name = "handleLogin";
            this.handleLogin.Size = new System.Drawing.Size(404, 41);
            this.handleLogin.TabIndex = 9;
            this.handleLogin.Text = "Login";
            this.handleLogin.UseVisualStyleBackColor = false;
            this.handleLogin.Click += new System.EventHandler(this.handleLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(69, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Haven\'t Registered yet? Click here to ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(101, 187);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(282, 29);
            this.password.TabIndex = 2;
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(101, 127);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(282, 29);
            this.email.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 579);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel redirectLogin;
        private System.Windows.Forms.Button handleLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
    }
}