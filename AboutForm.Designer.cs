namespace FunPro.CW2._10209
{
    partial class AboutForm
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
            this.lbltextpart1 = new System.Windows.Forms.Label();
            this.lbltextpart2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltextpart1
            // 
            this.lbltextpart1.AutoSize = true;
            this.lbltextpart1.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltextpart1.ForeColor = System.Drawing.Color.Black;
            this.lbltextpart1.Location = new System.Drawing.Point(53, 109);
            this.lbltextpart1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltextpart1.Name = "lbltextpart1";
            this.lbltextpart1.Size = new System.Drawing.Size(472, 24);
            this.lbltextpart1.TabIndex = 0;
            this.lbltextpart1.Text = "This desktop application was created for";
            // 
            // lbltextpart2
            // 
            this.lbltextpart2.AutoSize = true;
            this.lbltextpart2.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltextpart2.Location = new System.Drawing.Point(53, 164);
            this.lbltextpart2.Name = "lbltextpart2";
            this.lbltextpart2.Size = new System.Drawing.Size(410, 24);
            this.lbltextpart2.TabIndex = 1;
            this.lbltextpart2.Text = "FunPro Coursework 2 by 00010209";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 342);
            this.Controls.Add(this.lbltextpart2);
            this.Controls.Add(this.lbltextpart1);
            this.Font = new System.Drawing.Font("Gulim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltextpart1;
        private System.Windows.Forms.Label lbltextpart2;
    }
}