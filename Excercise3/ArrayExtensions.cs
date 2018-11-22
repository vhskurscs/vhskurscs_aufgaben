using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class ArrayExtensions
    {
        /// <summary>
        /// Berechne die (Quer-)Summe einer int-Arrays.
        /// Summiere dazu jedes Feld:
        /// Beispiel: 1,2,3,4,5 = 15
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Die Summe des Arrays.</returns>
        public static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        /// <summary>
        /// Spiegle ein int-Array.
        /// Beispiel: 1,2,3 = 3,2,1
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Das gespiegelte Array.</returns>
        public static int[] Reverse(int[] array)
        {
            int[] reversed = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[(array.Length - 1) - i];
            }
            return reversed;
        }

        /// <summary>
        /// Finde das Maximum (den höchsten Wert) eines int-Arrays.
        /// Beispiel: 1,3,2 = 3
        /// Gebe -1 zurück, wenn dass Array keine Elemente hat.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Der höchste Wert des Arrays</returns>
        public static int Max(int[] array)
        {
            if (array.Length <= 0)
                return -1;
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                max = max < array[i] ? array[i] : max;
                //if (max < array[i])
                //    max = array[i];
            }
            return max;
        }

        /// <summary>
        /// Finde das Minimum (den niedrigsten Wert) eines Arrays.
        /// Beispiel: 1,2,3 = 1
        /// Gebe -1 zurück, wenn dass Array keine Elemente hat.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static long Min(long[] array)
        {
            if (array.Length <= 0)
                return -1;
            long min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                min = min > array[i] ? array[i] : min;
                //if (min < array[i])
                //    min = array[i];
            }
            return min;
        }

        /// <summary>
        /// Finde den Durchschnittswert eines Arrays.
        /// Beispiel 1: 1,2 = 1
        /// Beispiel 2: 1,2,3 = 3
        /// Gebe -1 zurück, wenn dass Array keine Elemente hat.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Average(int[] array)
        {
            if (array.Length <= 0)
                return -1;
            decimal avg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            avg /= array.Length;
            //mittels Round-Methode -> diese Vorgehensweise ist vorzuziehen!
            //int uprounded = (int)Math.Round(avg, 0, MidpointRounding.AwayFromZero);
            //return uprounded;

            //Alternative ohne Round
            return (int)((avg % 1m) >= 0.5m ? (avg+0.5m) : avg);
        }

        /// <summary>
        /// Sortiert ein int-Array aufsteigend.
        /// Beispiel: 3,4,2,1,3 = 1,2,3,3,4
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SortArray(int[] array)
        {
            if (array == null || array.Length <= 0)
                return array;

            int temp;
            for (int i = 0; i < (array.Length-1); i++)
            {
                for (int j = 0; j < (array.Length-1); j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        //Austausch der ELemente
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

    }
}
