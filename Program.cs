using System;
using System.Data;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int start_zahl = 0;

            Console.Write("Gib eine Startzahl ein: ");
            string? input = Console.ReadLine();

            if ( !int.TryParse(input, out start_zahl))
            {
                Console.WriteLine("ungültige eingabe");
                return;
            }

            start_zahl = int.Parse(input);

            for ( int i = start_zahl ; i > 0 ; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Start!");
        }
    }
}