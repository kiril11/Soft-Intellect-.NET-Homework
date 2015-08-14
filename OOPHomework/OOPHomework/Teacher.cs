using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    class Teacher:Person
    {
        private string subject;
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public Teacher()
        {

        }
        public Teacher (string name, string lastname, string subject,int years)
            : base(name,lastname,years)
        {
            this.subject = subject;
        }
        public void PrintTeacher()
        {
            Console.WriteLine("{0} {1} has {2} of service in the subject of {3}!", name, lastname, years,subject);
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello"); count++;
        }
        public void PrintBye()
        {
            Console.WriteLine("Bye");
        }
        public void Check()
        {
            Console.WriteLine("Check homeworks:"); count++;
        }
    }
}
