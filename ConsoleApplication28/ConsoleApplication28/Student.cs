using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Student: Osoba
    {
        int rok;
        int numerGrupy;
        int numerAlbumu;

        public Student()
        {

        }

        public Student(string imie, string nazwisko, int rokUrodzenia, int rok,int numerGrupy, int numerAlbumu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("{0} {1} {2}", this.rok, this.numerGrupy, this.numerAlbumu);

        }
    }
}
