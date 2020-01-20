using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessclub
{
    class Employee:Person
    {
        protected string designation;
        protected string esalary;
        protected string eexperience;
        protected string empqualification;
        protected string workschedule;

        public string DESIGNATION
        {
            set { designation = value; }
            get { return designation; }
        }

        public string ESALARY
        {
            set { esalary = value; }
            get { return esalary; }
        }

        public string EEXPERIENC
        {
            set { eexperience = value; }
            get { return eexperience; }
        }

        public string EMPQUALIFICATION
        {
            set { empqualification = value; }
            get { return empqualification; }
        }

        public string WORKSCHEDULE
        {
            set { workschedule = value; }
            get { return workschedule; }
        }
        public override void setinput() { }
        public override void displaydata() { }
    }
}
