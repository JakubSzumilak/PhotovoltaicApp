
namespace Projekt
{
    partial class Form1
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
            this.WprowadzButton = new System.Windows.Forms.Button();
            this.OdczytajButton = new System.Windows.Forms.Button();
            this.ZaladujButton = new System.Windows.Forms.Button();
            this.MiesiaceListBox = new System.Windows.Forms.ListBox();
            this.WybierzRokLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WprowadzButton
            // 
            this.WprowadzButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WprowadzButton.Location = new System.Drawing.Point(78, 118);
            this.WprowadzButton.Name = "WprowadzButton";
            this.WprowadzButton.Size = new System.Drawing.Size(126, 45);
            this.WprowadzButton.TabIndex = 0;
            this.WprowadzButton.Text = "Wprowadź";
            this.WprowadzButton.UseVisualStyleBackColor = true;
            this.WprowadzButton.Click += new System.EventHandler(this.WprowadzButton_Click);
            // 
            // OdczytajButton
            // 
            this.OdczytajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdczytajButton.Location = new System.Drawing.Point(210, 118);
            this.OdczytajButton.Name = "OdczytajButton";
            this.OdczytajButton.Size = new System.Drawing.Size(126, 45);
            this.OdczytajButton.TabIndex = 1;
            this.OdczytajButton.Text = "Odczytaj";
            this.OdczytajButton.UseVisualStyleBackColor = true;
            this.OdczytajButton.Click += new System.EventHandler(this.OdczytajButton_Click);
            // 
            // ZaladujButton
            // 
            this.ZaladujButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZaladujButton.Location = new System.Drawing.Point(78, 67);
            this.ZaladujButton.Name = "ZaladujButton";
            this.ZaladujButton.Size = new System.Drawing.Size(258, 45);
            this.ZaladujButton.TabIndex = 2;
            this.ZaladujButton.Text = "Załaduj dane";
            this.ZaladujButton.UseVisualStyleBackColor = true;
            this.ZaladujButton.Click += new System.EventHandler(this.ZaladujButton_Click);
            // 
            // MiesiaceListBox
            // 
            this.MiesiaceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MiesiaceListBox.FormattingEnabled = true;
            this.MiesiaceListBox.ItemHeight = 31;
            this.MiesiaceListBox.Items.AddRange(new object[] {
            "Styczeń",
            "Luty",
            "Marzec",
            "Kwiecień",
            "Maj",
            "Czerwiec",
            "Lipiec",
            "Sierpień",
            "Wrzesień",
            "Październik",
            "Listopad",
            "Grudzień"});
            this.MiesiaceListBox.Location = new System.Drawing.Point(484, 12);
            this.MiesiaceListBox.Name = "MiesiaceListBox";
            this.MiesiaceListBox.Size = new System.Drawing.Size(304, 376);
            this.MiesiaceListBox.TabIndex = 3;
            this.MiesiaceListBox.SelectedValueChanged += new System.EventHandler(this.MiesiaceListBox_SelectedValueChanged);
            // 
            // WybierzRokLabel
            // 
            this.WybierzRokLabel.AutoSize = true;
            this.WybierzRokLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WybierzRokLabel.Location = new System.Drawing.Point(12, 9);
            this.WybierzRokLabel.Name = "WybierzRokLabel";
            this.WybierzRokLabel.Size = new System.Drawing.Size(393, 37);
            this.WybierzRokLabel.TabIndex = 7;
            this.WybierzRokLabel.Text = "Wybrany rok: Nie wybrano";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(78, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Zapisz dane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WybierzRokLabel);
            this.Controls.Add(this.MiesiaceListBox);
            this.Controls.Add(this.ZaladujButton);
            this.Controls.Add(this.OdczytajButton);
            this.Controls.Add(this.WprowadzButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WprowadzButton;
        private System.Windows.Forms.Button OdczytajButton;
        private System.Windows.Forms.Button ZaladujButton;
        private System.Windows.Forms.ListBox MiesiaceListBox;
        private System.Windows.Forms.Label WybierzRokLabel;
        private System.Windows.Forms.Button button1;
    }
}

