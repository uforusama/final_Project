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
    public partial class Mem1 : Form
    {
        public Mem1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Member m = new Member();
                m.Id = Convert.ToInt32(id.Text);
                m.Name = nam.Text;
                m.Password = pass.Text;
                m.Age = Convert.ToInt32(age.Text);
                m.ContactNo = Convert.ToInt32(con.Text);
                m.Status = sta.Text;
                m.Gender = gen.Text;
                m.Cnic = Convert.ToInt32(cn.Text);
                m.Address = add.Text;
                m.Joindate = join.Text;
                m.B_no = Convert.ToInt32(id.Text);
                m.Workoutexp = workout.Text;
                m.HealthStatus = healthsta.Text;
                m.mHeight = Convert.ToSingle(mheight.Text);
                m.mWeight = Convert.ToSingle(mweight.Text);
                m.HealthHistory = healthHis.Text;
                m.FatRatio = Convert.ToSingle(fatrat.Text);
                m.Waist = Convert.ToSingle(wai.Text);
                m.ArmSize = Convert.ToSingle(armsi.Text);
                m.Goal = go.Text;

                string connectionString = @"Data Source=DESKTOP-96TB03J\SQLEXPRESS;Initial Catalog=Fitnessclub;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                using (SqlCommand cmd = new SqlCommand("memberins", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();


                    cmd.Parameters.AddWithValue("@batchid", id.Text);
                    cmd.Parameters.AddWithValue("@workoutexp", workout.Text);
                    cmd.Parameters.AddWithValue("@healthstatus", healthsta.Text);
                    cmd.Parameters.AddWithValue("@mheight", mheight.Text);
                    cmd.Parameters.AddWithValue("@mweight", mweight.Text);
                    cmd.Parameters.AddWithValue("@healthhistory", healthHis.Text);
                    cmd.Parameters.AddWithValue("@fatratio", fatrat.Text);
                    cmd.Parameters.AddWithValue("@waist", wai.Text);
                    cmd.Parameters.AddWithValue("@armsize", armsi.Text);
                    cmd.Parameters.AddWithValue("@goal", go.Text);
 

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
                MessageBox.Show("Record is entered successfull");
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
    }
}
