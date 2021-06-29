using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FAHotelApp.DAO
{
	public class ReportDAO
	{
		#region Constructor & properties
		private static ReportDAO instance;
		public static ReportDAO Instance { get { if (instance == null) instance = new ReportDAO(); return instance; } }
		private ReportDAO()
		{

		}
		#endregion

		#region Method
		public DataTable LoadFullReport(int month, int year)
		{
			string query = "USP_LoadFullReport @month , @year";
			return DataProvider.Instance.ExecuteQuery(query, new object[] { month, year });
		}

		public bool InsertReport(int idBill)
		{
			return DataProvider.Instance.ExecuteNoneQuery("USP_InsertReport @idBill", new object[] { idBill }) > 0;
		}
		#endregion
	}
}
