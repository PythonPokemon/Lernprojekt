/*
Initialisierung von lokalen Variablen

Lokale Variablen müssen initialisiert werden, bevor sie verwendet werden.
Andernfalls führt dies zu einem Compiler-Fehler:
int zahl;
zahl = 5; // Initialisierung
------------------------------------------------------------------------------------------------------------------------
Instanzvariablen sind Variablen, die innerhalb einer Klasse,
aber außerhalb einer Methode deklariert werden und zu einer Instanz der Klasse gehören.
------------------------------------------------------------------------------------------------------------------------
*/

using System;

namespace Lernprojekt.Themen.Kapitel_2
{
    public class LokaleVariable
    {
        // Beispiel 1: Initialisierung und Verwendung innerhalb einer Methode
        public static void Beispiel1()
        {
            int zahl1; // Deklaration der lokalen Variablen
            zahl1 = 5; // Initialisierung der lokalen Variablen
            Console.WriteLine("\n" + zahl1); // Verwendung der initialisierten Variablen
        }

        // Beispiel 2: Initialisierung innerhalb eines Blocks
        public static void Beispiel2()
        {
            if (true)
            {
                int zahl2 = 10; // Deklaration und Initialisierung innerhalb eines Blocks
                Console.WriteLine("\n" + zahl2); // Verwendung der initialisierten Variablen
            }
            // Zahl2 ist außerhalb des Blocks nicht sichtbar
        }

        // Beispiel 3: Fehler bei nicht initialisierter Verwendung
        // In C# führt das Kompilieren von nicht initialisierten lokalen Variablen ebenfalls zu einem Fehler.
        //public static void Beispiel3()
        //{
        //    int zahl3; // Deklaration der lokalen Variablen
        //    Console.WriteLine(zahl3); // Fehler: Variable 'zahl3' wurde nicht initialisiert
        //}

        // Beispiel 4: Initialisierung innerhalb einer Schleife
        public static void Beispiel4()
        {
            for (int i = 0; i < 10; i++)
            {
                int zahl4 = i * 2; // Deklaration und Initialisierung innerhalb der Schleife
                Console.WriteLine("" + zahl4); // Verwendung der initialisierten Variablen
            }
        }
    }
}

/*
Zusammenfassung:
- **Deklaration**: Eine lokale Variable wird mit einem Datentyp und einem Namen deklariert.
- **Initialisierung**: Eine lokale Variable muss vor ihrer ersten Verwendung einen Wert zugewiesen bekommen.
- **Verwendung**: Nach der Initialisierung kann die lokale Variable innerhalb ihres Gültigkeitsbereichs verwendet werden.
- Das Nicht-Initialisieren einer lokalen Variablen vor ihrer Verwendung führt zu einem Compiler-Fehler,
  da C# keine Standardwerte für lokale Variablen vergibt.
*/
