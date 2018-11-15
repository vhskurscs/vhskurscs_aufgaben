using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class ClassExercise
    {
        /// <summary>
        /// Implementiere die nötigen Klassen des Programms so, dass es sich kompilieren und ausführen lässt.
        /// Hinweis: Erstelle eine Klasse Rechteck mit den im Code aufgeführten Eigenschaften (Properties)
        /// und Methoden.
        /// Hinweis 2: Schlage im Internet nach, die man den Flächeninhalt und Umfang eines Rechteckes
        /// berechnet, wenn du hier Probleme hast (vgl. https://de.wikipedia.org/wiki/Rechteck)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 5.0;
            Rechteck r = new Rechteck(a, b);

            PrintRechteck(r);

            Rechteck r2 = new Rechteck();
            r2.A = 4.0;
            r2.B = 2.0;

            PrintRechteck(r2);
        }

        static void PrintRechteck(Rechteck r)
        {
            Console.WriteLine("--- Rechteck ---");
            Console.WriteLine($"Seitenlängen: [a={r.A} b={r.B}]");
            Console.WriteLine($"Flächeninhalt: {r.Flaecheninhalt()}");
            Console.WriteLine($"Umfang: {r.Umfang()}");
        }
    }
}
