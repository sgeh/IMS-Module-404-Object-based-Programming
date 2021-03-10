using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ---------------------------------------------------------------------------
/// Hausaufgaben
/// Thema: Intro / Repetition
/// Author: Silvan Gehrig
/// Version: 1.0
/// -------------------------------------------------------------------- 2021 -
/// </summary>
namespace Bwz.Rappi
{
    /// <summary>
    /// Aufgabe 2.1 - Lösung
    /// </summary>
    class Solution2_1
    {
        static void Main(string[] args)
        {
            string vorname = "";
            string nachname = "";

            // read first name
            vorname = ReadName("Bitte Vorname eingeben:");

            if (vorname != null)
            {
                // read last name
                nachname = ReadName("Bitte Nachname eingeben:");
            }

            // output user data if valid
            if (vorname != null && nachname != null)
            {
                Console.WriteLine($"\n{vorname} {nachname}");
            }
            else
            {
                Console.WriteLine("Eingabe des Vornamens ungültig.");
            }
        }

        private static string ReadName(string message)
        {
            Console.WriteLine(message);
            int anzahlVersuche = 0;
            string name;

            do
            {
                if (anzahlVersuche == 3)
                {
                    return null;
                }

                anzahlVersuche++;
                name = Console.ReadLine();
            }
            while (name.Length < 3);
            return name;
        }
    }
}
