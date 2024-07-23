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
    public partial class ReadMonthForm : Form
    {

        public int rok = 0;
        public ReadMonthForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GotoweButton_Click(object sender, EventArgs e)
        {
            if (RokComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrano roku.", "Błąd");
                return;
            }

            Form1 f = (Form1)Application.OpenForms["Form1"];
            f.ZaladujDane(RokComboBox.SelectedItem.ToString());
            this.Close();
        }

        private void AnulujButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
