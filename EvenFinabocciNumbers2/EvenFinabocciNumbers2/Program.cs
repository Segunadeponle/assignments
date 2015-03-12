using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFinabocciNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum of the even fibonacci numbers less than 4,000,000 is");
            ulong x = 1, y = 2,t,sum = 0;

            for (int i = 0; i < 4e6; i+=1)
            {
                if ((x%2)==0)
                {
                    sum += x;    
                }
                
                t = y;
                y = x + y;
                x = t;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
