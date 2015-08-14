using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    class CollegeTeacher:Teacher
    {
        public void Check()
        {
            Console.WriteLine("Check homeworks:"); count++;
            Console.WriteLine("science");

        }
        private string uni;
        private string Uni
        {
            get { return uni; }
            set { uni = value; }
        }
    }
}
