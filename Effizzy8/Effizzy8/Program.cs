using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effizzy8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            try
            {
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine(Effizzy(input));
            }
            catch (Exception)
            {
                Console.WriteLine("You must enter a whole number");
            }
            Console.ReadKey();
        }

        static string Effizzy(int x)
        {
            if ((x % 3 == 0)&& (x%5==0))
            {
                return "FizzBuzz";
            }
            
            else if (x%3==0)
            {
                return "Fizz";
            }
            else if (x%5==0)
            {
                return "Buzz";
            }
            else
            {
                return x.ToString();
            }

        }
    }
}
