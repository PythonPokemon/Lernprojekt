using System;

namespace Lernprojekt.Themen.Kapitel_2.Casting
{
    class Animal
    {
        // Methoden und Felder für die Klasse Animal
    }

    class Dog : Animal
    {
        // Methoden und Felder für die Klasse Dog
    }

    public class ObjektCasting
    {
        public static void Methode()
        {
            // Beispiel 1: Korrektes Casting
            Animal animal = new Dog();
            Dog dog = (Dog)animal; // funktioniert, weil animal tatsächlich ein Dog ist
            Console.WriteLine("Casting von Animal zu Dog erfolgreich.");

            // Beispiel 2: Falsches Casting
            Animal anotherAnimal = new Animal();
            try
            {
                Dog anotherDog = (Dog)anotherAnimal; // wirft InvalidCastException zur Laufzeit
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("InvalidCastException: " + e.Message);
            }
        }
    }
}
