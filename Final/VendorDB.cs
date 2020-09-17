using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
	class VendorDB
	{
		public static List<Vendor> Vendors = new List<Vendor>();

		public static string connectionString = "Data Source=DESKTOP-AFHVFR2\\SQLEXPRESS;Initial Catalog=finalproj;Integrated Security=True";
		
		public static void PullVendorsFromDB()
		{


			//Create the connection based on the private static connection string
			SqlConnection connection = new SqlConnection(connectionString);
			
			//query
			string selectStatement = "SELECT * from Vendors";

			//
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader vendorReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
				Console.WriteLine("We made it here");

				while (vendorReader.Read())
				{
					Console.WriteLine("PullVendorsFromDB: Added 1 to Static List<>");

					//Converting and setting these temp variables so that passing many variables into a Vendor constructor is more readable.
					int id = Int32.Parse(vendorReader["VendorID"].ToString());
					string name = vendorReader["VendorName"].ToString();
					string description = vendorReader["VendorDescription"].ToString();
					string phone = vendorReader["VendorPhone"].ToString();
					string website = vendorReader["VendorWebsite"].ToString();
					string notes = vendorReader["VendorNotes"].ToString();
					DateTime since = DateTime.Parse(vendorReader["VendorSince"].ToString());
					int enabled = Int32.Parse(vendorReader["VendorEnabled"].ToString());

					//Creating new object and adding it to the Vendor List<>.
					Vendor aVendor = new Vendor(id, name, description, phone, website, notes, since, enabled);
					Vendors.Add(aVendor);
				}

				vendorReader.Close();

				//Debug purposes
				for(int i = 0; i < Vendors.Count(); i++)
				{
					Console.WriteLine(Vendors[i].Name);
				}

			}
			catch(SqlException ex)
			{
				MessageBox.Show("Yo", ex.Message);

				throw ex;
			}
			finally{
				connection.Close();
			}

			

		}

		public static void PullVendorByID(int id)
		{
			//Create the connection based on the private static connection string
			SqlConnection connection = new SqlConnection(connectionString);

			//query
			string selectStatement = "SELECT * from Vendors where VendorID='" + id + "'";
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{

				connection.Open();
				SqlDataReader vendorReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
				Console.WriteLine("We made it here");
				Vendors.Clear();

				while (vendorReader.Read())
				{
					Console.WriteLine("PullVendorsFromDB: Added 1 to Static List<>");

					//Converting and setting these temp variables so that passing many variables into a Vendor constructor is more readable.
					int idd = Int32.Parse(vendorReader["VendorID"].ToString());
					string name = vendorReader["VendorName"].ToString();
					string description = vendorReader["VendorDescription"].ToString();
					string phone = vendorReader["VendorPhone"].ToString();
					string website = vendorReader["VendorWebsite"].ToString();
					string notes = vendorReader["VendorNotes"].ToString();
					DateTime since = DateTime.Parse(vendorReader["VendorSince"].ToString());
					int enabled = Int32.Parse(vendorReader["VendorEnabled"].ToString());

					//Creating new object and adding it to the Vendor List<>.
					

					Vendor aVendor = new Vendor(idd, name, description, phone, website, notes, since, enabled);
					Vendors.Add(aVendor);
				}

				vendorReader.Close();

				//Debug purposes
				for (int i = 0; i < Vendors.Count(); i++)
				{
					Console.WriteLine(Vendors[i].Name);
				}

			}
			catch (SqlException ex)
			{
				MessageBox.Show("Yo", ex.Message);

				throw ex;
			}
			finally
			{
				connection.Close();
			}

		}

		public static void PullVendorByName(String namee)
		{
			//Create the connection based on the private static connection string
			SqlConnection connection = new SqlConnection(connectionString);

			//query
			string selectStatement = "SELECT * from Vendors where VendorName LIKE '%" + namee + "%'";
			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{

				connection.Open();
				SqlDataReader vendorReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
				Console.WriteLine("We made it here");
				Vendors.Clear();

				while (vendorReader.Read())
				{
					Console.WriteLine("PullVendorsFromDB: Added 1 to Static List<>");

					//Converting and setting these temp variables so that passing many variables into a Vendor constructor is more readable.
					int idd = Int32.Parse(vendorReader["VendorID"].ToString());
					string name = vendorReader["VendorName"].ToString();
					string description = vendorReader["VendorDescription"].ToString();
					string phone = vendorReader["VendorPhone"].ToString();
					string website = vendorReader["VendorWebsite"].ToString();
					string notes = vendorReader["VendorNotes"].ToString();
					DateTime since = DateTime.Parse(vendorReader["VendorSince"].ToString());
					int enabled = Int32.Parse(vendorReader["VendorEnabled"].ToString());

					//Creating new object and adding it to the Vendor List<>.


					Vendor aVendor = new Vendor(idd, name, description, phone, website, notes, since, enabled);
					Vendors.Add(aVendor);
				}

				vendorReader.Close();

				//Debug purposes
				for (int i = 0; i < Vendors.Count(); i++)
				{
					Console.WriteLine(Vendors[i].Name);
				}

			}
			catch (SqlException ex)
			{
				MessageBox.Show("Yo", ex.Message);

				throw ex;
			}
			finally
			{
				connection.Close();
			}

		}


		public static bool AddVendor(string name, string description, string phone, string website, string notes)
		{
			//Create the connection based on the private static connection string
			SqlConnection connection = new SqlConnection(connectionString);
			//Console.WriteLine("Name: " + name + " | Descr: " + description + " | phone: " + phone + " | website: " + website + " | Notes: " + notes);
			
			
			DateTime today = DateTime.Today;
			string formatDate = string.Format("{0:yyyy-MM-dd}", today);


			
			//query
			string insertStatement = "insert into Vendors (VendorName, VendorDescription, VendorPhone, VendorWebsite, VendorNotes, VendorSince, VendorEnabled ) values ('" + name + "', '" + description + "', '" + phone + "', '" + website + "', '" + notes + "', '" + formatDate + "', '1')";
			SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

			try
			{

				connection.Open();
				insertCommand.ExecuteNonQuery();
				connection.Close();
				return true;

			}
			catch(SqlException ex)
			{
				MessageBox.Show(ex.Message);
				throw ex;

			}
			finally
			{
				connection.Close();
				
			}

		}



	}


}
