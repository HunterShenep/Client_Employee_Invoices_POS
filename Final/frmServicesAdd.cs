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
	public partial class frmServicesAdd : Form
	{
		public frmServicesAdd()
		{
			InitializeComponent();
		}

		private void btnServiceAdd_Click(object sender, EventArgs e)
		{
			if (txtServiceName.Text.Equals("") || txtDescription.Text.Equals("") || txtPrice.Text.Equals(""))
			{
				MessageBox.Show("All fields must be answered!", "Error");
			}
			else
			{
				string s = "', '";
				string insertStatement = "insert into Services (ServiceName, ServiceDescription, ServicePrice) values ('"
					+ txtServiceName.Text + s + txtDescription.Text + s + txtPrice.Text + "')";

				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand insertCommand = new SqlCommand(insertStatement, connection);


				try
				{
					connection.Open();
					insertCommand.ExecuteNonQuery();
					frmServices.updated = true;
					MessageBox.Show("Success!");
					this.Close();
				}
				catch (SqlException ex)
				{
					MessageBox.Show("Error with database:  " + ex.Message);
				}
				finally
				{
					connection.Close();
				}
			}
		}
	}
}
