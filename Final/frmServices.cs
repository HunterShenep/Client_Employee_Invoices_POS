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
	public partial class frmServices : Form
	{

		private Timer timer1;
		public static bool updated = false;
		private static int ServiceIDSelected;

		public frmServices()
		{
			InitializeComponent();
		}

		private void frmServices_Load(object sender, EventArgs e)
		{
			reloadDefaultData();
			dropDownSearchTypes.Items.Clear();
			dropDownSearchTypes.Items.Add("ID");
			dropDownSearchTypes.Items.Add("Service Name");
			dropDownSearchTypes.Items.Add("Description");
			InitTimer();
		}

		private void reloadDefaultData()
		{
			clearDataGrid();
			
			string selectStatement = "select * from Services order by ServiceName asc";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{
					string serviceID = reader["ServiceID"].ToString();
					string serviceName = reader["ServiceName"].ToString();
					string serviceDescription = reader["ServiceDescription"].ToString();
					string servicePrice = reader["ServicePrice"].ToString();
					string[] stuff = new string[] { serviceID, serviceName, serviceDescription, servicePrice };

					dataGridServices.Rows.Add(stuff);
				}

			}

			catch (SqlException ex)
			{
				MessageBox.Show("Error with SQL initial loading. " + ex.Message);
			}
			finally
			{
				connection.Close();
				updateResultsNumber();
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
				reloadDefaultData();
				updateResultsNumber();
			}

			updated = false;
		}


		public void searchDataGrid(object sender, EventArgs e)
		{
			clearDataGrid();
			updateResultsNumber();

			if (!this.txtServiceSearch.Text.ToString().Equals(""))
			{

				if (this.dropDownSearchTypes.SelectedItem.ToString().Equals("ID"))
				{
					int temp;

					if (!Int32.TryParse(txtServiceSearch.Text.ToString(), out temp))
					{
						MessageBox.Show("You must enter a number");
					}
					else
					{
						searchById(Int32.Parse(txtServiceSearch.Text.ToString()));
					}
				}
				else if (this.dropDownSearchTypes.SelectedItem.ToString().Equals("Service Name"))
				{
					searchByWordColumn(this.txtServiceSearch.Text.ToString(), "ServiceDescription");
				}
				else if (this.dropDownSearchTypes.SelectedItem.ToString().Equals("Description"))
				{
					searchByWordColumn(this.txtServiceSearch.Text.ToString(), "ServiceDescription");
				}
			}
		}

		public void searchByWordColumn(String word, string column)
		{
			string selectStatement = "select * from Services where " + column + " LIKE '%" + word + "%' order by ServiceName desc";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{
					string serviceID = reader["ServiceID"].ToString();
					string serviceName = reader["ServiceName"].ToString();
					string serviceDescription = reader["ServiceDescription"].ToString();
					string servicePrice = reader["ServicePrice"].ToString();
					string[] stuff = new string[] { serviceID, serviceName, serviceDescription, servicePrice };

					dataGridServices.Rows.Add(stuff);
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
			string selectStatement = "select * from Services where ServiceID='" + id + "' order by ServiceID asc";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{
					string serviceID = reader["ServiceID"].ToString();
					string serviceName = reader["ServiceName"].ToString();
					string serviceDescription = reader["ServiceDescription"].ToString();
					string servicePrice = reader["ServicePrice"].ToString();
					string[] stuff = new string[] { serviceID, serviceName, serviceDescription, servicePrice };

					dataGridServices.Rows.Add(stuff);
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

		public void clearDataGrid()
		{

			this.dataGridServices.Rows.Clear();
			this.dataGridServices.Refresh();
		}

		public void enableSearch(object sender, EventArgs e)
		{
			txtServiceSearch.Text = "";
			txtServiceSearch.Enabled = true;
			Console.WriteLine("Drop down changed");
			updateResultsNumber();
		}

		private void updateResultsNumber()
		{
			lblResults.Text = "Results Found: " + dataGridServices.Rows.Count;
		}

		private void btnServiceAdd_Click(object sender, EventArgs e)
		{
			Form aForm = new frmServicesAdd();
			aForm.Show();
		}

		private void btnServiceEdit_Click(object sender, EventArgs e)
		{
			updateServiceID();
			Form aForm = new frmServicesEdit(ServiceIDSelected);
			aForm.Show();
		}

		public void updateServiceID()
		{
			ServiceIDSelected = Int32.Parse(dataGridServices.CurrentRow.Cells[0].Value.ToString());
		}

		private void btnServiceDelete_Click(object sender, EventArgs e)
		{
			//string deleteStatement = "delete from Customers where CustomerID='";
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this service?", "ATTENTION: PERMANENT CHANGE", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{

				ServiceIDSelected = Int32.Parse(dataGridServices.CurrentRow.Cells[0].Value.ToString());

				string deleteStatement = "delete from Services where ServiceID='" + ServiceIDSelected + "'";
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
