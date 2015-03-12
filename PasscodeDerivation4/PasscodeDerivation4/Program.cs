using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PasscodeDerivation4
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, string>[] arr = {new KeyValuePair<string,string>("235","317"),
                                                 new KeyValuePair<string,string>("146","528")};
            Passcode(arr);
            Console.ReadKey();
        }
        static void Passcode(KeyValuePair<string, string>[] arr)
        {
            List<char> list = new List<char>();
            
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr[i].Key.Length; j++)
                {

                    insert(list, int.Parse(arr[i].Key[j].ToString()), arr[i].Value[j]);
                }
            }
            foreach (var item in list)
            {
                if (item!='\0')
                {
                    Console.Write(item);
                }
            }

        }


        static void insert(List<char> list, int index, char item)
        {
            if (list.Count < index)
            {
                for (int i = 0; i < index; i++)
                {
                    try
                    {
                        if (list[i] == null)
                        {
                            
                        }
                    }
                    catch (Exception)
                    {
                        list.Add('\0');
                    }
                }
                list.Add(item);
            }
            else
            {
                list.Insert(index, item);
            }

        }
    }
}
