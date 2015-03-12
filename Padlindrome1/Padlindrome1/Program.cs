using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padlindrome1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to see if it is a Palindrome : ");
            string input = Console.ReadLine();
            if (Palindrome(input) == null)
            {
                Console.WriteLine("Your can't use an empty string");
            }
            else if (Palindrome(input) == true)
            {
                Console.WriteLine("{0} is a Palindrome", input);
            }
            else if (Palindrome(input) == false)
            {
                Console.WriteLine("{0} is not a Palindrome", input);
            }
            Console.ReadKey(true);
        }

        static bool? Palindrome(string x)
        {
            if (x == "")
            {
                return null;
            }
            else if (x == Reverse(x))
            {
                return true;
            }
            return false;
        }
        static string Reverse(string x)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = x.Length - 1; i >= 0; i -= 1)
            {
                sb.Append(x[i]);
            }

            return sb.ToString();
        }
    }
}
