namespace Final
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnStartEmployees = new System.Windows.Forms.Button();
			this.btnStartClients = new System.Windows.Forms.Button();
			this.btnStartInvoices = new System.Windows.Forms.Button();
			this.btnStartVendors = new System.Windows.Forms.Button();
			this.btnServices = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(41, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(325, 92);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnStartEmployees
			// 
			this.btnStartEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartEmployees.Location = new System.Drawing.Point(41, 134);
			this.btnStartEmployees.Name = "btnStartEmployees";
			this.btnStartEmployees.Size = new System.Drawing.Size(145, 41);
			this.btnStartEmployees.TabIndex = 1;
			this.btnStartEmployees.Text = "Employees";
			this.btnStartEmployees.UseVisualStyleBackColor = true;
			this.btnStartEmployees.Click += new System.EventHandler(this.btnStartEmployees_Click);
			// 
			// btnStartClients
			// 
			this.btnStartClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartClients.Location = new System.Drawing.Point(221, 134);
			this.btnStartClients.Name = "btnStartClients";
			this.btnStartClients.Size = new System.Drawing.Size(145, 41);
			this.btnStartClients.TabIndex = 2;
			this.btnStartClients.Text = "Customers";
			this.btnStartClients.UseVisualStyleBackColor = true;
			this.btnStartClients.Click += new System.EventHandler(this.btnStartClients_Click);
			// 
			// btnStartInvoices
			// 
			this.btnStartInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartInvoices.Location = new System.Drawing.Point(41, 203);
			this.btnStartInvoices.Name = "btnStartInvoices";
			this.btnStartInvoices.Size = new System.Drawing.Size(145, 41);
			this.btnStartInvoices.TabIndex = 3;
			this.btnStartInvoices.Text = "Invoices";
			this.btnStartInvoices.UseVisualStyleBackColor = true;
			this.btnStartInvoices.Click += new System.EventHandler(this.btnStartInvoices_Click);
			// 
			// btnStartVendors
			// 
			this.btnStartVendors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartVendors.Location = new System.Drawing.Point(221, 203);
			this.btnStartVendors.Name = "btnStartVendors";
			this.btnStartVendors.Size = new System.Drawing.Size(145, 41);
			this.btnStartVendors.TabIndex = 4;
			this.btnStartVendors.Text = "Vendors";
			this.btnStartVendors.UseVisualStyleBackColor = true;
			this.btnStartVendors.Click += new System.EventHandler(this.btnStartVendors_Click);
			// 
			// btnServices
			// 
			this.btnServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnServices.Location = new System.Drawing.Point(41, 272);
			this.btnServices.Name = "btnServices";
			this.btnServices.Size = new System.Drawing.Size(145, 41);
			this.btnServices.TabIndex = 5;
			this.btnServices.Text = "Services";
			this.btnServices.UseVisualStyleBackColor = true;
			this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(407, 351);
			this.Controls.Add(this.btnServices);
			this.Controls.Add(this.btnStartVendors);
			this.Controls.Add(this.btnStartInvoices);
			this.Controls.Add(this.btnStartClients);
			this.Controls.Add(this.btnStartEmployees);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "HC CODE WI | Client Employee Management";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnStartEmployees;
		private System.Windows.Forms.Button btnStartClients;
		private System.Windows.Forms.Button btnStartInvoices;
		private System.Windows.Forms.Button btnStartVendors;
		private System.Windows.Forms.Button btnServices;
	}
}

