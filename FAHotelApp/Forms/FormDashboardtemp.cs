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
	public partial class FormDashboardtemp : Form
	{
		public FormDashboardtemp()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lbUser.Text = Properties.Settings.Default.UsernameView;
			lbUserType.Text = Properties.Settings.Default.UserTypeView;
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			FormLogin2 f = new FormLogin2();
			f.Show();
			this.Hide();
		}
	}
}
