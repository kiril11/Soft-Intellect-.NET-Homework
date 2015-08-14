using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    class Lecturer : Person
    {
        private string uniname;
        public string Uniname
        {
            get { return uniname; }
            set { uniname = value; }
        }
        public Lecturer()
        {
        }
        public Lecturer(string name,string lastname)
        {

        }
        public Lecturer(string name, string lastname, string uniname, int years)
            : base(name, lastname, years)
        {
            this.uniname = uniname;
        }
        
        public Lecturer(int years)
        {
            this.years = years;
        }
        public void Check()
        {
        }
        public void Check(bool x)
        {
        }
        public void Check(int hours, string lecture)
        {
        }

        public void Goodday()
        {
            Console.WriteLine("Good day"); count++;
        }

        private void Lectures()
        {
            Console.WriteLine("Lectures of 2 each day"); count++;
        }
    }
}
