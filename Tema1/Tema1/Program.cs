using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Program // declarare clasa
    {
        static void Main(string[] args) // declarare metoda main
        {
            Laptop laptop = new Laptop();  // instantiere clasa laptop in variabila laptop, rezultatul instantierii este un obiect
            laptop.AfiseazaAtribute();  
            laptop.culoare = "negru";
            laptop.DescarcaBaterie(30); 
            laptop.AfiseazaAtribute();

            Console.WriteLine(laptop.ModificaLungime(1));

            int rezultat = laptop.ModificaLungime(1) + laptop.ModificaLungime(2);

            laptop.IncarcaBaterie(28); 
            laptop.AfiseazaAtribute();

            Console.WriteLine(rezultat);

            Console.ReadKey();
        }

    }


}




    
