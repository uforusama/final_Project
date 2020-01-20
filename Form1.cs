using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessclub
{
    public partial class trn : Form
    {
        public trn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tid_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.tratextid.BackColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            this.ttepr.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Trainer t2 = new Trainer();
                if (IsValidate())
                {
                    t2.id = Convert.ToInt32(tratextid.Text);
                    t2.NAME = ttname.Text;
                    t2.cnic = ttcnic.Text;
                    t2.CONTACTNO = ttcn.Text;
                    t2.ADDRESS = ttadd.Text;
                    t2.GENDER = ttg.Text;
                    t2.AGE = Convert.ToInt32(ttage.Text);
                    t2.STATUS = tts.Text;
                    t2.THEIGHT = Convert.ToSingle(tth.Text);
                    t2.TWEIGHT = Convert.ToSingle(ttw.Text);
                    t2.CERTIFICATION = ttcer.Text;
                    t2.QUALIFICATION = ttq.Text;
                    t2.TRAININGEXP = ttexp.Text;
                    t2.ACHIEVEMENTS = ttach.Text;
                    t2.EXPERTISE = ttepr.Text;
                    t2.WORKINGHOUR = ttwh.Text;
                    t2.SESSION = ttsession.Text;
                    t2.TSALARY = Convert.ToInt32(ttsal.Text);
                    t2.JOINDATE = tjd.Text;
                }
               


                string connString = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand("TrainerData", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                Trainer t1 = new Trainer();
                
                    t1.id = Convert.ToInt32(tratextid.Text);
                    t1.NAME = ttname.Text;
                    t1.cnic = ttcnic.Text;
                    t1.CONTACTNO = ttcn.Text;
                    t1.ADDRESS = ttadd.Text;
                    t1.GENDER = ttg.Text;
                    t1.AGE = Convert.ToInt32(ttage.Text);
                    t1.STATUS = tts.Text;
                    t1.THEIGHT = Convert.ToSingle(tth.Text);
                    t1.TWEIGHT = Convert.ToSingle(ttw.Text);
                    t1.CERTIFICATION = ttcer.Text;
                    t1.QUALIFICATION = ttq.Text;
                    t1.TRAININGEXP = ttexp.Text;
                    t1.ACHIEVEMENTS = ttach.Text;
                    t1.EXPERTISE = ttepr.Text;
                    t1.WORKINGHOUR = ttwh.Text;
                    t1.SESSION = ttsession.Text;
                    t1.TSALARY = Convert.ToInt32(ttsal.Text);
                    t1.JOINDATE = tjd.Text;
                
               
                

                cmd.Parameters.Add("@tid", SqlDbType.Int).Value=t1.id;
                cmd.Parameters.Add("@tname",SqlDbType.VarChar,50).Value=t1.NAME;
                cmd.Parameters.Add("@tcnic", SqlDbType.VarChar, 50).Value = t1.cnic;
                cmd.Parameters.Add("@tcno", SqlDbType.VarChar, 50).Value = t1.CONTACTNO;
                cmd.Parameters.Add("@tadd", System.Data.SqlDbType.VarChar).Value=t1.ADDRESS;
                cmd.Parameters.Add("@tgen", SqlDbType.VarChar, 50).Value=t1.GENDER;
                cmd.Parameters.Add("@tage", SqlDbType.Int).Value=t1.AGE;
                cmd.Parameters.Add("@tst", SqlDbType.VarChar, 50).Value=t1.STATUS;
                cmd.Parameters.Add("@th", SqlDbType.Float).Value=t1.THEIGHT;
                cmd.Parameters.Add("@tw", SqlDbType.Float).Value=t1.TWEIGHT;
                cmd.Parameters.Add("@tcer", System.Data.SqlDbType.VarChar).Value=t1.CERTIFICATION;
                cmd.Parameters.Add("@tqual", System.Data.SqlDbType.VarChar).Value=t1.QUALIFICATION;
                cmd.Parameters.Add("@texp", System.Data.SqlDbType.VarChar).Value=t1.TRAININGEXP;
                cmd.Parameters.Add("@tach", System.Data.SqlDbType.VarChar).Value=t1.ACHIEVEMENTS;
                cmd.Parameters.Add("@tepr", System.Data.SqlDbType.VarChar).Value=t1.EXPERTISE;
                cmd.Parameters.Add("@twh", SqlDbType.VarChar, 50).Value=t1.WORKINGHOUR;
                cmd.Parameters.Add("@tsession", SqlDbType.VarChar, 50).Value=t1.SESSION;
                cmd.Parameters.Add("@tsal", SqlDbType.Int).Value=t1.TSALARY;
                cmd.Parameters.Add("@jd", SqlDbType.VarChar, 50).Value = t1.JOINDATE;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data is Saved Successfuly!");
                this.Hide();
                tfetch tf = new tfetch();
                tf.ShowDialog();

            }catch(Exception ex){

                MessageBox.Show("Error! " + ex.Message);

            }
        }

        public bool IsValidate()
        {

            if (this.tratextid.Text == "")
            {
                MessageBox.Show("ID field should not Empty!");
                this.tratextid.BackColor = Color.Yellow;
                this.tratextid.Focus();
                return false;
            }

            if (this.ttname.Text == "")
            {
                MessageBox.Show("Name field should not Empty!");
                this.ttname.BackColor = Color.Yellow;
                this.ttname.Focus();
                return false;
            }

            if (this.ttcnic.Text == "")
            {
                MessageBox.Show("CNIC field should not Empty!");
                this.ttcnic.BackColor = Color.Yellow;
                this.ttcnic.Focus();
                return false;
            }

            if (this.ttcn.Text == "")
            {
                MessageBox.Show("Contact Number field should not Empty!");
                this.ttcn.BackColor = Color.Yellow;
                this.ttcn.Focus();
                return false;
            }

            if (this.ttadd.Text == "")
            {
                MessageBox.Show("Address field should not Empty!");
                this.ttadd.BackColor = Color.Yellow;
                this.ttadd.Focus();
                return false;
            }

            if (this.ttg.Text == "")
            {
                MessageBox.Show("Gender field should not Empty!");
                this.ttg.BackColor = Color.Yellow;
                this.ttg.Focus();
                return false;
            }

            if (this.ttage.Text == "")
            {
                MessageBox.Show("Age field should not Empty!");
                this.ttage.BackColor = Color.Yellow;
                this.ttage.Focus();
                return false;
            }

            if (this.tts.Text == "")
            {
                MessageBox.Show("Status field should not Empty!");
                this.tts.BackColor = Color.Yellow;
                this.tts.Focus();
                return false;
            }





            if (this.tth.Text == "")
            {
                MessageBox.Show("Height field should not Empty!");
                this.tth.BackColor = Color.Yellow;
                this.tth.Focus();
                return false;
            }

            if (this.ttw.Text == "")
            {
                MessageBox.Show("Weight field should not Empty!");
                this.ttw.BackColor = Color.Yellow;
                this.ttw.Focus();
                return false;
            }

            if (this.ttcer.Text == "")
            {
                MessageBox.Show("Certification field should not Empty!");
                this.ttcer.BackColor = Color.Yellow;
                this.ttcer.Focus();
                return false;
            }

            if (this.ttq.Text == "")
            {
                MessageBox.Show("Qualification field should not Empty!");
                this.ttq.BackColor = Color.Yellow;
                this.ttq.Focus();
                return false;
            }

            if (this.ttexp.Text == "")
            {
                MessageBox.Show("Experience field should not Empty!");
                this.ttexp.BackColor = Color.Yellow;
                this.ttexp.Focus();
                return false;
            }

            if (this.ttach.Text == "")
            {
                MessageBox.Show("Achievements field should not Empty!");
                this.ttach.BackColor = Color.Yellow;
                this.ttach.Focus();
                return false;
            }

            if (this.ttepr.Text == "")
            {
                MessageBox.Show("Expertise field should not Empty!");
                this.ttepr.BackColor = Color.Yellow;
                this.ttepr.Focus();
                return false;
            }

            if (this.ttwh.Text == "")
            {
                MessageBox.Show("Working Hours field should not Empty!");
                this.ttwh.BackColor = Color.Yellow;
                this.ttwh.Focus();
                return false;
            }

            if (this.ttsession.Text == "")
            {
                MessageBox.Show("Session field should not Empty!");
                this.ttsession.BackColor = Color.Yellow;
                this.ttsession.Focus();
                return false;
            }

            if (this.ttsal.Text == "")
            {
                MessageBox.Show("Salary field should not Empty!");
                this.ttsal.BackColor = Color.Yellow;
                this.ttsal.Focus();
                return false;
            }

            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.ttname.BackColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.ttsession.BackColor = Color.White;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ttcnic_TextChanged(object sender, EventArgs e)
        {
            this.ttcnic.BackColor = Color.White;
        }

        private void ttcn_TextChanged(object sender, EventArgs e)
        {
            this.ttcn.BackColor = Color.White;
        }

        private void ttadd_TextChanged(object sender, EventArgs e)
        {
            this.ttadd.BackColor = Color.White;
        }

        private void ttg_TextChanged(object sender, EventArgs e)
        {
            this.ttg.BackColor = Color.White;
        }

        private void ttage_TextChanged(object sender, EventArgs e)
        {
            this.ttage.BackColor = Color.White;
        }

        private void tts_TextChanged(object sender, EventArgs e)
        {
            this.tts.BackColor = Color.White;
        }

        private void tth_TextChanged(object sender, EventArgs e)
        {
            this.tth.BackColor = Color.White;
        }

        private void ttw_TextChanged(object sender, EventArgs e)
        {
            this.ttw.BackColor = Color.White;
        }

        private void ttcer_TextChanged(object sender, EventArgs e)
        {
            this.ttcer.BackColor = Color.White;
        }

        private void ttq_TextChanged(object sender, EventArgs e)
        {
            this.ttq.BackColor = Color.White;
        }

        private void ttexp_TextChanged(object sender, EventArgs e)
        {
            this.ttexp.BackColor = Color.White;
        }

        private void ttach_TextChanged(object sender, EventArgs e)
        {
            this.ttach.BackColor = Color.White;
        }

        private void ttwh_TextChanged(object sender, EventArgs e)
        {
            this.ttwh.BackColor = Color.White;
        }

        private void ttsal_TextChanged(object sender, EventArgs e)
        {
            this.ttsal.BackColor = Color.White;
        }

        private void tjd_TextChanged(object sender, EventArgs e)
        {
            this.tjd.BackColor = Color.White;
        }

        private void tratextid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttcnic_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttcn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttadd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttg_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tts_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tth_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttw_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttcer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttq_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttexp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttepr_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttwh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttsession_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttsal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tjd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttcer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttexp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttepr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttwh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tjd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tratextid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar)  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttcnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar)  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttcn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar)  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tth_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void ttw_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ttsession_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttsal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
