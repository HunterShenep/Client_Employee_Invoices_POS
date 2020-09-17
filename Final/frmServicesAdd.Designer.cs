namespace Final
{
	partial class frmServicesAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicesAdd));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.btnServiceAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtServiceName = new System.Windows.Forms.TextBox();
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
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtPrice);
			this.panel1.Controls.Add(this.txtDescription);
			this.panel1.Controls.Add(this.btnServiceAdd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtServiceName);
			this.panel1.Location = new System.Drawing.Point(7, 105);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(372, 212);
			this.panel1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Service Price";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Service Description";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(126, 143);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(63, 20);
			this.txtPrice.TabIndex = 2;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(126, 46);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(232, 91);
			this.txtDescription.TabIndex = 1;
			// 
			// btnServiceAdd
			// 
			this.btnServiceAdd.Location = new System.Drawing.Point(249, 177);
			this.btnServiceAdd.Name = "btnServiceAdd";
			this.btnServiceAdd.Size = new System.Drawing.Size(109, 23);
			this.btnServiceAdd.TabIndex = 3;
			this.btnServiceAdd.Text = "Add Service";
			this.btnServiceAdd.UseVisualStyleBackColor = true;
			this.btnServiceAdd.Click += new System.EventHandler(this.btnServiceAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Service Name";
			// 
			// txtServiceName
			// 
			this.txtServiceName.Location = new System.Drawing.Point(126, 20);
			this.txtServiceName.Name = "txtServiceName";
			this.txtServiceName.Size = new System.Drawing.Size(232, 20);
			this.txtServiceName.TabIndex = 0;
			// 
			// frmServicesAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(388, 326);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmServicesAdd";
			this.Text = "Add New Service";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnServiceAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtServiceName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtDescription;
	}
}