using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamTask
{
    public class country
    {
        private string countryy;
        public string Countryy
        {
            get { return countryy; }
            set { countryy = value; }
        }

        private string capital;
        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        private double population;
        public double Population
        {
            get { return population; }
            set { population = value; }
        }


        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.countryy, this.capital, this.population);
        }
    }
}