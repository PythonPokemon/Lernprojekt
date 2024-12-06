/*
Klassenblock (Class Block)
Dies ist ein Block, der den Körper einer Klasse definiert.
------------------------------------------------------------------------------------------------------------------------
Syntax

public class KlassenName {
    // Block in geschweiften Klammern
    // Dieser Code definiert Felder, Methoden und Konstruktoren der Klasse
}
------------------------------------------------------------------------------------------------------------------------
*/

using System;

namespace Lernprojekt.Themen.Kapitel_1.Code_Blöcke
{
    public class Person
    {
        public string Name;
        public int Alter;

        // Konstruktor der Klasse 'Person'
        // methodenName(Parametertyp parameterName, auch mehrere möglich: Parametertyp parameterName)
        public Person(string name, int alter)
        {
            this.Name = name;
            this.Alter = alter;
        }

        // Methode um die Parameter der Klasse aus
        public void DetailsAusgabe()
        {
            Console.WriteLine("Name: " + Name + ", Alter: " + Alter);
        }
    }

    // ACHTUNG | es geht immer nur eine 'public' klasse pro datei. !
    public class Klassenblock
    {
        public static void Methode()
        {
            // Instanz von Person erstellen
            Person person = new Person("Max Mustermann", 30);
            person.DetailsAusgabe();  // Details der Person ausgeben
        }
    }
}
