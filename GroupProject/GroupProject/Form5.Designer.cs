namespace GroupProject
{
    partial class Form5
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
            this.LogOut = new System.Windows.Forms.Button();
            this.LogedFs = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(221, 231);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(59, 27);
            this.LogOut.TabIndex = 11;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // LogedFs
            // 
            this.LogedFs.AutoSize = true;
            this.LogedFs.Location = new System.Drawing.Point(139, 238);
            this.LogedFs.Name = "LogedFs";
            this.LogedFs.Size = new System.Drawing.Size(76, 13);
            this.LogedFs.TabIndex = 12;
            this.LogedFs.Text = "Loged in as Fs";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(151, 40);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(63, 25);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LogedFs);
            this.Controls.Add(this.LogOut);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label LogedFs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Submit;
    }
}