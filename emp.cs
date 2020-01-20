using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace fitnessclub
{
    public partial class emp : Form
    {
        public emp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        public bool IsValidate()
        {

            if (this.teid.Text == "")
            {
                MessageBox.Show("ID field should not Empty!");
                this.teid.BackColor = Color.Yellow;
                this.teid.Focus();
                return false;
            }

            if (this.ten.Text == "")
            {
                MessageBox.Show("Name field should not Empty!");
                this.ten.BackColor = Color.Yellow;
                this.ten.Focus();
                return false;
            }

            if (this.tecnic.Text == "")
            {
                MessageBox.Show("CNIC field should not Empty!");
                this.tecnic.BackColor = Color.Yellow;
                this.tecnic.Focus();
                return false;
            }

            if (this.tecn.Text == "")
            {
                MessageBox.Show("Contact Number field should not Empty!");
                this.tecn.BackColor = Color.Yellow;
                this.tecn.Focus();
                return false;
            }

            if (this.teadd.Text == "")
            {
                MessageBox.Show("Address field should not Empty!");
                this.teadd.BackColor = Color.Yellow;
                this.teadd.Focus();
                return false;
            }

            if (this.teg.Text == "")
            {
                MessageBox.Show("Gender field should not Empty!");
                this.teg.BackColor = Color.Yellow;
                this.teg.Focus();
                return false;
            }

            if (this.teage.Text == "")
            {
                MessageBox.Show("Age field should not Empty!");
                this.teage.BackColor = Color.Yellow;
                this.teage.Focus();
                return false;
            }

            if (this.tes.Text == "")
            {
                MessageBox.Show("Status field should not Empty!");
                this.tes.BackColor = Color.Yellow;
                this.tes.Focus();
                return false;
            }





            if (this.tedes.Text == "")
            {
                MessageBox.Show("Designition field should not Empty!");
                this.tedes.BackColor = Color.Yellow;
                this.tedes.Focus();
                return false;
            }

            if (this.teq.Text == "")
            {
                MessageBox.Show("Qualification field should not Empty!");
                this.teq.BackColor = Color.Yellow;
                this.teq.Focus();
                return false;
            }

            if (this.teexp.Text == "")
            {
                MessageBox.Show("Experience field should not Empty!");
                this.teexp.BackColor = Color.Yellow;
                this.teexp.Focus();
                return false;
            }

            if (this.tesal.Text == "")
            {
                MessageBox.Show("Salary field should not Empty!");
                this.tesal.BackColor = Color.Yellow;
                this.tesal.Focus();
                return false;
            }

            if (this.tews.Text == "")
            {
                MessageBox.Show("Working Schedual field should not Empty!");
                this.tews.BackColor = Color.Yellow;
                this.tews.Focus();
                return false;
            }

            if (this.ejd.Text == "")
            {
                MessageBox.Show("Join Date field should not Empty!");
                this.ejd.BackColor = Color.Yellow;
                this.ejd.Focus();
                return false;
            }


            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                if (IsValidate())
                {
                    Employee e2 = new Employee();
                    e2.id = Convert.ToInt32(teid.Text);
                    e2.NAME = ten.Text;
                    e2.cnic = tecnic.Text;
                    e2.CONTACTNO = tecn.Text;
                    e2.ADDRESS = teadd.Text;
                    e2.GENDER = teg.Text;
                    e2.AGE = Convert.ToInt32(teage.Text);
                    e2.STATUS = tes.Text;
                    e2.DESIGNATION = tedes.Text;
                    e2.EMPQUALIFICATION = teq.Text;
                    e2.EEXPERIENC = teexp.Text;
                    e2.ESALARY = tesal.Text;
                    e2.WORKSCHEDULE = tews.Text;
                    e2.JOINDATE = ejd.Text;
                }
                string connString = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand("ProEmpNew", conn);
                cmd.CommandType = CommandType.StoredProcedure;


            Employee e1 = new Employee();
            e1.id = Convert.ToInt32(teid.Text);
            e1.NAME = ten.Text;
            e1.cnic = tecnic.Text;
            e1.CONTACTNO =tecn.Text;
            e1.ADDRESS = teadd.Text;
            e1.GENDER = teg.Text;
            e1.AGE = Convert.ToInt32(teage.Text);
            e1.STATUS = tes.Text;
            e1.DESIGNATION = tedes.Text;
            e1.EMPQUALIFICATION = teq.Text;
            e1.EEXPERIENC = teexp.Text;
            e1.ESALARY = tesal.Text;
            e1.WORKSCHEDULE = tews.Text;
            e1.JOINDATE = ejd.Text;

            cmd.Parameters.Add("@eid", SqlDbType.Int).Value = e1.id;
            cmd.Parameters.Add("@en", SqlDbType.VarChar, 50).Value = e1.NAME;
            cmd.Parameters.Add("@ecnic", SqlDbType.VarChar, 50).Value = e1.cnic;
            cmd.Parameters.Add("@ecn", SqlDbType.VarChar, 50).Value = e1.CONTACTNO;
            cmd.Parameters.Add("@eadd", System.Data.SqlDbType.VarChar).Value = e1.ADDRESS;
            cmd.Parameters.Add("@egen", SqlDbType.VarChar, 50).Value = e1.GENDER;
            cmd.Parameters.Add("@eage", SqlDbType.Int).Value = e1.AGE;
            cmd.Parameters.Add("@es", SqlDbType.VarChar, 50).Value = e1.STATUS;
            cmd.Parameters.Add("@edes", SqlDbType.VarChar,50).Value = e1.DESIGNATION;
            cmd.Parameters.Add("@eq", SqlDbType.VarChar,50).Value = e1.EMPQUALIFICATION;
            cmd.Parameters.Add("@eexp", System.Data.SqlDbType.VarChar,50).Value = e1.EEXPERIENC;
            cmd.Parameters.Add("@esal", System.Data.SqlDbType.VarChar, 50).Value = e1.ESALARY;
            cmd.Parameters.Add("@ews", System.Data.SqlDbType.VarChar,50).Value = e1.WORKSCHEDULE;
            cmd.Parameters.Add("@ejd", SqlDbType.VarChar, 50).Value = e1.JOINDATE;
           
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data is Saved Successfuly!");

            }
             catch (Exception ex)
             {

                 MessageBox.Show("Error! " + ex.Message);

             }



        }

        private void teid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tecnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tecn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tedes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teexp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tesal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tews_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ejd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teexp_TextChanged(object sender, EventArgs e)
        {
            this.teexp.BackColor = Color.White;
        }

        private void teid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ten_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tecnic_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tecn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void teadd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void teg_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void teage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tedes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void teq_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void teexp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tesal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tews_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ejd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void teid_TextChanged(object sender, EventArgs e)
        {
            this.teid.BackColor = Color.White;
        }

        private void ten_TextChanged(object sender, EventArgs e)
        {
            this.ten.BackColor = Color.White;
        }

        private void tecnic_TextChanged(object sender, EventArgs e)
        {
            this.tecnic.BackColor = Color.White;
        }

        private void tecn_TextChanged(object sender, EventArgs e)
        {
            this.tecn.BackColor = Color.White;
        }

        private void teadd_TextChanged(object sender, EventArgs e)
        {
            this.teadd.BackColor = Color.White;
        }

        private void teg_TextChanged(object sender, EventArgs e)
        {
            this.teg.BackColor = Color.White;
        }

        private void teage_TextChanged(object sender, EventArgs e)
        {
            this.teage.BackColor = Color.White;
        }

        private void tes_TextChanged(object sender, EventArgs e)
        {
            this.tes.BackColor = Color.White;
        }

        private void tedes_TextChanged(object sender, EventArgs e)
        {
            this.tedes.BackColor = Color.White;
        }

        private void teq_TextChanged(object sender, EventArgs e)
        {
            this.teq.BackColor = Color.White;
        }

        private void tesal_TextChanged(object sender, EventArgs e)
        {
            this.tesal.BackColor = Color.White;
        }

        private void tews_TextChanged(object sender, EventArgs e)
        {
            this.tews.BackColor = Color.White;
        }

        private void ejd_TextChanged(object sender, EventArgs e)
        {
            this.ejd.BackColor = Color.White;
        }

        private void closepic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
