using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        private List<Miesiac> MiesiacList = new List<Miesiac>();
        private List<String> NazwyMiesiecy = new List<String>();

        // używane przy ręcznym wprowadzaniu danych
        public float Wprowadzone_Oddane = -1;
        public float Wprowadzone_Pobrane = -1;
        public float Wprowadzone_Produkcja = -1;

        public Form1()
        {
            InitializeComponent();
            NazwyMiesiecy.Add("Ubiegły Grudzień");
            NazwyMiesiecy.Add("Styczeń");
            NazwyMiesiecy.Add("Luty");
            NazwyMiesiecy.Add("Marzec");
            NazwyMiesiecy.Add("Kwiecień");
            NazwyMiesiecy.Add("Maj");
            NazwyMiesiecy.Add("Czerwiec");
            NazwyMiesiecy.Add("Lipiec");
            NazwyMiesiecy.Add("Sierpień");
            NazwyMiesiecy.Add("Wrzesień");
            NazwyMiesiecy.Add("Październik");
            NazwyMiesiecy.Add("Listopad");
            NazwyMiesiecy.Add("Grudzień");

            MiesiacList.Add(new Miesiac(NazwyMiesiecy[0], 0, 0, 0));
        }

        public bool ZaladujDane(string NazwaPliku)
        {
            WybierzRokLabel.Text = "Wybrany Rok: " + NazwaPliku;
            // Jezeli sa juz jakies dane, usun je
            if (MiesiacList.Count > 1)
            {
                MiesiacList.Clear();
                MiesiacList.Add(new Miesiac(NazwyMiesiecy[0], 0, 0, 0));
            }


            System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\Dane\Dane" + NazwaPliku + ".txt");

            // Niezbedne do obliczen w obecnym roku
            if (!file.EndOfStream)
            {
                Miesiac PoprzedniGrudzien = new Miesiac(file.ReadLine(), float.Parse(file.ReadLine()), float.Parse(file.ReadLine()), float.Parse(file.ReadLine()));
                file.ReadLine();
                MiesiacList[0] = PoprzedniGrudzien;
            }

            int counter = 1;
            while (!file.EndOfStream && counter <= 12)
            {
                string nazwa = file.ReadLine();
                float oddane = float.Parse(file.ReadLine());
                float pobrane = float.Parse(file.ReadLine());
                float produkcja = float.Parse(file.ReadLine());
                if (counter < MiesiacList.Count())
                {
                    MiesiacList[counter].SetNazwa(nazwa);
                    MiesiacList[counter].SetOddane(oddane);
                    MiesiacList[counter].SetPobrane(pobrane);
                    MiesiacList[counter].SetProdukcja(produkcja);
                    MiesiacList[counter].Oblicz(MiesiacList[counter - 1]);
                }
                else
                {
                    Miesiac m = new Miesiac(nazwa, oddane, pobrane, produkcja);
                    m.Oblicz(MiesiacList[counter - 1]);
                    MiesiacList.Add(m);
                }
                file.ReadLine();
                //MiesiacList[counter] = m;
                //MessageBox.Show(m.GetProdukcja().ToString(), m.GetNazwa());
                counter++;
            } 
            file.Close();
            if (counter == 0)
            {
                MessageBox.Show("Nie udało się otworzyć pliku " + NazwaPliku, "UWAGA", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                MessageBox.Show("Plik " + NazwaPliku + " otworzony pomyślnie", "SUKCES", MessageBoxButtons.OK);
                return true;
            }
            
        }

        private void MiesiaceListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("Wybrano nowy miesiąc: " + MiesiaceListBox.SelectedIndex.ToString(), "MIESIĄC ZMIENIONY");
            int i = MiesiaceListBox.SelectedIndex + 1;
            if (i < MiesiacList.Count())
            {
                String Text = "Oddane: " + MiesiacList[i].GetOddane() + "\nPobrane: " + MiesiacList[i].GetPobrane() + "\nProdukcja: " + MiesiacList[i].GetProdukcja()
                    + "\n\nRzeczywite oddane: " + MiesiacList[i].R_Oddane + "\nRzeczywiste pobrane: " + MiesiacList[i].R_Pobrane + "\nRzeczywista produkcja: " + MiesiacList[i].R_Produkcja;
                MessageBox.Show(Text, MiesiacList[i].GetNazwa());
            }
            else
            {
                MessageBox.Show("Miesiac " + MiesiaceListBox.SelectedItem + " nie został jeszcze wprowadzony", "UWAGA");
            }
        }

        private void ZaladujButton_Click(object sender, EventArgs e)
        {
            ReadMonthForm ReadMonth = new ReadMonthForm();
            ReadMonth.Show();
        }

        private void OdczytajButton_Click(object sender, EventArgs e)
        {
            //for (int i = 1; i < MiesiacList.Count(); i++)
            //{
            //    String Text = "Oddane: " + MiesiacList[i].GetOddane() + "\nPobrane: " + MiesiacList[i].GetPobrane() + "\nProdukcja: " + MiesiacList[i].GetProdukcja();
            //    MessageBox.Show(Text, MiesiacList[i].GetNazwa());
            //}

            if (MiesiacList.Count() > 1)
            {
                MonthShowcase MonthShowcase = new MonthShowcase();
                MonthShowcase.LoadData(MiesiacList);
                MonthShowcase.Show();
            }
            else
            {
                MessageBox.Show("Brak danych do wyświetlenia", "BŁĄD", MessageBoxButtons.OK);
            }
        }

        private void WprowadzButton_Click(object sender, EventArgs e)
        {
            int i = MiesiaceListBox.SelectedIndex + 1;

            if (i > MiesiacList.Count() && i != 1)
            {
                MessageBox.Show("Wprwadź najpierw poprzedni miesiąc");
                return;
            }

            if (i == 0)
            {
                MessageBox.Show("Wybierz najpierw miesiąc do wprowadzenia");
                return;
            }

            InsertMonth WprowadzWindow = new InsertMonth(NazwyMiesiecy[i]);
            WprowadzWindow.Show();
        }

        public void AktualizujMiesiac(float Oddane, float Pobrane, float Produkcja)
        {
            int i = MiesiaceListBox.SelectedIndex + 1;
            if (i < MiesiacList.Count())
            {
                MiesiacList[i].SetOddane(Oddane);
                MiesiacList[i].SetPobrane(Pobrane);
                MiesiacList[i].SetProdukcja(Produkcja);
            }
            else
            {
                Miesiac m = new Miesiac(NazwyMiesiecy[i], Oddane, Pobrane, Produkcja);
                MiesiacList.Add(m);
            }
            MiesiacList[i].Oblicz(MiesiacList[i - 1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Zapisz dane
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "ZestawienieEnergetyczne.txt";
            save.Filter = "Tet File | *.txt";
            save.InitialDirectory = @"..\..\Dane\";
            save.RestoreDirectory = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(save.OpenFile());
                file.Flush();
                for (int i = 0; i < MiesiacList.Count; i++)
                {
                    file.WriteLine(MiesiacList[i].GetNazwa());
                    file.WriteLine(MiesiacList[i].GetOddane());
                    file.WriteLine(MiesiacList[i].GetPobrane());
                    file.WriteLine(MiesiacList[i].GetProdukcja());
                    file.WriteLine();
                }

                file.Dispose();
                file.Close();
            }
        }
    }
}
