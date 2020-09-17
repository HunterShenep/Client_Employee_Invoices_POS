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
	public partial class frmInvoicesView : Form
	{
		private int invoiceIDa;
		private int employeeIDa;
		private int customerIDa;
		public frmInvoicesView()
		{
			InitializeComponent();
		}

		public frmInvoicesView(int invoiceID)
		{
			invoiceIDa = invoiceID;
			InitializeComponent();
			populateStaticList();
			string selectStatement = "select c.CustomerFirstName, c.CustomerLastName, c.CustomerBusinessName, e.EmployeeFirstName, e.EmployeeLastName, i.InvoiceID, i.InvoiceDateCreated,  i.InvoicePaid " +
				"from Customers c, Employees e, Invoices i where(c.CustomerID = i.CustomerID AND i.EmployeeID = e.EmployeeID and i.InvoiceID='" + invoiceID + "')";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
				while (reader.Read())
				{

					string invoicePaid = reader["InvoicePaid"].ToString();
					string customerFirstName = reader["CustomerFirstName"].ToString();
					string customerLastName = reader["CustomerLastName"].ToString();
					string customerBusinessName = reader["CustomerBusinessName"].ToString();
					string employeeFirstName = reader["EmployeeFirstName"].ToString();
					string employeeLastName = reader["EmployeeLastName"].ToString();
					string creationDate = reader["InvoiceDateCreated"].ToString();

					string fullCust = customerFirstName + " " + customerLastName + " " + customerBusinessName;
					string fullEmp = employeeFirstName + " " + employeeLastName;

					

					lblInvoiceID.Text = invoiceID.ToString();
					lblEmployeeName.Text = fullEmp;
					lblCustomerName.Text = fullCust;
					this.Text = "View Invoice: " + fullEmp;
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
			loadDataGrid();
		}

		private void frmInvoicesView_Load(object sender, EventArgs e)
		{

		}

		private void loadDataGrid()
		{
			string selectStatement = "select * from InvoiceLineItems where InvoiceID='" + invoiceIDa + "'";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
			decimal total = 0;

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{
					int serviceID = Int32.Parse(reader["ServiceID"].ToString());
					int quantity = Int32.Parse(reader["InvoiceLineItemQuantity"].ToString());
					string serviceName = Services.getNameByID(serviceID);
					decimal price = Services.getPriceByName(serviceName);
					total += price * quantity;

					string[] stuff = { serviceName, price.ToString(), quantity.ToString() };
					dataGridLineItems.Rows.Add(stuff);
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Error loading invoices: " + ex.Message);

			}
			finally
			{
				connection.Close();
			}
			lblTotalPrice.Text = "Subtotal: " + total.ToString();
		}


		private string searchCustomerById(int id)
		{
			string fullName = null;
			string selectStatement = "select * from Customers where CustomerID='" + id + "'";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{

					string firstName = reader["CustomerFirstName"].ToString();
					string lastName = reader["CustomerLastName"].ToString();
					string bizName = reader["CustomerBusinessName"].ToString();
					fullName = firstName + " " + lastName + " " + bizName;
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
			return fullName;
		}

		private string searchEmployeeById(int id)
		{
			string selectStatement = "select * from Employees where EmployeeID='" + id + "'";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
			string fullName = null;
			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{
					string firstName = reader["EmployeeFirstName"].ToString();
					string lastName = reader["EmployeeLastName"].ToString();
					fullName = firstName + " " + lastName;
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
			return fullName;
		}

		private void populateStaticList()
		{


			string selectStatement = "select * from Services order by ServiceName asc";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{
					int serviceID = Int32.Parse(reader["ServiceID"].ToString());
					string serviceName = reader["ServiceName"].ToString();
					decimal price = decimal.Parse(reader["ServicePrice"].ToString());
					Services.ServicesList.Add(new Services(serviceID, serviceName, price));
				}

			}

			catch (SqlException ex)
			{
				MessageBox.Show("Error with SQL initial loading drop down list items. " + ex.Message);
			}
			finally
			{
				connection.Close();


			}
		}

	}
}
