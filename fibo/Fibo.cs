using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibo
{
    internal class Fibo
    {

        public double fibo(double x)
        {
            if (x > 1)
            {
                return fibo(x - 1) + fibo(x - 2);
            }

            return x;
        }
    }
}
