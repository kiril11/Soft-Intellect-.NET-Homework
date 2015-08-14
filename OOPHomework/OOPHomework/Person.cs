using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    class Person
    {
        public int count = 0;
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string lastname;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public int years;
        public int Years
        {
            get { return years; }
            set { years = value; }
        }
        public Person() {  }

        public Person(int years)
        {
            count++;
        }
        public Person (string name, string lastname,int years)
        {
            this.name = name;
            this.lastname = lastname;
            this.years = years;
        }
        public void PrintInfo()
        {
            Console.WriteLine("{0} {1} has {2} of service!", name, lastname, years); count++;
            
        }
        public void PrintCount()
        {
            Console.WriteLine("Objects are {0}", count); 
        }
    }
}
