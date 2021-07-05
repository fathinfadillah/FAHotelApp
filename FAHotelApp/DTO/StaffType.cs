using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAHotelApp.DTO
{
	public class StaffType
	{
		private int id;
		private string name;
		public StaffType() { }
		public StaffType(DataRow dataRow)
		{
			Id = (int)dataRow["id"];
			Name = dataRow["name"].ToString();
		}
		public bool Equals(StaffType staffTypePre)
		{
			return this.name == staffTypePre.name;
		}
		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
	}
}
