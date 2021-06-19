﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAHotelApp.DAO;
using FAHotelApp.DTO;

namespace FAHotelApp.Forms
{
	public partial class FormMenu : Form
	{
		private string userName;
		public FormMenu(string userName)
		{
			this.userName = userName;
			InitializeComponent();
			bunifuFormDock1.SubscribeControlToDragEvents(panelHeader);
			lbUser.Text = Properties.Settings.Default.UsernameView;
			lbUserType.Text = Properties.Settings.Default.UserTypeView;
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			foreach (var btn in panelMenu.Controls)
			{
				var bunifubtn = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)btn;
				bunifubtn.Visible = bunifubtn.Text.ToLower().Contains(txtSearch.Text.ToLower().Trim());
			}
		}

		private bool CheckAccess(string nameMenu)
		{
			return AccessDAO.Instance.CheckAccess(userName, nameMenu);
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			if (CheckAccess("Dashboard"))
			{
				bunifuPages1.SetPage(Dashboard);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void btnBooking_Click(object sender, EventArgs e)
		{
			bunifuPages1.SetPage(BookingKamar);
		}

		private void bunifuButton2_Click(object sender, EventArgs e)
		{
			if (CheckAccess("TerimaKamar"))
			{
				bunifuPages1.SetPage(TerimaKamar);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
