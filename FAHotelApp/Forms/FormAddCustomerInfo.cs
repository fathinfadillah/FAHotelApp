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
	public partial class FormAddCustomerInfo : Form
	{
		private static List<int> listIdCustomer;

		public static List<int> ListIdCustomer { get => listIdCustomer; set => listIdCustomer = value; }

		public FormAddCustomerInfo()
		{
			InitializeComponent();
			LoadCustomerType();
			ListIdCustomer = new List<int>();
		}
		public void LoadCustomerType()
		{
			cbCustomerType.DataSource = CustomerTypeDAO.Instance.LoadListCustomerType();
			cbCustomerType.DisplayMember = "Name";
		}
		public bool IsIdCardExists(string idCard)
		{
			return CustomerDAO.Instance.IsIdCardExists(idCard);
		}
		public void InsertCustomer(string idCard, string name, int idCustomerType, DateTime dateofBirth, string address, int phonenumber, string sex, string nationality)
		{
			CustomerDAO.Instance.InsertCustomer(idCard, name, idCustomerType, dateofBirth, address, phonenumber, sex, nationality);
		}
		public void GetInfoByIdCard(string idCard)
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
		public void ClearData()
		{
			txtIDCardSearch.Text = txtIDCard.Text = txtFullName.Text = txtAddress.Text = txtPhoneNumber.Text = cbNationality.Text = String.Empty;
		}
		public void AddIdCustomer(int idCustomer)
		{
			if (ListIdCustomer.Count != 0)
			{
				bool check = false;
				foreach (int item in ListIdCustomer)
				{
					if (item == idCustomer)
					{
						check = true;
						break;
					}
				}
				if (!check) ListIdCustomer.Add(idCustomer);
			}
			else
				ListIdCustomer.Add(idCustomer);
		}
		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			if (txtFullName.Text != string.Empty && txtIDCard.Text != string.Empty && txtAddress.Text != string.Empty && cbNationality.Text != string.Empty && txtPhoneNumber.Text != string.Empty)
			{
				if (!IsIdCardExists(txtIDCard.Text))
				{
					int idCustomerType = (cbCustomerType.SelectedItem as CustomerType).Id;
					InsertCustomer(txtIDCard.Text, txtFullName.Text, idCustomerType, dtpDateOfBirth.Value, txtAddress.Text, int.Parse(txtPhoneNumber.Text), cbSex.Text, cbNationality.Text);
				}
				MessageBox.Show("Berhasil Menambahkan Pelanggan.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
				AddIdCustomer(CustomerDAO.Instance.GetInfoByIdCard(txtIDCard.Text).Id);
				ClearData();
			}
			else
				MessageBox.Show("Silahkan Masukkan Informasi Yang Lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (txtIDCardSearch.Text != String.Empty)
			{
				if (IsIdCardExists(txtIDCardSearch.Text))
					GetInfoByIdCard(txtIDCardSearch.Text);
				else
					MessageBox.Show("KTP/NIK Tidak Ada.\nSilahkan Masukkan Kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtIDCardSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearData();
		}
	}
}
