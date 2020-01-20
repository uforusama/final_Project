using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessclub
{
    public partial class empedit : Form
    {

        private bool isUpdate;
        private bool isCanceled;
        protected int eID;
        protected string ename;
        protected string econtactNO;
        protected string eaddress;
        protected string eCNIC;
        protected int eage;
        protected string egender;
        protected string estatus;
        protected string ejoinDate;

        protected string edesignation;
        protected string eesalary;
        protected string eeexperience;
        protected string eempqualification;
        protected string eworkschedule;

        public int eid
        {
            set { eID = value; }
            get { return eID; }
        }

        public string eNAME
        {
            set { ename = value; }
            get { return ename; }
        }

        public string eCONTACTNO
        {
            set { econtactNO = value; }
            get { return econtactNO; }
        }

        public string eADDRESS
        {
            set { eaddress = value; }
            get { return eaddress; }
        }

        public string ecnic
        {
            set { eCNIC = value; }
            get { return eCNIC; }
        }

        public int eAGE
        {
            set { eage = value; }
            get { return eage; }
        }

        public string eGENDER
        {
            set { egender = value; }
            get { return egender; }
        }

        public string eSTATUS
        {
            set { estatus = value; }
            get { return estatus; }
        }
        public string eJOINDATE
        {
            set { ejoinDate = value; }
            get { return ejoinDate; }
        }
        public string eDESIGNATION
        {
            set { edesignation = value; }
            get { return edesignation; }
        }

        public string eESALARY
        {
            set { eesalary = value; }
            get { return eesalary; }
        }

        public string eEEXPERIENC
        {
            set { eeexperience = value; }
            get { return eeexperience; }
        }

        public string eEMPQUALIFICATION
        {
            set { eempqualification = value; }
            get { return eempqualification; }
        }

        public string eWORKSCHEDULE
        {
            set { eworkschedule = value; }
            get { return eworkschedule; }
        }

        public bool IsUpdate
        {
            set { isUpdate = value; }
            get { return isUpdate; }
        }
        public bool IsCanceled
        {
            set { isCanceled = value; }
            get { return isCanceled; }
        }


        public empedit()
        {
            InitializeComponent();
        }

       

        private void ebuttonup_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {

                eid = int.Parse(this.tueid.Text);
                eNAME = this.tuen.Text;
                eCONTACTNO = this.tuecn.Text;
                eADDRESS = this.tueadd.Text;
                ecnic = this.tuecnic.Text;
                eAGE = int.Parse(this.tueage.Text);
                eGENDER = this.tueg.Text;
                eSTATUS = this.tues.Text;
                eDESIGNATION = this.tuedes.Text;
                eESALARY = this.tuesal.Text;
                eEEXPERIENC = this.tueexp.Text;
                eEMPQUALIFICATION = this.tueq.Text;
                eWORKSCHEDULE = this.tuews.Text;
                eJOINDATE = this.tuejd.Text;

                IsCanceled = false;
                this.Close();
            }

        }

        private bool IsValidate()
        {

            if (this.tueid.Text == "")
            {
                MessageBox.Show("ID field should not Empty!");
                this.tueid.BackColor = Color.Yellow;
                this.tueid.Focus();
                return false;
            }

            if (this.tuen.Text == "")
            {
                MessageBox.Show("Name field should not Empty!");
                this.tuen.BackColor = Color.Yellow;
                this.tuen.Focus();
                return false;
            }

            if (this.tuecnic.Text == "")
            {
                MessageBox.Show("CNIC field should not Empty!");
                this.tuecnic.BackColor = Color.Yellow;
                this.tuecnic.Focus();
                return false;
            }

            if (this.tuecn.Text == "")
            {
                MessageBox.Show("Contact Number field should not Empty!");
                this.tuecn.BackColor = Color.Yellow;
                this.tuecn.Focus();
                return false;
            }

            if (this.tueadd.Text == "")
            {
                MessageBox.Show("Address field should not Empty!");
                this.tueadd.BackColor = Color.Yellow;
                this.tueadd.Focus();
                return false;
            }

            if (this.tueg.Text == "")
            {
                MessageBox.Show("Gender field should not Empty!");
                this.tueg.BackColor = Color.Yellow;
                this.tueg.Focus();
                return false;
            }

            if (this.tueage.Text == "")
            {
                MessageBox.Show("Age field should not Empty!");
                this.tueage.BackColor = Color.Yellow;
                this.tueage.Focus();
                return false;
            }

            if (this.tues.Text == "")
            {
                MessageBox.Show("Status field should not Empty!");
                this.tues.BackColor = Color.Yellow;
                this.tues.Focus();
                return false;
            }





            if (this.tuedes.Text == "")
            {
                MessageBox.Show("Designition field should not Empty!");
                this.tuedes.BackColor = Color.Yellow;
                this.tuedes.Focus();
                return false;
            }

            if (this.tueq.Text == "")
            {
                MessageBox.Show("Qualification field should not Empty!");
                this.tueq.BackColor = Color.Yellow;
                this.tueq.Focus();
                return false;
            }

            if (this.tueexp.Text == "")
            {
                MessageBox.Show("Experience field should not Empty!");
                this.tueexp.BackColor = Color.Yellow;
                this.tueexp.Focus();
                return false;
            }

            if (this.tuesal.Text == "")
            {
                MessageBox.Show("Salary field should not Empty!");
                this.tuesal.BackColor = Color.Yellow;
                this.tuesal.Focus();
                return false;
            }

            if (this.tuews.Text == "")
            {
                MessageBox.Show("Working Schedual field should not Empty!");
                this.tuews.BackColor = Color.Yellow;
                this.tuews.Focus();
                return false;
            }

            if (this.tuejd.Text == "")
            {
                MessageBox.Show("Join Date field should not Empty!");
                this.tuejd.BackColor = Color.Yellow;
                this.tuejd.Focus();
                return false;
            }

           
            return true;
        }

        private void tueid_TextChanged(object sender, EventArgs e)
        {
            this.tueid.BackColor = Color.White;
        }

        private void tuen_TextChanged(object sender, EventArgs e)
        {
            this.tuen.BackColor = Color.White;
        }

        private void tuecnic_TextChanged(object sender, EventArgs e)
        {
            this.tuecnic.BackColor = Color.White;
        }

        private void tuecn_TextChanged(object sender, EventArgs e)
        {
            this.tuecn.BackColor = Color.White;
        }

        private void tueadd_TextChanged(object sender, EventArgs e)
        {
            this.tueadd.BackColor = Color.White;
        }

        private void tueg_TextChanged(object sender, EventArgs e)
        {
            this.tueg.BackColor = Color.White;
        }

        private void tueage_TextChanged(object sender, EventArgs e)
        {
            this.tueage.BackColor = Color.White;
        }

        private void tues_TextChanged(object sender, EventArgs e)
        {
            this.tues.BackColor = Color.White;
        }

        private void tuedes_TextChanged(object sender, EventArgs e)
        {
            this.tuedes.BackColor = Color.White;
        }

        private void tueq_TextChanged(object sender, EventArgs e)
        {
            this.tueq.BackColor = Color.White;
        }

        private void tueexp_TextChanged(object sender, EventArgs e)
        {
            this.tueexp.BackColor = Color.White;
        }

        private void tuesal_TextChanged(object sender, EventArgs e)
        {
            this.tuesal.BackColor = Color.White;
        }

        private void tuews_TextChanged(object sender, EventArgs e)
        {
            this.tuews.BackColor = Color.White;
        }

        private void tuejd_TextChanged(object sender, EventArgs e)
        {
            this.tuejd.BackColor = Color.White;
        }

        private void ecancel_Click(object sender, EventArgs e)
        {
            IsCanceled = true;
            this.Close();

        }


        private void empedit_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                this.tueid.Text = Convert.ToInt32(eid).ToString();
                this.tuen.Text = eNAME.ToString();
                this.tuecnic.Text = ecnic.ToString();
                this.tuecn.Text = eCONTACTNO.ToString();
                this.tueadd.Text = eADDRESS.ToString();
                this.tueg.Text = eGENDER.ToString();
                this.tueage.Text = eAGE.ToString();
                this.tues.Text = eSTATUS.ToString();
                this.tuedes.Text =eDESIGNATION.ToString();
                this.tueq.Text = eEMPQUALIFICATION.ToString();
                this.tueexp.Text = eEEXPERIENC.ToString();
                this.tuesal.Text = eESALARY.ToString();
                this.tuews.Text = eWORKSCHEDULE.ToString();
                this.tuejd.Text = eJOINDATE.ToString();
               
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void tueid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tuen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tuecnic_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tuecn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tueadd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tueg_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tueage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tues_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tuedes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tueq_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tueexp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tuesal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tuews_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tuejd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tueid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tuen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tuecnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar)  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tuecn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar)  && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tueadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tueg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tueage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tues_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tuedes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tueq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tueexp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tuesal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tuews_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tuejd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
