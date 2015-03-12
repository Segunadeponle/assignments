using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a string: ");
                list.Add(Console.ReadLine());
                Sort(list.ToArray());
            }
        }
        static void Sort(String[] input)
        {
            var now = DateTime.Now;
            var len = input.Length-1;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (input[j].CompareTo(input[j+1])>0)
                    {
                        var temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }

                }
            }
            var end = DateTime.Now;
            Console.WriteLine("Sorting of {0} items was done in {1} Milliseconds", input.Length, (end - now).TotalMilliseconds);
        }
    }
}
