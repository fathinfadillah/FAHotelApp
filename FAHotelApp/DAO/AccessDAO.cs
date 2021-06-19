using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FAHotelApp.DAO
{
	class AccessDAO
	{
		#region Properties
		private static AccessDAO instance = new AccessDAO();
		internal static AccessDAO Instance { get => instance; }
		private AccessDAO() { }
		#endregion

		public DataTable GetFullAccessNow(int idStaffType)
		{
			string query = "USP_LoadFullAccessNow @idStaffType";
			return DataProvider.Instance.ExecuteQuery(query, new object[] { idStaffType });
		}
		public DataTable GetFullAccessRest(int idStaffType)
		{
			string query = "USP_LoadFullAccessRest @idStaffType";
			return DataProvider.Instance.ExecuteQuery(query, new object[] { idStaffType });
		}

		internal void Insert(object idJob, int idStaffType)
		{
			string query = "USP_InsertAccess @idjob , @idStafftype";
			DataProvider.Instance.ExecuteNoneQuery(query, new object[] { idJob, idStaffType });
		}

		internal void Delete(int idJob, int idStaffType)
		{
			if (idJob == 6 && idStaffType == 1) return;
			string query = "USP_DeleteAccess @idjob , @idStafftype";
			DataProvider.Instance.ExecuteNoneQuery(query, new object[] { idJob, idStaffType });
		}

		internal bool CheckAccess(string username, string menuName)
		{
			string query = "USP_ChekcAccess @username , @menuName";
			return !(DataProvider.Instance.ExecuteScalar(query, new object[] { username, menuName }) is null);
		}
	}
}
