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
			Account staff = AccountDAO.Instance.LoadStaffInforByUserName(userName);
			this.userName = userName;
			InitializeComponent();
			bunifuFormDock1.SubscribeControlToDragEvents(panelHeader);
			lbUser.Text = staff.DisplayName;
			lbUserType.Text = AccountTypeDAO.Instance.GetStaffTypeByUserName(userName).Name;
			if (staff != null)
			{
				if (!string.IsNullOrEmpty(staff.ImageUrl))
					pictureBox.Image = Image.FromFile(staff.ImageUrl);
			}
			System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
			gp.AddEllipse(0, 0, pictureBox.Width - 3, pictureBox.Height - 3);
			Region rg = new Region(gp);
			pictureBox.Region = rg;
			bunifuPages1.SetPage(FirstView);
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
			if (CheckAccess("BookingKamar"))
			{
				bunifuPages1.SetPage(BookingKamar);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			if (CheckAccess("KelolaKamar"))
			{
				bunifuPages1.SetPage(KelolaKamar);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton5_Click(object sender, EventArgs e)
		{
			if (CheckAccess("KelolaKaryawan"))
			{
				bunifuPages1.SetPage(KelolaKaryawan);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton6_Click(object sender, EventArgs e)
		{
			if (CheckAccess("KelolaPelanggan"))
			{
				bunifuPages1.SetPage(KelolaPelanggan);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton7_Click(object sender, EventArgs e)
		{
			if (CheckAccess("KelolaTagihan"))
			{
				bunifuPages1.SetPage(KelolaTagihan);
			}
			else MessageBox.Show("Anda tidak memiliki izin untuk mengakses.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void bunifuButton8_Click(object sender, EventArgs e)
		{
			if (CheckAccess("KelolaPelayanan"))
			{
				bunifuPages1.SetPage(KelolaPelayanan);
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
