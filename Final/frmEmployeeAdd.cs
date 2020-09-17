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
	public partial class frmEmployeeAdd : Form
	{
		public frmEmployeeAdd()
		{
			InitializeComponent();
		}

		private void frmEmployeeAdd_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < State.States.Count; i++)
			{
				comboStates.Items.Add(State.States[i].StateName);
			}
		}

		private void btnEmployeeAdd_Click(object sender, EventArgs e)
		{
			if (txtFirstName.Text.Equals("") || txtLastName.Text.Equals(""))
			{

				MessageBox.Show("You must enter either a full name.", "Error");

			}
			else
			{
				if (txtAddress.Text.Equals("") || txtZipcode.Text.Equals(""))
				{
					MessageBox.Show("You must enter a complete address", "Error");
				}
				else
				{
					if (comboStates.SelectedIndex == -1)
					{
						MessageBox.Show("You must select a state!", "Error");
					}
					else
					{
						string s = "', '";
						string fname = txtFirstName.Text;
						string lname = txtLastName.Text;

						string addr = txtAddress.Text;
						string zip = txtZipcode.Text;
						string state = State.NameToCode(comboStates.Text);
						string phone = txtPhone.Text;
						DateTime today = DateTime.Today;
						string fDate = string.Format("{0:yyyy-MM-dd}", today);

						string insertStatement = "insert into Employees (EmployeeFirstName, EmployeeLastName, EmployeeAddress, EmployeeZipcode, EmployeeState, EmployeePhone, EmployeeSinceDate, EmployeeEnabled) values ('"
							+ fname + s + lname  + s + addr + s + zip + s + state + s + phone + s + today + s + "1')";

						SqlConnection connection = new SqlConnection(VendorDB.connectionString);
						SqlCommand insertCommand = new SqlCommand(insertStatement, connection);


						try
						{
							connection.Open();
							insertCommand.ExecuteNonQuery();
							frmEmployees.updated = true;
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
	}
}
