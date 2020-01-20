using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace fitnessclub
{
    public partial class login : Form
    {
        protected int id;
        protected string pass;

        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public string PASS
        {
            set { pass = value; }
            get { return pass; }
        }
        public login()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public bool IsValidate()
        {

            if (this.tadid.Text == "")
            {
                MessageBox.Show("ID field should not Empty!");
                this.tadid.BackColor = Color.Yellow;
                this.tadid.Focus();
                return false;
            }

            if (this.tadpass.Text == "")
            {
                MessageBox.Show("Name field should not Empty!");
                this.tadpass.BackColor = Color.Yellow;
                this.tadpass.Focus();
                return false;
            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                ID = Convert.ToInt32(tadid.Text);
                PASS = tadpass.Text;
            }
            if (Athenticated(tadid.Text, tadpass.Text))
            {
                this.Hide();
                menu m = new menu();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Enter Wrong ID and Password");
            }
        }

        private bool Athenticated(string p1, string p2)
        {
            bool IsUserCredentailsCorrect = false;
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand("checkuser", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = p1;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = p2;
                conn.Open();
                IsUserCredentailsCorrect = (bool)cmd.ExecuteScalar();

                conn.Close();

            }
            catch (Exception ex) { MessageBox.Show("Error: ", ex.Message); }
            return IsUserCredentailsCorrect;



            return true;
        }

        private void tadid_TextChanged(object sender, EventArgs e)
        {
            this.tadid.BackColor = Color.White;
        }

        private void tadpass_TextChanged(object sender, EventArgs e)
        {
            this.tadpass.BackColor = Color.White;
        }

        private void tadid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tadpass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tadid_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tadpass_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void closepic2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
