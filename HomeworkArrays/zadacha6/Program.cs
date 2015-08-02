using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size for your array max is 100: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            if (size <= 0 || size > 100)
            {
                Console.WriteLine("Wrong input");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Enter numbers");
                    int y = int.Parse(Console.ReadLine());
                }

                int c = 1, maxcount = 1, maxvalue = 0;
                int result = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    maxvalue = arr[i];
                    for (int j = 0; j < arr.Length; j++)
                    {

                        if (maxvalue == arr[j] && j != i)
                        {
                            c++;
                            if (c > maxcount)
                            {
                                maxcount = c;
                                result = arr[i];

                            }
                        }
                        else
                        {
                            c = 1;

                        }

                    }
                }
                Console.WriteLine(result); 
            }
        }
    }
}


