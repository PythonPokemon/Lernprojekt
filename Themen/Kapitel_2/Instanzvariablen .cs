/*
Lokale Variablen
Werden innerhalb von Methoden oder Blöcken deklariert.
Sind nur innerhalb ihres Gültigkeitsbereichs sichtbar.
Müssen vor der ersten Verwendung initialisiert werden.
------------------------------------------------------------------------------------------------------------------------
Instanzvariablen
Werden außerhalb von Methoden, aber innerhalb einer Klasse deklariert.
Gehören zu einer Instanz der Klasse.
Werden automatisch mit Standardwerten initialisiert (z.B. 0 für int, null für Objektreferenzen).
------------------------------------------------------------------------------------------------------------------------
In C# müssen Methoden, die keine statischen Methoden sind, über ein Objekt der Klasse aufgerufen werden.
Dies liegt daran, dass nicht-statische Methoden (Instanzmethoden) an Instanzen der Klasse gebunden sind
und auf die Instanzvariablen und andere Instanzmethoden zugreifen können.
Um eine Instanzmethode aufzurufen, musst du daher ein Objekt der Klasse erstellen.
------------------------------------------------------------------------------------------------------------------------
*/

using System;

namespace Lernprojekt.Themen.Kapitel_2
{
    public class Instanzvariablen // Das ist eine Instanz | Bezeichner Instanzvariable
    {
        // Instanzvariable | in der Klasse, aber außerhalb der Methode
        private int instanzVariable = 20;

        //-----------------------------------Sichtbarkeit lokaler Variablen von hier bis--------------------------------
        public void Methode()
        {
            int lokaleVariable = 10; // Lokale Variable, innerhalb der Methode
            Console.WriteLine("Aufruf der lokalen variable in der Methode: " + lokaleVariable); // Zugriff auf lokale Variable
            Console.WriteLine("Aufruf der field == instanzvariable der Klasse: " +instanzVariable); // Zugriff auf Instanzvariable
        }
        //---------------------------------------bis hier---------------------------------------------------------------

        public static void Aufruf()
        {
            // Erstellung eines Objekts der Klasse, um die Instanzmethode aufzurufen
            Instanzvariablen beispiel = new Instanzvariablen();
            beispiel.Methode(); // Aufruf der Methode, die lokale und Instanzvariablen verwendet
        }

        /*
        Um eine Instanzvariable in einer Methode aufzurufen, braucht man ein Dummy-Objekt.
        Syntax: Klassenname dummyName = new Klassenname();
                dummyName.Methode();
        */
    }
}
