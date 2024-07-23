using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Miesiac
    {

        // Konstruktory
        public Miesiac()
        {
            Produkcja = 0;
            Nazwa = "NO_NAME";
        }

        public Miesiac(string _nazwa = "UNKNOWN", float _oddane = 0.0f, float _pobrane = 0.0f, float _produkcja = 0.0f)
        {
            Oddane = _oddane;
            Pobrane = _pobrane;
            Produkcja = _produkcja;
            Nazwa = _nazwa;
        }

        // Zmienne

        // Odczyt z licznika - energia wyprodukowana
        protected float Produkcja;
        // Rzeczywista produkcja
        public float R_Produkcja = 0;

        // Odczyt z licznika - energia oddana do sieci
        protected float Oddane;
        // Rzeczywista ilość energii oddanej
        public float R_Oddane = 0;

        // Odczyt z licznika - energia pobrana z sieci
        protected float Pobrane;
        // Rzeczywista ilość energii pobranej
        public float R_Pobrane = 0;

        // Nazwa miesiaca
        protected string Nazwa;

        // Getters & Setters

        public float GetProdukcja()
        {
            return Produkcja;
        }

        public float GetOddane()
        {
            return Oddane;
        }

        public float GetPobrane()
        {
            return Pobrane;
        }

        public string GetNazwa()
        {
            return Nazwa;
        }

        public void SetProdukcja(float _produkcja)
        {
            Produkcja = _produkcja;
        }

        public void SetOddane(float _Oddane)
        {
            Oddane = _Oddane;
        }

        public void SetPobrane(float _Pobrane)
        {
            Pobrane = _Pobrane;
        }

        public void SetNazwa(string _Nazwa)
        {
            Nazwa = _Nazwa;
        }

        public void Oblicz(Miesiac PoprzedniMiesiac)
        {
            R_Oddane = Oddane - PoprzedniMiesiac.GetOddane();
            R_Pobrane = Pobrane - PoprzedniMiesiac.GetPobrane();
            R_Produkcja = Produkcja - PoprzedniMiesiac.GetProdukcja();
        }
    }
}
