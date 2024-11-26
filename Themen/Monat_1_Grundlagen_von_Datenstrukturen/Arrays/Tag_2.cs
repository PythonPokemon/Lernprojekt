using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernprojekt.Themen.Monat_1_Grundlagen_von_Datenstrukturen.Arrays
{
    internal class Tag_2
    {
        // Einstiegspunkt für Tag 2
        public static void Lernen()
        {
            Console.WriteLine("Tag 2: Einführung in verkettete Listen");

            // Erstelle eine einfache verkettete Liste (als List<int>)
            List<int> liste = new List<int>();

            // 1. Werte hinzufügen
            Console.WriteLine("Füge 10, 20 und 30 zur Liste hinzu.");
            liste.Add(10);
            liste.Add(20);
            liste.Add(30);

            // 2. Werte ausgeben
            Console.WriteLine("Aktuelle Liste:");
            foreach (var zahl in liste)
            {
                Console.Write(zahl + " -> ");
            }
            Console.WriteLine("Ende der Liste anzeigen"); // Ende der Liste anzeigen

            // 3. Zusätzliche Werte hinzufügen
            Console.WriteLine("Füge weitere Werte hinzu (40, 50).");
            liste.Add(40);
            liste.Add(50);

            // 4. Aktualisierte Liste ausgeben
            Console.WriteLine("Aktualisierte Liste:");
            foreach (var zahl in liste)
            {
                Console.Write(zahl + " -> ");
            }
            Console.WriteLine("Ende der Liste anzeigen");
        }
    }
}

/*
 Was kannst du jetzt üben?
Vertiefungsübung: Implementiere eine Methode, die überprüft, ob ein bestimmter Wert in der Liste enthalten ist (Contains simulieren).
Listenoperationen: Experimentiere mit anderen Methoden der List<T>, z. B. Remove oder Insert.
 */