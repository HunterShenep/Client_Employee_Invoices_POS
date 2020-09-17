namespace Final
{
	partial class frmVendorEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendorEdit));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnVendorSave = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtVendorNotes = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtVendorWebsite = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtVendorPhone = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtVendorDescription = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtVendorName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(69, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(244, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.btnVendorSave);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtVendorNotes);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtVendorWebsite);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtVendorPhone);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtVendorDescription);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtVendorName);
			this.panel1.Location = new System.Drawing.Point(18, 105);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(352, 284);
			this.panel1.TabIndex = 2;
			// 
			// btnVendorSave
			// 
			this.btnVendorSave.Location = new System.Drawing.Point(237, 247);
			this.btnVendorSave.Name = "btnVendorSave";
			this.btnVendorSave.Size = new System.Drawing.Size(90, 23);
			this.btnVendorSave.TabIndex = 10;
			this.btnVendorSave.Text = "Save Changes";
			this.btnVendorSave.UseVisualStyleBackColor = true;
			this.btnVendorSave.Click += new System.EventHandler(this.btnVendorSave_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Notes";
			// 
			// txtVendorNotes
			// 
			this.txtVendorNotes.Location = new System.Drawing.Point(95, 182);
			this.txtVendorNotes.Multiline = true;
			this.txtVendorNotes.Name = "txtVendorNotes";
			this.txtVendorNotes.Size = new System.Drawing.Size(232, 59);
			this.txtVendorNotes.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 159);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Website";
			// 
			// txtVendorWebsite
			// 
			this.txtVendorWebsite.Location = new System.Drawing.Point(95, 156);
			this.txtVendorWebsite.Name = "txtVendorWebsite";
			this.txtVendorWebsite.Size = new System.Drawing.Size(232, 20);
			this.txtVendorWebsite.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Phone Number";
			// 
			// txtVendorPhone
			// 
			this.txtVendorPhone.Location = new System.Drawing.Point(95, 130);
			this.txtVendorPhone.Name = "txtVendorPhone";
			this.txtVendorPhone.Size = new System.Drawing.Size(232, 20);
			this.txtVendorPhone.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Description";
			// 
			// txtVendorDescription
			// 
			this.txtVendorDescription.AllowDrop = true;
			this.txtVendorDescription.Location = new System.Drawing.Point(95, 43);
			this.txtVendorDescription.Multiline = true;
			this.txtVendorDescription.Name = "txtVendorDescription";
			this.txtVendorDescription.Size = new System.Drawing.Size(232, 81);
			this.txtVendorDescription.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Vendor Name";
			// 
			// txtVendorName
			// 
			this.txtVendorName.Location = new System.Drawing.Point(95, 17);
			this.txtVendorName.Name = "txtVendorName";
			this.txtVendorName.Size = new System.Drawing.Size(232, 20);
			this.txtVendorName.TabIndex = 0;
			// 
			// frmVendorEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(390, 403);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmVendorEdit";
			this.Text = "Edit Vendor";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnVendorSave;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtVendorNotes;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtVendorWebsite;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtVendorPhone;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtVendorDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtVendorName;
	}
}