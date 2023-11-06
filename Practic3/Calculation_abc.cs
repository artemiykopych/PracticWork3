using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    public class Calculation_abc
    {
        public Calculation_abc(int a, int b, int c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }  
        
        int a, b, c;

        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

        public double D()
        {
            if (a > 5 || b > 5 || c > 5)
            {
                return Math.Pow(a + b + c, 3);
            }
            else
            {
                return a + b + c;
            }
        }
    }
}
