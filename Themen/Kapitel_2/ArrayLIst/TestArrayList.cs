using System;
using System.Collections.Generic;

namespace Lernprojekt.Themen.Kapitel_2.ArrayList
{
    class Person
    {
        public string Name { get; set; }
        public string Geschlecht { get; set; }
        public int Alter { get; set; }

        // Expliziter Konstruktor
        public Person(string name, string geschlecht, int alter)
        {
            Name = name;
            Geschlecht = geschlecht;
            Alter = alter;
        }

        // Methode zur Rückgabe der Personendetails als String
        public string GetDetails()
        {
            return $"{Name}: {Geschlecht}: {Alter} Jahre alt";
        }
    }

    public class TestArrayList
    {
        public static void Methode()
        {
            // Erstellen einer List von Person-Objekten
            List<Person> persons = new List<Person>();

            // Hinzufügen von Person-Objekten zur List
            persons.Add(new Person("Alice", "Weiblich", 30));
            persons.Add(new Person("Bob", "Männlich", 25));
            persons.Add(new Person("Charlie", "Divers", 35));

            // Ausgabe der Details jeder Person in der List
            foreach (var person in persons)
            {
                // Holen der Personendetails
                string details = person.GetDetails();
                // Ausgabe der Details
                Console.WriteLine(details);
            }
        }
    }
}
