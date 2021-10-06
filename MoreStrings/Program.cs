using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime ja perekonnanime
            //program tervitab kasutajat kasutades tema initsiaalne

            Console.WriteLine("Sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Tere {firstname[0]}. {LastName[0]}.");       
        }
    }
}
