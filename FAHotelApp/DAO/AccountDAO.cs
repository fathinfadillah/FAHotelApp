using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FAHotelApp.DTO;
using System.Security.Cryptography;
using System.Data;

namespace FAHotelApp.DAO
{
	class AccountDAO
	{
		private static AccountDAO instance;
		internal string HashPass(string text)
		{
			MD5 md5 = MD5.Create();
			byte[] temp = Encoding.ASCII.GetBytes(text);
			byte[] hashData = md5.ComputeHash(temp);
			string hashPass = "";
			foreach (var item in hashData)
			{
				hashPass += item.ToString("x2");
			}
			return hashPass;
		}
		internal bool Login(string userName, string passWord, int deparTment)
		{
			string hashPass = HashPass(passWord);
			string query = "USP_Login @userName , @passWord , @deparTment";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hashPass, deparTment });
			return data.Rows.Count > 0;
		}
		public List<StaffType> LoadListStaffType()
		{
			string query = "select * from StaffType";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			List<StaffType> listStaffType = new List<StaffType>
			{
				new StaffType { Id = 0, Name = "Departement" }
			};
			foreach (DataRow item in data.Rows)
			{
				StaffType staffType = new StaffType(item);
				listStaffType.Add(staffType);
			}
			return listStaffType;
		}
		//internal ViewCustomer LoadViewStaff()
		//{
		//	string query = "select * from ViewCustomer";
		//	DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
		//	ViewCustomer viewstaff = new ViewCustomer(dataTable.Rows[0]);
		//	return viewstaff;
		//}
		public List<ViewCustomer> LoadViewCustomer()
		{
			List<ViewCustomer> listViewCustomer = new List<ViewCustomer>();
			string query = "select * from ViewCustomer";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				ViewCustomer viewCustomer = new ViewCustomer(item);
				listViewCustomer.Add(viewCustomer);
			}
			return listViewCustomer;
		}
		internal Account LoadStaffInforByUserName(string username)
		{
			//string query = "USP_GetNameStaffTypeByUserName @username";
			//DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
			string query = "select * from Staff where UserName='" + username + "'";
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
			Account account = new Account(dataTable.Rows[0]);
			return account;
		}
		internal bool IsIdCardExists(string idCard)
		{
			string query = "USP_IsIdCardExistsAcc @idCard";
			return DataProvider.Instance.ExecuteQuery(query, new object[] { idCard }).Rows.Count > 0;
		}
		internal bool UpdateDisplayName(string username, string displayname)
		{
			string query = "USP_UpdateDisplayName @username , @displayname";
			return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { username, displayname }) > 0;
		}
		internal bool UpdatePassword(string username, string password)
		{
			string query = "USP_UpdatePassword @username , @password";
			return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { username, HashPass(password) }) > 0;
		}
		internal bool UpdatePhotoProfile(string username, string imageurl)
		{
			string query = "USP_UpdatePhotoProfile @username , @imageurl";
			return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { username, imageurl }) > 0;
		}
		internal bool UpdateInfo(string username, string address, string phonenumber, string idCard, DateTime dateOfBirth, string sex)
		{
			string query = "USP_UpdateInfo @username , @address , @phonenumber , @idcard , @dateOfBirth , @sex";
			return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { username, address, phonenumber, idCard, dateOfBirth, sex }) > 0;
		}
		internal Account GetStaffSetUp(int idBill)
		{
			string query = "USP_GetStaffSetUp @idBill";
			Account account = new Account(DataProvider.Instance.ExecuteQuery(query, new object[] { idBill }).Rows[0]);
			return account;
		}
		internal DataTable LoadFullStaff()
		{
			string query = "USP_LoadFullStaff";
			return DataProvider.Instance.ExecuteQuery(query);
		}
		internal bool InsertAccount(Account account)
		{
			string query = "EXEC USP_InsertStaff @user , @name , @pass , @idStaffType , @idCard , @dateOfBirth , @sex , @address , @phoneNumber , @startDay";
			object[] parameter = new object[] {account.UserName, account.DisplayName, account.PassWord, account.IdStaffType,
												account.IdCard, account.DateOfBirth, account.Sex,
												account.Address, account.PhoneNumber, account.StartDay};
			return DataProvider.Instance.ExecuteNoneQuery(query, parameter) > 0;
		}
		internal bool UpdateAccount(Account account)
		{
			string query = "EXEC USP_UpdateStaff @user , @name , @idStaffType , @idCard , @dateOfBirth , @sex , @address , @phoneNumber , @startDay";
			object[] parameter = new object[] {account.UserName, account.DisplayName, account.IdStaffType,
											   account.IdCard, account.DateOfBirth, account.Sex,
												account.Address, account.PhoneNumber, account.StartDay};
			return DataProvider.Instance.ExecuteNoneQuery(query, parameter) > 0;
		}
		internal bool ResetPassword(string user, string hashPass)
		{
			string query = "USP_UpdatePassword @user , @hashPass";
			return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { user, hashPass }) > 0;
		}
		internal DataTable Search(string @string, int phoneNumber)
		{
			string query = "USP_SearchStaff @string , @int";
			return DataProvider.Instance.ExecuteQuery(query, new object[] { @string, phoneNumber });
		}
		internal static AccountDAO Instance
		{
			get { if (instance == null) instance = new AccountDAO(); return instance; }
			private set => instance = value;
		}
		private AccountDAO() { }
	}
}
