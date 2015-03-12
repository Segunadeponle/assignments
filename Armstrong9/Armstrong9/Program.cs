using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            try
            {
                var input = int.Parse(Console.ReadLine());
                if (IsArmstong(input))
                {
                    Console.WriteLine("{0} is an Armstrong number",input);
                }
                else
                {
                    Console.WriteLine("{0} is not an Armstrong number",input);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You must enter a whole number");
            }
            Console.ReadKey();

        }
        static bool IsArmstong(int x)
        {
            var s = x.ToString();
            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += (int)Math.Pow(int.Parse(s[i].ToString()), 3);
            }
            if (sum==x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
