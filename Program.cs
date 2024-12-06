using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lernprojekt.Themen.Kapitel_1; // Namespace importieren


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


            //-----------------------------------------------------------------------------------------------------Woche 2: Arbeiten mit Methoden und Klassen



            //-----------------------------------------------------------------------------------------------------
            // Konsole offen halten
            Console.WriteLine("\nDrücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();

        }
    }
}
