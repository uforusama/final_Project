using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    class Work
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public void AddMethod (string name, int id)
        {
            string connectionString = @"Data Source=DESKTOP-96TB03J\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True";


            string myMagicQuery = @"IF NOT EXISTS (SELECT 1 FROM TestTable WHERE id = @id)
                                      BEGIN
                                     INSERT INTO TestTable (name, id) 
                                      VALUES (@name, @id) END";

            SqlConnection cn = new SqlConnection(connectionString);
            using (SqlCommand cmd = new SqlCommand(myMagicQuery, cn))
            {
                //cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Data isnerted successfully");
                }
                else
                {
                    MessageBox.Show("There was an error inserting data");
                }

            }

        }
    }
}
