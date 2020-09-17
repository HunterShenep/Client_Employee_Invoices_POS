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
	public partial class frmCustomerEdit : Form
	{
		private static int customerID;

		public frmCustomerEdit()
		{
			InitializeComponent();
			customerID = frmCustomer.CustomerIDSelected;
			Console.WriteLine("CustomerID: " + customerID);

			for (int i = 0; i < State.States.Count; i++)
			{
				comboStates.Items.Add(State.States[i].StateName);
			}
		}

		private void btnCustomerEdit_Click(object sender, EventArgs e)
		{
			string[] columns = {"CustomerFirstName", "CustomerLastName", "CustomerBusinessName", "CustomerAddress"
					, "CustomerZipcode", "CustomerPhone", "CustomerWebsite", "CustomerNotes"};
			TextBox[] txts = { txtFirstName, txtLastName, txtBusinessName, txtAddress, txtZipcode, txtPhone, txtWebsite, txtNotes };

			for(int i = 0; i < columns.Length; i++)
			{
				string updateStatement = "update Customers set " + columns[i] + "='" + txts[i].Text + "' where CustomerID='" + customerID + "'";

				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand updateCommand = new SqlCommand(updateStatement, connection);


				try
				{
					connection.Open();
					updateCommand.ExecuteNonQuery();

				
				}
				catch(SqlException ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					connection.Close();
				}
			}



			//Method to update the State manually.
			string updateStatement1 = "update Customers set CustomerState='" + State.NameToCode(comboStates.Text) + "' where CustomerID='" + customerID + "'"; ;
			SqlConnection connection1 = new SqlConnection(VendorDB.connectionString);
			SqlCommand updateCommand1 = new SqlCommand(updateStatement1, connection1);

			try
			{
				connection1.Open();
				updateCommand1.ExecuteNonQuery();
				frmCustomer.updated = true;
				MessageBox.Show("Success!");
				this.Close();
			}
			catch (SqlException ex)
			{

				MessageBox.Show(ex.Message);

			}
			finally
			{
				
			}
		}

			private void frmCustomerEdit_Load(object sender, EventArgs e)
			{

				string selectStatement = "select * from Customers where CustomerID='" + customerID + "'";

				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand selectCommand = new SqlCommand(selectStatement, connection);


				try
				{
					connection.Open();
					SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);


					while (reader.Read())
					{

						txtFirstName.Text = reader["CustomerFirstName"].ToString();
						txtLastName.Text = reader["CustomerLastName"].ToString();
						txtBusinessName.Text = reader["CustomerBusinessName"].ToString();
						txtAddress.Text = reader["CustomerAddress"].ToString();
						txtZipcode.Text = reader["CustomerZipcode"].ToString();
						txtPhone.Text = reader["CustomerPhone"].ToString();
						txtWebsite.Text = reader["CustomerWebsite"].ToString();
						txtNotes.Text = reader["CustomerNotes"].ToString();
						comboStates.Items.Add(State.CodeToName(reader["CustomerState"].ToString()));
						comboStates.SelectedIndex = State.States.Count;
						this.Text = "Editing " + txtFirstName.Text + " " + txtLastName.Text;
				}


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
	}
}

