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
	public partial class frmCustomerAdd : Form
	{
		public frmCustomerAdd()
		{
			InitializeComponent();
		}

		private void frmCustomerAdd_Load(object sender, EventArgs e)
		{
			for(int i = 0; i < State.States.Count; i++)
			{
				comboStates.Items.Add(State.States[i].StateName);
			}
		}

		private void btnVendorAdd_Click(object sender, EventArgs e)
		{
			Console.WriteLine(comboStates.SelectedIndex.ToString() + "a");
			//Console.WriteLine(comboStates.SelectedItem.ToString() + "c");
			//Console.WriteLine(comboStates.SelectedText.ToString() + "d");


			if((txtFirstName.Text.Equals("") || txtLastName.Text.Equals("")) && txtBusinessName.Text.Equals(""))
			{

				MessageBox.Show("You must enter either a full name, business name, or both.", "Error");

			}
			else
			{
				if(txtAddress.Text.Equals("") || txtZipcode.Text.Equals(""))
				{
					MessageBox.Show("You must enter an address", "Error");
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
						string bname = txtBusinessName.Text;
						string addr = txtAddress.Text;
						string zip = txtZipcode.Text;
						string state = State.NameToCode(comboStates.Text);
						string phone = txtPhone.Text;
						string web = txtWebsite.Text;
						string note = txtNotes.Text;
						DateTime today = DateTime.Today;
						string fDate = string.Format("{0:yyyy-MM-dd}", today);

						string insertStatement = "insert into Customers (CustomerFirstName, CustomerLastName, CustomerBusinessName, CustomerType, " +
							"CustomerAddress, CustomerZipcode, CustomerState, CustomerPhone, CustomerWebsite, CustomerSinceDate, CustomerNotes, " +
							"CustomerEnabled) values ('" + fname + s + lname + s + bname + s + "1" + s + addr + s + zip + s + state + s + phone + s + 
							web + s + fDate + s + note + s + "1')";

						SqlConnection connection = new SqlConnection(VendorDB.connectionString);
						SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

						try
						{
							connection.Open();
							insertCommand.ExecuteNonQuery();
							frmCustomer.updated = true;
							MessageBox.Show("Success!");
							this.Close();
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
				}




				
			}
		}
	}
}
