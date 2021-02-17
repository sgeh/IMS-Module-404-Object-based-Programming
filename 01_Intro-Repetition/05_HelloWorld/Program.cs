using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ---------------------------------------------------------------------------
/// Übungsserie 05
/// Thema: Hello World in C#
/// Author: Silvan Gehrig
/// Version: 1.0
/// -------------------------------------------------------------------- 2021 -
/// </summary>
namespace Bwz.Rappi
{
    /// <summary>
    /// Aufgabe 1.1 - Lösung
    /// </summary>
    class Solution1_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }

    /// <summary>
    /// Aufgabe 1.2 - Lösung
    /// </summary>
    class Solution1_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for(...)");
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(" > Hello World");
            }
            
            Console.WriteLine("\ndo-while(...)");
            int j = 0;
            do
            {
                Console.WriteLine(" > Hello World");
                ++j;
            }
            while (j < 3);

            Console.WriteLine("\nwhile(...)");
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine(" > Hello World");
                ++k;
            }
        }
    }

    /// <summary>
    /// Aufgabe 1.3 - Lösung
    /// </summary>
    class Solution1_3
    {
        static void Main(string[] args)
        {
            string vorname;
            Console.WriteLine("Bitte Vorname eingeben:");
            vorname = Console.ReadLine();

            string nachname;
            Console.WriteLine("Bitte Nachname eingeben:");
            nachname = Console.ReadLine();

            Console.WriteLine("\n" + vorname + " " + nachname);
        }
    }

    /// <summary>
    /// Aufgabe 1.4 - Lösung
    /// </summary>
    class Solution1_4
    {
        static void Main(string[] args)
        {
            string vorname;
            int vornameRetryCount = 0;
            Console.WriteLine("Bitte Vorname eingeben:");

            do
            {
                vorname = Console.ReadLine();
                if (vorname.Length < 3)
                {
                    vornameRetryCount++;
                }
            }
            while (vorname.Length < 3 && vornameRetryCount < 3);

            if (vornameRetryCount == 3)
            {
                Console.WriteLine("Eingabe des Vornamens ungültig.");
            }
            else
            {
                Console.WriteLine("Bitte Nachname eingeben:");
                string nachname = Console.ReadLine();

                Console.WriteLine("\n" + vorname + " " + nachname);
            }
        }
    }

    /// <summary>
    /// Aufgabe 2.1 - Lösung
    /// </summary>
    class Solution2_1
    {
        static void Main(string[] args)
        {
            string[] output = { "First Entry", "Second Entry", "Third Entry" };
            for (int i = 0; i < output.Length; ++i)
            {
                Console.WriteLine("i=" + i + "; " + output[i]);
            }
        }
    }

    /// <summary>
    /// Aufgabe 2.2 - Lösung
    /// </summary>
    class Solution2_2
    {
        static void Main(string[] args)
        {
            string[] output = { "Bitte den ersten Wert eingeben:", "Bitte den zweiten Wert eingeben:", "Bitte den dritten Wert eingeben:" };
            string[] input = new string[3];
            for (int i = 0; i < output.Length; ++i)
            {
                Console.WriteLine(output[i]);
                input[i] = Console.ReadLine();
            }

            Console.WriteLine("\nEingelesene Werte:");
            for (int i = 0; i < input.Length; ++i)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
