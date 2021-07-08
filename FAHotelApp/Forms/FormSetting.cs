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
using FAHotelApp.DAO;
using FAHotelApp.DTO;
using System.Globalization;
using FAHotelApp.UC;

namespace FAHotelApp.Forms
{
	public partial class FormSetting : Form
	{
		public FormSetting(string userName)
		{
			InitializeComponent();
			LoadProfile(userName);
		}
		string Password;
		public void LoadProfile(string username)
		{
			Account staff = AccountDAO.Instance.LoadStaffInforByUserName(username);
			lblUserName.Text = txbUserName.Text = staff.UserName;
			lblDisplayName.Text = txbDisplayName.Text = staff.DisplayName;
			txbStaffType.Text = AccountTypeDAO.Instance.GetStaffTypeByUserName(username).Name;
			txbIDCard.Text = staff.IdCard.ToString();
			txbPhoneNumber.Text = staff.PhoneNumber.ToString();
			txbAddress.Text = staff.Address;
			dpkDateOfBirth.Value = staff.DateOfBirth;
			cbSex.Text = staff.Sex;
			txbStartDay.Text = staff.StartDay.ToShortDateString();
			Password = staff.PassWord;
		}
		public void UpdateDisplayName(string username, string displayname)
		{
			AccountDAO.Instance.UpdateDisplayName(username, displayname);
		}
		public void UpdatePassword(string username, string password)
		{
			AccountDAO.Instance.UpdatePassword(username, password);
		}
		public void UpdateInfo(string username, string address, string phonenumber, string idCard, DateTime dateOfBirth, string sex)
		{
			AccountDAO.Instance.UpdateInfo(username, address, phonenumber, idCard, dateOfBirth, sex);
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBookRoom_Click(object sender, EventArgs e)
		{
			if (txbDisplayName.Text != String.Empty)
			{
				UpdateDisplayName(txbUserName.Text, txbDisplayName.Text);
				MessageBox.Show("Pembaruan informasi akun berhasil.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadProfile(txbUserName.Text);
			}
			else
				MessageBox.Show("Nama tampilan tidak valis.\nSilahkan masukkan kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnSecurity_Click(object sender, EventArgs e)
		{
			if (AccountDAO.Instance.HashPass(txbPass.Text) == Password && txbNewPass.Text != String.Empty && txbReNewPass.Text != String.Empty)
			{
				if (txbNewPass.Text == txbReNewPass.Text)
				{
					UpdatePassword(txbUserName.Text, txbNewPass.Text);
					MessageBox.Show("Berhail melakukan pembaruan.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txbPass.Text = txbNewPass.Text = txbReNewPass.Text = String.Empty;
					LoadProfile(txbUserName.Text);
				}
				else
				{
					MessageBox.Show("Kata sandi baru tidak valid.\nSilahkan masukkan kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txbNewPass.Text = txbReNewPass.Text = String.Empty;
				}
			}
			else
			{
				MessageBox.Show("Kata sandi tidak cocok.\nSilahkan masukkan kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txbPass.Text = txbNewPass.Text = txbReNewPass.Text = String.Empty;
			}
		}

		private void btnInformation_Click(object sender, EventArgs e)
		{
			if (txbAddress.Text != String.Empty && txbPhoneNumber.Text != String.Empty && cbSex.Text != string.Empty && dpkDateOfBirth.Value < DateTime.Now.Date)
			{
				if (AccountDAO.Instance.IsIdCardExists(txbIDCard.Text))
				{
					UpdateInfo(txbUserName.Text, txbAddress.Text, txbPhoneNumber.Text, txbIDCard.Text, dpkDateOfBirth.Value, cbSex.Text);
					MessageBox.Show("Pemberitahuan informasi dasar berhasil.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadProfile(txbUserName.Text);
				}
				else
					MessageBox.Show("KTP/ NIK tidak ada.\nSilahkan masukkan kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				MessageBox.Show("Informasi dasar tidak valid.\nSilahkan masukkan kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			FormLogin2 f = new FormLogin2();
			f.Show();
			this.Hide();
		}
	}
}
