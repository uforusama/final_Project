namespace fitnessclub
{
    partial class efetch
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
            this.tbesrch = new System.Windows.Forms.TextBox();
            this.esearch = new System.Windows.Forms.Button();
            this.srcht = new System.Windows.Forms.Label();
            this.EmpdataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbesrch
            // 
            this.tbesrch.Location = new System.Drawing.Point(93, 13);
            this.tbesrch.Name = "tbesrch";
            this.tbesrch.Size = new System.Drawing.Size(100, 20);
            this.tbesrch.TabIndex = 0;
            this.tbesrch.TextChanged += new System.EventHandler(this.tbesrch_TextChanged);
            // 
            // esearch
            // 
            this.esearch.Location = new System.Drawing.Point(211, 12);
            this.esearch.Name = "esearch";
            this.esearch.Size = new System.Drawing.Size(75, 23);
            this.esearch.TabIndex = 1;
            this.esearch.Text = "Search";
            this.esearch.UseVisualStyleBackColor = true;
            this.esearch.Click += new System.EventHandler(this.esearch_Click);
            // 
            // srcht
            // 
            this.srcht.AutoSize = true;
            this.srcht.Location = new System.Drawing.Point(27, 20);
            this.srcht.Name = "srcht";
            this.srcht.Size = new System.Drawing.Size(41, 13);
            this.srcht.TabIndex = 2;
            this.srcht.Text = "Search";
            // 
            // EmpdataGridView
            // 
            this.EmpdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpdataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.EmpdataGridView.Location = new System.Drawing.Point(12, 112);
            this.EmpdataGridView.Name = "EmpdataGridView";
            this.EmpdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpdataGridView.Size = new System.Drawing.Size(670, 215);
            this.EmpdataGridView.TabIndex = 3;
            this.EmpdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpdataGridView_CellContentClick);
            this.EmpdataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmpdataGridView_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // efetch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 368);
            this.Controls.Add(this.EmpdataGridView);
            this.Controls.Add(this.srcht);
            this.Controls.Add(this.esearch);
            this.Controls.Add(this.tbesrch);
            this.Name = "efetch";
            this.Text = "efetch";
            this.Load += new System.EventHandler(this.efetch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpdataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbesrch;
        private System.Windows.Forms.Button esearch;
        private System.Windows.Forms.Label srcht;
        private System.Windows.Forms.DataGridView EmpdataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}