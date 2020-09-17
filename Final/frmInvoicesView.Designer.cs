namespace Final
{
	partial class frmInvoicesView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoicesView));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblInvoiceID = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblEmployeeName = new System.Windows.Forms.Label();
			this.lblasdasdas = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.dataGridLineItems = new System.Windows.Forms.DataGridView();
			this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTotalPrice = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLineItems)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(129, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 54);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
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
			this.panel1.Location = new System.Drawing.Point(40, 82);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(335, 113);
			this.panel1.TabIndex = 10;
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Invoice ID:";
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
			// lblEmployeeName
			// 
			this.lblEmployeeName.AutoSize = true;
			this.lblEmployeeName.Location = new System.Drawing.Point(81, 48);
			this.lblEmployeeName.Name = "lblEmployeeName";
			this.lblEmployeeName.Size = new System.Drawing.Size(27, 13);
			this.lblEmployeeName.TabIndex = 3;
			this.lblEmployeeName.Text = "N/A";
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
			// dataGridLineItems
			// 
			this.dataGridLineItems.AllowUserToAddRows = false;
			this.dataGridLineItems.AllowUserToDeleteRows = false;
			this.dataGridLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridLineItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.Price,
            this.Quantity});
			this.dataGridLineItems.Location = new System.Drawing.Point(40, 216);
			this.dataGridLineItems.Name = "dataGridLineItems";
			this.dataGridLineItems.ReadOnly = true;
			this.dataGridLineItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridLineItems.Size = new System.Drawing.Size(335, 150);
			this.dataGridLineItems.TabIndex = 11;
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
			// lblTotalPrice
			// 
			this.lblTotalPrice.AutoSize = true;
			this.lblTotalPrice.Location = new System.Drawing.Point(37, 395);
			this.lblTotalPrice.Name = "lblTotalPrice";
			this.lblTotalPrice.Size = new System.Drawing.Size(52, 13);
			this.lblTotalPrice.TabIndex = 12;
			this.lblTotalPrice.Text = "Subtotal: ";
			// 
			// frmInvoicesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(444, 455);
			this.Controls.Add(this.lblTotalPrice);
			this.Controls.Add(this.dataGridLineItems);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmInvoicesView";
			this.Text = "View Invoice";
			this.Load += new System.EventHandler(this.frmInvoicesView_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLineItems)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblInvoiceID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEmployeeName;
		private System.Windows.Forms.Label lblasdasdas;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.DataGridView dataGridLineItems;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.Label lblTotalPrice;
	}
}