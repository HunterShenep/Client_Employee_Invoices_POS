namespace Final
{
	partial class frmEmployeeAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeAdd));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboStates = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtZipcode = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.btnEmployeeAdd = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(71, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(244, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.comboStates);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtZipcode);
			this.panel1.Controls.Add(this.txtAddress);
			this.panel1.Controls.Add(this.txtLastName);
			this.panel1.Controls.Add(this.btnEmployeeAdd);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtPhone);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtFirstName);
			this.panel1.Location = new System.Drawing.Point(9, 105);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(372, 212);
			this.panel1.TabIndex = 4;
			// 
			// comboStates
			// 
			this.comboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboStates.FormattingEnabled = true;
			this.comboStates.Location = new System.Drawing.Point(249, 124);
			this.comboStates.Name = "comboStates";
			this.comboStates.Size = new System.Drawing.Size(109, 21);
			this.comboStates.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.AllowDrop = true;
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(211, 127);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = "State";
			// 
			// label8
			// 
			this.label8.AllowDrop = true;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(18, 127);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "Zipcode";
			// 
			// label7
			// 
			this.label7.AllowDrop = true;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(17, 101);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Address";
			// 
			// txtZipcode
			// 
			this.txtZipcode.Location = new System.Drawing.Point(126, 124);
			this.txtZipcode.Name = "txtZipcode";
			this.txtZipcode.Size = new System.Drawing.Size(79, 20);
			this.txtZipcode.TabIndex = 4;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(126, 98);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(232, 20);
			this.txtAddress.TabIndex = 3;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(126, 46);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(232, 20);
			this.txtLastName.TabIndex = 1;
			// 
			// btnEmployeeAdd
			// 
			this.btnEmployeeAdd.Location = new System.Drawing.Point(249, 177);
			this.btnEmployeeAdd.Name = "btnEmployeeAdd";
			this.btnEmployeeAdd.Size = new System.Drawing.Size(109, 23);
			this.btnEmployeeAdd.TabIndex = 9;
			this.btnEmployeeAdd.Text = "Add Employee";
			this.btnEmployeeAdd.UseVisualStyleBackColor = true;
			this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Phone Number";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(126, 151);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(232, 20);
			this.txtPhone.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AllowDrop = true;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Last Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "First Name";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(126, 20);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(232, 20);
			this.txtFirstName.TabIndex = 0;
			// 
			// frmEmployeeAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(393, 327);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEmployeeAdd";
			this.Text = "Add New Employee";
			this.Load += new System.EventHandler(this.frmEmployeeAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox comboStates;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtZipcode;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Button btnEmployeeAdd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFirstName;
	}
}