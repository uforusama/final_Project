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
    public partial class Equipement1 : Form
    {
        public Equipement1()
        {
            InitializeComponent();
        }

        private void btnRequried_Click(object sender, EventArgs e)
        {
            

            try
            {
            Equipement eq= new Equipement();
            eq.Eqid = Convert.ToInt32(txteqid.Text);
            eq.Eqname = txteqname.Text;
            eq.Eqcondition = txteqcondition.Text;
            eq.Price = Convert.ToInt32(txteqprice.Text);
            eq.Eqrequirement = txteqrequirment.Text;

            string connectionString = @"Data Source=DESKTOP-96TB03J\SQLEXPRESS;Initial Catalog=Fitnessclub;Integrated Security=True";      
                SqlConnection conn = new SqlConnection(connectionString);

                using (SqlCommand cmd = new SqlCommand("eqinsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();


                    cmd.Parameters.AddWithValue("@eqid", txteqid.Text);
                    cmd.Parameters.AddWithValue("@eqname", txteqname.Text);
                    cmd.Parameters.AddWithValue("@eqcondition", txteqcondition.Text);
                    cmd.Parameters.AddWithValue("@price", txteqprice.Text);
                    cmd.Parameters.AddWithValue("@eqrequirement", txteqrequirment.Text);

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
    }
}
