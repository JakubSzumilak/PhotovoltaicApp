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
    public partial class MonthShowcase : Form
    {
        public MonthShowcase()
        {
            InitializeComponent();
        }

        public void LoadData(List<Miesiac> MiesiacList)
        {


            for (int i = 1; i <= MiesiacList.Count - 1; i++)
            {
                String Name = "OddaneLB" + i.ToString();
                Label lb = (Label)Controls.Find(Name, false)[0];
                lb.Text = MiesiacList[i].GetOddane().ToString();

                Name = "PobraneLB" + i.ToString();
                lb = (Label)Controls.Find(Name, false)[0];
                lb.Text = MiesiacList[i].GetPobrane().ToString();

                Name = "ProdukcjaLB" + i.ToString();
                lb = (Label)Controls.Find(Name, false)[0];
                lb.Text = MiesiacList[i].GetProdukcja().ToString();

                Name = "ROddaneLB" + i.ToString();
                lb = (Label)Controls.Find(Name, false)[0];
                lb.Text = MiesiacList[i].R_Oddane.ToString();

                Name = "RPobraneLB" + i.ToString();
                lb = (Label)Controls.Find(Name, false)[0];
                lb.Text = MiesiacList[i].R_Pobrane.ToString();

                Name = "RProdukcjaLB" + i.ToString();
                lb = (Label)Controls.Find(Name, false)[0];
                lb.Text = MiesiacList[i].R_Produkcja.ToString();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ROddaneLB12_Click(object sender, EventArgs e)
        {

        }
    }
}
