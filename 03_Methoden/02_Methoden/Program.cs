using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ---------------------------------------------------------------------------
/// Übungsserie 02
/// Thema: Methoden
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
            bool eingabenGueltig = true;
            string vorname = "";
            string nachname = "";

            // read first name
            Console.WriteLine("Bitte Vorname eingeben:");
            int anzahlVersucheVorname = 0;

            do
            {
                if (anzahlVersucheVorname == 3)
                {
                    eingabenGueltig = false;
                    break;
                }

                anzahlVersucheVorname++;
                vorname = Console.ReadLine();
            }
            while (vorname.Length < 3);

            if (!eingabenGueltig)
            {
                // read last name
                Console.WriteLine("Bitte Nachname eingeben:");
                int anzahlVersucheNachname = 0;

                do
                {
                    if (anzahlVersucheNachname == 3)
                    {
                        eingabenGueltig = false;
                        break;
                    }

                    anzahlVersucheNachname++;
                    nachname = Console.ReadLine();
                }
                while (nachname.Length < 3);
            }

            // output user data if valid
            if (eingabenGueltig)
            {

                Console.WriteLine($"\n{vorname} {nachname}");
            }
            else
            {
                Console.WriteLine("Eingabe des Namens ungültig.");
            }
        }
    }

    /// <summary>
    /// Demo 1.1 - Vorlage / Hausaufgaben
    /// </summary>
    class Template1_2
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

        static string ReadName(string message)
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

    /// <summary>
    /// Aufgabe 2.1 - Lösung
    /// </summary>
    class Solution2_1
    {
        static void Main(string[] args)
        {
            PrintWithFor();
            PrintWithDoWhile();
            PrintWithWhile();
        }

        static void PrintWithFor()
        {
            Console.WriteLine("for(...)");
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(" > Hello World");
            }
        }

        static void PrintWithDoWhile()
        {
            Console.WriteLine("\ndo-while(...)");
            int j = 0;
            do
            {
                Console.WriteLine(" > Hello World");
                ++j;
            }
            while (j < 3);
        }
        
        static void PrintWithWhile()
        {
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
    /// Aufgabe 2.2 - Lösung
    /// </summary>
    class Solution2_2
    {
        static void Main(string[] args)
        {
            const string hello = " > Hello World";
            PrintWithFor(hello);
            PrintWithDoWhile(hello);
            PrintWithWhile(hello);
        }

        static void PrintWithFor(string helloMessage)
        {
            Console.WriteLine("for(...)");
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine(helloMessage);
            }
        }

        static void PrintWithDoWhile(string helloMessage)
        {
            Console.WriteLine("\ndo-while(...)");
            int j = 0;
            do
            {
                Console.WriteLine(helloMessage);
                ++j;
            }
            while (j < 3);
        }

        static void PrintWithWhile(string helloMessage)
        {
            Console.WriteLine("\nwhile(...)");
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine(helloMessage);
                ++k;
            }
        }
    }


    /// <summary>
    /// Aufgabe 2.3 - Lösung
    /// </summary>
    class Solution2_3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; ++i)
            {
                PrintSquare(i);
            }
        }

        static void PrintSquare(int x)
        {
            Console.WriteLine($"{x * x}");
        }
    }


    /// <summary>
    /// Aufgabe 2.4 - Lösung
    /// </summary>
    class Solution2_4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; ++i)
            {
                Console.Write($"{i}: ");
                PrintMultiplication(i, i);
            }

            for (double j = 0.1; j < 2.1; j = j + 0.1)
            {
                Console.Write($"{j}: ");
                PrintMultiplication(j, j);
            }
        }

        static void PrintMultiplication(int x, int y)
        {
            Console.WriteLine($"{x * y}");
        }

        static void PrintMultiplication(double x, double y)
        {
            Console.WriteLine($"{x * y}");
        }
    }


    /// <summary>
    /// Aufgabe 3.1 - Lösung
    /// </summary>
    class Solution3_1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; ++i)
            {
                Console.WriteLine($"{i}: {Multiply(i, i)}");
            }

            for (double j = 0.1; j < 2.1; j = j + 0.1)
            {
                Console.WriteLine($"{j}: {Multiply(j, j)}");
            }
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }


    /// <summary>
    /// Aufgabe 3.2 - Lösung
    /// </summary>
    class Solution3_2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; ++i)
            {
                int output = 0;
                Multiply(i, i, out output);
                Console.WriteLine($"{i}: {output}");
            }

            for (double j = 0.1; j < 2.1; j = j + 0.1)
            {
                double output = 0;
                Multiply(j, j, out output);
                Console.WriteLine($"{j}: {output}");
            }
        }

        static void Multiply(int x, int y, out int res)
        {
            res = x * y;
        }

        static void Multiply(double x, double y, out double res)
        {
            res = x * y;
        }
    }
}
