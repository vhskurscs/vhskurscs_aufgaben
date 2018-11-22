using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Exercises
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 2, 1 };

            a = ArrayExtensions.SortArray(a);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
