namespace Final
{
	partial class frmCustomer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
			this.lblResults = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtCustomerSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dropDownSearchTypes = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnCustomerAdd = new System.Windows.Forms.ToolStripButton();
			this.btnCustomerEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnCustomerDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.dataGridCustomers = new System.Windows.Forms.DataGridView();
			this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerBusinessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerSinceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// lblResults
			// 
			this.lblResults.AutoSize = true;
			this.lblResults.Location = new System.Drawing.Point(636, 75);
			this.lblResults.Name = "lblResults";
			this.lblResults.Size = new System.Drawing.Size(81, 13);
			this.lblResults.TabIndex = 9;
			this.lblResults.Text = "Results Found: ";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.txtCustomerSearch);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.dropDownSearchTypes);
			this.panel2.Location = new System.Drawing.Point(482, 34);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(263, 38);
			this.panel2.TabIndex = 9;
			// 
			// txtCustomerSearch
			// 
			this.txtCustomerSearch.Enabled = false;
			this.txtCustomerSearch.Location = new System.Drawing.Point(157, 9);
			this.txtCustomerSearch.Name = "txtCustomerSearch";
			this.txtCustomerSearch.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerSearch.TabIndex = 4;
			this.txtCustomerSearch.TextChanged += new System.EventHandler(this.searchDataGrid);
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
			this.dropDownSearchTypes.TextChanged += new System.EventHandler(this.searchDataGrid);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(149, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.White;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomerAdd,
            this.btnCustomerEdit,
            this.toolStripSeparator1,
            this.btnCustomerDelete,
            this.toolStripSeparator2,
            this.btnRefresh});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(746, 25);
			this.toolStrip1.TabIndex = 10;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnCustomerAdd
			// 
			this.btnCustomerAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCustomerAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerAdd.Image")));
			this.btnCustomerAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCustomerAdd.Name = "btnCustomerAdd";
			this.btnCustomerAdd.Size = new System.Drawing.Size(23, 22);
			this.btnCustomerAdd.Text = "toolStripButton1";
			this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
			// 
			// btnCustomerEdit
			// 
			this.btnCustomerEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCustomerEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerEdit.Image")));
			this.btnCustomerEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCustomerEdit.Name = "btnCustomerEdit";
			this.btnCustomerEdit.Size = new System.Drawing.Size(23, 22);
			this.btnCustomerEdit.Text = "toolStripButton2";
			this.btnCustomerEdit.Click += new System.EventHandler(this.btnCustomerEdit_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnCustomerDelete
			// 
			this.btnCustomerDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCustomerDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDelete.Image")));
			this.btnCustomerDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCustomerDelete.Name = "btnCustomerDelete";
			this.btnCustomerDelete.Size = new System.Drawing.Size(23, 22);
			this.btnCustomerDelete.Text = "toolStripButton1";
			this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
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
			// dataGridCustomers
			// 
			this.dataGridCustomers.AllowUserToAddRows = false;
			this.dataGridCustomers.AllowUserToDeleteRows = false;
			this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerFirstName,
            this.CustomerLastName,
            this.CustomerBusinessName,
            this.CustomerPhone,
            this.CustomerSinceDate});
			this.dataGridCustomers.Location = new System.Drawing.Point(0, 91);
			this.dataGridCustomers.Name = "dataGridCustomers";
			this.dataGridCustomers.ReadOnly = true;
			this.dataGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridCustomers.Size = new System.Drawing.Size(745, 347);
			this.dataGridCustomers.TabIndex = 11;
			// 
			// CustomerID
			// 
			this.CustomerID.HeaderText = "CustomerID";
			this.CustomerID.Name = "CustomerID";
			this.CustomerID.ReadOnly = true;
			// 
			// CustomerFirstName
			// 
			this.CustomerFirstName.HeaderText = "First Name";
			this.CustomerFirstName.Name = "CustomerFirstName";
			this.CustomerFirstName.ReadOnly = true;
			// 
			// CustomerLastName
			// 
			this.CustomerLastName.HeaderText = "Last Name";
			this.CustomerLastName.Name = "CustomerLastName";
			this.CustomerLastName.ReadOnly = true;
			// 
			// CustomerBusinessName
			// 
			this.CustomerBusinessName.HeaderText = "Business Name";
			this.CustomerBusinessName.Name = "CustomerBusinessName";
			this.CustomerBusinessName.ReadOnly = true;
			this.CustomerBusinessName.Width = 150;
			// 
			// CustomerPhone
			// 
			this.CustomerPhone.HeaderText = "Phone";
			this.CustomerPhone.Name = "CustomerPhone";
			this.CustomerPhone.ReadOnly = true;
			this.CustomerPhone.Width = 150;
			// 
			// CustomerSinceDate
			// 
			this.CustomerSinceDate.HeaderText = "Customer Since";
			this.CustomerSinceDate.Name = "CustomerSinceDate";
			this.CustomerSinceDate.ReadOnly = true;
			// 
			// frmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(746, 444);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGridCustomers);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.lblResults);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCustomer";
			this.Text = "Customers / Clients";
			this.Load += new System.EventHandler(this.frmCustomer_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblResults;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtCustomerSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox dropDownSearchTypes;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnCustomerAdd;
		private System.Windows.Forms.ToolStripButton btnCustomerEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnCustomerDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.DataGridView dataGridCustomers;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerBusinessName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerSinceDate;
	}
}