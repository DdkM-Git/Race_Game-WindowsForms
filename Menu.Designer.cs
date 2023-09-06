
namespace Wyscigi
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.dalejButton = new System.Windows.Forms.Button();
            this.nickLabel = new System.Windows.Forms.Label();
            this.nicktextBox = new System.Windows.Forms.TextBox();
            this.tytułLabel = new System.Windows.Forms.Label();
            this.predkoscListBox = new System.Windows.Forms.ListBox();
            this.predkoscLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(31, 161);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(197, 78);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.HandleStart);
            // 
            // dalejButton
            // 
            this.dalejButton.Enabled = false;
            this.dalejButton.Location = new System.Drawing.Point(87, 116);
            this.dalejButton.Name = "dalejButton";
            this.dalejButton.Size = new System.Drawing.Size(101, 43);
            this.dalejButton.TabIndex = 7;
            this.dalejButton.Text = "DALEJ";
            this.dalejButton.UseVisualStyleBackColor = true;
            this.dalejButton.Click += new System.EventHandler(this.dalejButton_Click);
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.Location = new System.Drawing.Point(31, 74);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(37, 17);
            this.nickLabel.TabIndex = 6;
            this.nickLabel.Text = "nick:";
            // 
            // nicktextBox
            // 
            this.nicktextBox.Location = new System.Drawing.Point(74, 71);
            this.nicktextBox.Name = "nicktextBox";
            this.nicktextBox.Size = new System.Drawing.Size(154, 22);
            this.nicktextBox.TabIndex = 5;
            this.nicktextBox.TextChanged += new System.EventHandler(this.nicktextBox_TextChanged);
            // 
            // tytułLabel
            // 
            this.tytułLabel.AutoSize = true;
            this.tytułLabel.Location = new System.Drawing.Point(84, 35);
            this.tytułLabel.Name = "tytułLabel";
            this.tytułLabel.Size = new System.Drawing.Size(104, 17);
            this.tytułLabel.TabIndex = 4;
            this.tytułLabel.Text = "Podaj swój nick";
            // 
            // predkoscListBox
            // 
            this.predkoscListBox.FormattingEnabled = true;
            this.predkoscListBox.ItemHeight = 16;
            this.predkoscListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.predkoscListBox.Location = new System.Drawing.Point(74, 55);
            this.predkoscListBox.Name = "predkoscListBox";
            this.predkoscListBox.Size = new System.Drawing.Size(120, 84);
            this.predkoscListBox.TabIndex = 8;
            this.predkoscListBox.Visible = false;
            this.predkoscListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // predkoscLabel
            // 
            this.predkoscLabel.AutoSize = true;
            this.predkoscLabel.Location = new System.Drawing.Point(31, 9);
            this.predkoscLabel.Name = "predkoscLabel";
            this.predkoscLabel.Size = new System.Drawing.Size(184, 17);
            this.predkoscLabel.TabIndex = 9;
            this.predkoscLabel.Text = "WYBIERZ PRĘDKOŚĆ GRY";
            this.predkoscLabel.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 251);
            this.Controls.Add(this.predkoscLabel);
            this.Controls.Add(this.predkoscListBox);
            this.Controls.Add(this.dalejButton);
            this.Controls.Add(this.nickLabel);
            this.Controls.Add(this.nicktextBox);
            this.Controls.Add(this.tytułLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button dalejButton;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.TextBox nicktextBox;
        private System.Windows.Forms.Label tytułLabel;
        private System.Windows.Forms.ListBox predkoscListBox;
        private System.Windows.Forms.Label predkoscLabel;
    }
}

