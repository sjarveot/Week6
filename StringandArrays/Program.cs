using System;

namespace StringandArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi;
            //programm küsib kasutaja eesnime pikkust;

            Console.WriteLine("Sisesta palun oma eesnimi");
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");

        }
    }
}
