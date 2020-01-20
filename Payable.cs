using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessclub
{
    class Expence
    {
        protected string month;
        protected int totalsalaries;
        protected int electricitybill;
        protected int waterbill;
        protected int maintcost;
        protected int purchases;
        protected int total;
        protected string despurchase;

        public int TOTALSAL
        {
            set { totalsalaries = value; }
            get { return totalsalaries; }
        }

        public int ELECBILL
        {
            set { electricitybill = value; }
            get { return electricitybill; }
        }

        public int WATERBILL
        {
            set { waterbill = value; }
            get { return waterbill; }
        }

        public int MAINTCOST
        {
            set { maintcost = value; }
            get { return maintcost; }
        }
        public int TOTAL
        {
            set { total = value; }
            get { return total; }
        }
      

        public int PURCHASES
        {
            set {  purchases= value; }
            get { return purchases; }
        }

        public string DECPURCHASE
        {
            set { despurchase = value; }
            get { return despurchase; }
        }
        public string MONTH
        {
            set { month= value; }
            get { return month; }
        }

        public Trainer t1;
        public void agert(Trainer tr1)
        {
            t1 = tr1;
        }

        public Employee e1;

        public void agere(Employee emp1)
        {
            e1 = emp1;
        }
    }
}
