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

namespace FAHotelApp.Forms
{
	public partial class FormAddCustomer : Form
	{
		public FormAddCustomer()
		{
			InitializeComponent();
			LoadFullCustomerType();
		}
		private void LoadFullCustomerType()
		{
			DataTable table = GetFullCustomerType();
			cbCustomerType.DataSource = table;
			cbCustomerType.DisplayMember = "Name";
			if (table.Rows.Count > 0)
				cbCustomerType.SelectedIndex = 0;
		}
		private DataTable GetFullCustomerType()
		{
			return CustomerTypeDAO.Instance.LoadFullCustomerType();
		}
		private void Clean()
		{
			txtFullName.Text = string.Empty;
			txtAddress.Text = string.Empty;
			txtIDCard.Text = string.Empty;
			cbNationality.Text = string.Empty;
			txtPhoneNumber.Text = string.Empty;
		}
		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Menambahkan Pelanggan Baru?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
				if (CheckDate())
				{
					InsertCustomer();
				}
				else
					MessageBox.Show("Tanggal Lahir Harus Kurang Dari Tanggal Sekarang", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private bool CheckDate()
		{
			if (DateTime.Now.Subtract(dtpDateOfBirth.Value).Days <= 0)
				return false;
			else return true;
		}
		private void InsertCustomer()
		{
			if (!CheckFillInText(new Control[] { txtPhoneNumber, txtFullName, txtIDCard, cbNationality, txtAddress, cbCustomerType }))
			{
				MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				Customer customer = GetCustomerNow();
				if (CustomerDAO.Instance.InsertCustomer(customer))
				{
					MessageBox.Show("Sukses", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Clean();
				}
				else
					MessageBox.Show("Pelanggan Sudah Ada\nNIK Duplikat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			catch
			{
				MessageBox.Show("Kesalahan Menambahkan Pelanggan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static bool CheckFillInText(Control[] controls)
		{
			foreach (var control in controls)
			{
				if (control.Text == string.Empty)
					return false;
			}
			return true;
		}
		private Customer GetCustomerNow()
		{
			UC_Staff.Trim(new Bunifu.Framework.UI.BunifuMetroTextbox[] { txtAddress, txtFullName, txtIDCard });
			Customer customer = new Customer();
			customer.IdCard = txtIDCard.Text;
			int id = cbCustomerType.SelectedIndex;
			customer.IdCustomerType = (int)((DataTable)cbCustomerType.DataSource).Rows[id]["id"];
			customer.Name = txtFullName.Text;
			customer.Sex = cbSex.Text;
			customer.PhoneNumber = txtPhoneNumber.Text;
			customer.DateOfBirth = dtpDateOfBirth.Value;
			customer.Nationality = cbNationality.Text;
			customer.Address = txtAddress.Text;
			return customer;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void TxbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}

	}
}
