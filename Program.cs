using System;
using Lernprojekt.Themen.Kapitel_1; // Namespace importieren
using Lernprojekt.Themen.Kapitel_1.Umwandlung_Casting;
using Lernprojekt.Themen.Kapitel_1.Code_Blöcke;
using Lernprojekt.Themen.Kapitel_2;
using Lernprojekt.Themen.Kapitel_2.Array;
using Lernprojekt.Themen.Kapitel_2.ArrayList;
using Lernprojekt.Themen.Kapitel_2.Casting;


namespace Lernprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Auskommentieren Strg + K + C | Rückgängig Strg + K + U
            // Kapiel 1 
            //-----------------------------------------------------------------------------------------------------Kapiel 1
            //AusdrueckeOperandenOperatoren.Methode();
            //Datentypen.Methode();
            //ObjektDownCastingExplizit.Methode();
            //ObjektReferenz.Methode();
            //Objekt_UpCasting_Implizit.Methode();
            //StringBeispiel.Methode();
            //UmwandlungUndKonvertierung.Methode();
            //Casting_Vererbung_Objekte_Methoden.Methode();
            //Explizite_Umwandlung_Narrowing.Methode();
            //Implizite_Umwandlung_Widening.Methode();
            //// Code_Blöcke
            //Bedingungsblock_ConditionalBlock.Methode();
            //Klassenblock.Methode();
            //Methodenblock.Methode();
            //Schleifenblock_LoopBlock.Methode();

            //-----------------------------------------------------------------------------------------------------Kapiel 2
            // Array
            //Instanzvariablen.Aufruf();
            //LokaleVariable.Beispiel1();
            //LokaleVariable.Beispiel2();
            //LokaleVariable.Beispiel4();
            //PotenzBeispiel.Methode();
            //Quadratzahlen.Methode();
            //StatischeMethode_VS_InstanzMethoden.Methode();
            //StatischeMethode_VS_InstanzMethoden.StatischeMethode();
            //Array_Deklaration_Initialisierung.Methode();
            //Array_Letztes_Element_Index.Methode();
            //// Erstellung eines Objekts der Person-Klasse
            //Themen.Kapitel_2.Array.Person person = new Themen.Kapitel_2.Array.Person("John Doe", 30);
            //// Ausgabe der Personendetails
            //Console.WriteLine(person.GetDetails());
            //TestArray.Methode();

            // ArrayList
            //TestArrayList.Methode();

            // Casting
            ObjektCasting.Methode();
            ObjektCastingInstanceofMethode.Methode();
            Typumwandlung_Casting.Methode();





            //-----------------------------------------------------------------------------------------------------
            // Konsole offen halten
            Console.WriteLine("\nDrücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();

        }
    }
}
