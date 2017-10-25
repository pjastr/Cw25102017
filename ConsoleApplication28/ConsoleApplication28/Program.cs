using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("Jan", "Kowalski", 1990, 2016, 5, 234890);
            //Console.WriteLine(student1.ObliczWiek());
            //student1.SetMiejsceZamieszkania("Olsztyn, Słoneczna 54");
            //Osoba student2 = new Student();
            //Console.WriteLine(student1.ObliczWiek());
            //student2.WypiszInfo();
            //
            Student student3 = new Student();
            Osoba osoba3 = student3;
            Student student4 = (Student)osoba3;
            student4.WypiszInfo();
            Console.ReadKey();
        }
    }
}
