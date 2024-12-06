using System;

namespace Lernprojekt.Themen.Kapitel_1.Umwandlung_Casting
{
    public class Explizite_Umwandlung_Narrowing
    {
        public static void Methode()
        {
            // Beispiel für explizite Umwandlung (Narrowing) | das was gewünscht wird, wird in Klammern gesetzt
            double d = 100.04;
            float f = (float)d;  // explizite Umwandlung von double zu float
            Console.WriteLine("double to float: " + f);

            long l = (long)d;  // explizite Umwandlung von double zu long
            Console.WriteLine("double to long: " + l);

            int i = (int)d;  // explizite Umwandlung von double zu int
            Console.WriteLine("double to int: " + i);

            short s = (short)d;  // explizite Umwandlung von double zu short
            Console.WriteLine("double to short: " + s);

            byte b = (byte)d;  // explizite Umwandlung von double zu byte
            Console.WriteLine("double to byte: " + b);

            float f_Wert_F = 10.5F;
            long longFromFloat = (long)f_Wert_F;  // explizite Umwandlung von float zu long
            Console.WriteLine("float to long: " + longFromFloat);

            int intFromFloat = (int)f_Wert_F;  // explizite Umwandlung von float zu int
            Console.WriteLine("float to int: " + intFromFloat);

            short shortFromFloat = (short)f_Wert_F;  // explizite Umwandlung von float zu short
            Console.WriteLine("float to short: " + shortFromFloat);

            byte byteFromFloat = (byte)f_Wert_F;  // explizite Umwandlung von float zu byte
            Console.WriteLine("float to byte: " + byteFromFloat);

            long l2 = 100000L;
            int intFromLong = (int)l2;  // explizite Umwandlung von long zu int
            Console.WriteLine("long to int: " + intFromLong);

            short shortFromLong = (short)l2;  // explizite Umwandlung von long zu short
            Console.WriteLine("long to short: " + shortFromLong);

            byte byteFromLong = (byte)l2;  // explizite Umwandlung von long zu byte
            Console.WriteLine("long to byte: " + byteFromLong);

            int i2 = 65;
            char charValue = (char)i2;  // explizite Umwandlung von int zu char
            Console.WriteLine("int to char: " + charValue);

            short s2 = 100;
            byte byteFromShort = (byte)s2;  // explizite Umwandlung von short zu byte
            Console.WriteLine("short to byte: " + byteFromShort);

            // Es müssen erst Datentypen vorhanden sein, damit man auf diese zugreifen und umwandeln kann
            int i3 = 300;
            float f3 = (float)i3; // Explizite Umwandlung von int zu float
            Console.WriteLine(f3);
        }
    }
}
