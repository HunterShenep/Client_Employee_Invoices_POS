namespace Final
{
	partial class frmEmployees
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployees));
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtEmployeeSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dropDownSearchTypes = new System.Windows.Forms.ComboBox();
			this.dataGridEmployee = new System.Windows.Forms.DataGridView();
			this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerSinceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnEmployeeDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.lblResults = new System.Windows.Forms.Label();
			this.btnViewInvoice = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.btnViewInvoice);
			this.panel2.Controls.Add(this.txtEmployeeSearch);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.dropDownSearchTypes);
			this.panel2.Location = new System.Drawing.Point(156, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(590, 38);
			this.panel2.TabIndex = 13;
			// 
			// txtEmployeeSearch
			// 
			this.txtEmployeeSearch.Enabled = false;
			this.txtEmployeeSearch.Location = new System.Drawing.Point(481, 9);
			this.txtEmployeeSearch.Name = "txtEmployeeSearch";
			this.txtEmployeeSearch.Size = new System.Drawing.Size(100, 20);
			this.txtEmployeeSearch.TabIndex = 4;
			this.txtEmployeeSearch.TextChanged += new System.EventHandler(this.searchDataGrid);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(341, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Search";
			// 
			// dropDownSearchTypes
			// 
			this.dropDownSearchTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dropDownSearchTypes.FormattingEnabled = true;
			this.dropDownSearchTypes.Location = new System.Drawing.Point(386, 9);
			this.dropDownSearchTypes.Name = "dropDownSearchTypes";
			this.dropDownSearchTypes.Size = new System.Drawing.Size(89, 21);
			this.dropDownSearchTypes.TabIndex = 5;
			this.dropDownSearchTypes.SelectedIndexChanged += new System.EventHandler(this.enableSearch);
			// 
			// dataGridEmployee
			// 
			this.dataGridEmployee.AllowUserToAddRows = false;
			this.dataGridEmployee.AllowUserToDeleteRows = false;
			this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerFirstName,
            this.CustomerLastName,
            this.CustomerPhone,
            this.CustomerSinceDate});
			this.dataGridEmployee.Location = new System.Drawing.Point(0, 97);
			this.dataGridEmployee.Name = "dataGridEmployee";
			this.dataGridEmployee.ReadOnly = true;
			this.dataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridEmployee.Size = new System.Drawing.Size(745, 347);
			this.dataGridEmployee.TabIndex = 16;
			// 
			// CustomerID
			// 
			this.CustomerID.HeaderText = "CustomerID";
			this.CustomerID.Name = "CustomerID";
			this.CustomerID.ReadOnly = true;
			this.CustomerID.Width = 75;
			// 
			// CustomerFirstName
			// 
			this.CustomerFirstName.HeaderText = "First Name";
			this.CustomerFirstName.Name = "CustomerFirstName";
			this.CustomerFirstName.ReadOnly = true;
			this.CustomerFirstName.Width = 130;
			// 
			// CustomerLastName
			// 
			this.CustomerLastName.HeaderText = "Last Name";
			this.CustomerLastName.Name = "CustomerLastName";
			this.CustomerLastName.ReadOnly = true;
			this.CustomerLastName.Width = 130;
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
			this.CustomerSinceDate.HeaderText = "Employee Since";
			this.CustomerSinceDate.Name = "CustomerSinceDate";
			this.CustomerSinceDate.ReadOnly = true;
			this.CustomerSinceDate.Width = 150;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 37);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(149, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.White;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEmployeeDelete,
            this.toolStripSeparator2,
            this.btnRefresh});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(755, 25);
			this.toolStrip1.TabIndex = 15;
			this.toolStrip1.Text = "toolStrip1";
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
			this.lblResults.Location = new System.Drawing.Point(636, 81);
			this.lblResults.Name = "lblResults";
			this.lblResults.Size = new System.Drawing.Size(81, 13);
			this.lblResults.TabIndex = 14;
			this.lblResults.Text = "Results Found: ";
			// 
			// btnViewInvoice
			// 
			this.btnViewInvoice.Location = new System.Drawing.Point(6, 6);
			this.btnViewInvoice.Name = "btnViewInvoice";
			this.btnViewInvoice.Size = new System.Drawing.Size(75, 23);
			this.btnViewInvoice.TabIndex = 7;
			this.btnViewInvoice.Text = "View";
			this.btnViewInvoice.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(87, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Edit";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(168, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "New";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// frmEmployees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(755, 456);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGridEmployee);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.lblResults);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEmployees";
			this.Text = "Employees";
			this.Load += new System.EventHandler(this.frmEmployees_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtEmployeeSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox dropDownSearchTypes;
		private System.Windows.Forms.DataGridView dataGridEmployee;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnEmployeeDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.Label lblResults;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerSinceDate;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnViewInvoice;
	}
}