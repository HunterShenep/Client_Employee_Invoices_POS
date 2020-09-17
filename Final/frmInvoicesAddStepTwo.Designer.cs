namespace Final
{
	partial class frmInvoicesAddStepTwo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoicesAddStepTwo));
			this.label1 = new System.Windows.Forms.Label();
			this.lblasdasdas = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblInvoiceID = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnFinalize = new System.Windows.Forms.Button();
			this.lblTotalPrice = new System.Windows.Forms.Label();
			this.btnRemoveItem = new System.Windows.Forms.Button();
			this.dataGridLineItems = new System.Windows.Forms.DataGridView();
			this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAddLineItem = new System.Windows.Forms.Button();
			this.comboServices = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLineItems)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer: ";
			// 
			// lblasdasdas
			// 
			this.lblasdasdas.AutoSize = true;
			this.lblasdasdas.Location = new System.Drawing.Point(18, 48);
			this.lblasdasdas.Name = "lblasdasdas";
			this.lblasdasdas.Size = new System.Drawing.Size(56, 13);
			this.lblasdasdas.TabIndex = 1;
			this.lblasdasdas.Text = "Employee:";
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.Location = new System.Drawing.Point(81, 20);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(27, 13);
			this.lblCustomerName.TabIndex = 2;
			this.lblCustomerName.Text = "N/A";
			// 
			// lblEmployeeName
			// 
			this.lblEmployeeName.AutoSize = true;
			this.lblEmployeeName.Location = new System.Drawing.Point(81, 48);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new System.Drawing.Size(27, 13);
			this.lblEmployeeName.TabIndex = 3;
			this.lblEmployeeName.Text = "N/A";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Invoice ID:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleGreen;
			this.panel1.Controls.Add(this.lblInvoiceID);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lblEmployeeName);
			this.panel1.Controls.Add(this.lblasdasdas);
			this.panel1.Controls.Add(this.lblCustomerName);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(335, 113);
			this.panel1.TabIndex = 5;
			// 
			// lblInvoiceID
			// 
			this.lblInvoiceID.AutoSize = true;
			this.lblInvoiceID.Location = new System.Drawing.Point(81, 74);
			this.lblInvoiceID.Name = "lblInvoiceID";
			this.lblInvoiceID.Size = new System.Drawing.Size(27, 13);
			this.lblInvoiceID.TabIndex = 5;
			this.lblInvoiceID.Text = "N/A";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.txtQuantity);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnFinalize);
			this.panel2.Controls.Add(this.lblTotalPrice);
			this.panel2.Controls.Add(this.btnRemoveItem);
			this.panel2.Controls.Add(this.dataGridLineItems);
			this.panel2.Controls.Add(this.btnAddLineItem);
			this.panel2.Controls.Add(this.comboServices);
			this.panel2.Location = new System.Drawing.Point(12, 140);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(335, 342);
			this.panel2.TabIndex = 6;
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(261, 41);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(56, 20);
			this.txtQuantity.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(213, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Quantity";
			// 
			// btnFinalize
			// 
			this.btnFinalize.Enabled = false;
			this.btnFinalize.Location = new System.Drawing.Point(242, 295);
			this.btnFinalize.Name = "btnFinalize";
			this.btnFinalize.Size = new System.Drawing.Size(75, 23);
			this.btnFinalize.TabIndex = 5;
			this.btnFinalize.Text = "Finalize";
			this.btnFinalize.UseVisualStyleBackColor = true;
			this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
			// 
			// lblTotalPrice
			// 
			this.lblTotalPrice.AutoSize = true;
			this.lblTotalPrice.Location = new System.Drawing.Point(21, 300);
			this.lblTotalPrice.Name = "lblTotalPrice";
			this.lblTotalPrice.Size = new System.Drawing.Size(52, 13);
			this.lblTotalPrice.TabIndex = 4;
			this.lblTotalPrice.Text = "Subtotal: ";
			// 
			// btnRemoveItem
			// 
			this.btnRemoveItem.Enabled = false;
			this.btnRemoveItem.Location = new System.Drawing.Point(21, 78);
			this.btnRemoveItem.Name = "btnRemoveItem";
			this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveItem.TabIndex = 3;
			this.btnRemoveItem.Text = "Remove";
			this.btnRemoveItem.UseVisualStyleBackColor = true;
			this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
			// 
			// dataGridLineItems
			// 
			this.dataGridLineItems.AllowUserToAddRows = false;
			this.dataGridLineItems.AllowUserToDeleteRows = false;
			this.dataGridLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.Price,
            this.Quantity});
			this.dataGridLineItems.Location = new System.Drawing.Point(21, 123);
			this.dataGridLineItems.Name = "dataGridLineItems";
			this.dataGridLineItems.ReadOnly = true;
			this.dataGridLineItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridLineItems.Size = new System.Drawing.Size(296, 150);
			this.dataGridLineItems.TabIndex = 2;
			// 
			// ServiceName
			// 
			this.ServiceName.HeaderText = "Service Name";
			this.ServiceName.Name = "ServiceName";
			this.ServiceName.ReadOnly = true;
			// 
			// Price
			// 
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			this.Price.Width = 60;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			this.Quantity.Width = 60;
			// 
			// btnAddLineItem
			// 
			this.btnAddLineItem.Enabled = false;
			this.btnAddLineItem.Location = new System.Drawing.Point(242, 78);
			this.btnAddLineItem.Name = "btnAddLineItem";
			this.btnAddLineItem.Size = new System.Drawing.Size(75, 23);
			this.btnAddLineItem.TabIndex = 1;
			this.btnAddLineItem.Text = "Add Item";
			this.btnAddLineItem.UseVisualStyleBackColor = true;
			this.btnAddLineItem.Click += new System.EventHandler(this.btnAddLineItem_Click);
			// 
			// comboServices
			// 
			this.comboServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboServices.FormattingEnabled = true;
			this.comboServices.Location = new System.Drawing.Point(21, 41);
			this.comboServices.Name = "comboServices";
			this.comboServices.Size = new System.Drawing.Size(171, 21);
			this.comboServices.TabIndex = 0;
			this.comboServices.SelectedIndexChanged += new System.EventHandler(this.enableAddButton);
			// 
			// frmInvoicesAddStepTwo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(362, 494);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmInvoicesAddStepTwo";
			this.Text = "New Invoice For";
			this.Load += new System.EventHandler(this.frmInvoicesAddStepTwo_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLineItems)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblasdasdas;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.Label lblEmployeeName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblInvoiceID;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnAddLineItem;
		private System.Windows.Forms.ComboBox comboServices;
		private System.Windows.Forms.Button btnFinalize;
		private System.Windows.Forms.Label lblTotalPrice;
		private System.Windows.Forms.Button btnRemoveItem;
		private System.Windows.Forms.DataGridView dataGridLineItems;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.TextBox txtQuantity;
		private System.Windows.Forms.Label label2;
	}
}