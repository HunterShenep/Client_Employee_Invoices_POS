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
	public partial class frmServicesEdit : Form
	{
		private static int serviceID;
		public frmServicesEdit()
		{
			InitializeComponent();
		}
		public frmServicesEdit(int id)
		{
			InitializeComponent();
			serviceID = id;
		}

		private void frmServicesEdit_Load(object sender, EventArgs e)
		{


			string selectStatement = "select * from Services where ServiceID='" + serviceID + "'";

			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);


			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);



				while (reader.Read())
				{

					txtServiceName.Text = reader["ServiceName"].ToString();
					txtDescription.Text = reader["ServiceDescription"].ToString();
					txtPrice.Text = reader["ServicePrice"].ToString();
					this.Text = "Editing " + txtServiceName.Text;

				}
				reader.Close();


			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				Console.WriteLine("Closed connection");
				connection.Close();
			}
		}

		private void btnServiceSave_Click(object sender, EventArgs e)
		{



			string[] columns = { "ServiceName", " ServiceDescription" };
			TextBox[] txts = { txtServiceName, txtDescription};

			for (int i = 0; i < columns.Length; i++)
			{

				string updateStatement = "update Services set " + columns[i] + "='" + txts[i].Text + "' where ServiceID='" + serviceID + "'";
				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand updateCommand = new SqlCommand(updateStatement, connection);


				try
				{
					connection.Open();
					updateCommand.ExecuteNonQuery();
					frmServices.updated = true;


				}
				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					connection.Close();
				}
			}


			decimal temp;

			if (decimal.TryParse(txtPrice.Text, out temp))
			{
				string updateStatement1 = "update Services set ServicePrice='" + temp + "' where ServiceID='" + serviceID + "'";

				SqlConnection connection1 = new SqlConnection(VendorDB.connectionString);
				SqlCommand updateCommand1 = new SqlCommand(updateStatement1, connection1);

				try
				{
					connection1.Open();
					updateCommand1.ExecuteNonQuery();

				}
				catch (SqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					connection1.Close();
					MessageBox.Show("Success!");
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("Please enter a xx.xx format for price!", "Error!");
			}


		}
	}
}
