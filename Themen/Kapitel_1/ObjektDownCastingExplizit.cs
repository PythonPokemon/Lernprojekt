using System;

namespace Lernprojekt.Themen.Kapitel_1
{
    class Elternklasse
    {
    }

    class KindKlasse : Elternklasse
    {
    }

    public class ObjektDownCastingExplizit
    {
        public static void Methode()
        {
            Elternklasse eltern = new KindKlasse();  // Erstellen eines KindKlasse-Objekts und Upcasting auf Elternklasse

            // Umwandlung des fundamentalen Typs, zu der die Referenz zeigt
            // Explizit |<---------| von der 'eltern' Variable in der sich das KindKlassen-Objekt befindet
            KindKlasse kind = (KindKlasse)eltern;  // Explizites Downcasting:
                                                   // Elternklasse-Referenz wird in KindKlasse-Referenz umgewandelt

            /*
            * Das bedeutet, dass die Referenzvariable, die auf das Objekt zeigt, jetzt sowohl auf die Elternklasse
            * als auch auf die Kindklasse verweist:
            */
            Console.WriteLine(eltern);
            Console.WriteLine(kind);
            Console.WriteLine(eltern == kind);
            Console.WriteLine("Kind referenziert ein Objekt vom Typ: " + kind.GetType().Name);
        }
    }
}
