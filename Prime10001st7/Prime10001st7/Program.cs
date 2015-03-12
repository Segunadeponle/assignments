using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime10001st7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2,j = 0; ; i++)
            {
                if (IsPrime(i))
                {
                    j++;
                }
                if (j==10001)
                {
                    Console.WriteLine("{0} is the {1}th prime",i,j);
                    break;
                }
            }
            Console.ReadKey();
        }
        static bool IsPrime(long x)
        {
            var n = (int)Math.Sqrt(x);
            for (int i = 2; i <= n; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
