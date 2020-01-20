using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessclub
{
   abstract class Person
    {
        protected int ID;
        protected string name;
        protected string contactNO;
        protected string address;
        protected string CNIC;
        protected int age;
        protected string gender;
        protected string status;
        protected string joinDate;

        public int id
        {
            set { ID = value; }
            get { return ID; }
        }

        public string NAME
        {
            set { name = value; }
            get { return name; }
        }

        public string CONTACTNO
        {
            set { contactNO = value; }
            get { return contactNO; }
        }

        public string ADDRESS
        {
            set { address = value; }
            get { return address; }
        }

        public string cnic
        {
            set { CNIC = value; }
            get { return CNIC; }
        }

        public int AGE
        {
            set { age = value; }
            get { return age; }
        }

        public string GENDER
        {
            set { gender = value; }
            get { return gender; }
        }

        public string STATUS
        {
            set { status = value; }
            get { return status; }
        }
        public string JOINDATE
        {
            set { joinDate = value; }
            get { return joinDate; }
        }
     
       
        public abstract void setinput();
        public abstract void displaydata();

    }
}
