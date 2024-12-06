using System;

namespace Lernprojekt.Themen.Kapitel_1
{
    class A1
    {
        // Klasseninhalt von A       
    }

    class B1 : A1
    {
        // Klasseninhalt von B1
    }

    public class Objekt_UpCasting_Implizit
    {
        public static void Methode()
        {
            B1 b = new B1(); // Erstellen eines Objekts der Klasse B1
            A1 a = b;         // Implizites Casting von B1 nach A1 (Upcasting)

            Console.WriteLine(b); // Ausgabe des B1-Objekts
            Console.WriteLine(a); // Ausgabe der A1-Referenz, die auf das B1-Objekt verweist

            A1 a1 = new B1(); // Implizites Casting, die Oberklasse hat eine Referenz zum Objekt der Unterklasse
            Console.WriteLine(a1); // Ausgabe des A1-Objekts, das auf das B1-Objekt verweist
        }
    }
}
