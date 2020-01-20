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
    public partial class Workout1 : Form
    {
        public Workout1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void AddStuff ()
        {
            string connectionString = @"Data Source=DESKTOP-96TB03J\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";


//            string myMagicQuery = @"IF NOT EXISTS (SELECT 1 FROM TestTable WHERE id = @id)
//                                      BEGIN
//                                     INSERT INTO TestTable (name, id) 
//                                      VALUES (@name, @id) END";
                                      
            SqlConnection cn = new SqlConnection(connectionString);
            using (SqlCommand cmd = new SqlCommand("InsertThings", cn)) {
             
                cmd.CommandType = CommandType.StoredProcedure;
                
                cn.Open();
                cmd.Parameters.AddWithValue("@name", txtwname.Text);
                cmd.Parameters.AddWithValue("@id", txtid.Text);
                int row = cmd.ExecuteNonQuery();
                if (row > 0) 
                {
                    MessageBox.Show("Data isnerted successfully");
                }
                else
                {
                    MessageBox.Show("There was an error insertind data");
                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                Workout w = new Workout();
                w.Id = Convert.ToInt32(txtid.Text);
                w.w_name = txtwname.Text;
                w.Duration = txtduration.Text;
                w.Description = txtdescription.Text;
                w.expected_result = txtexpectedresult.Text;
                string connectionString = @"Data Source=DESKTOP-96TB03J\SQLEXPRESS;Initial Catalog=Fitnessclub;Integrated Security=True";
               // string connString = ConfigurationManager.ConnectionStrings["Fitnessclub"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            using (SqlCommand cmd = new SqlCommand("wi", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();


                //cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.Parameters.AddWithValue("@wname", txtwname.Text);
                cmd.Parameters.AddWithValue("@duration", txtduration.Text);
                cmd.Parameters.AddWithValue("@description", txtdescription.Text);
                cmd.Parameters.AddWithValue("@expectedresult", txtexpectedresult.Text);
                cmd.ExecuteNonQuery();
            }


                    //cmd.Parameters.Add("id", SqlDbType.Int).Value = w.Id;
                    //cmd.Parameters.Add("wname", SqlDbType.NVarChar, 100).Value = w.w_name;
                    //cmd.Parameters.Add("duration", SqlDbType.NVarChar, 100).Value = w.Duration;
                    //cmd.Parameters.Add("description", SqlDbType.NVarChar, 100).Value = w.Description;
                    //cmd.Parameters.Add("expectedresult", SqlDbType.NVarChar, 100).Value = w.expected_result;

                //    conn.Open();


                    //cmd.ExecuteNonQuery();
                    //conn.Close();
                    MessageBox.Show("conection is entered successfully");
                    }
            catch(Exception ex)
            {

                MessageBox.Show("Error! " + ex.Message);

            }
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
                   }

        
    }

    }
