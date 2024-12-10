using System;

namespace Lernprojekt.Themen.Kapitel_2
{
    public class PotenzBeispiel
    {
        public static void Methode()
        {
            // Verwendung der Math.Pow() Methode zur Berechnung der Potenz
            double basis = 2.0;
            double exponent = 3.0;
            double ergebnis = Math.Pow(basis, exponent);

            // Ausgabe des Ergebnisses
            Console.WriteLine($"{basis} hoch {exponent} ist {ergebnis}");
        }
    }
}
