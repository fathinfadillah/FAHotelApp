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
	public partial class FormRooms : Form
	{
		public FormRooms()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormRooms_Load(object sender, EventArgs e)
		{
			comboBoxStatus.SelectedIndex = 1;
			this.roomTableAdapter.Fill(this.fAHotelDataSet.Room, (int)(comboBoxStatus.SelectedIndex));
			this.reportViewer1.RefreshReport();
		}

		private void btnViewReport_Click(object sender, EventArgs e)
		{
			if (comboBoxStatus.SelectedIndex == 0)
			{
				MessageBox.Show("Pilih status terlebih dahulu!");
				return;
			}
			else
			{
				this.roomTableAdapter.Fill(this.fAHotelDataSet.Room, (int)(comboBoxStatus.SelectedIndex));
				this.reportViewer1.RefreshReport();
			}
		}
	}
}
