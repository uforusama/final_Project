using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication4
{
    class Supliment
    {

        private int supid;
        private string supname;
        private string supdescription;
        private int supprice;
        private string expiredate;
        private string benefit;


        public int Sup
        {
            get
            {
                return this.supid;
            }
            set
            {
                this.supid = value;
            }
        }

        public string Supname
        {
            get
            {
                return this.supname;
            }
            set
            {
                this.supname = value;
            }
        }

        public string Supdescription
        {
            get
            {
                return this.supdescription;
            }
            set
            {
                this.supdescription = value;
            }
        }


        public int Supprice
        {
            get
            {
                return this.supprice;
            }
            set
            {
                this.supprice = value;
            }
        }

        public string Expiredate
        {
            get
            {
                return this.expiredate;
            }
            set
            {
                this.expiredate = value;
            }
        }


        public string Benefit
        {
            get
            {
                return this.benefit;
            }
            set
            {
                this.benefit = value;
            }
        }
 
    }
}
