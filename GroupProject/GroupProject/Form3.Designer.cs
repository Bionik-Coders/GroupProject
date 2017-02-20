namespace GroupProject
{
    partial class Form3
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
            this.LogedAdmin = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogedAdmin
            // 
            this.LogedAdmin.AutoSize = true;
            this.LogedAdmin.Location = new System.Drawing.Point(121, 238);
            this.LogedAdmin.Name = "LogedAdmin";
            this.LogedAdmin.Size = new System.Drawing.Size(94, 13);
            this.LogedAdmin.TabIndex = 9;
            this.LogedAdmin.Text = "Loged in as Admin";
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(221, 231);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(59, 27);
            this.LogOut.TabIndex = 10;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.LogedAdmin);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogedAdmin;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label label1;
    }
}