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
using FAHotelApp.Forms;
using System.Threading;
using FAHotelApp.DAO;

namespace FAHotelApp.Forms
{
	public partial class FormWelcome : Form
	{
		public FormWelcome()
		{
			InitializeComponent();
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			timer1.Start();

			lbDate.Text = DateTime.Now.ToString("dddd,\nMMM dd yyyy");

			lbTime.Text = DateTime.Now.ToLongTimeString();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
		}

		private void btnIDN_Click(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("id-ID");
			FormLogin f = new FormLogin();
			f.Show();
			this.Hide();
		}

		private void btnENG_Click(object sender, EventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-EN");
			FormLogin f = new FormLogin();
			f.Show();
			this.Hide();
		}
	}
}