﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernprojekt.Themen.Monat_5_Graphen_und_Algorithmen
{
    internal class Test5
    {
        public static void Test5lauf ()
        {

            // 1. Ein Array deklarieren und initialisieren
            int[] zahlen = { 10, 20, 30, 40, 50 };

            // 2. Zugriff auf ein Element des Arrays mit seinem Index
            Console.WriteLine("Erstes Element: " + zahlen[0]);

            // 3. Länge des Arrays anzeigen
            Console.WriteLine("Länge des Arrays: " + zahlen.Length);

            // 4. Alle Elemente des Arrays durchlaufen
            Console.WriteLine("Alle Elemente im Array:");
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine("Index " + i + ": " + zahlen[i]);
            }

            // 5. Elemente bearbeiten
            zahlen[1] = 25; // Das Element an Index 1 wird geändert.
            Console.WriteLine("Geändertes Array:");
            foreach (var zahl in zahlen)
            {
                Console.WriteLine(zahl);
            }
        }
    }
}
