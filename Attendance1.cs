using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Attendance1 : Form
    {
        public Attendance1()
        {
            InitializeComponent();
        }

        private void btnTaken_Click(object sender, EventArgs e)
        {
            Attendnce a = new Attendnce();
            a.Date =txtdate.Text;
            a.Time = txttime.Text;
            
        }
    }
}
