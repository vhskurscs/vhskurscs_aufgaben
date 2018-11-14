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
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                    counter++;
            }
            return counter;
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
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                //ist a oder b oder c
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'c')
                    counter++;
            }
            return counter;
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
            string ab = "ab";
            bool retVal = false;
            for (int i = 0; i < str.Length - (ab.Length - 1); i++)
            {
                if (str[i] == 'a' && str[i + 1] == 'b')
                {
                    retVal = true;
                }
            }
            return retVal;
        }

        /// <summary>
        /// Spiegelt eine Zeichenkette und gibt diese zurück.
        /// Beispiel: "Hallo" --> "ollaH"
        /// </summary>
        /// <param name="str">Zeichenkette, die gespiegelt werden soll</param>
        /// <returns></returns>
        public static string Reverse(string str)
        {
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            return reversed;

            //Alternative Lösung mittels StringBuilder
            //StringBuilder sb = new StringBuilder();
            //for (int i = (str.Length - 1); i >= 0; i--)
            //{
            //    sb.Append(str[i]);
            //}
            //return sb.ToString();
        }

        /// <summary>
        /// Prüft, ob eine übergeben Zahl (num) in der Zeichenkette vorhanden ist.
        /// </summary>
        /// <param name="str">Zeichenkette, in der gesucht werden soll</param>
        /// <param name="num">Ganzzahl nach der gesucht werden soll</param>
        /// <returns></returns>
        public static bool IsNumInString(string str, int num)
        {
            string numStr = num.ToString();
            for (int i = 0; i < (str.Length - (numStr.Length - 1)); i++)
            {
                bool isNumInString = true;
                for (int j = 0; j < numStr.Length; j++)
                {
                    if (str[i + j] != numStr[j])
                    {
                        isNumInString = false;
                        break;
                    }
                }
                if (isNumInString)
                    return true;
            }
            return false;
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
            //If first part
            int startIndex = 0;
            int endIndex = str.Length - (str.Length / 2);
            //If second part
            if (!returnFirstPart)
            {
                startIndex = endIndex;
                endIndex = str.Length;
            }

            string half = string.Empty; // Same like ""

            for (int i = startIndex; i < endIndex; i++)
            {
                half += str[i];
            }

            return half;


            //DAS WÄRE ZUM BEISPIEL EINE KURZE FORM MITTELS VERWENDUNG VON STRING-KLASSEN-METHODEN
            //if (returnFirstPart)
            //    return str.Substring(0, str.Length - (str.Length / 2));
            //else
            //    return str.Substring(str.Length - (str.Length / 2));

        }

        /// <summary>
        /// Zählt die Vorkommen einer beliebigen Zeichenfolge (word) in einem String (str).
        /// Zeichen, die bereits gezählt wurden, dürfen nicht wiederverwendet werden. Siehe Beispiel 2.
        /// Beispiel 1: CountStringInString("Programmierenistschwer ,aber,macht,Spaß,aber", ",abe") --> 2
        /// Beispiel 2: CountStringInString("lololol", "lol") --> 2
        /// </summary>
        /// <param name="str">Zeichenkette in der gesucht werden soll</param>
        /// <param name="word">Zeichenkette, die in str gezählt werden soll.</param>
        /// <returns></returns>
        public static int CountStringInString(string str, string word)
        {
            if (string.IsNullOrEmpty(str) && string.IsNullOrEmpty(word))
                return 1;
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(word))
                return 0;
            if (word.Length == 0)
                return 0;

            int wordCounter = 0;
            for (int i = 0; i < (str.Length - (word.Length - 1));)
            {
                bool isNumInString = true;
                int j = 0;
                while(j < word.Length)
                {
                    j++;
                    if(str[i + (j-1)] != word[j-1])
                    {
                        isNumInString = false;
                        break;//word nicht gefunden, verlasse while-Schleife
                    }
                }
                if (isNumInString)
                {
                    wordCounter++;
                    i += j;
                }
                else
                {
                    i++;
                }
            }
            return wordCounter;
        }
    }
}
