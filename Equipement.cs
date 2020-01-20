using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication4
{
    class Equipement
    {
        private int eqid;
        private string eqname;
        private string eqcondition;
        private int price;
        private string eqrequirement;

        public int Eqid
        {


            get
            {
                return this.eqid;
            }
            set
            {
                this.eqid = value;
            }
        }
        public string Eqname
        {


            get
            {
                return this.eqname;
            }
            set
            {
                this.eqname = value;
            }
        }


        public string Eqcondition
        {


            get
            {
                return this.eqcondition;
            }
            set
            {
                this.eqcondition = value;
            }
        }

        public int Price
        {

            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Eqrequirement
        {


            get
            {
                return this.eqrequirement;
            }
            set
            {
                this.eqrequirement = value;
            }
        }



    }
}
