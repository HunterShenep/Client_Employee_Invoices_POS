namespace Final
{
	partial class frmServices
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServices));
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtServiceSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dropDownSearchTypes = new System.Windows.Forms.ComboBox();
			this.dataGridServices = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnServiceAdd = new System.Windows.Forms.ToolStripButton();
			this.btnServiceEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnServiceDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.lblResults = new System.Windows.Forms.Label();
			this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServiceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridServices)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.txtServiceSearch);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.dropDownSearchTypes);
			this.panel2.Location = new System.Drawing.Point(482, 43);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(263, 38);
			this.panel2.TabIndex = 18;
			// 
			// txtServiceSearch
			// 
			this.txtServiceSearch.Enabled = false;
			this.txtServiceSearch.Location = new System.Drawing.Point(157, 9);
			this.txtServiceSearch.Name = "txtServiceSearch";
			this.txtServiceSearch.Size = new System.Drawing.Size(100, 20);
			this.txtServiceSearch.TabIndex = 4;
			this.txtServiceSearch.TextChanged += new System.EventHandler(this.searchDataGrid);
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
			// dropDownSearchTypes
			// 
			this.dropDownSearchTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dropDownSearchTypes.FormattingEnabled = true;
			this.dropDownSearchTypes.Location = new System.Drawing.Point(62, 9);
			this.dropDownSearchTypes.Name = "dropDownSearchTypes";
			this.dropDownSearchTypes.Size = new System.Drawing.Size(89, 21);
			this.dropDownSearchTypes.TabIndex = 5;
			this.dropDownSearchTypes.SelectedIndexChanged += new System.EventHandler(this.enableSearch);
			// 
			// dataGridServices
			// 
			this.dataGridServices.AllowUserToAddRows = false;
			this.dataGridServices.AllowUserToDeleteRows = false;
			this.dataGridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.ServiceName,
            this.ServiceDescription,
            this.ServicePrice});
			this.dataGridServices.Location = new System.Drawing.Point(0, 100);
			this.dataGridServices.Name = "dataGridServices";
			this.dataGridServices.ReadOnly = true;
			this.dataGridServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridServices.Size = new System.Drawing.Size(745, 347);
			this.dataGridServices.TabIndex = 21;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(149, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.White;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnServiceAdd,
            this.btnServiceEdit,
            this.toolStripSeparator1,
            this.btnServiceDelete,
            this.toolStripSeparator2,
            this.btnRefresh});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(753, 25);
			this.toolStrip1.TabIndex = 20;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnServiceAdd
			// 
			this.btnServiceAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnServiceAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnServiceAdd.Image")));
			this.btnServiceAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnServiceAdd.Name = "btnServiceAdd";
			this.btnServiceAdd.Size = new System.Drawing.Size(23, 22);
			this.btnServiceAdd.Text = "toolStripButton1";
			this.btnServiceAdd.Click += new System.EventHandler(this.btnServiceAdd_Click);
			// 
			// btnServiceEdit
			// 
			this.btnServiceEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnServiceEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnServiceEdit.Image")));
			this.btnServiceEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnServiceEdit.Name = "btnServiceEdit";
			this.btnServiceEdit.Size = new System.Drawing.Size(23, 22);
			this.btnServiceEdit.Text = "toolStripButton2";
			this.btnServiceEdit.Click += new System.EventHandler(this.btnServiceEdit_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnServiceDelete
			// 
			this.btnServiceDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnServiceDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnServiceDelete.Image")));
			this.btnServiceDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnServiceDelete.Name = "btnServiceDelete";
			this.btnServiceDelete.Size = new System.Drawing.Size(23, 22);
			this.btnServiceDelete.Text = "toolStripButton1";
			this.btnServiceDelete.Click += new System.EventHandler(this.btnServiceDelete_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnRefresh
			// 
			this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(23, 22);
			this.btnRefresh.Text = "toolStripButton1";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// lblResults
			// 
			this.lblResults.AutoSize = true;
			this.lblResults.Location = new System.Drawing.Point(636, 84);
			this.lblResults.Name = "lblResults";
			this.lblResults.Size = new System.Drawing.Size(81, 13);
			this.lblResults.TabIndex = 19;
			this.lblResults.Text = "Results Found: ";
			// 
			// ServiceID
			// 
			this.ServiceID.HeaderText = "Service ID";
			this.ServiceID.Name = "ServiceID";
			this.ServiceID.ReadOnly = true;
			// 
			// ServiceName
			// 
			this.ServiceName.HeaderText = "Service Name";
			this.ServiceName.Name = "ServiceName";
			this.ServiceName.ReadOnly = true;
			this.ServiceName.Width = 150;
			// 
			// ServiceDescription
			// 
			this.ServiceDescription.HeaderText = "Service Description";
			this.ServiceDescription.Name = "ServiceDescription";
			this.ServiceDescription.ReadOnly = true;
			this.ServiceDescription.Width = 300;
			// 
			// ServicePrice
			// 
			this.ServicePrice.HeaderText = "Service Price";
			this.ServicePrice.Name = "ServicePrice";
			this.ServicePrice.ReadOnly = true;
			this.ServicePrice.Width = 80;
			// 
			// frmServices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(753, 456);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGridServices);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.lblResults);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmServices";
			this.Text = "Services";
			this.Load += new System.EventHandler(this.frmServices_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridServices)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtServiceSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox dropDownSearchTypes;
		private System.Windows.Forms.DataGridView dataGridServices;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServicePrice;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnServiceAdd;
		private System.Windows.Forms.ToolStripButton btnServiceEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnServiceDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.Label lblResults;
	}
}