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
	public partial class frmInvoicesAdd : Form
	{

		private int customerIDSelected;
		private int employeeIDSelected;

		public frmInvoicesAdd()
		{
			InitializeComponent();
		}

		private void frmInvoicesAdd_Load(object sender, EventArgs e)
		{
			populateComboBoxes();
		}



		private void searchCustomerDataGrid(object sender, EventArgs e)
		{
			clearDataGrid("c");
			if (!this.txtCustomerSearch.Text.ToString().Equals(""))
			{

				if (this.comboBoxCustomers.SelectedItem.ToString().Equals("ID"))
				{
					int temp;

					if (!Int32.TryParse(txtCustomerSearch.Text.ToString(), out temp))
					{
						MessageBox.Show("You must enter a number");
					}
					else
					{
						customerSearchByID(Int32.Parse(txtCustomerSearch.Text.ToString()));
					}
				}
				else if (this.comboBoxCustomers.SelectedItem.ToString().Equals("Last Name"))
				{
					customerSearchByColumn(this.txtCustomerSearch.Text.ToString(), "CustomerLastName");
				}
				else if (this.comboBoxCustomers.SelectedItem.ToString().Equals("Business Name"))
				{
					customerSearchByColumn(this.txtCustomerSearch.Text.ToString(), "CustomerBusinessName");
				}

			}
		}

		public void customerSearchByID(int id)
		{
			string selectStatement = "select * from Customers where CustomerID='" + id + "' order by CustomerLastName asc";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{
					string idd = reader["CustomerID"].ToString();
					string firstName = reader["CustomerFirstName"].ToString();
					string lastName = reader["CustomerLastName"].ToString();
					string businessName = reader["CustomerBusinessName"].ToString();
					string phone = reader["CustomerPhone"].ToString();
					string customerSince = reader["CustomerSinceDate"].ToString();



					string[] stuff = new string[] { idd, firstName, lastName, businessName, phone, customerSince };

					dataGridCustomer.Rows.Add(stuff);
				}
				
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			finally
			{
				connection.Close();
			}
		}

		public void customerSearchByColumn(String word, string column)
		{
			string selectStatement = "select * from Customers where " + column + " LIKE '%" + word + "%' order by CustomerLastName desc";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
				while (reader.Read())
				{
					string idd = reader["CustomerID"].ToString();
					string firstName = reader["CustomerFirstName"].ToString();
					string lastName = reader["CustomerLastName"].ToString();
					string businessName = reader["CustomerBusinessName"].ToString();
					string[] stuff = new string[] { idd, firstName, lastName, businessName };
					dataGridCustomer.Rows.Add(stuff);
				}
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			finally
			{
				connection.Close();
			}
		}

		public void searchEmployeeDataGrid(object sender, EventArgs e)
		{
			clearDataGrid("e");


			if (!this.txtSearchEmployee.Text.ToString().Equals(""))
			{

				if (this.comboBoxEmployee.SelectedItem.ToString().Equals("ID"))
				{
					int temp;

					if (!Int32.TryParse(txtSearchEmployee.Text.ToString(), out temp))
					{
						MessageBox.Show("You must enter a number");
					}
					else
					{
						searchById(Int32.Parse(txtSearchEmployee.Text.ToString()));
					}
				}
				else if (this.comboBoxEmployee.SelectedItem.ToString().Equals("Last Name"))
				{
					searchByWordColumn(this.txtSearchEmployee.Text.ToString(), "EmployeeLastName");
				}

			}
		}

		public void searchByWordColumn(String word, string column)
		{
			string selectStatement = "select * from Employees where " + column + " LIKE '%" + word + "%' order by EmployeeLastName desc";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{
					string idd = reader["EmployeeID"].ToString();
					string firstName = reader["EmployeeFirstName"].ToString();
					string lastName = reader["EmployeeLastName"].ToString();

					string[] stuff = new string[] { idd, firstName, lastName};

					dataGridEmployee.Rows.Add(stuff);
				}

			}
			catch (SqlException ex)
			{
				throw ex;
			}
			finally
			{
				connection.Close();
			}
		}

		public void searchById(int id)
		{
			string selectStatement = "select * from Employees where EmployeeID='" + id + "' order by EmployeeID asc";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{
					string idd = reader["EmployeeID"].ToString();
					string firstName = reader["EmployeeFirstName"].ToString();
					string lastName = reader["EmployeeLastName"].ToString();
					string[] stuff = new string[] { idd, firstName, lastName };

					dataGridEmployee.Rows.Add(stuff);
				}

			}
			catch (SqlException ex)
			{
				throw ex;
			}
			finally
			{
				connection.Close();
			}
		}



		private void clearDataGrid(String type)
		{
			if (type.Equals("c"))
			{
				this.dataGridCustomer.Rows.Clear();
				this.dataGridCustomer.Refresh();
			}
			else if (type.Equals("e"))
			{
				this.dataGridEmployee.Rows.Clear();
				this.dataGridEmployee.Refresh();
			}
		}
		private void populateComboBoxes()
		{
			//Customers/Clients
			comboBoxCustomers.Items.Clear();
			comboBoxCustomers.Items.Add("ID");
			comboBoxCustomers.Items.Add("Last Name");
			comboBoxCustomers.Items.Add("Business Name");
			comboBoxEmployee.Items.Clear();
			comboBoxEmployee.Items.Add("ID");
			comboBoxEmployee.Items.Add("Last Name");

		}
		private void enableCustomerSearch(object sender, EventArgs e)
		{
			txtCustomerSearch.Enabled = true;
		}
		private void enableEmployeeSearch(object sender, EventArgs e)
		{
			txtSearchEmployee.Enabled = true;
		}
		private void btnSelectCustomer_Click(object sender, EventArgs e)
		{
			customerIDSelected = Int32.Parse(dataGridCustomer.CurrentRow.Cells[0].Value.ToString());
			lblCustomerSelected.Text = "Customer Selected: " + customerIDSelected + " - " + dataGridCustomer.CurrentRow.Cells[1].Value.ToString() 
				+ " " + dataGridCustomer.CurrentRow.Cells[2].Value.ToString() + " " + dataGridCustomer.CurrentRow.Cells[3].Value.ToString();
		}
		private void btnSelectEmployee_Click(object sender, EventArgs e)
		{
			employeeIDSelected = Int32.Parse(dataGridEmployee.CurrentRow.Cells[0].Value.ToString());
			lblEmployeeSelected.Text = "Employee Selected: " + employeeIDSelected + " - " + dataGridEmployee.CurrentRow.Cells[1].Value.ToString()
				+ " " + dataGridEmployee.CurrentRow.Cells[2].Value.ToString();

		}
		private void btnContinue_Click(object sender, EventArgs e)
		{
			if (customerIDSelected == 0 || employeeIDSelected == 0)
			{
				MessageBox.Show("You forgot to select Customer or Employee!", "Error!");
			}
			else
			{

				DateTime today = DateTime.Today;
				string fDate = string.Format("{0:yyyy-MM-dd}", today);

				string insertStatement = "insert into Invoices (CustomerID, EmployeeID, InvoiceDateCreated, InvoicePaidAmount, InvoicePaid) values " +
					"('" + customerIDSelected + "', '" + employeeIDSelected + "', '" + fDate + "', '0', '0')";

				string selectStatement = "SELECT TOP 1 * FROM Invoices ORDER BY InvoiceID DESC";

				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
				SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
				try
				{
					connection.Open();
					insertCommand.ExecuteNonQuery();
					SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
					int idOfLastCreated = 0;

					while (reader.Read())
					{
						idOfLastCreated = Int32.Parse(reader["InvoiceID"].ToString());
					}
					reader.Close();

					Form lastStep = new frmInvoicesAddStepTwo(customerIDSelected, employeeIDSelected, idOfLastCreated);
					lastStep.Show();
					this.Close();
					frmInvoices.updated = true;
				}
				catch (SqlException ex)
				{
					MessageBox.Show("Error adding new invoice: " + ex.Message);
				}
				finally
				{
					connection.Close();

				}
			}

			//


		}
	}
}
