using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FAHotelApp.DAO;
using FAHotelApp.DTO;
using System.Globalization;
using FAHotelApp.UC;
using Microsoft.Reporting.WinForms;

namespace FAHotelApp.Forms
{
	public partial class FormIncome : Form
	{
		public FormIncome()
		{
			InitializeComponent();
		}

		private void FormIncome_Load(object sender, EventArgs e)
		{
			comboBoxMonth.Text = DateTime.Now.Month.ToString();
			numericYear.Value = DateTime.Now.Year;
			this.dt_incomeTableAdapter.Fill(this.fAHotelDataSet.dt_Income, int.Parse(comboBoxMonth.Text),
				(int)(numericYear.Value));
			this.reportViewer1.RefreshReport();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnViewReport_Click(object sender, EventArgs e)
		{
			this.dt_incomeTableAdapter.Fill(this.fAHotelDataSet.dt_Income, int.Parse(comboBoxMonth.Text),
				(int)(numericYear.Value));
			this.reportViewer1.RefreshReport();
		}
	}
}
