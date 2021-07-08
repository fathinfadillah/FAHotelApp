using System;
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
using FAHotelApp.UC;

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
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
			if (CheckAccess("CheckInKamar"))
			{
				bunifuPages1.SetPage(CheckInKamar);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton3_Click(object sender, EventArgs e)
		{
			if (CheckAccess("LayanandanPembayaran"))
			{
				//bunifuPages1.SetPage(LayanandanPembayaran);
				//this.Hide();
				FormUseService f = new FormUseService(userName);
				f.ShowDialog();
				this.Show();
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton1_Click(object sender, EventArgs e)
		{
			if (CheckAccess("ManajerKamar"))
			{
				bunifuPages1.SetPage(ManajerKamar);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton5_Click(object sender, EventArgs e)
		{
			if (CheckAccess("ManajerKaryawan"))
			{
				bunifuPages1.SetPage(ManajerKaryawan);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton6_Click(object sender, EventArgs e)
		{
			if (CheckAccess("ManajerPelanggan"))
			{
				bunifuPages1.SetPage(ManajerPelanggan);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton7_Click(object sender, EventArgs e)
		{
			if (CheckAccess("ManajerTagihan"))
			{
				bunifuPages1.SetPage(ManajerTagihan);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton8_Click(object sender, EventArgs e)
		{
			if (CheckAccess("ManajerPelayanan"))
			{
				bunifuPages1.SetPage(ManajerPelayanan);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton9_Click(object sender, EventArgs e)
		{
			if (CheckAccess("PeraturanHotel"))
			{
				bunifuPages1.SetPage(PeraturanHotel);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void bunifuButton10_Click(object sender, EventArgs e)
		{
			FormSetting f = new FormSetting(userName);
			f.ShowDialog();
			this.Show();
		}

		private void bunifuButton11_Click(object sender, EventArgs e)
		{
			FormLogin2 f = new FormLogin2();
			f.Show();
			this.Hide();
		}
	}
}
