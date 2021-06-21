using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FAHotelApp.DTO
{
	public class ServiceType
	{
		private int id;
		private string name;
		public ServiceType() { }
		public ServiceType(DataRow dataRow)
		{
			Id = (int)dataRow["id"];
			Name = dataRow["name"].ToString();
		}
		public bool Equals(ServiceType serviceTypePre)
		{
			return this.name == serviceTypePre.name;
		}
		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
	}
}
