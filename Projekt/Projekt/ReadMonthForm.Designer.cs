
namespace Projekt
{
    partial class ReadMonthForm
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
            this.RokComboBox = new System.Windows.Forms.ComboBox();
            this.RokLabel = new System.Windows.Forms.Label();
            this.GotoweButton = new System.Windows.Forms.Button();
            this.AnulujButton = new System.Windows.Forms.Button();
            this.WybierzRokLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RokComboBox
            // 
            this.RokComboBox.FormattingEnabled = true;
            this.RokComboBox.Items.AddRange(new object[] {
            "2022",
            "2023"});
            this.RokComboBox.Location = new System.Drawing.Point(106, 72);
            this.RokComboBox.Name = "RokComboBox";
            this.RokComboBox.Size = new System.Drawing.Size(128, 21);
            this.RokComboBox.TabIndex = 3;
            // 
            // RokLabel
            // 
            this.RokLabel.AutoSize = true;
            this.RokLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RokLabel.Location = new System.Drawing.Point(43, 67);
            this.RokLabel.Name = "RokLabel";
            this.RokLabel.Size = new System.Drawing.Size(57, 26);
            this.RokLabel.TabIndex = 2;
            this.RokLabel.Text = "Rok:";
            // 
            // GotoweButton
            // 
            this.GotoweButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GotoweButton.Location = new System.Drawing.Point(144, 219);
            this.GotoweButton.Name = "GotoweButton";
            this.GotoweButton.Size = new System.Drawing.Size(126, 45);
            this.GotoweButton.TabIndex = 4;
            this.GotoweButton.Text = "Gotowe";
            this.GotoweButton.UseVisualStyleBackColor = true;
            this.GotoweButton.Click += new System.EventHandler(this.GotoweButton_Click);
            // 
            // AnulujButton
            // 
            this.AnulujButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AnulujButton.Location = new System.Drawing.Point(12, 219);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(126, 45);
            this.AnulujButton.TabIndex = 5;
            this.AnulujButton.Text = "Anuluj";
            this.AnulujButton.UseVisualStyleBackColor = true;
            this.AnulujButton.Click += new System.EventHandler(this.AnulujButton_Click);
            // 
            // WybierzRokLabel
            // 
            this.WybierzRokLabel.AutoSize = true;
            this.WybierzRokLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WybierzRokLabel.Location = new System.Drawing.Point(39, 8);
            this.WybierzRokLabel.Name = "WybierzRokLabel";
            this.WybierzRokLabel.Size = new System.Drawing.Size(195, 37);
            this.WybierzRokLabel.TabIndex = 6;
            this.WybierzRokLabel.Text = "Wybierz rok:";
            // 
            // ReadMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 276);
            this.Controls.Add(this.WybierzRokLabel);
            this.Controls.Add(this.AnulujButton);
            this.Controls.Add(this.GotoweButton);
            this.Controls.Add(this.RokComboBox);
            this.Controls.Add(this.RokLabel);
            this.Name = "ReadMonthForm";
            this.Text = "ReadMonthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox RokComboBox;
        private System.Windows.Forms.Label RokLabel;
        private System.Windows.Forms.Button GotoweButton;
        private System.Windows.Forms.Button AnulujButton;
        private System.Windows.Forms.Label WybierzRokLabel;
    }
}