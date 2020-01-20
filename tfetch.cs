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
    public partial class tfetch : Form
    {
        private DataTable dtTrainer;
        private DataView dttrainerview;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;
        private SqlConnection conn=new SqlConnection(ConfigurationManager.ConnectionStrings["testdb"].ConnectionString);

        public tfetch()
        {
            InitializeComponent();
        }

        private void tfetch_Load(object sender, EventArgs e)
        {
            tdata.DataSource = GetDataTable();
            dttrainerview = dtTrainer.DefaultView;

            //tdata.DataSource = ds.Tables["trainer"];
        }

        private DataTable GetDataTable()
        {
            
             dtTrainer = new DataTable();

                using (cmd = new SqlCommand("get_trainer", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dtTrainer);
                }

            return dtTrainer;
        }

        private void srchb_Click(object sender, EventArgs e)
        {
            dttrainerview.RowFilter = "Name LIKE '%" + srcht.Text+"%'";
        }

        private void tdata_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //tdata is a grid view name
                var hti=tdata.HitTest(e.X, e.Y);
                tdata.ClearSelection();
                tdata.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Do You Really Want To Delete This Record?", "Deleting Records", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           if (result == DialogResult.Yes)
           {
               int rowToDeleteIndex = tdata.Rows.GetFirstRow(DataGridViewElementStates.Selected);
               tdata.Rows.RemoveAt(rowToDeleteIndex);
               SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
               adapter.Update(dtTrainer);
               MessageBox.Show("Data is deleted successfully!");
           }


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uptrainer upt1 = new uptrainer();
            int rowToUpdate = tdata.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DataRow row = dtTrainer.Rows[rowToUpdate];

            upt1.Tid = int.Parse(row["ID"].ToString());
            upt1.tNAME = row["Name"].ToString();
            upt1.tcnic = row["CNIC"].ToString();
            upt1.tCONTACTNO = row["Contact_NO"].ToString();
            upt1.tADDRESS = row["Address"].ToString();
            upt1.tGENDER = row["Gender"].ToString();
            upt1.tAGE = int.Parse(row["Age"].ToString());
            upt1.tSTATUS = row["Status"].ToString();
            upt1.TTHEIGHT = Convert.ToSingle(row["Height"].ToString());
            upt1.TTWEIGHT = Convert.ToSingle(row["Weight"].ToString());
            upt1.TCERTIFICATION = row["Certification"].ToString();
            upt1.TQUALIFICATION = row["Qualification"].ToString();
            upt1.TTRAININGEXP = row["Experience"].ToString();
            upt1.TACHIEVEMENTS = row["Achievement"].ToString();
            upt1.TEXPERTISE = row["Expertise"].ToString();
            upt1.TWORKINGHOUR = row["Working_Hours"].ToString();
            upt1.TSESSION = row["Session"].ToString();
            upt1.TTSALARY = int.Parse(row["Salary"].ToString());

            upt1.IsUpdate = true;
            upt1.ShowDialog();
            if (!upt1.IsCanceled)
            {
                 row["ID"]=upt1.Tid;
                 row["Name"] = upt1.tNAME;
                 row["CNIC"] = upt1.tcnic;
                row["Contact_NO"]=upt1.tCONTACTNO; 
                 row["Address"]=upt1.tADDRESS;
                 row["Gender"]=upt1.tGENDER; 
                 row["Age"]=upt1.tAGE;
                 row["Status"]=upt1.tSTATUS ;
                 row["Height"]=upt1.TTHEIGHT ;
                 row["Weight"]=upt1.TTWEIGHT ;
                 row["Certification"]=upt1.TCERTIFICATION ;
                 row["Qualification"]=upt1.TQUALIFICATION; 
                row["Experience"]= upt1.TTRAININGEXP ;
                 row["Achievement"]=upt1.TACHIEVEMENTS; 
                 row["Expertise"]=upt1.TEXPERTISE ;
                 row["Working_Hours"]=upt1.TWORKINGHOUR ;
                 row["Session"]=upt1.TSESSION ;
                row["Salary"] = upt1.TTSALARY;

                upt1.IsUpdate = false;

                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dtTrainer);

                tdata.Update();
                MessageBox.Show("Record is updated Successfully!");

            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void closepic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        //private DataTable GetDataTable()
        //{
        //    //DataSet ds = new DataSet();
        //   // ds.DataSetName = "fitnessclub";
        //    DataTable dtTrainer = new DataTable();
        //    dtTrainer.TableName = "trainer";
        //    dtTrainer.Columns.Add("id", typeof(int));
        //    dtTrainer.Columns.Add("name");
        //    dtTrainer.Rows.Add(1, "Usama");
        //   // ds.Tables.Add(dtTrainer);
        //    return dtTrainer;
        //}
    }
}
