﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAHotelApp.UC
{
	public partial class UC_Dashboard : UserControl
	{
		public UC_Dashboard()
		{
			if (Program.IsInDesignMode()) return;
			InitializeComponent();
		}
	}
}
