
namespace Wyscigi
{
    partial class Gra
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
            this.nickGraLLabel = new System.Windows.Forms.Label();
            this.nickGraLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nickGraLLabel
            // 
            this.nickGraLLabel.AutoSize = true;
            this.nickGraLLabel.Location = new System.Drawing.Point(33, 9);
            this.nickGraLLabel.Name = "nickGraLLabel";
            this.nickGraLLabel.Size = new System.Drawing.Size(43, 17);
            this.nickGraLLabel.TabIndex = 0;
            this.nickGraLLabel.Text = "NICK:";
            // 
            // nickGraLabel
            // 
            this.nickGraLabel.AutoSize = true;
            this.nickGraLabel.Location = new System.Drawing.Point(82, 9);
            this.nickGraLabel.Name = "nickGraLabel";
            this.nickGraLabel.Size = new System.Drawing.Size(30, 17);
            this.nickGraLabel.TabIndex = 1;
            this.nickGraLabel.Text = "text";
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(982, 253);
            this.Controls.Add(this.nickGraLabel);
            this.Controls.Add(this.nickGraLLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 300);
            this.Name = "Gra";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Gra_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gra_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nickGraLLabel;
        private System.Windows.Forms.Label nickGraLabel;
    }
}