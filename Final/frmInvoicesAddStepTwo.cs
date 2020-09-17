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
	public partial class frmInvoicesAddStepTwo : Form
	{
		private decimal subtotal;
		//private int customerID;
		//private int employeeID;
		private int invoiceID;


		public frmInvoicesAddStepTwo()
		{

		}
		public frmInvoicesAddStepTwo(int customerID, int employeeID, int invoiceID)
		{

			InitializeComponent();
			populateCombo();
			Console.WriteLine(customerID + " " + employeeID + " " + invoiceID);
			string fullName = searchCustomerById(customerID);
			lblCustomerName.Text = fullName;
			lblEmployeeName.Text = searchEmployeeById(employeeID);
			lblInvoiceID.Text = invoiceID.ToString();
			this.Text = "New Invoice For " + fullName;

			//this.customerID = customerID;
			//this.employeeID = employeeID;
			this.invoiceID = invoiceID;
		}

		private void frmInvoicesAddStepTwo_Load(object sender, EventArgs e)
		{

		}

		private void populateCombo()
		{
			//comboBoxCustomers.Items.Add("ID");

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
					comboServices.Items.Add(serviceName);
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



		private void enableAddButton(object sender, EventArgs e)
		{
			btnAddLineItem.Enabled = true;
		}

		private void determineStuff()
		{
			//Remove button 
			if (dataGridLineItems.Rows.Count > 0)
			{
				btnRemoveItem.Enabled = true;
			}
			else
			{
				btnRemoveItem.Enabled = false;
			}

			//Finalize button
			if (dataGridLineItems.Rows.Count > 0)
			{
				btnFinalize.Enabled = true;
			}

			//Update subtotal
			subtotal = 0;
			for(int i = 0; i < dataGridLineItems.Rows.Count; i++)
			{
				decimal num1 = decimal.Parse(dataGridLineItems.CurrentRow.Cells[1].Value.ToString());
				decimal num2 = decimal.Parse(dataGridLineItems.CurrentRow.Cells[2].Value.ToString());
				subtotal += num1 * num2;
			}
			lblTotalPrice.Text = "Subtotal: " + subtotal.ToString("C");

		}

		private void btnRemoveItem_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow item in this.dataGridLineItems.SelectedRows)
			{
				dataGridLineItems.Rows.RemoveAt(item.Index);
			}

			determineStuff();
		}


		private void btnAddLineItem_Click(object sender, EventArgs e)
		{
			
			

			if (!txtQuantity.Text.Equals(""))
			{
				int output;
				if (Int32.TryParse(txtQuantity.Text, out output))
				{
					dataGridLineItems.Rows.Add(comboServices.Text, Services.getPriceByName(comboServices.Text), output);
				}
				else
				{
					MessageBox.Show("You must enter a whole number for quantity!", "Error!");
				}
			}
			else
			{
				MessageBox.Show("You must enter a quantity!", "Error!");
			}

			determineStuff();
		}

		private void btnFinalize_Click(object sender, EventArgs e)
		{
			for(int i = 0; i < dataGridLineItems.Rows.Count; i++)
			{
				string s = "', '";
				int service = Services.getIDByName(dataGridLineItems.CurrentRow.Cells[0].Value.ToString());
				string insertStatement = "insert into InvoiceLineItems (InvoiceID, ServiceID, InvoiceLineItemQuantity, InvoiceLineItemDiscountType, InvoiceLineItemDiscountAmount)" +
					" values ('" + invoiceID + s + service + s + Int32.Parse(dataGridLineItems.Rows[i].Cells[2].Value.ToString()) + "', '0', '0.0')";
				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

				try
				{
					connection.Open();
					insertCommand.ExecuteNonQuery();
				}
				catch(SqlException ex)
				{
					MessageBox.Show("Error saving invoice: " + ex.Message);
				}
				finally
				{
					connection.Close();
					
				}
			}
			MessageBox.Show("Success!");
		}
	}
	class Services
	{
		public string Name;
		public int ServiceID;
		public decimal Price;

		public static List<Services> ServicesList = new List<Services>();
		public Services(int id, string name, decimal price)
		{
			this.ServiceID = id;
			this.Name = name;
			this.Price = price;
		}

		public static decimal getPriceByName(string name)
		{
			decimal price = 0;
			for(int i = 0; i < ServicesList.Count; i++)
			{
				if (ServicesList[i].Name.Equals(name)){
					price = ServicesList[i].Price;
				}
			}
			return price;
		}

		public static int getIDByName(string name)
		{
			int id = 0;
			for (int i = 0; i < ServicesList.Count; i++)
			{
				if (ServicesList[i].Name.Equals(name))
				{
					id = ServicesList[i].ServiceID;
				}
			}
			return id;
		}

		public static string getNameByID(int id)
		{
			string name = "";
			for (int i = 0; i < ServicesList.Count; i++)
			{
				if (ServicesList[i].ServiceID == id)
				{
				name = ServicesList[i].Name;
			}
		}
			return name;
		}


}

}
