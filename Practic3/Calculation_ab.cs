using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    public class Calculation_ab
    {
        int a, b;

        public Calculation_ab(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A { get { return a; } }

        public int B { get { return b; } }

        public int Sun()
        {
            var k = 0;

            if (a > b)
            {
                throw
                    new ArgumentOutOfRangeException("А повинно бути менше B");
            }

            if (a == b)
            {
                return 0;
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 44 == 0 || i % 2 != 0 || i % 5 == 3)
                    {
                        k += 1;
                    }
                }
                return k;
            }
        }
    }
}
