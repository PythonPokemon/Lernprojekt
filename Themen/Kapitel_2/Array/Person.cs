using System;

namespace Lernprojekt.Themen.Kapitel_2.Array
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Konstruktor der Person-Klasse
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Methode zur Rückgabe der Personendetails als String
        public string GetDetails()
        {
            return Name + ", " + Age + " years old";
        }
    }

    // Test-Klasse kann als 'internal' deklariert werden, wenn sie nicht von außerhalb des Namespace verwendet werden soll
    internal class Test
    {
        public static void Methode()
        {
            // Erstellen eines Arrays von Person-Objekten mit einer Länge von 3
            Person[] persons = new Person[3];
            Person[] persons2 = persons; // Deklaration einer neuen Referenzvariable 'persons2' und Zuweisung von 'persons'

            // Zu diesem Zeitpunkt ist persons: [null, null, null]

            // Initialisieren der Elemente des Arrays mit Person-Objekten
            persons[0] = new Person("Alice", 30);
            persons[1] = new Person("Bob", 25);
            persons[2] = new Person("Charlie", 35);

            // Ausgabe der Personen im Array
            Console.WriteLine("persons:");
            Console.WriteLine(persons[0].GetDetails());
            Console.WriteLine(persons[1].GetDetails());
            Console.WriteLine(persons[2].GetDetails());

            // Zweite Referenzvariable, die auf dieselben Array-Objekte im Array zeigt
            Console.WriteLine("persons2:");
            Console.WriteLine(persons2[0].GetDetails());
            Console.WriteLine(persons2[1].GetDetails());
            Console.WriteLine(persons2[2].GetDetails());

            // Vergleich der Objekte in den Arrays
            Console.WriteLine(persons[0] == persons[1]); // Ausgabe: False, weil sie unterschiedliche Objekte sind

            // Ausgabe der Details jeder Person im Array
            for (int i = 0; i < persons.Length; i++)
            {
                // Holen der Personendetails
                string details = persons[i].GetDetails();
                // Ausgabe der Details
                Console.WriteLine(details);
            }
        }
    }
}
