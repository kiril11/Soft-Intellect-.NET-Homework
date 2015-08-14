using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    class SchoolTeacher:Teacher
    {
        public void Check()
        {
            Console.WriteLine("Check homeworks:"); count++;
            Console.WriteLine("kids");
        }
        string [] classes= new string [] {"3A","4B","5C","7S","4X"}; 
        public void PrintClass()
        {
            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine("The classesa are: {0}",classes[i]);count++;
            }
        }
    }
}
