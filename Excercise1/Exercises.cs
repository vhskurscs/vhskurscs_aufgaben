using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
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
            {
                int index = 10;
                do
                {
                    Console.WriteLine("Lösung 1: " + index);
                    index--;
                } while (index > 0);
            }

            Console.WriteLine();

            //----------------------------------------------------------------------------
            //AUFGABE 2
            //Addiere die Zahlen von 1 bis 100 und gebe das Ergebnis auf der Konsole aus.
            string loesung2 = "Lösung 2: ";
            Console.WriteLine("LÖSUNG 2: while");
            Console.WriteLine("-------------------------");
            {
                int index = 1;
                int counter = 0;
                while(index <= 100)
                {
                    counter += index;
                    index++;
                }
                Console.WriteLine(loesung2 + counter);
            }

            Console.WriteLine();

            Console.WriteLine("LÖSUNG 2: for");
            Console.WriteLine("-------------------------");
            {
                int counter = 0;
                for(int i = 1; i <= 100; i++)
                {
                    counter += i;
                }
                Console.WriteLine(loesung2 + counter);
            }

            Console.WriteLine();

            Console.WriteLine("LÖSUNG 2: do-while");
            Console.WriteLine("-------------------------");
            {
                int index = 1;
                int counter = 0;
                do
                {
                    counter += index;
                    index++;
                } while(index <= 100);
                Console.WriteLine(loesung2 + counter);
            }

            Console.WriteLine();

            //ERGEBNIS 2: 5050
            //----------------------------------------------------------------------------


            //----------------------------------------------------------------------------
            //AUFGABE 3
            //Berchnet die Fakultät von 10 und gebe sie auf der Konsole aus
            //Hinweis: Die Fakultät(!) von 5 wäre zum Beispiel 5! = 1 * 2 * 3 * 4 * 5
            string loesung3 = "Lösung 3: ";
            Console.WriteLine("LÖSUNG 3: while");
            Console.WriteLine("-------------------------");
            {
                int index = 2;
                int counter = 1;
                while(index <= 10)
                {
                    counter *= index;
                    index++;
                }
                Console.WriteLine(loesung3 + counter);
            }
            Console.WriteLine();

            Console.WriteLine("LÖSUNG 3: for");
            Console.WriteLine("-------------------------");
            {
                int counter = 1;
                for (int i = 2; i <= 10; i++)
                {
                    counter *= i;
                }
                Console.WriteLine(loesung3 + counter);
            }
            Console.WriteLine();

            Console.WriteLine("LÖSUNG 3: do-while");
            Console.WriteLine("-------------------------");
            {
                int index = 2;
                int counter = 1;
                do
                {
                    counter *= index;
                    index++;
                } while (index <= 10);
                Console.WriteLine(loesung3 + counter);
            }
            Console.WriteLine();

            //ERGEBNIS 3: 3628800
            //----------------------------------------------------------------------------


            //----------------------------------------------------------------------------
            //AUFGABE 4
            //Addiere alle gerade Zahlen von 0 bis 1000
            string loesung4 = "Lösung 4: ";
            Console.WriteLine("LÖSUNG 4: while");
            Console.WriteLine("-------------------------");
            {
                int index = 2;
                int counter = 0;
                while(index <= 1000)
                {
                    counter += index;
                    index += 2;
                    //if (index % 2 == 0)
                    //    counter += index;
                    //index++;
                }
                Console.WriteLine(loesung4 + counter);
            }
            Console.WriteLine();

            Console.WriteLine("LÖSUNG 4: for");
            Console.WriteLine("-------------------------");
            {
                int counter = 0;
                for (int i = 2; i <= 1000; i+=2)
                {
                    counter += i;
                }
                Console.WriteLine(loesung4 + counter);
            }
            Console.WriteLine();

            Console.WriteLine("LÖSUNG 4: do-while");
            Console.WriteLine("-------------------------");
            {
                int index = 2;
                int counter = 0;
                do
                {
                    counter += index;
                    index += 2;
                } while (index <= 1000);
                Console.WriteLine(loesung4 + counter);
            }
            Console.WriteLine();

            //ERGEBNIS 4: 250500
            //----------------------------------------------------------------------------


            //----------------------------------------------------------------------------
            //AUFGABE 5
            //Addiere alle ungeraden Zahlen von 1 bis 99
            string loesung5 = "Lösung 5: ";
            Console.WriteLine("LÖSUNG 5: while");
            Console.WriteLine("-------------------------");
            {
                int index = 1;
                int counter = 0;
                while(index <= 99)
                {
                    counter += index;
                    index += 2;
                }
                Console.WriteLine(loesung5 + counter);
            }
            Console.WriteLine();

            Console.WriteLine("LÖSUNG 5: for");
            Console.WriteLine("-------------------------");
            {
                int counter = 0;
                for (int i = 1; i <= 99; i+=2)
                {
                    counter += i;
                }
                Console.WriteLine(loesung5 + counter);
            }
            Console.WriteLine();

            Console.WriteLine("LÖSUNG 5: do-while");
            Console.WriteLine("-------------------------");
            {
                int index = 1;
                int counter = 0;
                do
                {
                    counter += index;
                    index += 2;
                } while (index <= 99);
                Console.WriteLine(loesung5 + counter);
            }
            Console.WriteLine();

            //ERGEBNIS 5: 2500
            //----------------------------------------------------------------------------


            //----------------------------------------------------------------------------
            //AUFGABE 6
            //Gebe alle Primzahlen von 1 bis 1000 aus
            //string loesung6 = "Lösung 6: ";
            Console.WriteLine("LÖSUNG 6: while");
            Console.WriteLine("-------------------------");
            {
                int index = 2;
                int counter = 0;
                while(index <= 1000)
                {
                    bool isprim = true;
                    int i = 2;
                    while(i < index)
                    {
                        if (index % i == 0)
                        {
                            isprim = false;
                            //break; //bricht innere Schleife ab, da Ergebnis bereits negativ
                        }
                        i++;
                    }
                    if (isprim)
                    {
                        counter++;
                        Console.WriteLine("Primzahl gefunden: " + i);

                    }
                    index++;
                }
                Console.WriteLine("Primzahlen insgesamt: " + counter);
            }
            Console.WriteLine();

            Console.WriteLine("LÖSUNG 6: for");
            Console.WriteLine("-------------------------");
            {
                int counter = 0;
                for (int i = 2; i < 1000; i++)
                {
                    bool isprim = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isprim = false;
                            //break; //bricht innere Schleife ab, da Ergebnis bereits negativ
                        }
                            
                    }
                    if (isprim)
                    {
                        counter++;
                        Console.WriteLine("Primzahl gefunden: " + i);
                    }
                }
                Console.WriteLine("Primzahlen insgesamt: " + counter);
                //Console.WriteLine(loesung6 + counter);
            }
            Console.WriteLine();

            Console.WriteLine("LÖSUNG 6: do-while");
            Console.WriteLine("-------------------------");
            {
                int index = 2;
                int counter = 0;
                do
                {
                    bool isprim = true;
                    int i = 2;
                    while (i < index)
                    {
                        if (index % i == 0)
                        {
                            isprim = false;
                            //break; //bricht innere Schleife ab, da Ergebnis bereits negativ
                        }
                        i++;
                    }
                    if (isprim)
                    {
                        counter++;
                        Console.WriteLine("Primzahl gefunden: " + i);

                    }
                    index++;
                } while (index <= 1000);
                Console.WriteLine("Primzahlen insgesamt: " + counter);
            }
            Console.WriteLine();

            //ERGEBNIS 6: siehe http://www.numere-prime.ro/numerele_prime_pana_la_1000.php?lang=de 
            //----------------------------------------------------------------------------


            Console.WriteLine();
            Console.WriteLine("Drücke eine beliebige Taste um zu beenden...");
            Console.ReadKey();
        }
    }
}
