using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;
        private string miejsceZamieszkania;

        public Osoba()
        {
        }
        public Osoba(string imie, string nazwisko, int rok)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rok;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("{0} {1} {2}", this.imie, this.nazwisko, this.rokUrodzenia);
        }
        protected internal int ObliczWiek()
        {
            return DateTime.Now.Year - this.rokUrodzenia;
        }

        public void SetMiejsceZamieszkania(string adres)
        {
            this.miejsceZamieszkania = adres;
        }
    }
}
