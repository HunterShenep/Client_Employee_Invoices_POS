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
	public partial class frmInvoices : Form
	{
		public static bool updated;
		private Timer timer1;

		public frmInvoices()
		{
			InitializeComponent();
		}

		private void frmInvoices_Load(object sender, EventArgs e)
		{
			populateDataGridDefault();
			dropDownSearchTypes.Items.Add("Invoice ID");
			dropDownSearchTypes.Items.Add("Customer Last Name");
			dropDownSearchTypes.Items.Add("Employee Last Name");
			updateResultsNumber();
			InitTimer();
		}


		private void btnEmployeeAdd_Click(object sender, EventArgs e)
		{
			Form aForm = new frmInvoicesAdd();
			aForm.Show();
			

		}
		private void clearDataGrid()
		{
			dataGridInvoices.Rows.Clear();
			dataGridInvoices.Refresh();
		}
		private void populateDataGridDefault()
		{
			clearDataGrid();
			string selectStatement = "select c.CustomerFirstName, c.CustomerLastName, c.CustomerBusinessName, e.EmployeeFirstName, e.EmployeeLastName, i.InvoiceID, i.InvoiceDateCreated,  i.InvoicePaid " +
				"from Customers c, Employees e, Invoices i where(c.CustomerID = i.CustomerID AND i.EmployeeID = e.EmployeeID)";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
				while (reader.Read())
				{
					string invoiceID = reader["InvoiceID"].ToString();
					string invoicePaid = reader["InvoicePaid"].ToString();
					string customerFirstName = reader["CustomerFirstName"].ToString();
					string customerLastName = reader["CustomerLastName"].ToString();
					string customerBusinessName = reader["CustomerBusinessName"].ToString();
					string employeeFirstName = reader["EmployeeFirstName"].ToString();
					string employeeLastName = reader["EmployeeLastName"].ToString();
					string creationDate = reader["InvoiceDateCreated"].ToString();

					string fullCust = customerFirstName + " " + customerLastName + " " + customerBusinessName;
					string fullEmp = employeeFirstName + " " + employeeLastName;

					string[] stuff = { invoiceID, fullCust, creationDate, fullEmp, invoicePaid };
					dataGridInvoices.Rows.Add(stuff);

				}
				reader.Close();
			}
			catch(SqlException ex)
			{
				MessageBox.Show("Error loading invoices: " + ex.Message);

			}
			finally
			{
				connection.Close();
			}


		}

		private void searchEnabled(object sender, EventArgs e)
		{
			txtInvoiceSearch.Enabled = true;
		}

		public void searchDataGrid(object sender, EventArgs e)
		{
			clearDataGrid();
			
			if (!this.txtInvoiceSearch.Text.ToString().Equals(""))
			{

				if (this.dropDownSearchTypes.SelectedItem.ToString().Equals("Invoice ID"))
				{
					int temp;

					if (!Int32.TryParse(txtInvoiceSearch.Text.ToString(), out temp))
					{
						MessageBox.Show("You must enter a number");
					}
					else
					{
						searchByInvoiceID(Int32.Parse(txtInvoiceSearch.Text.ToString()));
					}
				}
				else if (this.dropDownSearchTypes.SelectedItem.ToString().Equals("Customer Last Name"))
				{
					searchByColumn(this.txtInvoiceSearch.Text.ToString(), "c.CustomerLastName");
				}
				else if (this.dropDownSearchTypes.SelectedItem.ToString().Equals("Employee Last Name"))
				{
					searchByColumn(this.txtInvoiceSearch.Text.ToString(), "e.EmployeeLastName");
				}

			}
			updateResultsNumber();
		}
		private void updateResultsNumber()
		{
			lblResults.Text = "Results Found: " + dataGridInvoices.Rows.Count;
		}

		private void searchByInvoiceID(int id)
		{
			clearDataGrid();
			string selectStatement = "select c.CustomerFirstName, c.CustomerLastName, c.CustomerBusinessName, e.EmployeeFirstName, e.EmployeeLastName, i.InvoiceID, i.InvoiceDateCreated,  i.InvoicePaid " +
				"from Customers c, Employees e, Invoices i where(c.CustomerID = i.CustomerID AND i.EmployeeID = e.EmployeeID AND InvoiceID='" + id + "')";

			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
				while (reader.Read())
				{
					string invoiceID = reader["InvoiceID"].ToString();
					string invoicePaid = reader["InvoicePaid"].ToString();
					string customerFirstName = reader["CustomerFirstName"].ToString();
					string customerLastName = reader["CustomerLastName"].ToString();
					string customerBusinessName = reader["CustomerBusinessName"].ToString();
					string employeeFirstName = reader["EmployeeFirstName"].ToString();
					string employeeLastName = reader["EmployeeLastName"].ToString();
					string creationDate = reader["InvoiceDateCreated"].ToString();

					string fullCust = customerFirstName + " " + customerLastName + " " + customerBusinessName;
					string fullEmp = employeeFirstName + " " + employeeLastName;

					string[] stuff = { invoiceID, fullCust, creationDate, fullEmp, invoicePaid };
					dataGridInvoices.Rows.Add(stuff);

				}
				reader.Close();
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Error loading invoices: " + ex.Message);

			}
			finally
			{
				connection.Close();
			}
		}

		private void searchByColumn(string word, string column)
		{

			clearDataGrid();
			string selectStatement = "select c.CustomerFirstName, c.CustomerLastName, c.CustomerBusinessName, e.EmployeeFirstName, e.EmployeeLastName, i.InvoiceID, i.InvoiceDateCreated,  i.InvoicePaid " +
				"from Customers c, Employees e, Invoices i where(c.CustomerID = i.CustomerID AND i.EmployeeID = e.EmployeeID AND " + column + " LIKE '%" + word + "%')";

			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
				while (reader.Read())
				{
					string invoiceID = reader["InvoiceID"].ToString();
					string invoicePaid = reader["InvoicePaid"].ToString();
					string customerFirstName = reader["CustomerFirstName"].ToString();
					string customerLastName = reader["CustomerLastName"].ToString();
					string customerBusinessName = reader["CustomerBusinessName"].ToString();
					string employeeFirstName = reader["EmployeeFirstName"].ToString();
					string employeeLastName = reader["EmployeeLastName"].ToString();
					string creationDate = reader["InvoiceDateCreated"].ToString();

					string fullCust = customerFirstName + " " + customerLastName + " " + customerBusinessName;
					string fullEmp = employeeFirstName + " " + employeeLastName;

					string[] stuff = { invoiceID, fullCust, creationDate, fullEmp, invoicePaid };
					dataGridInvoices.Rows.Add(stuff);

				}
				reader.Close();
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Error loading invoices: " + ex.Message);

			}
			finally
			{
				connection.Close();
			}
		}

		private void btnEmployeeDelete_Click(object sender, EventArgs e)
		{
			//string deleteStatement = "delete from Customers where CustomerID='";
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "ATTENTION: PERMANENT CHANGE", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Console.WriteLine("Yes");

				int invoiceIDselected = Int32.Parse(dataGridInvoices.CurrentRow.Cells[0].Value.ToString());

				string deleteStatement = "delete from Invoices where CustomerID='" + invoiceIDselected + "'";
				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);

				try
				{
					connection.Open();
					deleteCommand.ExecuteNonQuery();
					updated = true;

					MessageBox.Show("Record deleted.");


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
			else if (dialogResult == DialogResult.No)
			{
				//
			}
		}

		public void InitTimer()
		{
			timer1 = new Timer();
			timer1.Tick += new EventHandler(timer1_Tick);
			timer1.Interval = 500; // in miliseconds
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (updated == true)
			{
				populateDataGridDefault();
				updateResultsNumber();
			}
			updated = false;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			populateDataGridDefault();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Form aForm = new frmInvoicesView(Int32.Parse(dataGridInvoices.CurrentRow.Cells[0].Value.ToString()));
			aForm.Show();
		}
	}
}
