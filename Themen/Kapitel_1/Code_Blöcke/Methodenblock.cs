/*
Methodenblock (Method Block)
Dies ist ein Block, der den Körper einer Methode definiert.
------------------------------------------------------------------------------------------------------------------------
Syntax

Rückgabewert methodenName(Parametertyp parameterName) {
    // Block in geschweiften Klammern
    // Dieser Code wird ausgeführt, wenn die Methode aufgerufen wird
}
------------------------------------------------------------------------------------------------------------------------
*/

using System;

namespace Lernprojekt.Themen.Kapitel_1.Code_Blöcke
{
    public class Methodenblock
    {
        public static void Methode()
        {
            // Eine Instanz der Methodenblock-Klasse erstellen
            Methodenblock mb = new Methodenblock();
            mb.PrintHello();  // Methode aufrufen
        }

        public void PrintHello()
        {
            Console.WriteLine("Hello, World!"); // Block in geschweiften Klammern
        }
    }
}
