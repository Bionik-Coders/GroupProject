namespace GroupProject
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
            this.Login = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Username_input = new System.Windows.Forms.TextBox();
            this.Password_input = new System.Windows.Forms.TextBox();
            this.WrongLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(96, 132);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 25);
            this.Login.TabIndex = 0;
            this.Login.Text = "Sign-In";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(59, 60);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(59, 90);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // Username_input
            // 
            this.Username_input.Location = new System.Drawing.Point(120, 57);
            this.Username_input.Name = "Username_input";
            this.Username_input.Size = new System.Drawing.Size(120, 20);
            this.Username_input.TabIndex = 3;
            // 
            // Password_input
            // 
            this.Password_input.Location = new System.Drawing.Point(120, 87);
            this.Password_input.Name = "Password_input";
            this.Password_input.PasswordChar = '*';
            this.Password_input.Size = new System.Drawing.Size(120, 20);
            this.Password_input.TabIndex = 4;
            // 
            // WrongLogin
            // 
            this.WrongLogin.AutoSize = true;
            this.WrongLogin.Location = new System.Drawing.Point(117, 31);
            this.WrongLogin.Name = "WrongLogin";
            this.WrongLogin.Size = new System.Drawing.Size(0, 13);
            this.WrongLogin.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 216);
            this.Controls.Add(this.WrongLogin);
            this.Controls.Add(this.Password_input);
            this.Controls.Add(this.Username_input);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Username_input;
        private System.Windows.Forms.TextBox Password_input;
        private System.Windows.Forms.Label WrongLogin;
    }
}

