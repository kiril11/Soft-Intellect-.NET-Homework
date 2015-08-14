using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose type of teacher you wish to test:");
            Console.WriteLine();
            Console.WriteLine("1 for Teacher");
            Console.WriteLine("2 for School Teacher");
            Console.WriteLine("3 for College teacher");
            Console.WriteLine("4 for Assistant ");
            Console.WriteLine("5 for Professor");
            Console.WriteLine();
            Console.Write("Your choice is: ");
            int select = int.Parse(Console.ReadLine());
            Console.WriteLine();
  
                switch (select)
                {
                    case 1:
                        Teacher Joe = new Teacher("Joe", "Brix", "Biology", 12);
                        Joe.PrintHello();
                        Joe.PrintTeacher();
                        Joe.Check();
                        Joe.PrintBye();
                        Joe.PrintCount();
                        break;

                    case 2:
                        SchoolTeacher Jax = new SchoolTeacher();
                        Jax.Check();
                        Jax.PrintClass();
                        Jax.PrintCount();
                        break;
                    case 3:
                        CollegeTeacher Alex = new CollegeTeacher();
                        Alex.Check();
                        Alex.PrintCount();
                        break;

                    case 4:
                        Assistant Gary = new Assistant("Gary", "Sheppard", true);
                        Gary.PrintAssist();
                        Gary.Check();
                        Gary.PrintCount();
                        break;
                    case 5:
                        Professor Brandon = new Professor("Title", -32);
                        Brandon.PrintProf();
                        Brandon.Check();
                         Brandon.PrintCount();
                        break;
                }
            }
        }
    }


