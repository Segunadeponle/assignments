using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime6
{
    class Program
    {
        static void Main(string[] args)
        {
            var max = 1000000;
            List<long> q = new List<long>();

            for (int i = 2; i < max; i++)
            {
                if (IsPrime(i))
                {
                    q.Add(i);
                }

            }

            long result = 0;
            int numberOfPrimes = 0;
            long[] primes = q.ToArray();
            long[] primeSum = new long[primes.Length + 1];
            int i1 = 0, j1 = 0;
            primeSum[0] = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                primeSum[i + 1] = primeSum[i] + primes[i];
            }

            for (int i = numberOfPrimes; i < primeSum.Length; i++)
            {
                for (int j = i - (numberOfPrimes + 1); j >= 0; j--)
                {
                    if (primeSum[i] - primeSum[j] > max)
                    {
                        break;

                    }
                    if (Array.BinarySearch(primes, primeSum[i] - primeSum[j]) >= 0)
                    {
                        numberOfPrimes = i - j;
                        result = primeSum[i] - primeSum[j];
                        j1 = j; i1 = i;
                    }

                }

            }
            Console.WriteLine("The longest sum of consecutive primes below {0} is {1}",max,result);
            Console.ReadKey(true);
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
