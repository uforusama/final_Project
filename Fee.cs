using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Fee
    {
        private int id;
        private string name;
        private int monthly;
        private int pastdues;
        private int admissionFee;
        private int fine;
        private int extra;
        private int security;
        private string joinDate;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Monthly
        {
            get
            {
                return this.monthly;
            }
            set
            {
                this.monthly = value;
            }
        }
        public int PastDues
        {
            get
            {
                return this.pastdues;
            }
            set
            {
                this.pastdues = value;
            }
        }
        public int AdmissionFee
        {
            get
            {
                return this.admissionFee;
            }
            set
            {
                this.admissionFee = value;
            }
        }
        public int Fine
        {
            get
            {
                return this.fine;
            }
            set
            {
                this.fine = value;
            }
        }
        public int Extra
        {
            get
            {
                return this.extra;
            }
            set
            {
                this.extra = value;
            }
        }
        public int Security
        {
            get
            {
                return this.security;
            }
            set
            {
                this.security = value;
            }
        }
        public string JoinDate
        {
            get
            {
                return this.joinDate;
            }
            set
            {
                this.joinDate = value;
            }
        }
    }
}