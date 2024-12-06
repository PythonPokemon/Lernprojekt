using System;
using Lernprojekt.Themen.Kapitel_1; // Namespace importieren
using Lernprojekt.Themen.Kapitel_1.Umwandlung_Casting;
using Lernprojekt.Themen.Kapitel_1.Code_Blöcke;


namespace Lernprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kapiel 1 
            //-----------------------------------------------------------------------------------------------------Woche 1: Einstieg in die Programmierung mit C#
            AusdrueckeOperandenOperatoren.Methode();
            Datentypen.Methode();
            ObjektDownCastingExplizit.Methode();
            ObjektReferenz.Methode();
            Objekt_UpCasting_Implizit.Methode();
            StringBeispiel.Methode();
            UmwandlungUndKonvertierung.Methode();
            Casting_Vererbung_Objekte_Methoden.Methode();
            Explizite_Umwandlung_Narrowing.Methode();
            Implizite_Umwandlung_Widening.Methode();
            // Code_Blöcke
            Bedingungsblock_ConditionalBlock.Methode();
            Klassenblock.Methode();
            Methodenblock.Methode();
            Schleifenblock_LoopBlock.Methode();

            //-----------------------------------------------------------------------------------------------------Woche 2: Arbeiten mit Methoden und Klassen



            //-----------------------------------------------------------------------------------------------------
            // Konsole offen halten
            Console.WriteLine("\nDrücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();

        }
    }
}
