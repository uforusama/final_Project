namespace WindowsFormsApplication4
{
    partial class Attendance1
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
            this.lblname = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnTaken = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(469, 269);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 19);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "name";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(50, 269);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(36, 19);
            this.lbltime.TabIndex = 7;
            this.lbltime.Text = "time";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(469, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 19);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(50, 37);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(36, 19);
            this.lbldate.TabIndex = 9;
            this.lbldate.Text = "date";
            // 
            // btnTaken
            // 
            this.btnTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaken.Location = new System.Drawing.Point(724, 371);
            this.btnTaken.Name = "btnTaken";
            this.btnTaken.Size = new System.Drawing.Size(154, 78);
            this.btnTaken.TabIndex = 14;
            this.btnTaken.Text = "Taken";
            this.btnTaken.UseVisualStyleBackColor = true;
            this.btnTaken.Click += new System.EventHandler(this.btnTaken_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(426, 330);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(122, 20);
            this.txtname.TabIndex = 15;
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(12, 330);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(122, 20);
            this.txttime.TabIndex = 16;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(12, 80);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(122, 20);
            this.txtdate.TabIndex = 17;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(426, 80);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(122, 20);
            this.txtID.TabIndex = 18;
            // 
            // Attendance1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.gym_attendance;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 488);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnTaken);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblname);
            this.Name = "Attendance1";
            this.Text = "Attendance1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btnTaken;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtID;
    }
}