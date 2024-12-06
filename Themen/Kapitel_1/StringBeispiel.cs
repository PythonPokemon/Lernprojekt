using System;

namespace Lernprojekt.Themen.Kapitel_1
{
    public class StringBeispiel
    {
        public static void Methode()
        {
            // Hier wird explizit im String-Pool geprüft, ob das Literal bereits vorhanden ist
            string s1 = "Java"; // String-Literal im String-Pool
            string s2 = "Java"; // Wiederverwendung des String-Literals im String-Pool | Deshalb kein neues Objekt

            // Mit 'new' wird immer ein neues String-Objekt erzeugt, im Heap
            string s3 = new string("Java".ToCharArray()); // Neues String-Objekt im Heap
            string s4 = new string("Java".ToCharArray()); // Wieder ein neues String-Objekt im Heap

            // Vergleicht, ob die Referenzen auf dieselbe Speicheradresse zeigen
            Console.WriteLine(s1 == s2); // true, s1 und s2 referenzieren dasselbe Objekt im String-Pool
            Console.WriteLine(s1 == s3); // false, s1 ist im String-Pool, s3 ist im Heap
            Console.WriteLine(s3 == s4); // false, s3 und s4 sind unterschiedliche Objekte im Heap

            // Inhalte vergleichen
            Console.WriteLine(s1.Equals(s3)); // true, der Inhalt ist gleich
            Console.WriteLine(s3.Equals(s4)); // true, der Inhalt ist gleich

            // Identitätsprüfung mit dem Hashcode
            Console.WriteLine("HashCode von s1: " + s1.GetHashCode());
            Console.WriteLine("HashCode von s2: " + s2.GetHashCode());
            Console.WriteLine("HashCode von s3: " + s3.GetHashCode());
            Console.WriteLine("HashCode von s4: " + s4.GetHashCode());
        }
    }
}
