using System;

namespace Lernprojekt.Themen.Kapitel_2.IF_Else
{
    public class IF_Else_Anweisung_Erweitert
    {
        public static void Methode()
        {
            int zahl = 100;

            if (zahl > 10)
            {
                Console.WriteLine("Zahl ist größer als 10");
            }
            else if (zahl > 5)
            {
                Console.WriteLine("Zahl ist größer als 5, aber kleiner oder gleich 10");
            }
            else if (zahl > 0)
            {
                Console.WriteLine("Zahl ist größer als 0, aber kleiner oder gleich 5");
            }
            else if (zahl == 0)
            {
                Console.WriteLine("Zahl ist gleich 0");
            }
            else
            {
                Console.WriteLine("Zahl ist kleiner als 0");
            }
        }
    }
}
