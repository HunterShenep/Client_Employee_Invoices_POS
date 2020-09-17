using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			State.pullStatesFromDB();
			Console.WriteLine("State size: " + State.States.Count);
		}

		private void btnStartEmployees_Click(object sender, EventArgs e)
		{
			Form aForm = new frmEmployees();
			aForm.Show();
		}

		private void btnStartClients_Click(object sender, EventArgs e)
		{
			Form customers = new frmCustomer();
			customers.Show();
		}

		private void btnStartInvoices_Click(object sender, EventArgs e)
		{
			Form aForm = new frmInvoices();
			aForm.Show();
		}

		private void btnStartVendors_Click(object sender, EventArgs e)
		{
			
			Form vendors = new frmVendors();
	
			vendors.Show();
		}

		private void btnServices_Click(object sender, EventArgs e)
		{
			Form aForm = new frmServices();
			aForm.Show();
		}
	}
}
