using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    class Assistant:Lecturer
    {
        private bool head;
        public bool Head
        {
            get { return head; }
            set { head = value; }
        }
        public Assistant (string name, string lastname, bool head)
            : base(name,lastname)
        {
            this.head = head;
        }
        public void PrintAssist()
        {
            Console.WriteLine("{0} {1} is head assistant: {2} ", name, lastname, head); count++;
        }
        public void Check()
        {
            Console.WriteLine("During exams"); count++;
        }
    }
}
