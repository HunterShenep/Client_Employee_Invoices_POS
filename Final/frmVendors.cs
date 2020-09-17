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
	public partial class frmVendors : Form
	{
		public static int VendorIDSelected;
		public static bool updated;
		private Timer timer1;

		public frmVendors()
		{

			InitializeComponent();
			clearDataGrid();
			VendorDB.PullVendorsFromDB();
			InitTimer();

			populateDateGrid();
			comboVendorSearchTypes.Items.Clear();
			comboVendorSearchTypes.Items.Add("ID");
			comboVendorSearchTypes.Items.Add("Name");

		}

		public void TestRefresh(frmVendors theForm)
		{
			this.clearDataGrid();
			VendorDB.PullVendorsFromDB();

			populateDateGrid();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			announceSelectedIndex(this.dataGridVendors);
			//populateDateGrid(this.dataGridVendors);
			clearDataGrid();
		}


		public void populateDateGrid()
		{

			lblResults.Text = "Results Found: " + VendorDB.Vendors.Count();

			for (int i = 0; i < VendorDB.Vendors.Count(); i++)
			{

				string[] stuff = new string[] { VendorDB.Vendors[i].ID.ToString(), VendorDB.Vendors[i].Name, VendorDB.Vendors[i].Phone, VendorDB.Vendors[i].Website };

				dataGridVendors.Rows.Add(stuff);


			}


		}

		public void announceSelectedIndex(DataGridView dataGrid)
		{
			Console.WriteLine(dataGrid.CurrentCell.RowIndex);
			Console.WriteLine("Value of Row - Cell" + dataGrid.CurrentRow.Cells[1].Value);

		}

		public void clearDataGrid()
		{
			VendorDB.Vendors.Clear();
			this.dataGridVendors.Rows.Clear();
			this.dataGridVendors.Refresh();
		}

		public void searchDataGrid(object sender, EventArgs e)
		{
			clearDataGrid();
			updateResultsNumber();
			if (!this.txtVendorSearch.Text.ToString().Equals(""))
			{

				if (this.comboVendorSearchTypes.SelectedItem.ToString().Equals("ID"))
				{
					int temp;

					if (!Int32.TryParse(txtVendorSearch.Text.ToString(), out temp))
					{
						MessageBox.Show("You must enter a number");
					}
					else
					{
						VendorDB.PullVendorByID(Int32.Parse(txtVendorSearch.Text));
						populateDateGrid();
					}
				}
				else
				{
					clearDataGrid();

					VendorDB.PullVendorByName(txtVendorSearch.Text.ToString());
					populateDateGrid();
				}


			}
		}

		public void enableSearch(object sender, EventArgs e)
		{
			txtVendorSearch.Text = "";
			txtVendorSearch.Enabled = true;
			Console.WriteLine("Drop down changed");
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			Form aForm = new frmVendorAdd();
			aForm.Show();
		}

		private void btnVendorLoadAll_Click(object sender, EventArgs e)
		{
			reloadDefaultData();
		}

		private void btnVendorEdit_Click(object sender, EventArgs e)
		{
			VendorIDSelected = Int32.Parse(dataGridVendors.CurrentRow.Cells[0].Value.ToString());
			Form aForm = new frmVendorEdit();
			aForm.Show();
		}

		private void btnVendorDelete_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "ATTENTION: PERMANENT CHANGE", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Console.WriteLine("Yes");

				VendorIDSelected = Int32.Parse(dataGridVendors.CurrentRow.Cells[0].Value.ToString());
				string deleteStatement = "delete from Vendors where VendorID='" + VendorIDSelected + "'";
				SqlConnection connection = new SqlConnection(VendorDB.connectionString);
				SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);

				try
				{
					connection.Open();
					deleteCommand.ExecuteNonQuery();
					MessageBox.Show("Record deleted. ");
					clearDataGrid();
					VendorDB.PullVendorsFromDB();
					populateDateGrid();
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

		public void reloadDefaultData()
		{
			clearDataGrid();
			VendorDB.PullVendorsFromDB();
			populateDateGrid();
		}

		public void updateResultsNumber(){
			lblResults.Text = "Results Found: " + dataGridVendors.Rows.Count;
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
	}
}
