using System;

namespace Lernprojekt.Themen.Kapitel_1
{
    // Beispiel: Wenn Sie eine Klasse Person haben, dann ist Person sowohl der Name der Klasse als auch der Datentyp.
    class Person : A
    {
        // Klassenvariable
        public string name = "lola";
        public string sternzeichen;
        public int alter;
        public static int ARBEITEN = 8;  // statische Variable
    }

    class A
    {
        // Wenn kein explizit definierter Konstruktor erstellt wird, fügt der Compiler einen unsichtbaren 'Konstruktor' implizit hinzu
    }

    public class ObjektReferenz
    {
        public static void Methode()
        {
            string lokaleVariable1 = "C#";
            string lokaleVariable2 = "Java";
            string lokaleVariable3 = "Python";

            // Man kann mehrere Objekte des gleichen Typs einer Klasse erstellen
            A a1 = new A(); // Klasse vom Typ A greift mit der Referenzvariable a1 auf das Objekt A zu
            A a2 = new A();
            A a3 = new A();

            // Damit man ein neues Objekt vom Typ A an den Konstruktor von Person referenzieren kann,
            // muss man entweder die Klasse A an Person vererben oder eine explizite Typumwandlung vollziehen!
            A a4 = new Person(); // Erlaubt, weil Person von A erbt

            // Person p3 = new A(); // <--- warum geht das nicht?

            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine("\n" + "Hier wird die Variable a1 der Variable a3 zugewiesen: " + (a3 = a1));
            Console.WriteLine(a1.Equals(a2)); // false
            Console.WriteLine(a1.Equals(a3)); // true
            Console.WriteLine(ReferenceEquals(a1, a2)); // false
            Console.WriteLine(ReferenceEquals(a1, a3)); // true

            // Ganz ausgeschrieben
            // Person p = new Person();
            //-------------------------
            // Oder in Einzelschritten
            Person p1; // p ist eine Referenzvariable vom Typ Person | Deklaration
            p1 = new Person(); // p wird ein neues Person-Objekt zugewiesen | Initialisierung
            p1.name = "\nDora";
            Person.ARBEITEN = 10; // Zugriff auf statische Variable über den Klassennamen

            Console.WriteLine(p1.name); // die Klassenvariable '.name' wird hier als Attribut übernommen und ausgedrückt
            Console.WriteLine(p1.sternzeichen); // solange nicht initialisiert, springt der Konstruktor stellvertretend ein
            Console.WriteLine(p1.alter); // 0
            Console.WriteLine(Person.ARBEITEN); // Zugriff auf statische Variable

            // Objekt 2 des Typs Person und der Klasse mit Standardkonstruktor Person
            Person p2 = new Person();
            p2.name = "\nSido";
            p2.sternzeichen = "Fisch";
            p2.alter = 49;

            Console.WriteLine(p2.name);
            Console.WriteLine(p2.sternzeichen);
            Console.WriteLine(p2.alter);

            // Zuweisen einer lokalen Variablen an ein Feld des Objekts
            p2.name = lokaleVariable1;
            Console.WriteLine("Name von p2 nach Zuweisung der lokalen Variable: " + p2.name);

            // Nutzung der unbenutzten Variablen
            Console.WriteLine("Lokale Variable2: " + lokaleVariable2);
            Console.WriteLine("Lokale Variable3: " + lokaleVariable3);
        }
    }
}
