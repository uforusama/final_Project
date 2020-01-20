namespace fitnessclub
{
    partial class tfetch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tfetch));
            this.srcht = new System.Windows.Forms.TextBox();
            this.srchb = new System.Windows.Forms.Button();
            this.tdata = new System.Windows.Forms.DataGridView();
            this.DGVContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.closepic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tdata)).BeginInit();
            this.DGVContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).BeginInit();
            this.SuspendLayout();
            // 
            // srcht
            // 
            this.srcht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcht.Location = new System.Drawing.Point(82, 30);
            this.srcht.Name = "srcht";
            this.srcht.Size = new System.Drawing.Size(130, 29);
            this.srcht.TabIndex = 1;
            // 
            // srchb
            // 
            this.srchb.BackColor = System.Drawing.Color.ForestGreen;
            this.srchb.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchb.ForeColor = System.Drawing.Color.White;
            this.srchb.Location = new System.Drawing.Point(227, 30);
            this.srchb.Name = "srchb";
            this.srchb.Size = new System.Drawing.Size(78, 29);
            this.srchb.TabIndex = 2;
            this.srchb.Text = "Search";
            this.srchb.UseVisualStyleBackColor = false;
            this.srchb.Click += new System.EventHandler(this.srchb_Click);
            // 
            // tdata
            // 
            this.tdata.AllowUserToAddRows = false;
            this.tdata.AllowUserToDeleteRows = false;
            this.tdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tdata.ContextMenuStrip = this.DGVContextMenu;
            this.tdata.Location = new System.Drawing.Point(84, 79);
            this.tdata.Name = "tdata";
            this.tdata.ReadOnly = true;
            this.tdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tdata.Size = new System.Drawing.Size(598, 234);
            this.tdata.TabIndex = 3;
            this.tdata.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tdata_MouseDown);
            // 
            // DGVContextMenu
            // 
            this.DGVContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem,
            this.addToolStripMenuItem});
            this.DGVContextMenu.Name = "DGVContextMenu";
            this.DGVContextMenu.Size = new System.Drawing.Size(108, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search By Name";
            // 
            // closepic
            // 
            this.closepic.BackColor = System.Drawing.Color.Transparent;
            this.closepic.Image = ((System.Drawing.Image)(resources.GetObject("closepic.Image")));
            this.closepic.Location = new System.Drawing.Point(718, -1);
            this.closepic.Name = "closepic";
            this.closepic.Size = new System.Drawing.Size(45, 46);
            this.closepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closepic.TabIndex = 88;
            this.closepic.TabStop = false;
            this.closepic.Click += new System.EventHandler(this.closepic_Click);
            // 
            // tfetch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 325);
            this.Controls.Add(this.closepic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tdata);
            this.Controls.Add(this.srchb);
            this.Controls.Add(this.srcht);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tfetch";
            this.Text = "tfetch";
            this.Load += new System.EventHandler(this.tfetch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tdata)).EndInit();
            this.DGVContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srcht;
        private System.Windows.Forms.Button srchb;
        private System.Windows.Forms.DataGridView tdata;
        private System.Windows.Forms.ContextMenuStrip DGVContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox closepic;
    }
}