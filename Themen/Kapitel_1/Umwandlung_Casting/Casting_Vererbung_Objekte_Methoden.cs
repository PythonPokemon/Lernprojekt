using System;

namespace Lernprojekt.Themen.Kapitel_1.Umwandlung_Casting
{
    class A
    {
        // Eigenschaften und Methoden von A
        public void Methode_A()
        {
            Console.WriteLine("Method of class A");
        }
    }

    class B : A
    {
        // Eigenschaften und Methoden von B
        public void Methode_B()
        {
            Console.WriteLine("Method of class B");
        }
    }

    public class Casting_Vererbung_Objekte_Methoden
    {
        public static void Methode()
        {
            // Instanz der Klasse A
            A a1 = new A();
            a1.Methode_A(); // Erlaubt

            // Instanz der Klasse B, referenziert durch A
            A a2 = new B();
            a2.Methode_A(); // Erlaubt, aber die Methode von B wird ausgeführt, wenn überschrieben
            // a2.Methode_B(); // Nicht erlaubt, da a2 vom Typ A ist

            // Instanz der Klasse B
            B b1 = new B();
            b1.Methode_A(); // Erlaubt, weil B von A erbt
            b1.Methode_B(); // Erlaubt

            // Dies ist nicht erlaubt und verursacht einen Kompilierfehler
            // B b2 = new A(); // Kompilierfehler: incompatible types: A cannot be converted to B

            // Demonstration von Castings
            if (a2 is B b2)
            {
                b2.Methode_B(); // Jetzt erlaubt, da a2 tatsächlich eine Instanz von B ist
            }
        }
    }
}
