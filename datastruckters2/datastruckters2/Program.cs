using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace datastruckters2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your words or sentence");
            string text = Convert.ToString(Console.ReadLine());
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var j in text.Split(' ','!','?','\n',',','.'))
            {
                if (dic.ContainsKey(j))
                {
                    dic[j] = dic[j] + 1;
                }
                else
                {
                    dic.Add(j, 1);
                }
            }
            foreach (var temp in dic)
            {
                Console.WriteLine();
                Console.WriteLine("The word {0} occurs {1} times", temp.Key, temp.Value);
            }
        }
    }
}
