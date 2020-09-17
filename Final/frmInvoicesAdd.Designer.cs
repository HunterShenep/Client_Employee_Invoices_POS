namespace Final
{
	partial class frmInvoicesAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoicesAdd));
			this.dataGridCustomer = new System.Windows.Forms.DataGridView();
			this.lblCustomerSelected = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSelectCustomer = new System.Windows.Forms.Button();
			this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
			this.txtCustomerSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BusinessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnSelectEmployee = new System.Windows.Forms.Button();
			this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
			this.txtSearchEmployee = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridEmployee = new System.Windows.Forms.DataGridView();
			this.lblEmployeeSelected = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridCustomer
			// 
			this.dataGridCustomer.AllowUserToAddRows = false;
			this.dataGridCustomer.AllowUserToDeleteRows = false;
			this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.LastName,
            this.BusinessName});
			this.dataGridCustomer.Location = new System.Drawing.Point(3, 74);
			this.dataGridCustomer.Name = "dataGridCustomer";
			this.dataGridCustomer.ReadOnly = true;
			this.dataGridCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridCustomer.Size = new System.Drawing.Size(429, 133);
			this.dataGridCustomer.TabIndex = 1;
			// 
			// lblCustomerSelected
			// 
			this.lblCustomerSelected.AutoSize = true;
			this.lblCustomerSelected.Location = new System.Drawing.Point(9, 216);
			this.lblCustomerSelected.Name = "lblCustomerSelected";
			this.lblCustomerSelected.Size = new System.Drawing.Size(102, 13);
			this.lblCustomerSelected.TabIndex = 2;
			this.lblCustomerSelected.Text = "Customer Selected: ";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGreen;
			this.panel1.Controls.Add(this.btnSelectCustomer);
			this.panel1.Controls.Add(this.comboBoxCustomers);
			this.panel1.Controls.Add(this.txtCustomerSearch);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dataGridCustomer);
			this.panel1.Controls.Add(this.lblCustomerSelected);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(435, 239);
			this.panel1.TabIndex = 3;
			// 
			// btnSelectCustomer
			// 
			this.btnSelectCustomer.Location = new System.Drawing.Point(304, 40);
			this.btnSelectCustomer.Name = "btnSelectCustomer";
			this.btnSelectCustomer.Size = new System.Drawing.Size(115, 23);
			this.btnSelectCustomer.TabIndex = 6;
			this.btnSelectCustomer.Text = "Select Customer";
			this.btnSelectCustomer.UseVisualStyleBackColor = true;
			this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
			// 
			// comboBoxCustomers
			// 
			this.comboBoxCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCustomers.FormattingEnabled = true;
			this.comboBoxCustomers.Location = new System.Drawing.Point(177, 41);
			this.comboBoxCustomers.Name = "comboBoxCustomers";
			this.comboBoxCustomers.Size = new System.Drawing.Size(121, 21);
			this.comboBoxCustomers.TabIndex = 5;
			this.comboBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.enableCustomerSearch);
			// 
			// txtCustomerSearch
			// 
			this.txtCustomerSearch.Enabled = false;
			this.txtCustomerSearch.Location = new System.Drawing.Point(20, 41);
			this.txtCustomerSearch.Name = "txtCustomerSearch";
			this.txtCustomerSearch.Size = new System.Drawing.Size(150, 20);
			this.txtCustomerSearch.TabIndex = 4;
			this.txtCustomerSearch.TextChanged += new System.EventHandler(this.searchCustomerDataGrid);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Customer / Client selection";
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Width = 50;
			// 
			// FirstName
			// 
			this.FirstName.HeaderText = "First Name";
			this.FirstName.Name = "FirstName";
			this.FirstName.ReadOnly = true;
			// 
			// LastName
			// 
			this.LastName.HeaderText = "Last Name";
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			// 
			// BusinessName
			// 
			this.BusinessName.HeaderText = "Biz Name";
			this.BusinessName.Name = "BusinessName";
			this.BusinessName.ReadOnly = true;
			this.BusinessName.Width = 130;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.LightGreen;
			this.panel2.Controls.Add(this.btnSelectEmployee);
			this.panel2.Controls.Add(this.comboBoxEmployee);
			this.panel2.Controls.Add(this.txtSearchEmployee);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.dataGridEmployee);
			this.panel2.Controls.Add(this.lblEmployeeSelected);
			this.panel2.Location = new System.Drawing.Point(12, 267);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(435, 239);
			this.panel2.TabIndex = 7;
			// 
			// btnSelectEmployee
			// 
			this.btnSelectEmployee.Location = new System.Drawing.Point(304, 40);
			this.btnSelectEmployee.Name = "btnSelectEmployee";
			this.btnSelectEmployee.Size = new System.Drawing.Size(115, 23);
			this.btnSelectEmployee.TabIndex = 6;
			this.btnSelectEmployee.Text = "Select Employee";
			this.btnSelectEmployee.UseVisualStyleBackColor = true;
			this.btnSelectEmployee.Click += new System.EventHandler(this.btnSelectEmployee_Click);
			// 
			// comboBoxEmployee
			// 
			this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEmployee.FormattingEnabled = true;
			this.comboBoxEmployee.Location = new System.Drawing.Point(177, 41);
			this.comboBoxEmployee.Name = "comboBoxEmployee";
			this.comboBoxEmployee.Size = new System.Drawing.Size(121, 21);
			this.comboBoxEmployee.TabIndex = 5;
			this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.enableEmployeeSearch);
			// 
			// txtSearchEmployee
			// 
			this.txtSearchEmployee.Enabled = false;
			this.txtSearchEmployee.Location = new System.Drawing.Point(20, 41);
			this.txtSearchEmployee.Name = "txtSearchEmployee";
			this.txtSearchEmployee.Size = new System.Drawing.Size(150, 20);
			this.txtSearchEmployee.TabIndex = 4;
			this.txtSearchEmployee.TextChanged += new System.EventHandler(this.searchEmployeeDataGrid);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Completed by Employee";
			// 
			// dataGridEmployee
			// 
			this.dataGridEmployee.AllowUserToAddRows = false;
			this.dataGridEmployee.AllowUserToDeleteRows = false;
			this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.dataGridEmployee.Location = new System.Drawing.Point(3, 74);
			this.dataGridEmployee.Name = "dataGridEmployee";
			this.dataGridEmployee.ReadOnly = true;
			this.dataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridEmployee.Size = new System.Drawing.Size(429, 133);
			this.dataGridEmployee.TabIndex = 1;
			// 
			// lblEmployeeSelected
			// 
			this.lblEmployeeSelected.AutoSize = true;
			this.lblEmployeeSelected.Location = new System.Drawing.Point(9, 216);
			this.lblEmployeeSelected.Name = "lblEmployeeSelected";
			this.lblEmployeeSelected.Size = new System.Drawing.Size(98, 13);
			this.lblEmployeeSelected.TabIndex = 2;
			this.lblEmployeeSelected.Text = "Employee Selected";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 50;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(79, 529);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(298, 51);
			this.button1.TabIndex = 8;
			this.button1.Text = "Continue";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btnContinue_Click);
			// 
			// frmInvoicesAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(460, 603);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmInvoicesAdd";
			this.Text = "New Invoice";
			this.Load += new System.EventHandler(this.frmInvoicesAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridCustomer;
		private System.Windows.Forms.Label lblCustomerSelected;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSelectCustomer;
		private System.Windows.Forms.ComboBox comboBoxCustomers;
		private System.Windows.Forms.TextBox txtCustomerSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn BusinessName;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSelectEmployee;
		private System.Windows.Forms.ComboBox comboBoxEmployee;
		private System.Windows.Forms.TextBox txtSearchEmployee;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridEmployee;
		private System.Windows.Forms.Label lblEmployeeSelected;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Button button1;
	}
}