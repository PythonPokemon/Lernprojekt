using System;

namespace Lernprojekt.Themen.Kapitel_1.Umwandlung_Casting
{
    public class Implizite_Umwandlung_Widening
    {
        public static void Methode()
        {
            // Beispiel für implizite Umwandlung (Widening)
            //----------------------------------------------------------------------------------------------------
            byte b = 42;
            short s = b;  // implizite Umwandlung von byte zu short
            Console.WriteLine("byte zu short: " + s);
            //----------------------------------------------------------------------------------------------------
            int i = s;  // implizite Umwandlung von short zu int
            Console.WriteLine("short zu int: " + i);
            //----------------------------------------------------------------------------------------------------
            long l = i;  // implizite Umwandlung von int zu long
            double d3 = i;  // implizite Umwandlung von int zu double
            Console.WriteLine("int zu long: " + l);
            Console.WriteLine("int zu double: " + d3);
            //----------------------------------------------------------------------------------------------------
            float f = l;  // implizite Umwandlung von long zu float
            double d4 = l;  // implizite Umwandlung von long zu double
            Console.WriteLine("long zu float: " + f);
            Console.WriteLine("long zu double: " + d4);
            //----------------------------------------------------------------------------------------------------
            double d = f;  // implizite Umwandlung von float zu double
            Console.WriteLine("float zu double: " + d);
            //----------------------------------------------------------------------------------------------------
            char c = 'A'; // 62 weil Char 'A' ASCI / UNI-Code den Platz 65 entspricht

            int i2 = c;  // implizite Umwandlung von char zu int
            long l2 = c;  // implizite Umwandlung von char zu long
            float f2 = c;  // implizite Umwandlung von char zu float
            double d2 = c;  // implizite Umwandlung von char zu double
            Console.WriteLine("char zu int: " + i2);
            Console.WriteLine("char zu long: " + l2);
            Console.WriteLine("char zu float: " + f2);
            Console.WriteLine("char zu double: " + d2);
        }
    }
}
