using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAHotelApp.DTO
{
	public class ViewCustomer
	{
		private int customerAmount;
		public ViewCustomer() { }
		public ViewCustomer(DataRow dataRow)
		{
			CustomerAmount = (int)dataRow["id"];
		}
		public bool Equals(ViewCustomer viewCustomerPre)
		{
			return this.customerAmount == viewCustomerPre.customerAmount;
		}
		public int CustomerAmount { get => customerAmount; set => customerAmount = value; }
	}
}
