/*
Erklärung:
Implizite Umwandlung (Widening): Hier wird der int-Wert automatisch in einen double-Wert umgewandelt, ohne dass Daten verloren gehen.
Explizite Umwandlung (Narrowing): Der double-Wert muss explizit in int umgewandelt werden, da dabei ein möglicher Verlust von Präzision auftreten kann.
Aufwärtsumwandlung (Upcasting): Ein Dog-Objekt wird zu einem Animal-Objekt umgewandelt. Dies geschieht implizit, da Dog eine Unterklasse von Animal ist.
Abwärtsumwandlung (Downcasting): Ein Animal-Objekt wird explizit zu einem Dog-Objekt umgewandelt. Hier muss der Typ sicherstellen, dass es sich tatsächlich um ein Dog handelt.
Konvertierung von String zu int: Hier wird ein String in einen int umgewandelt.
Konvertierung von Object zu String: Das ToString()-Verfahren wird verwendet, um ein Object in einen String zu konvertieren.
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Das Dollarzeichen $ vor einer String-Deklaration in C# bedeutet, dass es sich um ein interpoliertes String-Literal handelt. 

Mit dieser Syntax kannst du Platzhalter in einen String einfügen, die dann zur Laufzeit durch den Wert einer Variablen oder eines Ausdrucks ersetzt werden.

1. String-Interpolation ($-Syntax):
Das Dollarzeichen ermöglicht eine String-Interpolation, bei der Variablen oder Ausdrücke direkt in den String eingefügt werden, ohne dass du + verwenden musst, um den String zusammenzusetzen. 
Du kannst die Variablen direkt in geschweifte Klammern {} einfügen.

Beispiel:
int b = 100;
Console.WriteLine($"Der Wert von b ist: {b}");

Erklärung:
Das $ ermöglicht, dass du den Wert der Variablen b direkt in den String einfügst.

Anstelle von:
Console.WriteLine("Der Wert von b ist: " + b);
kannst du nun die elegantere und lesbarere Version mit String-Interpolation verwenden.
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2. Warum geschweifte Klammern {} verwendet werden:
In der String-Interpolation werden die geschweiften Klammern {} verwendet, um anzugeben, dass an dieser Stelle eine Variable oder ein Ausdruck eingefügt werden soll. 
Innerhalb der Klammern kann jede gültige C#-Ausdruck geschrieben werden, einschließlich Variablen, Methodenaufrufen oder komplexeren Berechnungen.

Beispiel:
int a = 5;
int b = 10;
Console.WriteLine($"Summe: {a + b}");  // Berechnung direkt innerhalb der Interpolation
Hier wird das Ergebnis von a + b berechnet und direkt in den String eingefügt.
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Zusammengefasst:
Das $ steht für String-Interpolation und ermöglicht das Einfügen von Variablen und Ausdrücken in einen String.
Die geschweiften Klammern {} umschließen den Platzhalter, in dem der Wert der Variablen oder der Ausdruck eingefügt wird.
Das macht den Code kürzer, sauberer und lesbarer, da du nicht explizit Strings zusammenfügen musst.
 */

using System;

namespace Lernprojekt.Themen.Kapitel_1
{
    class UmwandlungUndKonvertierung
    {
        public static void Methode()
        {
            // Unterschiedliche Arten der Umwandlung

            // Primitive Typumwandlungen
            int a = 100;
            double b = a;  // Implizite Umwandlung (Widening) von int zu double
            Console.WriteLine($"Implizite Umwandlung (int zu double): {b}");

            double c = 100.04;
            int d = (int)c;  // Explizite Umwandlung (Narrowing) von double zu int
            Console.WriteLine($"Explizite Umwandlung (double zu int): {d}");

            // Referenztypumwandlungen
            Dog dog = new Dog();
            Animal animal = dog;  // Implizite Aufwärtsumwandlung (Upcasting)
            Console.WriteLine($"Implizite Aufwärtsumwandlung (Dog zu Animal): {animal.GetType()}");

            Animal animal2 = new Dog();
            Dog dog2 = (Dog)animal2;  // Explizite Abwärtsumwandlung (Downcasting)
            Console.WriteLine($"Explizite Abwärtsumwandlung (Animal zu Dog): {dog2.GetType()}");

            // Konvertierungen
            string str = "123";
            int number = int.Parse(str);  // Konvertierung von String zu int
            Console.WriteLine($"Konvertierung von String zu int: {number}");

            object obj = 123;
            string strObj = obj.ToString();  // Konvertierung von Object zu String
            Console.WriteLine($"Konvertierung von Object zu String: {strObj}");
        }
    }

    class Animal { }

    class Dog : Animal { }
}
