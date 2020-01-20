using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication4
{
    class Workout
    {
        private int id;
        private string wname;
        private string duration;
        private string description;
        private string expectedresult;

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

        public string w_name
        {
            get
            {
                return this.wname;
            }
            set
            {
                this.wname = value;
            }
        }

        public string Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public string expected_result
        {
            get
            {
                return this.expectedresult;
            }
            set
            {
                this.expectedresult = value;
            }
        }

    }
}
