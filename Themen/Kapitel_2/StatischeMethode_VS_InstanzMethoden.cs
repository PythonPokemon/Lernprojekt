using System;

namespace Lernprojekt.Themen.Kapitel_2
{
    public class StatischeMethode_VS_InstanzMethoden
    {
        private int instanzVariable = 42; // Instanzvariable (Field)

        // Statische Methode: Kann nur auf statische Variablen und Methoden zugreifen
        public static void StatischeMethode()
        {
            Console.WriteLine("Dies ist eine statische Methode.");
            // Console.WriteLine(instanzVariable); // Fehler: Kein Zugriff auf Instanzvariable
        }

        // Instanzmethode: Kann auf Instanzvariablen und andere Instanzmethoden zugreifen
        public void InstanzMethode()
        {
            Console.WriteLine("Dies ist eine Instanzmethode.");
            Console.WriteLine("Instanzvariable: " + instanzVariable); // Zugriff auf Instanzvariable
        }

        // Methode zum Testen, statisch aufzurufen
        public static void Methode()
        {
            // Aufruf der statischen Methode
            StatischeMethode();

            // Erstellung eines Objekts für den Aufruf der Instanzmethode
            var obj = new StatischeMethode_VS_InstanzMethoden();
            obj.InstanzMethode();

            // Zweites Objekt, um die Unabhängigkeit von Instanzvariablen zu zeigen
            var obj2 = new StatischeMethode_VS_InstanzMethoden();
            obj2.InstanzMethode();
        }
    }
}
