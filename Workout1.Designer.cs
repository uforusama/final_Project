namespace WindowsFormsApplication4
{
    partial class Workout1
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
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblexpectedresult = new System.Windows.Forms.Label();
            this.lblduration = new System.Windows.Forms.Label();
            this.lblwname = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.txtwname = new System.Windows.Forms.TextBox();
            this.txtexpectedresult = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(50, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 19);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "id";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(451, 20);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(77, 19);
            this.lbldescription.TabIndex = 1;
            this.lbldescription.Text = "description";
            // 
            // lblexpectedresult
            // 
            this.lblexpectedresult.AutoSize = true;
            this.lblexpectedresult.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpectedresult.Location = new System.Drawing.Point(440, 180);
            this.lblexpectedresult.Name = "lblexpectedresult";
            this.lblexpectedresult.Size = new System.Drawing.Size(97, 19);
            this.lblexpectedresult.TabIndex = 2;
            this.lblexpectedresult.Text = "expectedresult";
            // 
            // lblduration
            // 
            this.lblduration.AutoSize = true;
            this.lblduration.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduration.Location = new System.Drawing.Point(34, 361);
            this.lblduration.Name = "lblduration";
            this.lblduration.Size = new System.Drawing.Size(63, 19);
            this.lblduration.TabIndex = 3;
            this.lblduration.Text = "duration";
            // 
            // lblwname
            // 
            this.lblwname.AutoSize = true;
            this.lblwname.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwname.Location = new System.Drawing.Point(34, 180);
            this.lblwname.Name = "lblwname";
            this.lblwname.Size = new System.Drawing.Size(54, 19);
            this.lblwname.TabIndex = 4;
            this.lblwname.Text = "wname";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(12, 70);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(117, 20);
            this.txtid.TabIndex = 5;
            this.txtid.Text = "12";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(423, 70);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(142, 20);
            this.txtdescription.TabIndex = 6;
            // 
            // txtduration
            // 
            this.txtduration.Location = new System.Drawing.Point(12, 414);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(117, 20);
            this.txtduration.TabIndex = 7;
            // 
            // txtwname
            // 
            this.txtwname.Location = new System.Drawing.Point(12, 228);
            this.txtwname.Name = "txtwname";
            this.txtwname.Size = new System.Drawing.Size(117, 20);
            this.txtwname.TabIndex = 8;
            // 
            // txtexpectedresult
            // 
            this.txtexpectedresult.Location = new System.Drawing.Point(423, 218);
            this.txtexpectedresult.Name = "txtexpectedresult";
            this.txtexpectedresult.Size = new System.Drawing.Size(142, 20);
            this.txtexpectedresult.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(721, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 88);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Workout1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.leg_press_5_1;
            this.ClientSize = new System.Drawing.Size(967, 488);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtexpectedresult);
            this.Controls.Add(this.txtwname);
            this.Controls.Add(this.txtduration);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblwname);
            this.Controls.Add(this.lblduration);
            this.Controls.Add(this.lblexpectedresult);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblid);
            this.Name = "Workout1";
            this.Text = "Workout1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblexpectedresult;
        private System.Windows.Forms.Label lblduration;
        private System.Windows.Forms.Label lblwname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.TextBox txtwname;
        private System.Windows.Forms.TextBox txtexpectedresult;
        private System.Windows.Forms.Button btnSubmit;
    }
}

