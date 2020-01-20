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

namespace WindowsFormsApplication4
{
    public partial class Supliment1 : Form
    {
        public Supliment1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Supliment s = new Supliment();
                s.Sup = Convert.ToInt32(txtsup.Text);
                s.Supdescription = txtsupdescription.Text;
                s.Supprice = Convert.ToInt32(txtsupp.Text);
                s.Expiredate = txtexpiredate.Text;
                s.Benefit = txtbenefit.Text;
                string connectionString = @"Data Source=DESKTOP-96TB03J\SQLEXPRESS;Initial Catalog=Fitnessclub;Integrated Security=True";        
                SqlConnection conn = new SqlConnection(connectionString);

                using (SqlCommand cmd = new SqlCommand("usp_Supliment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();


                    cmd.Parameters.AddWithValue("@supid", txtsup.Text);
                    cmd.Parameters.AddWithValue("@supname", txtsupname.Text);
                    cmd.Parameters.AddWithValue("@supdescription", txtsupdescription.Text);
                    cmd.Parameters.AddWithValue("@supprice", txtsupp.Text);
                    cmd.Parameters.AddWithValue("@Expiredate", txtexpiredate.Text);
                    cmd.Parameters.AddWithValue("@Benefit", txtbenefit.Text);

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

        private void Supliment1_Load(object sender, EventArgs e)
        {

        }
    }
}
