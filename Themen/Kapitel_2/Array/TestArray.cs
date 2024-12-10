using System;

namespace Lernprojekt.Themen.Kapitel_2.Array
{
    public class TestArray
    {
        public static void Methode()
        {
            // Erstellen und Initialisieren eines Arrays von Strings mit einer festen Größe von 3
            string[] strArr = { "Alice", "Bob", "Charlie" };

            // Ausgabe der Elemente des Arrays
            foreach (string str in strArr)
            {
                Console.WriteLine(str); // Ausgabe: Alice, Bob, Charlie
            }
        }
    }
}
