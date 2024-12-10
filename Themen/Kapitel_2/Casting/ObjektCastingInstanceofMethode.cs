using System;

namespace Lernprojekt.Themen.Kapitel_2.Casting
{
    class AnimalClass
    {
        // Methoden und Felder für die Klasse Animal
    }

    class DogClass : AnimalClass
    {
        // Methoden und Felder für die Klasse Dog
    }

    class CatClass : AnimalClass
    {
        // Methoden und Felder für die Klasse Cat
    }

    public class ObjektCastingInstanceofMethode
    {
        public static void Methode()
        {
            // Beispiel 1: Korrektes Casting mit 'is' Überprüfung
            AnimalClass animal = new DogClass();
            if (animal is DogClass)
            {
                DogClass dog = (DogClass)animal;
                Console.WriteLine("Casting von Animal zu Dog erfolgreich.");
            }
            else
            {
                Console.WriteLine("animal ist kein Dog und kann nicht gecastet werden.");
            }

            // Beispiel 2: Falsches Casting vermeiden mit 'is' Überprüfung
            AnimalClass anotherAnimal = new AnimalClass();
            if (anotherAnimal is DogClass)
            {
                DogClass anotherDog = (DogClass)anotherAnimal;
                Console.WriteLine("Casting von Animal zu Dog erfolgreich.");
            }
            else
            {
                Console.WriteLine("anotherAnimal ist kein Dog und kann nicht gecastet werden.");
            }

            // Beispiel 3: Casting zu einem anderen Typ mit 'is' Überprüfung
            AnimalClass yetAnotherAnimal = new CatClass();
            if (yetAnotherAnimal is DogClass)
            {
                DogClass yetAnotherDog = (DogClass)yetAnotherAnimal;
                Console.WriteLine("Casting von Animal zu Dog erfolgreich.");
            }
            else
            {
                Console.WriteLine("yetAnotherAnimal ist kein Dog und kann nicht gecastet werden.");
            }

            // Beispiel 4: Korrektes Casting zu Cat mit 'is' Überprüfung
            if (yetAnotherAnimal is CatClass)
            {
                CatClass yetAnotherCat = (CatClass)yetAnotherAnimal;
                Console.WriteLine("Casting von Animal zu Cat erfolgreich.");
            }
            else
            {
                Console.WriteLine("yetAnotherAnimal ist kein Cat und kann nicht gecastet werden.");
            }
        }
    }
}
