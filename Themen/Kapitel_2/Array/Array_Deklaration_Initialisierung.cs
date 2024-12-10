using System;

namespace Lernprojekt.Themen.Kapitel_2.Array
{
    public class Array_Deklaration_Initialisierung
    {
        public static void Methode()
        {
            // Variante 1: Array-Deklaration mit Dimension
            int[] a = new int[4];

            Console.WriteLine("Gibt die Speicheradresse des Arrays aus ---> " + a +
                              " <--- das auf die Variable a referenziert ist!");

            Console.WriteLine("Gibt vom default-Konstruktor das Element " + a[0] +
                              " aus Index 0 aus, da es nicht initialisiert wurde!");

            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);

            // Variante 2: Array-Deklaration mit Initialisierungswerten
            int[] b = new int[] { 1, 2, 3, 4 }; // Ein Array mit 4 Elementen, initialisiert mit den angegebenen Werten

            Console.WriteLine("Array b Adresse ---> " + b);
            Console.WriteLine("Element an Index 0 von b: " + b[0]);
        }
    }
}
