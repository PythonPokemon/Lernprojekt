using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lernprojekt.Themen.Arrays; // Namespace importieren

namespace Lernprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tag 1: Arrays Grundlagen");
            Tag_1.Lernen(); // Aufruf der Methode aus der Klasse Tag_1


            // Konsole offen halten
            Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
            Console.ReadKey();

        }
    }
}
