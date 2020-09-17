using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
	class Vendor
	{
		private int id;
		private string name;
		private string description;
		private string phone;
		private string notes;
		private string website;
		private DateTime sinceDate;
		private bool enabled;


		public Vendor()
		{
			this.Enabled = false;
		}


		public Vendor(int ID, string vendorName, string vendorDescription, string vendorPhone, string vendorWebsite, string vendorNotes, DateTime vendorSince, int vendorEnabled)
		{
			this.ID = ID;
			this.Name = vendorName;
			this.Description = vendorDescription;
			this.Phone = vendorPhone;
			this.Website = vendorWebsite;
			this.Notes = vendorNotes;
			this.SinceDate = vendorSince;

			if (vendorEnabled == 1)
			{
				this.Enabled = true;
			}
			else
			{
				this.Enabled = false;
			}
		}



		public int ID
		{

			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}

		public string Name
		{

			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		public string Description
		{

			get
			{
				return description;
			}
			set
			{
				description = value;
			}
		}

		public string Phone
		{

			get
			{
				return phone;
			}
			set
			{
				phone = value;
			}
		}

		public string Website
		{

			get
			{
				return website;
			}
			set
			{
				website = value;
			}
		}

		public string Notes
		{

			get
			{
				return notes;
			}
			set
			{
				notes = value;
			}
		}

		public DateTime SinceDate
		{

			get
			{
				return sinceDate;
			}
			set
			{
				sinceDate = value;
			}
		}

		public bool Enabled
		{

			get
			{
				return enabled;
			}
			set
			{
				enabled = value;
			}
		}

	}

}
