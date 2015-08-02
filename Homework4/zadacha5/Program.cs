using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The symetrical numbers from 10 to 999 are: ");
            int[] arr = new int[999];
            int value = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = value++;
                if (arr[i]%10 == arr[i]/100)
                {
                    Console.WriteLine(arr[i]);
                }
                else if(arr[i]%10==arr[i]/10)
                {
                    Console.WriteLine(arr[i]);
                }           
            }
        }
    }
}
