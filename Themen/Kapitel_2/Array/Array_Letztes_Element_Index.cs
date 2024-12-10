using System;
using System.Collections.Generic;

namespace Lernprojekt.Themen.Kapitel_2.Array
{
    public class Array_Letztes_Element_Index
    {
        public static void Methode()
        {
            // List<T> in C#: Äquivalent zu ArrayList in Java
            List<int> al = new List<int>(); // Liste vom Typ int

            // Elemente hinzufügen
            al.Add(111); // Index 0
            al.Add(222); // Index 1

            // Ausgabe der Größe der Liste
            Console.WriteLine("Array Länge ist: " + al.Count); // Anzahl der Elemente (entspricht size() in Java)

            // Zugriff auf Elemente per Index
            Console.WriteLine("Array Index: " + al[0]); // Element an Index 0
            Console.WriteLine("Array Index: " + al[1]); // Element an Index 1

            // Zugriff auf das letzte Element
            if (al.Count > 0) // Überprüfung, ob die Liste nicht leer ist
            {
                Console.WriteLine("Gibt das Element aus dem letzten Index aus: " + al[al.Count - 1]); // Letztes Element
            }
            else
            {
                Console.WriteLine("Die Liste ist leer, kein letztes Element vorhanden.");
            }
        }
    }
}
