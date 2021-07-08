﻿using System;
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
using System.Globalization;

namespace FAHotelApp.Forms
{
	public partial class FormLogin2 : Form
	{
		public FormLogin2()
		{
			InitializeComponent();
		}

		public bool Login()
		{
			return AccountDAO.Instance.Login(txtUsername.Text, txtPassword.Text, cbDepartement.SelectedIndex);
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			cbDepartement.DataSource = AccountDAO.Instance.LoadListStaffType();
			cbDepartement.DisplayMember = "Name";

			timer1.Start();

			CultureInfo culture = new CultureInfo("id-ID");
			lbDate.Text = DateTime.Now.ToString("dddd,\ndd MMMM yyyy", culture);

			lbTime.Text = DateTime.Now.ToLongTimeString();

			if (Properties.Settings.Default.Username != string.Empty)
			{
				txtUsername.Text = Properties.Settings.Default.Username;
				txtPassword.Text = Properties.Settings.Default.Password;
				cbDepartement.Text = Properties.Settings.Default.UserType;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.UsernameView = txtUsername.Text;
			Properties.Settings.Default.UserTypeView = cbDepartement.Text;

			if (txtUsername.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Mohon masukkan username dan password anda terlebih dahulu !");
			}
			else
			{
				if (Login())
				{
					this.Hide();
					FormMenu f = new FormMenu(txtUsername.Text);
					f.ShowDialog();
				}
				else
				{
					MessageBox.Show("Username tidak ada atau Password salah.\nSilahkan masuk kembali !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			if (tsRememberMe.Checked == true)
			{
				Properties.Settings.Default.Username = txtUsername.Text;
				Properties.Settings.Default.Password = txtPassword.Text;
				Properties.Settings.Default.UserType = cbDepartement.Text;
				Properties.Settings.Default.Save();
			}
			if (tsRememberMe.Checked == false)
			{
				Properties.Settings.Default.Username = "";
				Properties.Settings.Default.UserType = "";
				Properties.Settings.Default.Password = "";
				Properties.Settings.Default.Save();
			}
		}

		private void lbContactAdmin_Click(object sender, EventArgs e)
		{
			FormContactAdmin f = new FormContactAdmin();
			f.Show();
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void tsShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (tsShowPassword.Checked == true)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			if (tsShowPassword.Checked == false)
			{
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void txtUsername_Leave(object sender, EventArgs e)
		{
			if (txtUsername.Text == "")
			{
				epWarning.SetError(txtUsername, "TextBox Username tidak boleh kosong !");
				epWrong.SetError(txtUsername, "");
				epCorrect.SetError(txtUsername, "");
			}
			else
			{
				epWarning.SetError(txtUsername, "");
				epWrong.SetError(txtUsername, "");
				epCorrect.SetError(txtUsername, "Terisi !");
			}

		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (txtPassword.Text == "")
			{
				epWarning.SetError(txtPassword, "TextBox Password tidak boleh kosong !");
				epWrong.SetError(txtPassword, "");
				epCorrect.SetError(txtPassword, "");
			}
			else
			{
				epWarning.SetError(txtPassword, "");
				epWrong.SetError(txtPassword, "");
				epCorrect.SetError(txtPassword, "Terisi !");
			}

		}

		private void lbForgotPassword_Click(object sender, EventArgs e)
		{
			FormForgotPassword f = new FormForgotPassword();
			f.Show();
			this.Hide();
		}

		private void lbTermCon_Click(object sender, EventArgs e)
		{
			FormTC f = new FormTC();
			f.Show();
		}

		private void cbDepartement_Leave(object sender, EventArgs e)
		{
			if (cbDepartement.SelectedIndex == 0)
			{
				epWarning.SetError(cbDepartement, "Pilih Departement terlebih dahulu");
				epWrong.SetError(cbDepartement, "");
				epCorrect.SetError(cbDepartement, "");
			}
			else
			{
				epWarning.SetError(cbDepartement, "");
				epWrong.SetError(cbDepartement, "");
				epCorrect.SetError(cbDepartement, "Terisi!");
			}
		}
	}
}