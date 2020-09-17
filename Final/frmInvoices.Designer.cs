namespace Final
{
	partial class frmInvoices
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoices));
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtInvoiceSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dropDownSearchTypes = new System.Windows.Forms.ComboBox();
			this.dataGridInvoices = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnEmployeeAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnEmployeeDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.lblResults = new System.Windows.Forms.Label();
			this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridInvoices)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.txtInvoiceSearch);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.dropDownSearchTypes);
			this.panel2.Location = new System.Drawing.Point(430, 31);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(315, 38);
			this.panel2.TabIndex = 18;
			// 
			// txtInvoiceSearch
			// 
			this.txtInvoiceSearch.Enabled = false;
			this.txtInvoiceSearch.Location = new System.Drawing.Point(209, 9);
			this.txtInvoiceSearch.Name = "txtInvoiceSearch";
			this.txtInvoiceSearch.Size = new System.Drawing.Size(100, 20);
			this.txtInvoiceSearch.TabIndex = 4;
			this.txtInvoiceSearch.TextChanged += new System.EventHandler(this.searchDataGrid);
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
			this.dropDownSearchTypes.Size = new System.Drawing.Size(141, 21);
			this.dropDownSearchTypes.TabIndex = 5;
			this.dropDownSearchTypes.SelectedIndexChanged += new System.EventHandler(this.searchEnabled);
			// 
			// dataGridInvoices
			// 
			this.dataGridInvoices.AllowUserToAddRows = false;
			this.dataGridInvoices.AllowUserToDeleteRows = false;
			this.dataGridInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.CustomerName,
            this.CreateDate,
            this.CreatedBy,
            this.Paid});
			this.dataGridInvoices.Location = new System.Drawing.Point(0, 88);
			this.dataGridInvoices.Name = "dataGridInvoices";
			this.dataGridInvoices.ReadOnly = true;
			this.dataGridInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridInvoices.Size = new System.Drawing.Size(745, 347);
			this.dataGridInvoices.TabIndex = 21;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 28);
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
            this.btnEmployeeAdd,
            this.btnEdit,
            this.toolStripSeparator1,
            this.btnEmployeeDelete,
            this.toolStripSeparator2,
            this.btnRefresh});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(752, 25);
			this.toolStrip1.TabIndex = 20;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnEmployeeAdd
			// 
			this.btnEmployeeAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnEmployeeAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeAdd.Image")));
			this.btnEmployeeAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEmployeeAdd.Name = "btnEmployeeAdd";
			this.btnEmployeeAdd.Size = new System.Drawing.Size(23, 22);
			this.btnEmployeeAdd.Text = "toolStripButton1";
			this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnEmployeeDelete
			// 
			this.btnEmployeeDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnEmployeeDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeDelete.Image")));
			this.btnEmployeeDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEmployeeDelete.Name = "btnEmployeeDelete";
			this.btnEmployeeDelete.Size = new System.Drawing.Size(23, 22);
			this.btnEmployeeDelete.Text = "toolStripButton1";
			this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
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
			this.lblResults.Location = new System.Drawing.Point(636, 72);
			this.lblResults.Name = "lblResults";
			this.lblResults.Size = new System.Drawing.Size(81, 13);
			this.lblResults.TabIndex = 19;
			this.lblResults.Text = "Results Found: ";
			// 
			// InvoiceID
			// 
			this.InvoiceID.HeaderText = "Invoice ID";
			this.InvoiceID.Name = "InvoiceID";
			this.InvoiceID.ReadOnly = true;
			this.InvoiceID.Width = 80;
			// 
			// CustomerName
			// 
			this.CustomerName.HeaderText = "Customer Name";
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.ReadOnly = true;
			this.CustomerName.Width = 150;
			// 
			// CreateDate
			// 
			this.CreateDate.HeaderText = "Creation Date";
			this.CreateDate.Name = "CreateDate";
			this.CreateDate.ReadOnly = true;
			// 
			// CreatedBy
			// 
			this.CreatedBy.HeaderText = "Created By";
			this.CreatedBy.Name = "CreatedBy";
			this.CreatedBy.ReadOnly = true;
			this.CreatedBy.Width = 150;
			// 
			// Paid
			// 
			this.Paid.HeaderText = "Paid";
			this.Paid.Name = "Paid";
			this.Paid.ReadOnly = true;
			// 
			// btnEdit
			// 
			this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(23, 22);
			this.btnEdit.Text = "toolStripButton1";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// frmInvoices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(752, 440);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGridInvoices);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.lblResults);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmInvoices";
			this.Text = "Invoices";
			this.Load += new System.EventHandler(this.frmInvoices_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridInvoices)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtInvoiceSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox dropDownSearchTypes;
		private System.Windows.Forms.DataGridView dataGridInvoices;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnEmployeeAdd;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnEmployeeDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.Label lblResults;
		private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
		private System.Windows.Forms.ToolStripButton btnEdit;
	}
}