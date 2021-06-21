﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FAHotelApp.DTO
{
	public class AccountType
	{
		private int id;
		private string name;
		public AccountType(DataRow dataRow)
		{
			Id = (int)dataRow["id"];
			Name = dataRow["name"].ToString();
		}

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
	}
}
