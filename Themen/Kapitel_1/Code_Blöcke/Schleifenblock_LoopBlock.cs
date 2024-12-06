/*
Schleifenblock (Loop Block)
Dies ist ein Block, der in einer Schleife wie for, while oder do-while verwendet wird.
------------------------------------------------------------------------------------------------------------------------
Syntax

while (Bedingung) {
    // Block in geschweiften Klammern
    // Dieser Code wird wiederholt ausgeführt, solange die Bedingung wahr ist
}
------------------------------------------------------------------------------------------------------------------------
*/

using System;

namespace Lernprojekt.Themen.Kapitel_1.Code_Blöcke
{
    public class Schleifenblock_LoopBlock
    {
        public static void Methode()
        {
            int i = 0;

            while (i < 5) // Bedingung in runden Klammern
            {
                Console.WriteLine("i: " + i); // Block in geschweiften Klammern
                i++;
            }
        }
    }
}
