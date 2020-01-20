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

namespace WindowsFormsApplication2
{
    public partial class Fee1 : Form
    {
        public Fee1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Fee f = new Fee();
                f.Id = Convert.ToInt32(id.Text);
                f.Name = name.Text;
                f.Monthly = Convert.ToInt32(mDues.Text);
                f.PastDues = Convert.ToInt32(pDues.Text);
                f.Security = Convert.ToInt32(secur.Text);
                f.AdmissionFee = Convert.ToInt32(addFee.Text);
                f.Fine = Convert.ToInt32(fine.Text);
                f.Extra = Convert.ToInt32(extra.Text);
                f.Security = Convert.ToInt32(secur.Text);
               f.JoinDate = date.Text;

               string connectionString = @"Data Source=DESKTOP-96TB03J\SQLEXPRESS;Initial Catalog=Fitnessclub;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                using (SqlCommand cmd = new SqlCommand("fins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();


                    cmd.Parameters.AddWithValue("@id", id.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@monthly", mDues.Text);
                    cmd.Parameters.AddWithValue("@pastdues", pDues.Text);
                    cmd.Parameters.AddWithValue("@admissionFee", secur.Text);
                    cmd.Parameters.AddWithValue("@fine", addFee.Text);
                    cmd.Parameters.AddWithValue("@extra", fine.Text);
                    cmd.Parameters.AddWithValue("@security", extra.Text);
                    cmd.Parameters.AddWithValue("@joinDate", date.Text);

                    cmd.ExecuteNonQuery();
                }
                //cmd.Parameters.Add("supid", SqlDbType.Int).Value = s.Sup;
                //cmd.Parameters.Add("supname", SqlDbType.NVarChar, 100).Value = s.Supdescription;
                //cmd.Parameters.Add("supdescription", SqlDbType.NVarChar, 100).Value = s.Supdescription;
                //cmd.Parameters.Add("supprice", SqlDbType.NVarChar, 100).Value = s.Supprice;
                //cmd.Parameters.Add("Expiredate", SqlDbType.NVarChar, 100).Value = s.Expiredate;
                //cmd.Parameters.Add("Benefit", SqlDbType.NVarChar, 100).Value = s.Benefit;

                //conn.Open();


                //cmd.ExecuteNonQuery();
                //conn.Close();
                MessageBox.Show("conection is entered successfull");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error! " + ex.Message);

            }

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
