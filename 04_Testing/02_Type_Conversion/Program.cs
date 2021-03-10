using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ---------------------------------------------------------------------------
/// Übungsserie 02
/// Thema: Type Conversion
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
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie eine weitere Zahl ein:");
            string input2 = Console.ReadLine();

            double value1 = Convert.ToDouble(input1);
            double value2 = Convert.ToDouble(input2);
            Console.WriteLine($"Eingelesene Zahlen:\n{value1}\n{value2}");
        }
    }

    /// <summary>
    /// Aufgabe 1.2 - Lösung
    /// </summary>
    class Solution1_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Seite c in einem rechtwinkligen Dreieck.");
            Console.WriteLine("Bitte geben Sie a ein:");
            string a = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie b ein:");
            string b = Console.ReadLine();

            double c = CalculateC(Convert.ToDouble(a, CultureInfo.InvariantCulture), Convert.ToDouble(b));

            Console.WriteLine($"Die Länge von c ist: {c}");
        }

        static double CalculateC(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }


    /// <summary>
    /// Aufgabe 2.1 - Lösung
    /// </summary>
    public class Solution2_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechnet die Seite c in einem rechtwinkligen Dreieck.");
            Console.WriteLine("Bitte geben Sie a ein:");
            string aInput = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie b ein:");
            string bInput = Console.ReadLine();

            double a;
            double b;

            if (double.TryParse(aInput, out a) && double.TryParse(bInput, NumberStyles.Any, CultureInfo.InvariantCulture, out b))
            {
                double c = CalculateC(a, b);
                Console.WriteLine($"Die Länge von c ist: {c}");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe!");
            }
        }

        public static double CalculateC(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
