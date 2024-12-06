/*
Bedingungsblock (Conditional Block)
Dies ist ein Block, der in einer Bedingung wie if, else if oder else verwendet wird.
------------------------------------------------------------------------------------------------------------------------
Syntax

if (Bedingung) {
    // Block in geschweiften Klammern
    // Dieser Code wird ausgeführt, wenn die Bedingung wahr ist
}
------------------------------------------------------------------------------------------------------------------------
* */

using System;

namespace Lernprojekt.Themen.Kapitel_1.Code_Blöcke
{
    public class Bedingungsblock_ConditionalBlock
    {
        public static void Methode()
        {
            int x = 10;

            if (x > 5) // Bedingung in runden Klammern
            {
                Console.WriteLine("x ist größer als 5"); // Block in geschweiften Klammern
            }
            else
            {
                Console.WriteLine("x ist kleiner oder gleich 5");
            }
        }
    }
}
