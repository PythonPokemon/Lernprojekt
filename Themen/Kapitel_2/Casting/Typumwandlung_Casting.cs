using System;

namespace Lernprojekt.Themen.Kapitel_2.Casting
{
    public class Typumwandlung_Casting
    {
        public static void Methode()
        {
            // 1. Implizites Casting (Widening) | Kleineren zu einem größeren Typ | Information geht nicht verloren
            int myInt = 100;
            long myLong = myInt; // Implizites Casting von int zu long
            float myFloat = myLong; // Implizites Casting von long zu float

            Console.WriteLine(myInt);
            Console.WriteLine(myLong);
            Console.WriteLine(myFloat);

            // 2. Explizites Casting (Narrowing) | Größeren zu einem kleineren Typ | Informationen können verloren gehen
            double myDouble = 9.78;

            int myInt2 = (int)myDouble; // Explizites Casting von double zu int | Variante 1 | über den Bezeichner
            int myInt3 = (int)9.78;     // Explizites Casting von double zu int | Variante 2 | über den Wert
            Console.WriteLine(myInt2);
            Console.WriteLine(myInt3);

            // 3. Casting von Wrapper-Klassen | Integer, Double, Float, etc. können auch explizit gecastet werden
            int myInteger2 = 10;

            double myDouble2 = (double)myInteger2; // Explizites Casting notwendig
            double myDouble3 = (double)10;
            Console.WriteLine(myDouble2);
            Console.WriteLine(myDouble3);

            // 4. Autoboxing und Unboxing | Automatische Konvertierung zwischen primitiven Datentypen und ihren Wrapper-Klassen
            int myInt4 = 14;

            // In C# gibt es keinen expliziten "Autoboxing"-Mechanismus, aber die Konvertierung von int zu Integer erfolgt automatisch:
            int myInteger4 = myInt4; // Das entspricht dem Wert von myInt4
            int anotherInt = myInteger4; // Unboxing

            Console.WriteLine(myInt4);
            Console.WriteLine(myInteger4);
            Console.WriteLine(anotherInt);

            // 5. Trainingsbereich
            Console.WriteLine();
        }
    }
}
