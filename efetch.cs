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
    public partial class efetch : Form
    {

        private DataTable dtEmployee;
        private DataView dtemployeeview;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["testdb"].ConnectionString);

        public efetch()
        {
            InitializeComponent();
        }

        private void efetch_Load(object sender, EventArgs e)
        {
            EmpdataGridView.DataSource = GetDataTable();
            dtemployeeview = dtEmployee.DefaultView;
        }

        private DataTable GetDataTable()
        {

            dtEmployee = new DataTable();

            using (cmd = new SqlCommand("employee_fetch", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtEmployee);
            }

            return dtEmployee;
        }

        private void esearch_Click(object sender, EventArgs e)
        {
            dtemployeeview.RowFilter = "Name LIKE '%" + tbesrch.Text + "%'";
        }

        private void tbesrch_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpdataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //tdata is a grid view name
                var hti = EmpdataGridView.HitTest(e.X, e.Y);
                EmpdataGridView.ClearSelection();
                EmpdataGridView.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void EmpdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Really Want To Delete This Record?", "Deleting Records", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                int rowToDeleteIndex = EmpdataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                EmpdataGridView.Rows.RemoveAt(rowToDeleteIndex);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dtEmployee);
                MessageBox.Show("Data is deleted successfully!");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empedit upe1 = new empedit();
            int rowToUpdate = EmpdataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataRow row = dtEmployee.Rows[rowToUpdate];

            upe1.eid = int.Parse(row["ID"].ToString());
            upe1.eNAME = row["Name"].ToString();
            upe1.ecnic = row["CNIC"].ToString();
            upe1.eCONTACTNO = row["Contact_NO"].ToString();
            upe1.eADDRESS = row["Address"].ToString();
            upe1.eGENDER = row["Gender"].ToString();
            upe1.eAGE = int.Parse(row["Age"].ToString());
            upe1.eSTATUS = row["Status"].ToString();
            upe1.eDESIGNATION = row["Designation"].ToString();
            upe1.eEMPQUALIFICATION = row["Qualification"].ToString();
            upe1.eEEXPERIENC = row["Experience"].ToString();
            upe1.eESALARY = row["Salary"].ToString();
            upe1.eWORKSCHEDULE = row["Working_Schedual"].ToString();
            upe1.eJOINDATE= row["Join_Date"].ToString();
            

            upe1.IsUpdate = true;
            upe1.ShowDialog();
            if (!upe1.IsCanceled)
            {
                row["ID"] = upe1.eid;
                row["Name"] = upe1.eNAME;
                row["CNIC"] = upe1.ecnic;
                row["Contact_NO"] = upe1.eCONTACTNO;
                row["Address"] = upe1.eADDRESS;
                row["Gender"] = upe1.eGENDER;
                row["Age"] = upe1.eAGE;
                row["Status"] = upe1.eSTATUS;
                row["Designation"] = upe1.eDESIGNATION;
                row["Qualification"] = upe1.eEMPQUALIFICATION;
                row["Experience"] = upe1.eEEXPERIENC;
                row["Salary"] = upe1.eESALARY;
                row["Working_Schedual"] = upe1.eWORKSCHEDULE;
                row["Join_Date"] = upe1.eJOINDATE;
               

                upe1.IsUpdate = false;

                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dtEmployee);

                EmpdataGridView.Update();
                MessageBox.Show("Record is updated Successfully!");

            }
        }



    }
}
