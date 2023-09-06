
namespace Wyscigi
{
    partial class LogInForm
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
            this.Tytuł = new System.Windows.Forms.Label();
            this.nicktextBox = new System.Windows.Forms.TextBox();
            this.nick = new System.Windows.Forms.Label();
            this.dalejButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tytuł
            // 
            this.Tytuł.AutoSize = true;
            this.Tytuł.Location = new System.Drawing.Point(82, 9);
            this.Tytuł.Name = "Tytuł";
            this.Tytuł.Size = new System.Drawing.Size(104, 17);
            this.Tytuł.TabIndex = 0;
            this.Tytuł.Text = "Podaj swój nick";
            this.Tytuł.Click += new System.EventHandler(this.dalejButton_Click);
            // 
            // nicktextBox
            // 
            this.nicktextBox.Location = new System.Drawing.Point(72, 45);
            this.nicktextBox.Name = "nicktextBox";
            this.nicktextBox.Size = new System.Drawing.Size(154, 22);
            this.nicktextBox.TabIndex = 1;
            // 
            // nick
            // 
            this.nick.AutoSize = true;
            this.nick.Location = new System.Drawing.Point(29, 48);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(37, 17);
            this.nick.TabIndex = 2;
            this.nick.Text = "nick:";
            // 
            // dalejButton
            // 
            this.dalejButton.Location = new System.Drawing.Point(85, 91);
            this.dalejButton.Name = "dalejButton";
            this.dalejButton.Size = new System.Drawing.Size(101, 43);
            this.dalejButton.TabIndex = 3;
            this.dalejButton.Text = "DALEJ";
            this.dalejButton.UseVisualStyleBackColor = true;
            this.dalejButton.Click += new System.EventHandler(this.dalejButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.dalejButton);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.nicktextBox);
            this.Controls.Add(this.Tytuł);
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "LogInForm";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nicktextBox;
        private System.Windows.Forms.Label Tytuł;
        private System.Windows.Forms.Label nick;
        private System.Windows.Forms.Button dalejButton;
    }
}