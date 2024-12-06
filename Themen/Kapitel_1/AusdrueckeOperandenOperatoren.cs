/*
Hinweis:

In C# sind Umwandlungen zwischen kompatiblen Datentypen wie byte zu short, short zu int und so weiter automatisch und implizit möglich, 
ohne dass explizite Casts erforderlich sind.
Beim Umwandeln von char zu int oder long wird der numerische Wert des Zeichens (z. B. der ASCII-Code) verwendet.
 */

using System;

namespace Lernprojekt.Themen.Kapitel_1
{
    public class AusdrueckeOperandenOperatoren
    {
       public static void Methode()
        {
            // Zuweisungsoperator: '='
            int zahl0 = 10;
            Console.WriteLine(zahl0);
            //----------------------------------------------------------------------------------------------------------------------
            // Arithmetische Operatoren: + (Addition), - (Subtraktion), * (Multiplikation), / (Division) und % (Modulus)
            int summe = 5 + 3;       // 8
            int differenz = 5 - 3;   // 2
            int produkt = 5 * 3;     // 15
            int quotient = 5 / 3;    // 1
            int rest = 5 % 4;        // 1 | Modulus gibt den Rest an
            Console.WriteLine(summe);
            Console.WriteLine(differenz);
            Console.WriteLine(produkt);
            Console.WriteLine(quotient);
            Console.WriteLine(rest);
            //----------------------------------------------------------------------------------------------------------------------
            // Unäres Minus und Plus - und +
            int positiv = +5;   // 5
            int negativ = -5;   // -5
            Console.WriteLine(positiv);
            Console.WriteLine(negativ);
            //----------------------------------------------------------------------------------------------------------------------
            // Präfix- oder Postfix-Inkrement und -Dekrement
            int x = 5;
            int y = ++x;    // y ist 6, x ist 6 (Präfix)
            int z = x--;    // z ist 6, x ist 5 (Postfix)
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            //----------------------------------------------------------------------------------------------------------------------
            // Zuweisung mit Operation (Verbundoperator): +=, -=, *=, /=, %=
            int zahl1 = 5;
            zahl1 += 3; // zahl ist jetzt 8
            zahl1 *= 2; // zahl ist jetzt 16
            Console.WriteLine(zahl1);

            int zahl2 = zahl1; // zahl2 bekommt den aktuellen Wert von zahl1
            Console.WriteLine(zahl2);

            int zahl3 = 4;
            int ergebnisVerbundoperator = zahl3 + zahl2 + zahl1;
            Console.WriteLine(ergebnisVerbundoperator); // 36
            //----------------------------------------------------------------------------------------------------------------------
            // Relationale Operatoren und Gleichheitsoperatoren:
            bool gleich = (5 == 5);
            bool ungleich = (5 != 3);
            bool kleiner = (3 < 5);
            bool größer = (5 > 3);
            bool kleinerGleich = (5 <= 5);
            bool größerGleich = (3 >= 3);
            Console.WriteLine(gleich);
            Console.WriteLine(ungleich);
            Console.WriteLine(kleiner);
            Console.WriteLine(größer);
            Console.WriteLine(kleinerGleich);
            Console.WriteLine(größerGleich);
            //----------------------------------------------------------------------------------------------------------------------
            // Logische Operatoren: Nicht, Und, Oder, XOR
            bool nicht = !(5 == 5);
            bool und = (5 == 5) && (3 < 5);
            bool oder = (5 == 5) || (3 > 5);
            bool xor = (5 == 5) ^ (3 > 5);
            Console.WriteLine(nicht);
            Console.WriteLine(und);
            Console.WriteLine(oder);
            Console.WriteLine(xor);
            //----------------------------------------------------------------------------------------------------------------------
            // Kurzschluss-Operatoren && und ||
            /*bool kurzschluss1 = (5 > 3) || (5 / 0 == 0); */// true, keine Division durch 0
            bool kurzschluss2 = (5 <= 5 && 1 > 3 || 5 == 5);
            bool testKO1 = ((1 + 3) == 4 && 5 == 5);
            bool testKO2 = (((100 - 65) == 35) || ((1 + 1) == 2));

            bool ergebnisOP = testKO1 == testKO2;
            //Console.WriteLine(kurzschluss1);
            Console.WriteLine(kurzschluss2);
            Console.WriteLine(testKO1);
            Console.WriteLine(testKO2);
            Console.WriteLine(ergebnisOP);
            //----------------------------------------------------------------------------------------------------------------------
            // Der Rang der Operatoren in der Auswertungsreihenfolge
            int ergebnis_1 = 5 + 3 * 2; // ergebnis ist 11
            float ergebnis_2 = 2 + 4 / 2;
            double ergebnis_3 = 2.1 + 2.2;

            Console.WriteLine(ergebnis_1);
            Console.WriteLine(ergebnis_2);
            Console.WriteLine(ergebnis_3);
            //----------------------------------------------------------------------------------------------------------------------
            // Die Typumwandlung (das Casting)
            double gleitkommaZahl = 3.14;
            int zahlCast1 = (int)gleitkommaZahl;
            float zahlCast2 = (float)2;
            Console.WriteLine(zahlCast1);
            Console.WriteLine(zahlCast2);

            int komma_zu_ganzZahl = (int)2.123f;
            float ganzzahlZuKomma = (float)1;
            double großeKommaZahl = (double)9999999;
            Console.WriteLine(komma_zu_ganzZahl);
            Console.WriteLine(ganzzahlZuKomma);
            Console.WriteLine(großeKommaZahl);
            //----------------------------------------------------------------------------------------------------------------------
            // Überladenes Plus für Strings
            string verkettungsFrage = "Hallo " + "Welt " + "wie geht " + "es dir heute?";
            string gesamtAntwort = "Mir geht es gut, danke der nachfrage :-)";
            Console.WriteLine(verkettungsFrage);
            Console.WriteLine(gesamtAntwort);
            //----------------------------------------------------------------------------------------------------------------------
            // Math.Pow() Methode
            double basis = 2.0;
            double exponent = 3.0;
            double ergebnis = Math.Pow(basis, exponent);
            Console.WriteLine($"{basis} hoch {exponent} ist {ergebnis}");
        }
    }
}
