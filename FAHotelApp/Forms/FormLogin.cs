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

namespace FAHotelApp
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			timer1.Start();

			lbDate.Text = DateTime.Now.ToString("dddd,\nMMM dd yyyy");

			lbTime.Text = DateTime.Now.ToLongTimeString();

			if (Properties.Settings.Default.Username != string.Empty)
			{
				txtUsername.Text = Properties.Settings.Default.Username;
				cbUserType.Text = Properties.Settings.Default.UserType;
				txtPassword.Text = Properties.Settings.Default.Password;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (tsRememberMe.Checked == true)
			{
				Properties.Settings.Default.Username = txtUsername.Text;
				Properties.Settings.Default.UserType = cbUserType.Text;
				Properties.Settings.Default.Password = txtPassword.Text;
				Properties.Settings.Default.Save();
			}
			if (tsRememberMe.Checked == false)
			{
				Properties.Settings.Default.Username = "";
				Properties.Settings.Default.UserType = "";
				Properties.Settings.Default.Password= "";
				Properties.Settings.Default.Save();
			}

			SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-LHKUU3D; Initial Catalog = FAHotel; Integrated Security = True");
			SqlCommand cmd = new SqlCommand("select * from Tabel_User where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", con);
			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			string cmbItemValue = cbUserType.SelectedItem.ToString();
			if (dt.Rows.Count > 0)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					if (dt.Rows[i]["usertype"].ToString() == cmbItemValue) //you can use 2 instead of usertype in that index because usertype column is in 2 index
					{
						MessageBox.Show("you are login as " + dt.Rows[i][5]);
						if (cbUserType.SelectedIndex == 0)
						{
							Form1 f = new Form1();
							f.Show();
							this.Hide();
						}
						else
						{
							Form2 ff = new Form2();
							ff.Show();
							this.Hide();
						}
					}
				}
			}
			else
			{
				MessageBox.Show("error");
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
	}
}