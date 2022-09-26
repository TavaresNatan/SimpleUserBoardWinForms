namespace SimpleUserBoard
{
    partial class TestScreen
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
            this.Testtxt = new System.Windows.Forms.TextBox();
            this.Testlbl = new System.Windows.Forms.Label();
            this.Problemslbl = new System.Windows.Forms.Label();
            this.Problemstxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Testtxt
            // 
            this.Testtxt.BackColor = System.Drawing.Color.Black;
            this.Testtxt.ForeColor = System.Drawing.Color.DarkGreen;
            this.Testtxt.Location = new System.Drawing.Point(15, 25);
            this.Testtxt.Multiline = true;
            this.Testtxt.Name = "Testtxt";
            this.Testtxt.ReadOnly = true;
            this.Testtxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Testtxt.Size = new System.Drawing.Size(250, 250);
            this.Testtxt.TabIndex = 0;
            // 
            // Testlbl
            // 
            this.Testlbl.AutoSize = true;
            this.Testlbl.Location = new System.Drawing.Point(12, 9);
            this.Testlbl.Name = "Testlbl";
            this.Testlbl.Size = new System.Drawing.Size(51, 13);
            this.Testlbl.TabIndex = 1;
            this.Testlbl.Text = "Testing...";
            // 
            // Problemslbl
            // 
            this.Problemslbl.AutoSize = true;
            this.Problemslbl.Location = new System.Drawing.Point(278, 9);
            this.Problemslbl.Name = "Problemslbl";
            this.Problemslbl.Size = new System.Drawing.Size(50, 13);
            this.Problemslbl.TabIndex = 2;
            this.Problemslbl.Text = "Problems";
            // 
            // Problemstxt
            // 
            this.Problemstxt.BackColor = System.Drawing.Color.Black;
            this.Problemstxt.ForeColor = System.Drawing.Color.DarkRed;
            this.Problemstxt.Location = new System.Drawing.Point(281, 25);
            this.Problemstxt.Multiline = true;
            this.Problemstxt.Name = "Problemstxt";
            this.Problemstxt.ReadOnly = true;
            this.Problemstxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Problemstxt.Size = new System.Drawing.Size(250, 250);
            this.Problemstxt.TabIndex = 3;
            // 
            // TestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(545, 286);
            this.Controls.Add(this.Problemstxt);
            this.Controls.Add(this.Problemslbl);
            this.Controls.Add(this.Testlbl);
            this.Controls.Add(this.Testtxt);
            this.Name = "TestScreen";
            this.Text = "TestScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Testtxt;
        private System.Windows.Forms.Label Testlbl;
        private System.Windows.Forms.Label Problemslbl;
        private System.Windows.Forms.TextBox Problemstxt;
    }
}