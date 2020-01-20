using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class BMI
    {
        
        private float height;
        private float weight;
       private float BMIresult;
       
        public float Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public float Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public float BmiResult
        {
            get
            {
                return this.BMIresult;
            }
            set
            {
                this.BMIresult = value;
            }
        }
        public float cal_bmi()
        {
           
            BmiResult = Weight * 703 / (Height * Height);

            
            return BmiResult;
        }
    }
}
