using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAHotelApp.Forms
{
	public partial class FormDashboard : Form
	{
		public FormDashboard()
		{
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

		private void btnSideMenu_Click(object sender, EventArgs e)
		{
			bunifuPages1.SetPage(((Control)sender).Text);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
