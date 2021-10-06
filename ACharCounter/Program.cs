using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime
            //programm küsib sisestada perekonnaime
            //programm kuvab, mitu 'a' tähte on kasutaja eesnimes ja 
            //perekonnanimes on            

            Console.WriteLine("Sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi");
            string LastName = Console.ReadLine();

            string fullname = $"{firstname} {LastName}".ToLower();
           
            int counter = 0;
            
            foreach(char character in fullname)
                if (character == 'a')
                {
                    counter++; //counter = counter +1
                }
            Console.WriteLine($"sinu nimes on {counter} a-tähte");
        }
    }
}
