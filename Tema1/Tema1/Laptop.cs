using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Laptop // declara clasa Laptop
    {
        public string culoare = "gri"; // declara atributul culoare si am atribuit valoarea gri
        public string sistemDeOperare = "windows";
        public int baterie = 100;
        public int lungime = 38;
        public int latime = 25;

        public void AfiseazaAtribute()
        {
            Console.WriteLine($"Culoare: {culoare}, Sistem de operare: {sistemDeOperare}, Baterie {baterie}, Diagonala {Diagonala()}," +
                $" Lungime {lungime}, Latime {latime}");

        }

        public int ModificaLungime(int lungimenoua)
        {
            lungime = lungime + lungimenoua;

            return lungime;
        }

        public double CalculDiagonala(int a, int b)
        {
            var ipotenuzaLaPatrat = a * a + b * b;
            return Math.Sqrt(ipotenuzaLaPatrat); // radical 
        }

        public double Diagonala()
        {
            return CalculDiagonala(lungime, latime);
        }

        public void DescarcaBaterie(int x)
        {
            baterie = baterie - x;
        }

        public void IncarcaBaterie(int y)
        {
            baterie = baterie + y;
        }

    }
}



