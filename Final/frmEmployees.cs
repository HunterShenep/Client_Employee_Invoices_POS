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
	public partial class frmEmployees : Form
	{


		public static int EmployeeIDSelected;
		private Timer timer1;
		public static bool updated = false;


		public frmEmployees()
		{
			InitializeComponent();
			dropDownSearchTypes.Items.Clear();
			dropDownSearchTypes.Items.Add("ID");
			dropDownSearchTypes.Items.Add("Last Name");
			InitTimer();
		}

		private void frmEmployees_Load(object sender, EventArgs e)
		{
			reloadDefaultData();
		}


		public void updateEmployeeID()
		{
			EmployeeIDSelected = Int32.Parse(dataGridEmployee.CurrentRow.Cells[0].Value.ToString());
		}

		public void clearDataGrid()
		{

			this.dataGridEmployee.Rows.Clear();
			this.dataGridEmployee.Refresh();
		}

		public void enableSearch(object sender, EventArgs e)
		{
			txtEmployeeSearch.Text = "";
			txtEmployeeSearch.Enabled = true;
			Console.WriteLine("Drop down changed");
			updateResultsNumber();
		}

		private void updateResultsNumber()
		{
			lblResults.Text = "Results Found: " + dataGridEmployee.Rows.Count;
		}

		public void updateCustomerID()
		{
			EmployeeIDSelected = Int32.Parse(dataGridEmployee.CurrentRow.Cells[0].Value.ToString());
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
				reloadDefaultData();
				updateResultsNumber();
			}
			updated = false;
		}


		public void searchDataGrid(object sender, EventArgs e)
		{
			clearDataGrid();
			updateResultsNumber();

			if (!this.txtEmployeeSearch.Text.ToString().Equals(""))
			{

				if (this.dropDownSearchTypes.SelectedItem.ToString().Equals("ID"))
				{
					int temp;

					if (!Int32.TryParse(txtEmployeeSearch.Text.ToString(), out temp))
					{
						MessageBox.Show("You must enter a number");
					}
					else
					{
						searchById(Int32.Parse(txtEmployeeSearch.Text.ToString()));
					}
				}
				else if (this.dropDownSearchTypes.SelectedItem.ToString().Equals("Last Name"))
				{
					searchByWordColumn(this.txtEmployeeSearch.Text.ToString(), "EmployeeLastName");
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
					string phone = reader["EmployeePhone"].ToString();
					string employeeSince = reader["EmployeeSinceDate"].ToString();
					string[] stuff = new string[] { idd, firstName, lastName, phone, employeeSince };

					dataGridEmployee.Rows.Add(stuff);
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
					string phone = reader["EmployeePhone"].ToString();
					string employeeSince = reader["EmployeeSinceDate"].ToString();
					string[] stuff = new string[] { idd, firstName, lastName, phone, employeeSince };

					dataGridEmployee.Rows.Add(stuff);
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

		private void reloadDefaultData()
		{
			clearDataGrid();
			string selectStatement = "select * from Employees order by EmployeeLastName asc";
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
					string phone = reader["EmployeePhone"].ToString();
					string employeeSince = reader["EmployeeSinceDate"].ToString();

					string[] stuff = new string[] { idd, firstName, lastName, phone, employeeSince };

					dataGridEmployee.Rows.Add(stuff);
				}

			}

			catch (SqlException ex)
			{
				MessageBox.Show("Error with SQL initial loading. " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		private void btnEmployeeAdd_Click(object sender, EventArgs e)
		{
			Form aForm = new frmEmployeeAdd();
			aForm.Show();
		}

		private void btnEmployeeEdit_Click(object sender, EventArgs e)
		{
			updateCustomerID();
			Form aaForm = new frmEmployeeEdit();
			aaForm.Show();
		}

		private void btnEmployeeDelete_Click(object sender, EventArgs e)
		{
			//string deleteStatement = "delete from Customers where CustomerID='";
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "ATTENTION: PERMANENT CHANGE", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Console.WriteLine("Yes");

				EmployeeIDSelected = Int32.Parse(dataGridEmployee.CurrentRow.Cells[0].Value.ToString());

				string deleteStatement = "delete from Employees where EmployeeID='" + EmployeeIDSelected + "'";
				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);



				try
				{
					connection.Open();
					deleteCommand.ExecuteNonQuery();
					updated = true;

					


				}
				catch (SqlException ex)
				{
					MessageBox.Show("Error with SQL initial loading. " + ex.Message);
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

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			reloadDefaultData();
		}
	}
}
