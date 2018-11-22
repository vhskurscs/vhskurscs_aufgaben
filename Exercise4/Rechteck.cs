using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Rechteck
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rechteck()
        {
            A = 0.0;
            B = 0.0;
        }

        public Rechteck(double a, double b)
        {
            A = a;
            B = b;
        }

        public double Flaecheninhalt()
        {
            return A * B;
        }

        public double Umfang()
        {
            return 2 * (A + B);
        }
    }
}
