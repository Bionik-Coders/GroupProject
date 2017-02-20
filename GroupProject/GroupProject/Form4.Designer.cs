namespace GroupProject
{
    partial class Form4
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
            this.LogedPF = new System.Windows.Forms.Label();
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
            // LogedPF
            // 
            this.LogedPF.AutoSize = true;
            this.LogedPF.Location = new System.Drawing.Point(137, 238);
            this.LogedPF.Name = "LogedPF";
            this.LogedPF.Size = new System.Drawing.Size(78, 13);
            this.LogedPF.TabIndex = 13;
            this.LogedPF.Text = "Loged in as PF";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.LogedPF);
            this.Controls.Add(this.LogOut);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label LogedPF;
    }
}