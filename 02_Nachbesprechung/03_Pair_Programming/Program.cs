using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ---------------------------------------------------------------------------
/// Übungsserie 03
/// Thema: Pair Programming
/// Author: Silvan Gehrig
/// Version: 1.0
/// -------------------------------------------------------------------- 2021 -
/// </summary>
namespace Bwz.Rappi
{
    class Solution1
    {
        static void Main(string[] args)
        {
            #region R001

            Console.WriteLine("// --------------------------");
            Console.WriteLine("// Willkommen bei Venti-Pizza");
            Console.WriteLine("// --------------------------");

            #endregion

            #region R002

            Console.WriteLine("Bitte geben Sie Ihre Adresse ein.");
            Console.WriteLine("Vorname:");
            string vorname = Console.ReadLine();

            Console.WriteLine("Nachname:");
            string nachname = Console.ReadLine();

            Console.WriteLine("Adresse:");
            string adresse = Console.ReadLine();

            Console.WriteLine("PLZ:");
            string plz = Console.ReadLine();

            Console.WriteLine("Ort:");
            string ort = Console.ReadLine();

            #endregion

            double margherita = 15.5;
            double funghi = 15.5;
            double calzone = 15.5;

            int margheritaCount = 0;
            int funghiCount = 0;
            int calzoneCount = 0;
            bool hasSelection = true;

            do
            {
                #region R005

                Console.WriteLine("Welche Pizza dürfen wir Ihnen liefern?");
                Console.WriteLine($"   1. Margherita       {margherita,6:0.00} CHF");
                Console.WriteLine($"   2. Funghi           {funghi,6:0.00} CHF");
                Console.WriteLine($"   3. Calzone          {calzone,6:0.00} CHF");
                Console.WriteLine("oder eine andere Eingabe, um Ihre BEstellung abzuschliessen.");

                #endregion

                #region R006

                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        margheritaCount++;
                        break;
                    case "2":
                        funghiCount++;
                        break;
                    case "3":
                        calzoneCount++;
                        break;
                    default:
                        #region R007
                        hasSelection = false;
                        #endregion
                        break;
                }

                #endregion

                if (hasSelection)
                {
                    #region R008

                    Console.WriteLine("Gewählte Pizzen");
                    Console.WriteLine($"{margheritaCount,2}x Margherita         {margheritaCount * margherita,6:0.00} CHF");
                    Console.WriteLine($"{funghiCount,2}x Funghi             {funghiCount * funghi,6:0.00} CHF");
                    Console.WriteLine($"{calzoneCount,2}x Calzone            {calzoneCount * calzone,6:0.00} CHF");

                    #endregion
                }
            }
            while (hasSelection);

            #region R008

            double sumTotal = (margheritaCount * margherita) + (funghiCount * funghi) + (calzoneCount * calzone);
            Console.WriteLine($"TOTAL                  {sumTotal,6:0.00} CHF");
            Console.WriteLine($"                       ==========");

            #endregion
        }
    }

    class Solution1_alt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// --------------------------");
            Console.WriteLine("// Willkommen bei Venti-Pizza");
            Console.WriteLine("// --------------------------");

            bool hasInvalidAddress = false;
            int retryCount = 0;

            #region R003

            do
            {
                Console.WriteLine("Bitte geben Sie Ihre Adresse ein.");
                Console.WriteLine("Vorname:");
                string vorname = Console.ReadLine();

                if (vorname.Length < 2)
                {
                    hasInvalidAddress = true;
                    retryCount++;
                    continue;
                }
                else
                {
                    hasInvalidAddress = false;
                }

                Console.WriteLine("Nachname:");
                string nachname = Console.ReadLine();

                if (nachname.Length < 2)
                {
                    hasInvalidAddress = true;
                    retryCount++;
                    continue;
                }
                else
                {
                    hasInvalidAddress = false;
                }

                Console.WriteLine("Adresse:");
                string adresse = Console.ReadLine();

                Console.WriteLine("PLZ:");
                string plz = Console.ReadLine();

                if (plz.Length < 4)
                {
                    hasInvalidAddress = true;
                    retryCount++;
                    continue;
                }
                else
                {
                    hasInvalidAddress = false;
                }

                Console.WriteLine("Ort:");
                string ort = Console.ReadLine();
            }
            while (hasInvalidAddress && retryCount < 3);

            #endregion
            
            if (!hasInvalidAddress)
            {
                bool orderAgain = false;

                do
                {
                    double margherita = 15.5;
                    double funghi = 15.5;
                    double calzone = 15.5;

                    int margheritaCount = 0;
                    int funghiCount = 0;
                    int calzoneCount = 0;
                    bool hasSelection = true;

                    do
                    {
                        Console.WriteLine("Welche Pizza dürfen wir Ihnen liefern?");
                        Console.WriteLine($"   1. Margherita       {margherita,6:0.00} CHF");
                        Console.WriteLine($"   2. Funghi           {funghi,6:0.00} CHF");
                        Console.WriteLine($"   3. Calzone          {calzone,6:0.00} CHF");
                        string selection = Console.ReadLine();
                        switch (selection)
                        {
                            case "1":
                                margheritaCount++;
                                break;
                            case "2":
                                funghiCount++;
                                break;
                            case "3":
                                calzoneCount++;
                                break;
                            default:
                                hasSelection = false;
                                break;
                        }
                        
                        if (hasSelection)
                        {
                            Console.WriteLine("Gewählte Pizzen");
                            Console.WriteLine($"{margheritaCount,2}x Margherita         {margheritaCount * margherita,6:0.00} CHF");
                            Console.WriteLine($"{funghiCount,2}x Funghi             {funghiCount * funghi,6:0.00} CHF");
                            Console.WriteLine($"{calzoneCount,2}x Calzone            {calzoneCount * calzone,6:0.00} CHF");
                        }
                    }
                    while (hasSelection);

                    double sumTotal = (margheritaCount * margherita) + (funghiCount * funghi) + (calzoneCount * calzone);

                    if (sumTotal != 0)
                    {
                        Console.WriteLine($"TOTAL                  {sumTotal,6:0.00} CHF");
                        Console.WriteLine($"                       ==========");
                        orderAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Möchten Sie wirklich keine Pizza bestellen?");
                        orderAgain = (Console.ReadLine() != "J");
                    }
                }
                while (orderAgain);
            }
            else
            {
                #region R004
                Console.WriteLine("Ungültige Eingabe");
                #endregion
            }
        }
    }
}
