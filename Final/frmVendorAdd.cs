using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
	public partial class frmVendorAdd : Form
	{

		public frmVendorAdd()
		{
			InitializeComponent();
		}



		private void btnVendorAdd_Click(object sender, EventArgs e)
		{
			if (!txtVendorName.Text.ToString().Equals(""))
			{
				if(VendorDB.AddVendor(txtVendorName.Text, txtVendorDescription.Text, txtVendorPhone.Text, txtVendorWebsite.Text, txtVendorNotes.Text))
				{
					frmVendors.updated = true;
					MessageBox.Show("Success!");
					clearTextBoxes(sender, e);
					this.Close();
					
				}
				else
				{
					MessageBox.Show("Error?");
				}
			}
			else
			{
				MessageBox.Show("You must enter at least a name!");
			}
		}

		private void clearTextBoxes(object sender, EventArgs e)
		{
			txtVendorDescription.Text = "";
			txtVendorName.Text = "";
			txtVendorNotes.Text = "";
			txtVendorPhone.Text = "";
			txtVendorWebsite.Text = "";
		}



	}
}
