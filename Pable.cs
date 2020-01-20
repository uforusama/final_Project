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
    public partial class Pable : Form
    {
        public Pable()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void cal_Click(object sender, EventArgs e)
        {
            Expence exp1 = new Expence();
            if (IsValidate())
            {
                exp1.MONTH = tm.Text;
                exp1.DECPURCHASE = tpd.Text;
                exp1.TOTALSAL = Convert.ToInt32(ts.Text);
                exp1.ELECBILL = Convert.ToInt32(teb.Text);
                exp1.WATERBILL = Convert.ToInt32(twb.Text);
                exp1.MAINTCOST = Convert.ToInt32(tmain.Text);
                exp1.PURCHASES = Convert.ToInt32(tp.Text);
            }
            exp1.TOTAL = exp1.TOTALSAL + exp1.ELECBILL + exp1.WATERBILL + exp1.MAINTCOST + exp1.PURCHASES;
            total.Text = Convert.ToString(exp1.TOTAL);
        }

        public bool IsValidate()
        {

            if (this.tm.Text == "")
            {
                MessageBox.Show("Month field should not Empty!");
                this.tm.BackColor = Color.Yellow;
                this.tm.Focus();
                return false;
            }

            if (this.ts.Text == "")
            {
                MessageBox.Show("Salary field should not Empty!");
                this.ts.BackColor = Color.Yellow;
                this.ts.Focus();
                return false;
            }

            if (this.teb.Text == "")
            {
                MessageBox.Show("Electricity_Bill field should not Empty!");
                this.teb.BackColor = Color.Yellow;
                this.teb.Focus();
                return false;
            }

            if (this.twb.Text == "")
            {
                MessageBox.Show("Water_Bill field should not Empty!");
                this.twb.BackColor = Color.Yellow;
                this.twb.Focus();
                return false;
            }

            if (this.tmain.Text == "")
            {
                MessageBox.Show("Maintainance field should not Empty!");
                this.tmain.BackColor = Color.Yellow;
                this.tmain.Focus();
                return false;
            }

            if (this.tpd.Text == "")
            {
                MessageBox.Show("Purchase_Details field should not Empty!");
                this.tpd.BackColor = Color.Yellow;
                this.tpd.Focus();
                return false;
            }

            if (this.tp.Text == "")
            {
                MessageBox.Show("Purchase field should not Empty!");
                this.tp.BackColor = Color.Yellow;
                this.tp.Focus();
                return false;
            }

           
                      return true;
                  }



        private void tsave_Click(object sender, EventArgs e)
        {
             try
             {
                 Expence exp2 = new Expence();
               
                  

                string connString = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand("AddExpence", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                    
                    exp2.MONTH = tm.Text;
                    exp2.TOTALSAL = Convert.ToInt32(ts.Text);
                    exp2.ELECBILL = Convert.ToInt32(teb.Text);
                    exp2.WATERBILL = Convert.ToInt32(twb.Text);
                    exp2.MAINTCOST = Convert.ToInt32(tmain.Text);
                    exp2.DECPURCHASE = tpd.Text;
                    exp2.PURCHASES = Convert.ToInt32(tp.Text);
                    exp2.TOTAL = Convert.ToInt32(total.Text);
                

            cmd.Parameters.Add("@m", SqlDbType.VarChar, 50).Value = exp2.MONTH;
                cmd.Parameters.Add("@sal",SqlDbType.Int).Value=exp2.TOTALSAL;
                cmd.Parameters.Add("@eb", SqlDbType.Int).Value = exp2.ELECBILL;
                cmd.Parameters.Add("@wb", SqlDbType.Int).Value = exp2.WATERBILL;
                cmd.Parameters.Add("@main", SqlDbType.Int).Value=exp2.MAINTCOST;
                cmd.Parameters.Add("@pdes", SqlDbType.VarChar, 50).Value=exp2.DECPURCHASE;
                cmd.Parameters.Add("@p", SqlDbType.Int).Value=exp2.PURCHASES;
                cmd.Parameters.Add("@total", SqlDbType.Int).Value=exp2.TOTAL;

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

        private void tm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void SelectNextControl(Action<object, KeyEventArgs> tm_KeyUp, bool p1, bool p2, bool p3, bool p4)
        {
            throw new NotImplementedException();
        }

        private void ts_TextChanged(object sender, EventArgs e)
        {
            this.ts.BackColor = Color.White;
        }

        private void ts_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void teb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void twb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tmain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tpd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tsave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void twb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tmain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tpd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tm_TextChanged(object sender, EventArgs e)
        {
            this.tm.BackColor = Color.White;
        }

        private void teb_TextChanged(object sender, EventArgs e)
        {
            this.teb.BackColor = Color.White;
        }

        private void twb_TextChanged(object sender, EventArgs e)
        {
            this.twb.BackColor = Color.White;
        }

        private void tmain_TextChanged(object sender, EventArgs e)
        {
            this.tmain.BackColor = Color.White;
        }

        private void tpd_TextChanged(object sender, EventArgs e)
        {
            this.tpd.BackColor = Color.White;
        }

        private void tp_TextChanged(object sender, EventArgs e)
        {
            this.tp.BackColor = Color.White;
        }

        private void closepic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
