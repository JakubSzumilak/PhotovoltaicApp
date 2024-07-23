using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class InsertMonth : Form
    {
        public InsertMonth(String NazwaMiesiaca)
        {
            InitializeComponent();
            MiesiacLabel.Text = NazwaMiesiaca;
        }

        protected float Oddane = -1;
        protected float Pobrane = -1;
        protected float Produkcja = -1;

        private void AnulujButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GotoweButton_Click(object sender, EventArgs e)
        {
            Oddane = float.Parse(OddaneBox.Text);
            Pobrane = float.Parse(PobraneBox.Text);
            Produkcja = float.Parse(ProdukcjaBox.Text);

            if (Oddane == -1 || Pobrane == -1 || Produkcja == -1)
            {
                MessageBox.Show("Wprowadź wszystkie odczyty, by kontynuować");
            }
            else
            {
                Form1 f = (Form1)Application.OpenForms["Form1"];
                f.AktualizujMiesiac(Oddane, Pobrane, Produkcja);
                this.Close();
            }
        }
    }
}
