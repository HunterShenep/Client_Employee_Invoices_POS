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
	public partial class frmCustomer : Form
	{
		public static int CustomerIDSelected;
		private Timer timer1;
		public static bool updated = false;

		public frmCustomer()
		{
			InitializeComponent();
			dropDownSearchTypes.Items.Clear();
			dropDownSearchTypes.Items.Add("ID");
			dropDownSearchTypes.Items.Add("Last Name");
			dropDownSearchTypes.Items.Add("Business Name");
			InitTimer();

		}

		private void frmCustomer_Load(object sender, EventArgs e)
		{

			string selectStatement = "select * from Customers order by CustomerLastName asc";
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

					dataGridCustomers.Rows.Add(stuff);
				}
				updateResultsNumber();


			}
			catch(SqlException ex)
			{
				MessageBox.Show("Error with SQL initial loading." + ex.Message);
			}
			finally
			{
				connection.Close();
			}


		}

		public void enableSearch(object sender, EventArgs e)
		{
			txtCustomerSearch.Text = "";
			txtCustomerSearch.Enabled = true;
			Console.WriteLine("Drop down changed");
			updateResultsNumber();
		}

		public void updateCustomerID()
		{
				CustomerIDSelected = Int32.Parse(dataGridCustomers.CurrentRow.Cells[0].Value.ToString());
		}

		public void clearDataGrid()
		{
			
			this.dataGridCustomers.Rows.Clear();
			this.dataGridCustomers.Refresh();
		}

		public void searchDataGrid(object sender, EventArgs e)
		{
			clearDataGrid();
			updateResultsNumber();
			if (!this.txtCustomerSearch.Text.ToString().Equals(""))
			{

				if (this.dropDownSearchTypes.SelectedItem.ToString().Equals("ID"))
				{
					int temp;

					if (!Int32.TryParse(txtCustomerSearch.Text.ToString(), out temp))
					{
						MessageBox.Show("You must enter a number");
					}
					else
					{
						searchById(Int32.Parse(txtCustomerSearch.Text.ToString()));
					}
				}
				else if(this.dropDownSearchTypes.SelectedItem.ToString().Equals("Last Name"))
				{
					searchByWordColumn(this.txtCustomerSearch.Text.ToString(), "CustomerLastName");
				}
				else if (this.dropDownSearchTypes.SelectedItem.ToString().Equals("Business Name"))
				{
					searchByWordColumn(this.txtCustomerSearch.Text.ToString(), "CustomerBusinessName");
				}

			}
		}



		public void searchById(int id)
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

					dataGridCustomers.Rows.Add(stuff);
				}
				updateResultsNumber();
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

		public void searchByWordColumn(String word, string column)
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
					string phone = reader["CustomerPhone"].ToString();
					string customerSince = reader["CustomerSinceDate"].ToString();



					string[] stuff = new string[] { idd, firstName, lastName, businessName, phone, customerSince };

					dataGridCustomers.Rows.Add(stuff);
				}
				updateResultsNumber();
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

		private void btnCustomerAdd_Click(object sender, EventArgs e)
		{
			Form aForm = new frmCustomerAdd();
			aForm.Show();
		}

		private void btnCustomerEdit_Click(object sender, EventArgs e)
		{
			updateCustomerID();
			Form aForm = new frmCustomerEdit();
			aForm.Show();


		}

		private void btnCustomerDelete_Click(object sender, EventArgs e)
		{
			//string deleteStatement = "delete from Customers where CustomerID='";
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "ATTENTION: PERMANENT CHANGE", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Console.WriteLine("Yes");

				CustomerIDSelected = Int32.Parse(dataGridCustomers.CurrentRow.Cells[0].Value.ToString());

				string deleteStatement = "delete from Customers where CustomerID='" + CustomerIDSelected + "'";
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
			if(updated == true)
			{
				reloadDefaultData();
				updateResultsNumber();
			}
			updated = false;
		}

		private void reloadDefaultData()
		{
			clearDataGrid();
			string selectStatement = "select * from Customers order by CustomerLastName desc";
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

					dataGridCustomers.Rows.Add(stuff);
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

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			reloadDefaultData();
		}

		private void updateResultsNumber()
		{
			lblResults.Text = "Results Found: " + dataGridCustomers.Rows.Count;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
