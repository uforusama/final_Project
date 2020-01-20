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
    public partial class uptrainer : Form
    {
        private bool isUpdate;
        private bool isCanceled;
        protected int tID;
        protected string tname;
        protected string tcontactNO;
        protected string taddress;
        protected string tCNIC;
        protected int tage;
        protected string tgender;
        protected string tstatus;
        protected string tjoinDate;

        protected string tcertification;
        protected string ttrainingexp;
        protected float ttheight;
        protected float ttweight;
        protected int ttsalary;
        protected string tqualification;
        protected string tachievements;
        protected string texpertise;
        protected string tworkinghours;
        protected string tsession;
        protected string tjoindate;

        public bool IsUpdate
        {
            set { isUpdate = value; }
            get { return isUpdate; }
        }
        public bool IsCanceled
        {
            set { isCanceled = value; }
            get { return isCanceled;}
        }

        public int Tid
        {
            set { tID = value; }
            get { return tID; }
        }

        public string tNAME
        {
            set { tname = value; }
            get { return tname; }
        }

        public string tCONTACTNO
        {
            set { tcontactNO = value; }
            get { return tcontactNO; }
        }

        public string tADDRESS
        {
            set { taddress = value; }
            get { return taddress; }
        }

        public string tcnic
        {
            set { tCNIC = value; }
            get { return tCNIC; }
        }

        public int tAGE
        {
            set { tage = value; }
            get { return tage; }
        }

        public string tGENDER
        {
            set { tgender = value; }
            get { return tgender; }
        }

        public string tSTATUS
        {
            set { tstatus = value; }
            get { return tstatus; }
        }




        public string TCERTIFICATION
        {
            set { tcertification = value; }
            get { return tcertification; }
        }

        public string TTRAININGEXP
        {
            set { ttrainingexp = value; }
            get { return ttrainingexp; }
        }

        public float TTHEIGHT
        {
            set { ttheight = value; }
            get { return ttheight; }
        }

        public float TTWEIGHT
        {
            set { ttweight = value; }
            get { return ttweight; }
        }

        public int TTSALARY
        {
            set { ttsalary = value; }
            get { return ttsalary; }
        }

        public string TQUALIFICATION
        {
            set { tqualification = value; }
            get { return tqualification; }
        }

        public string TACHIEVEMENTS
        {
            set { tachievements = value; }
            get { return tachievements; }
        }

        public string TEXPERTISE
        {
            set { texpertise = value; }
            get { return texpertise; }
        }

        public string TWORKINGHOUR
        {
            set { tworkinghours = value; }
            get { return tworkinghours; }
        }

        public string TSESSION
        {
            set { tsession = value; }
            get { return tsession; }
        }
        public string TJOINDATE
        {
            set { tjoindate = value; }
            get { return tjoindate; }
        }



        public uptrainer()
        {
            InitializeComponent();
        }

        private void tupdate_Click(object sender, EventArgs e)
        {
           
        }

        private void tbuttonup_Click(object sender, EventArgs e)
        {
            if (IsValidate()) {

                Tid = int.Parse(this.tratextuid.Text);
                tNAME = this.ttuname.Text;
                tCONTACTNO = this.ttucn.Text;
                tADDRESS = this.ttuadd.Text;
                tcnic = this.ttucnic.Text;
                tAGE = int.Parse(this.ttuage.Text);
                tGENDER = this.ttug.Text;
                tSTATUS = this.ttus.Text;
                TCERTIFICATION = this.ttucer.Text;
                TTRAININGEXP = this.ttuexp.Text;
                TTHEIGHT = Convert.ToSingle(this.ttuh.Text);
                 TTWEIGHT = Convert.ToSingle(this.ttuw.Text);
                 TTSALARY = int.Parse(this.ttusal.Text);
                 TQUALIFICATION = this.ttuq.Text;
                 TACHIEVEMENTS = this.ttuach.Text;
                 TEXPERTISE = this.ttuepr.Text;
                 TWORKINGHOUR = this.ttuwh.Text;
                 TSESSION = this.ttusession.Text;
                 TJOINDATE = this.tjd.Text;


                IsCanceled = false;
                this.Close();
            }
        }

        private bool IsValidate()
        {

            if (this.tratextuid.Text == "")
            {
                MessageBox.Show("ID field should not Empty!");
                this.tratextuid.BackColor = Color.Yellow;
                this.tratextuid.Focus();
                return false;
            }

            if (this.ttuname.Text == "")
            {
                MessageBox.Show("Name field should not Empty!");
                this.ttuname.BackColor = Color.Yellow;
                this.ttuname.Focus();
                return false;
            }

            if (this.ttucnic.Text == "")
            {
                MessageBox.Show("CNIC field should not Empty!");
                this.ttucnic.BackColor = Color.Yellow;
                this.ttucnic.Focus();
                return false;
            }

            if (this.ttucn.Text == "")
            {
                MessageBox.Show("Contact Number field should not Empty!");
                this.ttucn.BackColor = Color.Yellow;
                this.ttucn.Focus();
                return false;
            }

            if (this.ttuadd.Text == "")
            {
                MessageBox.Show("Address field should not Empty!");
                this.ttuadd.BackColor = Color.Yellow;
                this.ttuadd.Focus();
                return false;
            }

            if (this.ttug.Text == "")
            {
                MessageBox.Show("Gender field should not Empty!");
                this.ttug.BackColor = Color.Yellow;
                this.ttug.Focus();
                return false;
            }

            if (this.ttuage.Text == "")
            {
                MessageBox.Show("Age field should not Empty!");
                this.ttuage.BackColor = Color.Yellow;
                this.ttuage.Focus();
                return false;
            }

            if (this.ttus.Text == "")
            {
                MessageBox.Show("Status field should not Empty!");
                this.ttus.BackColor = Color.Yellow;
                this.ttus.Focus();
                return false;
            }





            if (this.ttuh.Text == "")
            {
                MessageBox.Show("Height field should not Empty!");
                this.ttuh.BackColor = Color.Yellow;
                this.ttuh.Focus();
                return false;
            }

            if (this.ttuw.Text == "")
            {
                MessageBox.Show("Weight field should not Empty!");
                this.ttuw.BackColor = Color.Yellow;
                this.ttuw.Focus();
                return false;
            }

            if (this.ttucer.Text == "")
            {
                MessageBox.Show("Certification field should not Empty!");
                this.ttucer.BackColor = Color.Yellow;
                this.ttucer.Focus();
                return false;
            }

            if (this.ttuq.Text == "")
            {
                MessageBox.Show("Qualification field should not Empty!");
                this.ttuq.BackColor = Color.Yellow;
                this.ttuq.Focus();
                return false;
            }

            if (this.ttuexp.Text == "")
            {
                MessageBox.Show("Experience field should not Empty!");
                this.ttuexp.BackColor = Color.Yellow;
                this.ttuexp.Focus();
                return false;
            }

            if (this.ttuach.Text == "")
            {
                MessageBox.Show("Achievements field should not Empty!");
                this.ttuach.BackColor = Color.Yellow;
                this.ttuach.Focus();
                return false;
            }

            if (this.ttuepr.Text == "")
            {
                MessageBox.Show("Expertise field should not Empty!");
                this.ttuepr.BackColor = Color.Yellow;
                this.ttuepr.Focus();
                return false;
            }

            if (this.ttuwh.Text == "")
            {
                MessageBox.Show("Working Hours field should not Empty!");
                this.ttuwh.BackColor = Color.Yellow;
                this.ttuwh.Focus();
                return false;
            }

            if (this.ttusession.Text == "")
            {
                MessageBox.Show("Session field should not Empty!");
                this.ttusession.BackColor = Color.Yellow;
                this.ttusession.Focus();
                return false;
            }

            if (this.ttusal.Text == "")
            {
                MessageBox.Show("Salary field should not Empty!");
                this.ttusal.BackColor = Color.Yellow;
                this.ttusal.Focus();
                return false;
            }
            if (this.tjd.Text == "")
            {
                MessageBox.Show("Join Date field should not Empty!");
                this.tjd.BackColor = Color.Yellow;
                this.tjd.Focus();
                return false;
            }


            return true;
        }

        private void tratextuid_TextChanged(object sender, EventArgs e)
        {
            this.tratextuid.BackColor = Color.White;
        }

        private void ttuname_TextChanged(object sender, EventArgs e)
        {
            this.ttuname.BackColor = Color.White;
        }

        private void ttucnic_TextChanged(object sender, EventArgs e)
        {
            this.ttucnic.BackColor = Color.White;
        }

        private void ttucn_TextChanged(object sender, EventArgs e)
        {
            this.ttucn.BackColor = Color.White;
        }

        private void ttuadd_TextChanged(object sender, EventArgs e)
        {
            this.ttuadd.BackColor = Color.White;
        }

        private void ttug_TextChanged(object sender, EventArgs e)
        {
            this.ttug.BackColor = Color.White;
        }

        private void ttuage_TextChanged(object sender, EventArgs e)
        {
            this.ttuage.BackColor = Color.White;
        }

        private void ttus_TextChanged(object sender, EventArgs e)
        {
            this.ttus.BackColor = Color.White;
        }

        private void ttuh_TextChanged(object sender, EventArgs e)
        {
            this.ttuh.BackColor = Color.White;
        }

        private void ttuw_TextChanged(object sender, EventArgs e)
        {
            this.ttuw.BackColor = Color.White;
        }

        private void ttucer_TextChanged(object sender, EventArgs e)
        {
            this.ttucer.BackColor = Color.White;
        }

        private void ttuq_TextChanged(object sender, EventArgs e)
        {
            this.ttuq.BackColor = Color.White;
        }

        private void ttuexp_TextChanged(object sender, EventArgs e)
        {
            this.ttuexp.BackColor = Color.White;
        }

        private void ttuach_TextChanged(object sender, EventArgs e)
        {
            this.ttuach.BackColor = Color.White;
        }

        private void ttuepr_TextChanged(object sender, EventArgs e)
        {
            this.ttuepr.BackColor = Color.White;
        }

        private void ttuwh_TextChanged(object sender, EventArgs e)
        {
            this.ttuwh.BackColor = Color.White;
        }

        private void ttusession_TextChanged(object sender, EventArgs e)
        {
            this.ttusession.BackColor = Color.White;
        }

        private void ttusal_TextChanged(object sender, EventArgs e)
        {
            this.ttusal.BackColor = Color.White;
        }

        private void tcancel_Click(object sender, EventArgs e)
        {
            IsCanceled = true;
            this.Close();
        }

        private void uptrainer_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                this.tratextuid.Text = Convert.ToInt32(Tid).ToString();
                this.ttuname.Text = tNAME.ToString();
                this.ttucnic.Text = tcnic.ToString();
                this.ttucn.Text = tCONTACTNO.ToString();
                this.ttuadd.Text = tADDRESS.ToString();
                this.ttug.Text = tGENDER.ToString();
                this.ttuage.Text = tAGE.ToString();
                this.ttus.Text = tSTATUS.ToString();
                this.ttuh.Text = Convert.ToSingle(TTHEIGHT).ToString();
                this.ttuw.Text = Convert.ToSingle(TTWEIGHT).ToString();
                this.ttucer.Text = TCERTIFICATION.ToString();
                this.ttuq.Text = TQUALIFICATION.ToString();
                this.ttuexp.Text = TTRAININGEXP.ToString();
                this.ttuach.Text = TACHIEVEMENTS.ToString();
                this.ttuepr.Text = TEXPERTISE.ToString();
                this.ttuwh.Text = TWORKINGHOUR.ToString();
                this.ttusession.Text = TSESSION.ToString();
                this.ttusal.Text = Convert.ToInt32(TTSALARY).ToString();
                this.tjd.Text = TJOINDATE.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void tratextuid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttuname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttucnic_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttucn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttuadd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttug_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttuage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttus_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttuh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttuw_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttucer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttuq_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttuexp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttuach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttuepr_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttuwh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttusession_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ttusal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tbuttonup_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tcancel_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void tratextuid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttuname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttucnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttucn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttuadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttug_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttuage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttucer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttuq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttuexp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttuach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttuepr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttuwh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttusession_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&  !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ttusal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsNumber(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.tjd.BackColor = Color.White;
        }
    }
}
