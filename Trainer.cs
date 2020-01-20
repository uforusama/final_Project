using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnessclub
{
    class Trainer:Person
    {
        protected string certification;
        protected string trainingexp;
        protected float theight;
        protected float tweight;
        protected int tsalary;
        protected string qualification;
        protected string achievements;
        protected string expertise;
        protected string workinghours;
        protected string session;

        public string CERTIFICATION
        {
            set { certification = value; }
            get { return certification; }
        }

        public string TRAININGEXP
        {
            set { trainingexp = value; }
            get { return trainingexp; }
        }

        public float THEIGHT
        {
            set { theight = value; }
            get { return theight; }
        }

        public float TWEIGHT
        {
            set { tweight = value; }
            get { return tweight; }
        }

        public int TSALARY
        {
            set { tsalary = value; }
            get { return tsalary; }
        }

        public string QUALIFICATION
        {
            set { qualification = value; }
            get { return qualification; }
        }

        public string ACHIEVEMENTS
        {
            set { achievements = value; }
            get { return achievements; }
        }

        public string EXPERTISE
        {
            set { expertise = value; }
            get { return expertise; }
        }

        public string WORKINGHOUR
        {
            set { workinghours = value; }
            get { return workinghours; }
        }

        public string SESSION
        {
            set { session = value; }
            get { return session; }
        }
        
        public override void setinput() {
            id = 5;
        }
        public override void displaydata() { }
    }
}
