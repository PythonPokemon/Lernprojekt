/*
Erklärungen:

Nicht-statische Felder (zahlNormal): 
Diese können nicht direkt innerhalb einer statischen Methode (Methode()) verwendet werden, 
da sie Instanzvariablen sind und für den Zugriff eine Instanz der Klasse erforderlich ist.

Statische Felder (zahlStatisch): 
Diese können in einer statischen Methode verwendet werden, da sie zur Klasse selbst und nicht zu einer Instanz gehören.
 */

using System;

namespace Lernprojekt.Themen.Kapitel_2.IF_Else
{
    public class IF_Anweisung_Vermehrt_Statisch
    {
        // Felder
        int zahlNormal = 10; // Nicht-statische Klassenvariablen können nicht in statischen Methoden aufgerufen werden
        static int zahlStatisch = 20; // Statische Klassenvariablen können in statischen Methoden aufgerufen werden

        public static void Methode()
        {
            int zahl = 10;

            // Es können mehrere if-Anweisungen innerhalb der Methode existieren, die auf dieselbe Variable zugreifen
            if (zahl > 5) // Zugriff auf die lokale Variable, nur innerhalb der Methode
            {
                Console.WriteLine("Zahl ist größer als 5");
            }

            if (zahlStatisch > 4) // Zugriff auf die statische Variable
            {
                Console.WriteLine("Die Zahl " + zahlStatisch + " ist größer als 4");
            }
        }
    }
}
