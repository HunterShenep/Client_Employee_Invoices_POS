namespace Final
{
	partial class frmVendors
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendors));
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.dataGridVendors = new System.Windows.Forms.DataGridView();
			this.clmVendorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmVendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmVendorPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clmVendorWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtVendorSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboVendorSearchTypes = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblResults = new System.Windows.Forms.Label();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.btnVendorEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnVendorDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnVendorLoadAll = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridVendors)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// ContentPanel
			// 
			this.ContentPanel.Size = new System.Drawing.Size(150, 175);
			// 
			// dataGridVendors
			// 
			this.dataGridVendors.AllowUserToAddRows = false;
			this.dataGridVendors.AllowUserToDeleteRows = false;
			this.dataGridVendors.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dataGridVendors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridVendors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmVendorID,
            this.clmVendorName,
            this.clmVendorPhone,
            this.clmVendorWebsite});
			this.dataGridVendors.Location = new System.Drawing.Point(9, 75);
			this.dataGridVendors.Name = "dataGridVendors";
			this.dataGridVendors.ReadOnly = true;
			this.dataGridVendors.RowTemplate.Height = 25;
			this.dataGridVendors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridVendors.Size = new System.Drawing.Size(776, 363);
			this.dataGridVendors.TabIndex = 1;
			// 
			// clmVendorID
			// 
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
			this.clmVendorID.DefaultCellStyle = dataGridViewCellStyle1;
			this.clmVendorID.HeaderText = "VendorID";
			this.clmVendorID.Name = "clmVendorID";
			this.clmVendorID.ReadOnly = true;
			// 
			// clmVendorName
			// 
			this.clmVendorName.HeaderText = "VendorName";
			this.clmVendorName.Name = "clmVendorName";
			this.clmVendorName.ReadOnly = true;
			// 
			// clmVendorPhone
			// 
			this.clmVendorPhone.HeaderText = "VendorPhone";
			this.clmVendorPhone.Name = "clmVendorPhone";
			this.clmVendorPhone.ReadOnly = true;
			this.clmVendorPhone.Width = 200;
			// 
			// clmVendorWebsite
			// 
			this.clmVendorWebsite.HeaderText = "VendorWebsite";
			this.clmVendorWebsite.Name = "clmVendorWebsite";
			this.clmVendorWebsite.ReadOnly = true;
			this.clmVendorWebsite.Width = 300;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(9, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(775, 44);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.txtVendorSearch);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.comboVendorSearchTypes);
			this.panel2.Location = new System.Drawing.Point(509, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(263, 38);
			this.panel2.TabIndex = 9;
			// 
			// txtVendorSearch
			// 
			this.txtVendorSearch.Enabled = false;
			this.txtVendorSearch.Location = new System.Drawing.Point(157, 9);
			this.txtVendorSearch.Name = "txtVendorSearch";
			this.txtVendorSearch.Size = new System.Drawing.Size(100, 20);
			this.txtVendorSearch.TabIndex = 4;
			this.txtVendorSearch.TextChanged += new System.EventHandler(this.searchDataGrid);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Search";
			// 
			// comboVendorSearchTypes
			// 
			this.comboVendorSearchTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboVendorSearchTypes.FormattingEnabled = true;
			this.comboVendorSearchTypes.Location = new System.Drawing.Point(62, 9);
			this.comboVendorSearchTypes.Name = "comboVendorSearchTypes";
			this.comboVendorSearchTypes.Size = new System.Drawing.Size(89, 21);
			this.comboVendorSearchTypes.TabIndex = 5;
			this.comboVendorSearchTypes.SelectedIndexChanged += new System.EventHandler(this.enableSearch);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(149, 38);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// lblResults
			// 
			this.lblResults.AutoSize = true;
			this.lblResults.Location = new System.Drawing.Point(672, 59);
			this.lblResults.Name = "lblResults";
			this.lblResults.Size = new System.Drawing.Size(81, 13);
			this.lblResults.TabIndex = 7;
			this.lblResults.Text = "Results Found: ";
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.AutoScroll = true;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.lblResults);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
			this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridVendors);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(799, 454);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(799, 479);
			this.toolStripContainer1.TabIndex = 9;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.White;
			this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
			this.toolStripContainer1.TopToolStripPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnVendorEdit,
            this.toolStripSeparator1,
            this.btnVendorDelete,
            this.toolStripSeparator2,
            this.btnVendorLoadAll});
			this.toolStrip1.Location = new System.Drawing.Point(3, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(116, 25);
			this.toolStrip1.TabIndex = 8;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// btnVendorEdit
			// 
			this.btnVendorEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnVendorEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnVendorEdit.Image")));
			this.btnVendorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnVendorEdit.Name = "btnVendorEdit";
			this.btnVendorEdit.Size = new System.Drawing.Size(23, 22);
			this.btnVendorEdit.Text = "toolStripButton2";
			this.btnVendorEdit.Click += new System.EventHandler(this.btnVendorEdit_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnVendorDelete
			// 
			this.btnVendorDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnVendorDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnVendorDelete.Image")));
			this.btnVendorDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnVendorDelete.Name = "btnVendorDelete";
			this.btnVendorDelete.Size = new System.Drawing.Size(23, 22);
			this.btnVendorDelete.Text = "toolStripButton3";
			this.btnVendorDelete.Click += new System.EventHandler(this.btnVendorDelete_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnVendorLoadAll
			// 
			this.btnVendorLoadAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnVendorLoadAll.Image = ((System.Drawing.Image)(resources.GetObject("btnVendorLoadAll.Image")));
			this.btnVendorLoadAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnVendorLoadAll.Name = "btnVendorLoadAll";
			this.btnVendorLoadAll.Size = new System.Drawing.Size(23, 22);
			this.btnVendorLoadAll.Text = "toolStripButton4";
			this.btnVendorLoadAll.Click += new System.EventHandler(this.btnVendorLoadAll_Click);
			// 
			// frmVendors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(799, 479);
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmVendors";
			this.Text = "Vendors";
			((System.ComponentModel.ISupportInitialize)(this.dataGridVendors)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ContentPanel.PerformLayout();
			this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.TopToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridVendors;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtVendorSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboVendorSearchTypes;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblResults;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton btnVendorEdit;
		private System.Windows.Forms.ToolStripButton btnVendorDelete;
		private System.Windows.Forms.ToolStripButton btnVendorLoadAll;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmVendorID;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmVendorName;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmVendorPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn clmVendorWebsite;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}