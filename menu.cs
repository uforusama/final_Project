using fitnessclub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessclub
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.pic1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.black1;
        }

        private void pictureBoxemp_MouseHover(object sender, EventArgs e)
        {
            pictureBoxemp.Image = Resources.sven_mieke_jO6vBWX9h9Y_unsplash;
        }

        private void pictureBoxemp_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxemp.Image = Resources.black1;
        }

        private void pictureBoxPay_MouseHover(object sender, EventArgs e)
        {
            pic7.Image = Resources.man_holding_brown_rope_3253501;
        }

        private void pictureBoxPay_MouseLeave(object sender, EventArgs e)
        {
            pic7.Image = Resources.black1;
        }

        private void closepic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic3_MouseLeave(object sender, EventArgs e)
        {
            pic3.Image = Resources.black1;
        }

        private void pic4_MouseLeave(object sender, EventArgs e)
        {
            pic4.Image = Resources.black1;
        }

        private void pic5_MouseLeave(object sender, EventArgs e)
        {
            pic5.Image = Resources.black1;
        }

        private void pic6_MouseLeave(object sender, EventArgs e)
        {
            pic6.Image = Resources.black1;
        }

        private void pic8_MouseLeave(object sender, EventArgs e)
        {
            pic8.Image = Resources.black1;
        }

        private void pic9_MouseLeave(object sender, EventArgs e)
        {
            pic9.Image = Resources.black1;
        }

        private void pic10_MouseLeave(object sender, EventArgs e)
        {
            pic10.Image = Resources.black1;
        }

        private void pic11_MouseLeave(object sender, EventArgs e)
        {
            pic11.Image = Resources.black1;
        }

        private void pic12_MouseLeave(object sender, EventArgs e)
        {
            pic12.Image = Resources.black1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trn t3 = new trn();
            t3.ShowDialog();
        }

        private void pictureBoxemp_Click(object sender, EventArgs e)
        {
            this.Hide();
            emp emp = new emp();
            emp.ShowDialog();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pable p = new Pable();
            p.ShowDialog();
        }
    }
}
