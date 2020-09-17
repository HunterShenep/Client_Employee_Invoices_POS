using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
	public partial class frmVendorEdit : Form
	{
		private static int vendorID;

		public frmVendorEdit()
		{

			InitializeComponent();
			vendorID = frmVendors.VendorIDSelected;
			//frmVendors.dataGridIndex;
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);


			string selectStatement = "select VendorID, VendorName, VendorWebsite, VendorDescription, VendorNotes, VendorPhone from Vendors where VendorID='" + vendorID + "'";

			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
				while (reader.Read())
				{
					txtVendorName.Text = reader["VendorName"].ToString();
					txtVendorDescription.Text = reader["VendorDescription"].ToString();
					txtVendorNotes.Text = reader["VendorNotes"].ToString();
					txtVendorPhone.Text = reader["VendorPhone"].ToString();
					txtVendorWebsite.Text = reader["VendorWebsite"].ToString();
					this.Text = "Editing " + reader["VendorName"].ToString();
				}


			}
			catch(SqlException ex)
			{
				throw ex;
			}
			finally
			{
				connection.Close();
			}
		}

		private void btnVendorSave_Click(object sender, EventArgs e)
		{
			string[] columns = { "VendorName", "VendorDescription", "VendorNotes", "VendorPhone", "VendorWebsite" };
			TextBox[] txts = { txtVendorName, txtVendorDescription, txtVendorNotes, txtVendorPhone, txtVendorWebsite};

			for(int i = 0; i < columns.Length; i++)
			{
				string updateStatement = "update Vendors set " + columns[i] + "='" + txts[i].Text.ToString() + "' where VendorID='" + vendorID + "'";

				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

				try
				{
					connection.Open();
					updateCommand.ExecuteNonQuery();
					frmVendors.updated = true;

				}
				catch(SqlException ex)
				{
					throw ex;
				}
				finally
				{
					connection.Close();
				}

			}


			MessageBox.Show("Success!");
			this.Close();
		}
	}
}
