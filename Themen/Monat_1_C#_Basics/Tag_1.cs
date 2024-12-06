using System;

namespace Lernprojekt.Themen.Monat_1_C_Basics
{
    public class Tag_1
    {

        public static void Main()
        {
            // Code, der ausgeführt wird, wenn diese Klasse gestartet wird
            Console.WriteLine("Dies ist Tag 1!");
        }

        // Methode, die grundlegende Variablen demonstriert
        public static void Lernen()
        {
            // Einfache Datentypen
            int ganzeZahl = 42; // Ganze Zahl
            double gleitkommaZahl = 3.14; // Kommazahl
            char einzelnesZeichen = 'A'; // Einzelnes Zeichen
            string text = "Hallo, Welt!"; // Text
            bool wahrheitswert = true; // Wahr/Falsch

            // Ausgabe der Variablen
            Console.WriteLine("Ganze Zahl: " + ganzeZahl);
            Console.WriteLine("Gleitkommazahl: " + gleitkommaZahl);
            Console.WriteLine("Einzelnes Zeichen: " + einzelnesZeichen);
            Console.WriteLine("Text: " + text);
            Console.WriteLine("Wahrheitswert: " + wahrheitswert);

            // Beispiel einer einfachen Berechnung
            int summe = ganzeZahl + 10;
            Console.WriteLine("Summe: " + summe);
        }
    }
}
