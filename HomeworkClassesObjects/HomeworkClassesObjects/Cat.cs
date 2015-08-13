using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassesObjects
{
    class Cat
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

         public Cat (string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Say()
        {
            Console.WriteLine("Your cats name is {0} and  {1} years of age.", name, age);
        }
    }
}
