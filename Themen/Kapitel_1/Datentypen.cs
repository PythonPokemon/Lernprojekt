using System;

namespace Lernprojekt.Themen.Kapitel_1
{
    public class Datentypen
    {
        public static void Methode()
        {
            // Datentyp | Bezeichner | Wert
            int zahl0;      // Dieser Ausdruck wurde nur deklariert, aber nicht initialisiert
            int zahl1 = 1;  // Dieser Ausdruck wurde deklariert & initialisiert, indem der Wert 1 dem Bezeichner zugewiesen wurde
            var zahl2 = 2;  // 'var' stellt automatisch den Datentyp fest, den man mit var deklariert und initialisiert.
            var zahl3 = 3.123;

            // Fließkommazahlen mit den Datentypen
            float f = 3.14f;
            double d = 3.14;

            // Ganzzahlige Datentypen
            byte b = 100;
            short s = 10000;
            int i = 100000;
            long l = 10000000000L;

            // Wahrheitswerte
            bool wahr = true;
            bool falsch = false;

            // Unterstriche in Zahlen
            int zahl = 1_000_000;

            // Alphanumerische Zeichen
            char zeichen = 'A';

            // Gute Namen, schlechte Namen
            int anzahlDerTeilnehmer; // Gut
            int a; // Schlecht

            // Ausgabe der Variablen
            Console.WriteLine("\n" + zahl1);
            Console.WriteLine(zahl2);  // Deswegen wird hier eine 'Ganzzahl' ausgegeben
            Console.WriteLine(zahl3);  // Deswegen wird hier eine 'Gleitkommazahl' ausgegeben
        }
    }
}
