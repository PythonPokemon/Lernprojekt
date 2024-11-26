using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lernprojekt.Themen.Monat_1_Grundlagen_von_Datenstrukturen.Arrays; // Namespace importieren
using Lernprojekt.Themen.Monat_2_Fortgeschrittene_Datenstrukturen;      // Namespace importieren
using Lernprojekt.Themen.Monat_3_Such_und_Sortieralgorithmen;           // Namespace importieren
using Lernprojekt.Themen.Monat_4_Baumstrukturen;                        // Namespace importieren
using Lernprojekt.Themen.Monat_5_Graphen_und_Algorithmen;               // Namespace importieren
using Lernprojekt.Themen.Monat_6_Praxisprojekte_und_Optimierung;        // Namespace importieren

namespace Lernprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tag 1: Arrays Grundlagen");
            Tag_1.Lernen(); // Aufruf der Methode aus der Klasse Tag_1

            Test2.Test2lauf();
            Test3.Test3lauf();
            Test4.Test4lauf();
            Test5.Test5lauf();
            Test6.Test6lauf();

            // Konsole offen halten
            Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();

        }
    }
}
