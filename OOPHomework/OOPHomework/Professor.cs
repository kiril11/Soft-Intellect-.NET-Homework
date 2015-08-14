using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    class Professor:Lecturer
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public Professor ( string title,int years)
            : base(years)
        {
            this.title = title;
            if(years<0)
            {
                Console.WriteLine("The years can not be negative,your information is wrong"); count++;
            }
        }
        public void PrintProf()
        {
            Console.WriteLine("The title is {0} and has {1} years of service!", title, years); count++;
        }
        public void Check()
        {
            Console.WriteLine("Exams"); count++;
        }
    }
}
