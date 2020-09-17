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
	public partial class frmEmployeeEdit : Form
	{

		private static int employeeID;

		public frmEmployeeEdit()
		{
			InitializeComponent();
		}


		private void frmEmployeeEdit_Load_1(object sender, EventArgs e)
		{

			//Just incase the index changes in the main form while this form is open.
			employeeID = frmEmployees.EmployeeIDSelected;


			Console.WriteLine("EmployeeID: " + employeeID);

			for (int i = 0; i < State.States.Count; i++)
			{
				comboStates.Items.Add(State.States[i].StateName);
			}



			string selectStatement = "select * from Employees where EmployeeID='" + employeeID + "'";

			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);


			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);



				while (reader.Read())
				{

					txtFirstName.Text = reader["EmployeeFirstName"].ToString();
					txtLastName.Text = reader["EmployeeLastName"].ToString();
					txtAddress.Text = reader["EmployeeAddress"].ToString();
					txtZipcode.Text = reader["EmployeeZipcode"].ToString();
					txtPhone.Text = reader["EmployeePhone"].ToString();
					comboStates.Items.Add(State.CodeToName(reader["EmployeeState"].ToString()));
					comboStates.SelectedIndex = State.States.Count;
					this.Text = "Editing " + txtFirstName.Text + " " + txtLastName.Text;

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

		private void btnEmployeeAdd_Click(object sender, EventArgs e)
		{
			string[] columns = { "EmployeeFirstName", " EmployeeLastName", " EmployeeAddress", " EmployeeZipcode", 
				" EmployeePhone"};
			TextBox[] txts = { txtFirstName, txtLastName, txtAddress, txtZipcode, txtPhone };

			for (int i = 0; i < columns.Length; i++)
			{
				string updateStatement = "update Employees set " + columns[i] + "='" + txts[i].Text + "' where EmployeeID='" + employeeID + "'";

				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand updateCommand = new SqlCommand(updateStatement, connection);


				try
				{
					connection.Open();
					updateCommand.ExecuteNonQuery();


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



			//Method to update the State manually.
			string updateStatement1 = "update Employees set EmployeeState='" + State.NameToCode(comboStates.Text) + "' where EmployeeID='" + employeeID + "'"; ;
			SqlConnection connection1 = new SqlConnection(VendorDB.connectionString);
			SqlCommand updateCommand1 = new SqlCommand(updateStatement1, connection1);

			try
			{
				connection1.Open();
				updateCommand1.ExecuteNonQuery();
				frmEmployees.updated = true;
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
	}
}
