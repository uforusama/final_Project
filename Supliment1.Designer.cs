namespace WindowsFormsApplication4
{
    partial class Supliment1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtexpiredate = new System.Windows.Forms.TextBox();
            this.txtsup = new System.Windows.Forms.TextBox();
            this.txtsupname = new System.Windows.Forms.TextBox();
            this.txtsupp = new System.Windows.Forms.TextBox();
            this.txtsupdescription = new System.Windows.Forms.TextBox();
            this.txtbenefit = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(445, 176);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(75, 19);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "expiredate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "supprice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "benefit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "supdescription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "supname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "sup";
            // 
            // txtexpiredate
            // 
            this.txtexpiredate.Location = new System.Drawing.Point(411, 218);
            this.txtexpiredate.Name = "txtexpiredate";
            this.txtexpiredate.Size = new System.Drawing.Size(132, 20);
            this.txtexpiredate.TabIndex = 7;
            // 
            // txtsup
            // 
            this.txtsup.Location = new System.Drawing.Point(12, 66);
            this.txtsup.Name = "txtsup";
            this.txtsup.Size = new System.Drawing.Size(134, 20);
            this.txtsup.TabIndex = 8;
            // 
            // txtsupname
            // 
            this.txtsupname.Location = new System.Drawing.Point(12, 218);
            this.txtsupname.Name = "txtsupname";
            this.txtsupname.Size = new System.Drawing.Size(134, 20);
            this.txtsupname.TabIndex = 9;
            // 
            // txtsupp
            // 
            this.txtsupp.Location = new System.Drawing.Point(411, 66);
            this.txtsupp.Name = "txtsupp";
            this.txtsupp.Size = new System.Drawing.Size(132, 20);
            this.txtsupp.TabIndex = 10;
            // 
            // txtsupdescription
            // 
            this.txtsupdescription.Location = new System.Drawing.Point(12, 367);
            this.txtsupdescription.Name = "txtsupdescription";
            this.txtsupdescription.Size = new System.Drawing.Size(134, 20);
            this.txtsupdescription.TabIndex = 11;
            // 
            // txtbenefit
            // 
            this.txtbenefit.Location = new System.Drawing.Point(411, 367);
            this.txtbenefit.Name = "txtbenefit";
            this.txtbenefit.Size = new System.Drawing.Size(132, 20);
            this.txtbenefit.TabIndex = 12;
            this.txtbenefit.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(773, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 78);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Supliment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.mobileapp_banner04_large;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 479);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbenefit);
            this.Controls.Add(this.txtsupdescription);
            this.Controls.Add(this.txtsupp);
            this.Controls.Add(this.txtsupname);
            this.Controls.Add(this.txtsup);
            this.Controls.Add(this.txtexpiredate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblid);
            this.DoubleBuffered = true;
            this.Name = "Supliment1";
            this.Text = "Supliment1";
            this.Load += new System.EventHandler(this.Supliment1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtexpiredate;
        private System.Windows.Forms.TextBox txtsup;
        private System.Windows.Forms.TextBox txtsupname;
        private System.Windows.Forms.TextBox txtsupp;
        private System.Windows.Forms.TextBox txtsupdescription;
        private System.Windows.Forms.TextBox txtbenefit;
        private System.Windows.Forms.Button btnAdd;
    }
}