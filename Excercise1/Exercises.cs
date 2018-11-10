using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    class Exercises
    {
        /// <summary>
        /// Löse alle durch //AUFGABE gekennzeichneten Aufgaben jeweils durch
        /// eine for-Schleife, eine while-Schleife und eine do-while-Schleife.
        /// Die Erste aufgabe wurde beispielhaft bereits teilweise gelöst (bis auf do-while-Schleife).
        /// Verfahre mit dem Rest der Aufgaben ähnlich.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //AUFGABE 1
            //Zähle die Zahlen von 10 bishin zu 1 herunter und gebe sie auf der Konsole aus.
            //Die Ausgabe soll wie folgt aussehen:
            // "Lösung 1: 10"
            // "Lösung 1: 9"
            // ...
            // "Lösung 1: 1"
            //Hinweis: Die Verwendung des Dekrement-Operators bietet sich hier an

            //LÖSUNG 1 mittels while-Schleife
            Console.WriteLine("LÖSUNG 1: while");
            Console.WriteLine("-------------------------");
            {
                int index = 10;
                while (index > 0)
                {
                    Console.WriteLine("Lösung 1: " + index);
                    index--;
                }
            }
            //Erklärung: Der Code befindet sich in einem separaten Codeblock {}
            //Dadurch können Variablen-Namen (wie index) im folgenden nochmals verwendet werden. 

            Console.WriteLine(); //Leerzeile ausgeben (zur Übersichtlichkeit)

            //LÖSUNG 1 mittels for-Schleife
            Console.WriteLine("LÖSUNG 1: for");
            Console.WriteLine("-------------------------");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Lösung 1: " + i);
            }

            Console.WriteLine();

            //LÖSUNG 1 mittels do-while-Schleife
            Console.WriteLine("LÖSUNG 1: do-while");
            Console.WriteLine("-------------------------");

            //TODO Lösung durch do-while-Schleife

            Console.WriteLine();

            //----------------------------------------------------------------------------
            //AUFGABE 2
            //Addiere die Zahlen von 1 bis 100 und gebe das Ergebnis auf der Konsole aus.
            Console.WriteLine("LÖSUNG 2: while");
            Console.WriteLine("-------------------------");

            //TODO Lösung durch while-Schleife

            Console.WriteLine();

            Console.WriteLine("LÖSUNG 2: for");
            Console.WriteLine("-------------------------");

            //TODO Lösung durch for-Schleife

            Console.WriteLine();

            Console.WriteLine("LÖSUNG 2: do-while");
            Console.WriteLine("-------------------------");

            //TODO Lösung durch do-while-Schleife

            Console.WriteLine();

            //ERGEBNIS 2: 5050
            //----------------------------------------------------------------------------


            //----------------------------------------------------------------------------
            //AUFGABE 3
            //Berchnet die Fakultät von 10 und gebe sie auf der Konsole aus
            //Hinweis: Die Fakultät(!) von 5 wäre zum Beispiel 5! = 1 * 2 * 3 * 4 * 5

            //ERGEBNIS 3: 3628800
            //----------------------------------------------------------------------------


            //----------------------------------------------------------------------------
            //AUFGABE 4
            //Addiere alle gerade Zahlen von 0 bis 1000

            //ERGEBNIS 4: 250500
            //----------------------------------------------------------------------------


            //----------------------------------------------------------------------------
            //AUFGABE 5
            //Addiere alle ungeraden Zahlen von 1 bis 99

            //ERGEBNIS 5: 2500
            //----------------------------------------------------------------------------


            //----------------------------------------------------------------------------
            //AUFGABE 6
            //Gebe alle Primzahlen von 1 bis 1000 aus

            //ERGEBNIS 6: siehe http://www.numere-prime.ro/numerele_prime_pana_la_1000.php?lang=de 
            //----------------------------------------------------------------------------


            Console.WriteLine();
            Console.WriteLine("Drücke eine beliebige Taste um zu beenden...");
            Console.ReadKey();
        }
    }
}
