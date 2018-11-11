using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    public class StringExercise
    {
        /// <summary>
        /// Zählt die Vorkommen des Buchstaben 'a' (klein) in einer Zeichenkette.
        /// Beispiel:
        /// Mit dem String "Als Programmierer hat man Spaß" würde die Methode den Wert 4 zurückgeben.
        /// </summary>
        /// <param name="str">Zeichenkette in der gezählt werden soll</param>
        /// <returns>Anzahl der Vorkommen</returns>
        public static int CountAs(string str)
        {
            //Dummy-Wert
            return -1; //Entfernen und richtig implementieren
        }

        /// <summary>
        /// Zählt die Vorkommen der Buchstaben 'a','e' und 'c' (klein) in einer Zeichenkette.
        /// Beispiel:
        /// Mit dem String "Programmieren macht Spaß" würde die Methode den Wert 6 zurückgeben.
        /// </summary>
        /// <param name="str">Zeichenkette in der gezählt werden soll</param>
        /// <returns>Anzahl der Vorkommen</returns>
        public static int CountAsEsCs(string str)
        {
            //Dummy-Wert
            return -1; //Entfernen und richtig implementieren
        }

        /// <summary>
        /// Prüft, ob die Zeichenfolge "ab" (klein) in einer Zeichenketten vorhanden ist.
        /// Beispiel: "ich habe einen schönen Abend" -> Gibt true zurück.
        /// Beispiel: "das ist ein schöner Abend" -> Gibt false zurück.
        /// </summary>
        /// <param name="str">Zeichenkette, die geprüft werden soll</param>
        /// <returns></returns>
        public static bool IsABInString(string str)
        {
            //Dummy-Wert
            return false; //Entfernen und richtig implementieren
        }

        /// <summary>
        /// Spiegelt eine Zeichenkette und gibt diese zurück.
        /// Beispiel: "Hallo" --> "ollaH"
        /// </summary>
        /// <param name="str">Zeichenkette, die gespiegelt werden soll</param>
        /// <returns></returns>
        public static string Reverse(string str)
        {
            //Dummy-Wert
            return null; //Entfernen und richtig implementieren
        }

        /// <summary>
        /// Prüft, ob eine übergeben Zahl (num) in der Zeichenkette vorhanden ist.
        /// </summary>
        /// <param name="str">Zeichenkette, in der gesucht werden soll</param>
        /// <param name="num">Ganzzahl nach der gesucht werden soll</param>
        /// <returns></returns>
        public static bool IsNumInString(string str, int num)
        {
            //Dummy-Wert
            return false; //Entfernen und richtig implementieren
        }

        /// <summary>
        /// Schneidet eine Zeichenkette in 2 Teile und gibt einen Teil als Ergebnis zurück.
        /// Wenn die Teile nicht gleichgroß sein sollten, soll der erste Teil der größere sein.
        /// </summary>
        /// <param name="str">Zeichenfolge, die geteilt werden soll.</param>
        /// <param name="returnFirstPart">Wenn true, dann gebe den ersten Teil der Zeichenkette zurück; 
        /// wenn false, den zweiten.</param>
        /// <returns></returns>
        public static string CutInHalf(string str, bool returnFirstPart)
        {
            //Dummy-Wert
            return null; //Entfernen und richtig implementieren
        }

        /// <summary>
        /// Zählt die Vorkommen einer beliebigen Zeichenfolge (word) in einem String (str).
        /// Beispiel: CountStringInString("Programmierenistschwer ,aber,macht,Spaß,aber", ",abe") --> 2
        /// </summary>
        /// <param name="str"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int CountStringInString(string str, string word)
        {
            //Dummy-Wert
            return -1; //Entfernen und richtig implementieren
        }
    }
}
