using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FAHotelApp.DAO
{
	class DataProvider
	{
		private static DataProvider instance;
		//revisi (manage config (mengambil data diapp config)) buat 1 connection string saja
		private string connectionStr = Properties.Settings.Default.FAHotelConnectionString;
		public DataTable ExecuteQuery(string query, object[] parameter = null)
		{
			DataTable data = new DataTable();
			using (SqlConnection connection = new SqlConnection(connectionStr))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				AddParameter(query, parameter, command);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(data);
				connection.Close();
			}
			return data;
		}
		public int ExecuteNoneQuery(string query, object[] parameter = null)
		{
			int data = 0;
			using (SqlConnection connection = new SqlConnection(connectionStr))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				AddParameter(query, parameter, command);
				data = command.ExecuteNonQuery();
				connection.Close();
			}
			return data;
		}
		public object ExecuteScalar(string query, object[] parameter = null)
		{
			object data = new object();
			using (SqlConnection connection = new SqlConnection(connectionStr))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				AddParameter(query, parameter, command);
				data = command.ExecuteScalar();
				connection.Close();
			}
			return data;
		}
		private void AddParameter(string query, object[] parameter, SqlCommand command)
		{
			if (parameter != null)
			{
				string[] listParameter = query.Split(' ');
				int i = 0;
				foreach (string item in listParameter)
				{
					if (item.Contains("@"))
					{
						command.Parameters.AddWithValue(item, parameter[i]);
						++i;
					}
				}
			}
		}
		public static DataProvider Instance
		{
			get { if (instance == null) instance = new DataProvider(); return instance; }
			private set => instance = value;
		}
		private DataProvider() { }
	}
}
