using System;
using System.Data;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Aufgabe2();
        }

        static void Aufgabe1()
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

        static void Aufgabe2()
        {
            int input;
            int zahl;
            int player1_versuche = 1;
            int player2_versuche = 1;
            bool input_wiederholen = true;
            bool richtige_zahl = false;

            zahl = input_to_int("gib eine zahl ein die dein freund erraten soll: ");
            

            while (true)
            {
                input = input_to_int("Ratte die Zahl: ");

                if ( input == zahl )
                {
                    Console.WriteLine("Richtig erraten! mit " + player1_versuche + " versuche!");
                    break;
                }

                Console.WriteLine("");
            }
        }

        static int input_to_int(string frage)
        {
            while (true)
            {
                Console.Write(frage);
                string? input = Console.ReadLine();

                if ( int.TryParse(input, out int zaz))
                {
                    return int.Parse(input);
                }

                Console.WriteLine("ungültige zahl, versuch nochmal");
            }
            
        }
    }
}