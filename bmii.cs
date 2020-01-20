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
    public partial class bmii : Form
    {
        public bmii()
        {
            InitializeComponent();
        }

        private void BMI_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BMI b = new BMI();

            b.Height = float.Parse(height.Text);
            b.Weight = float.Parse(weight.Text);

            if (!string.IsNullOrEmpty(height.Text) || string.IsNullOrEmpty(weight.Text))
            {

          b.cal_bmi();

                b.BmiResult = float.Parse(bmiRes.Text);

            }
 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
