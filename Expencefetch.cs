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
    public partial class Expencefetch : Form
    {
        private DataTable dtExpence;
        private DataView dtexpenceview;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["testdb"].ConnectionString);


        public Expencefetch()
        {
            InitializeComponent();
        }

        private void Expencefetch_Load(object sender, EventArgs e)
        {
            dtvexp.DataSource = GetDataTable();
            dtexpenceview = dtExpence.DefaultView;
        }
        private DataTable GetDataTable()
        {

            dtExpence = new DataTable();

            using (cmd = new SqlCommand("ExpenceDataFetch", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtExpence);
            }

            return dtExpence;
        }

        private void dtvexp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //tdata is a grid view name
                var hti = dtvexp.HitTest(e.X, e.Y);
                dtvexp.ClearSelection();
                dtvexp.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Really Want To Delete This Record?", "Deleting Records", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                int rowToDeleteIndex = dtvexp.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                dtvexp.Rows.RemoveAt(rowToDeleteIndex);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dtExpence);
                MessageBox.Show("Data is deleted successfully!");
            }
        }

    }
}
