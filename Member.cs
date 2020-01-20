using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Member : Person
    {
        private int batchid;
        private string goal;
        private float mheight;
        private float mweight;
        private string workoutexp;
        private string healthstatus;
        private string healthhistory;
        private float fatratio;
        private float waist;
        private float armsize;
        public Fee f1;
        public int B_no
        {
            get
            {
                return this.batchid;
            }
            set
            {
                this.batchid = value;
            }
        }
        public string Goal
        {
            get
            {
                return this.goal;
            }
            set
            {
                this.goal = value;
            }
        }
        public float mHeight
        {
            get
            {
                return this.mheight;
            }
            set
            {
                this.mheight = value;
            }
        }
        public float mWeight
        {
            get
            {
                return this.mweight;
            }
            set
            {
                this.mweight = value;
            }
        }
        public string Workoutexp
        {
            get
            {
                return this.workoutexp;
            }
            set
            {
                this.workoutexp = value;
            }
        }
        public string HealthStatus
        {
            get
            {
                return this.healthstatus;
            }
            set
            {
                this.healthstatus = value;
            }
        }
        public string HealthHistory
        {
            get
            {
                return this.healthhistory;
            }
            set
            {
                this.healthhistory = value;
            }
        }
        public float FatRatio
        {
            get
            {
                return this.fatratio;
            }
            set
            {
                this.fatratio = value;
            }
        }
        public float Waist
        {
            get
            {
                return this.waist;
            }
            set
            {
                this.waist = value;
            }
        }
        public float ArmSize
        {
            get
            {
                return this.armsize;
            }
            set
            {
                this.armsize = value;
            }
        }

        public void fee_info(Fee f)
        {
            f1 = f;
        }
    }

}