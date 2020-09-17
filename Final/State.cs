using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
	class State
	{
		public string StateCode;
		public string StateName;
		public static List<State> States = new List<State>();


		public State(string StateCode, string StateName)
		{
			this.StateCode = StateCode;
			this.StateName = StateName;
		}


		public static void pullStatesFromDB()
		{

			string selectStatement = "select * from states";
			SqlConnection connection = new SqlConnection(VendorDB.connectionString);

			SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

			try
			{
				connection.Open();
				SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);

				while (reader.Read())
				{
					States.Add(new State(reader["StateCode"].ToString(), reader["StateName"].ToString()));
				}

			}
			catch(SqlException ex)
			{
				throw ex;
			}
			finally
			{
				connection.Close();
			}

		}

		public static string NameToCode(String name)
		{
			string code = "";

			for(int i = 0; i < States.Count; i++)
			{
				if (States[i].StateName.Equals(name))
				{
					code = States[i].StateCode;
					break;
				}
			}

			return code;
		}

		public static string CodeToName(String code)
		{
			string name = "";

			for (int i = 0; i < States.Count; i++)
			{
				if (States[i].StateCode.Equals(code))
				{
					name = States[i].StateName;
					break;
				}
			}

			return name;
		}


	}
}
