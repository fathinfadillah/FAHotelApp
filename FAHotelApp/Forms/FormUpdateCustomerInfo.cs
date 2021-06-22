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

namespace FAHotelApp.Forms
{
	public partial class FormUpdateCustomerInfo : Form
	{
		string idCard;
		public FormUpdateCustomerInfo(string _idCard)
		{
			InitializeComponent();
			idCard = _idCard;
			LoadCustomerType();
			LoadCustomerInfo(_idCard);
		}
		public void LoadCustomerType()
		{
			cbCustomerType.DataSource = CustomerTypeDAO.Instance.LoadListCustomerType();
			cbCustomerType.DisplayMember = "Name";
		}
		public void LoadCustomerInfo(string idCard)
		{
			Customer customer = CustomerDAO.Instance.GetInfoByIdCard(idCard);
			txtIDCard.Text = customer.IdCard.ToString();
			txtFullName.Text = customer.Name;
			txtAddress.Text = customer.Address;
			dtpDateOfBirth.Value = customer.DateOfBirth;
			cbSex.Text = customer.Sex;
			txtPhoneNumber.Text = customer.PhoneNumber.ToString();
			cbNationality.Text = customer.Nationality;
			cbCustomerType.Text = CustomerTypeDAO.Instance.GetNameByIdCard(idCard);
		}
		public void UpdateCustomer()
		{
			int idCustomerType = (cbCustomerType.SelectedItem as CustomerType).Id;
			CustomerDAO.Instance.UpdateCustomer(CustomerDAO.Instance.GetInfoByIdCard(idCard).Id, txtFullName.Text, txtIDCard.Text, idCustomerType, int.Parse(txtPhoneNumber.Text), dtpDateOfBirth.Value, txtAddress.Text, cbSex.Text, cbNationality.Text);
		}
		public void ClearData()
		{
			txtIDCard.Text = txtFullName.Text = txtAddress.Text = txtPhoneNumber.Text = cbNationality.Text = String.Empty;
		}
		public bool IsIdCardExists(string idCard)
		{
			return CustomerDAO.Instance.IsIdCardExists(idCard);
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnClose__Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearData();
		}

		private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void btnUpdateCustomer_Click(object sender, EventArgs e)
		{
			if (txtFullName.Text != string.Empty && txtIDCard.Text != string.Empty && txtAddress.Text != string.Empty && cbNationality.Text != string.Empty && txtPhoneNumber.Text != string.Empty)
			{
				//Kiểm tra IDCard có trùng không
				if (!IsIdCardExists(txtIDCard.Text) || txtIDCard.Text == idCard)
				{
					UpdateCustomer();
					MessageBox.Show("Pembaruan Informasi Pelanggan Berhasil.", "Pemberitahuan.", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearData();
					LoadCustomerInfo(idCard);
				}
				else
					MessageBox.Show("KTP/NIK Tidak Cocok.\nSilahkan Masukkan Kembali.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				MessageBox.Show("Silahkan Masukkan Informasi Lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
