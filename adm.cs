using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class adm : Form
    {
        public adm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Name = name.Text;
            a.Password = pass.Text;
            a.Id = Convert.ToInt32(id.Text);
            a.Age = Convert.ToInt32(id.Text);
            a.Gender = gen.Text;
            a.Cnic = Convert.ToInt32(cnic.Text);
            a.ContactNo = Convert.ToInt32(contact.Text);
            a.Address = addre.Text;
            a.Status = stat.Text;
           // a.JoinDate = dateb.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
