namespace GroupProject
{
    partial class Form2
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
            this.LogedStLo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(768, 605);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(59, 27);
            this.LogOut.TabIndex = 11;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // LogedStLo
            // 
            this.LogedStLo.AutoSize = true;
            this.LogedStLo.Location = new System.Drawing.Point(675, 612);
            this.LogedStLo.Name = "LogedStLo";
            this.LogedStLo.Size = new System.Drawing.Size(87, 13);
            this.LogedStLo.TabIndex = 12;
            this.LogedStLo.Text = "Loged in as StLo";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 644);
            this.Controls.Add(this.LogedStLo);
            this.Controls.Add(this.LogOut);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label LogedStLo;

    }
}