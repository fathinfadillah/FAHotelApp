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

namespace FAHotelApp.Forms
{
	public partial class FormBookRoomDetails : Form
	{
		int idBookRoom;
		string idCard;
		public FormBookRoomDetails(int _idBookRoom, string _idCard)
		{
			idBookRoom = _idBookRoom;
			idCard = _idCard;
			InitializeComponent();
			LoadRoomType();
			LoadCustomerType();
			LoadData();
			LoadDays();
			txtIDBookRoom.Text = _idBookRoom.ToString();
		}
		public void LoadRoomType()
		{
			cbRoomType.DataSource = RoomTypeDAO.Instance.LoadListRoomType();
			cbRoomType.DisplayMember = "Name";
		}
		public void LoadData()
		{
			DataRow data = BookRoomDAO.Instance.ShowBookRoomInfo(idBookRoom);
			dtpDateCheckIn.Value = (DateTime)data["DateCheckIn"];
			dtpDateCheckOut.Value = (DateTime)data["DateCheckOut"];

			cbRoomType.Text = RoomTypeDAO.Instance.GetRoomTypeByIdBookRoom(idBookRoom).Name;

			GetInfoByIdCard(idCard);
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
		public void LoadCustomerType()
		{
			cbCustomerType.DataSource = CustomerTypeDAO.Instance.LoadListCustomerType();
			cbCustomerType.DisplayMember = "Name";
		}
		public bool IsIdCardExists(string idCard)
		{
			return CustomerDAO.Instance.IsIdCardExists(idCard);
		}
		public void LoadDays()
		{
			txtDays.Text = (dtpDateCheckOut.Value.Date - dtpDateCheckIn.Value.Date).Days.ToString();
		}
		public void UpdateCustomer()
		{
			int idCustomerType = (cbCustomerType.SelectedItem as CustomerType).Id;
			CustomerDAO.Instance.UpdateCustomer(CustomerDAO.Instance.GetInfoByIdCard(idCard).Id, txtFullName.Text, txtIDCard.Text, idCustomerType, int.Parse(txtPhoneNumber.Text), dtpDateOfBirth.Value, txtAddress.Text, cbSex.Text, cbNationality.Text);
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dtpDateCheckIn_onValueChanged(object sender, EventArgs e)
		{
			if (dtpDateCheckIn.Value <= DateTime.Now)
				LoadData();
			if (dtpDateCheckOut.Value <= dtpDateCheckIn.Value)
				LoadData();
			LoadDays();
		}

		private void dtpDateCheckOut_onValueChanged(object sender, EventArgs e)
		{
			if (dtpDateCheckOut.Value < DateTime.Now)
				LoadData();
			if (dtpDateCheckOut.Value <= dtpDateCheckIn.Value)
				LoadData();
			LoadDays();
		}
		public void ClearData()
		{
			txtIDCard.Text = txtFullName.Text = txtAddress.Text = txtPhoneNumber.Text = cbNationality.Text = String.Empty;
		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (txtFullName.Text != string.Empty && txtIDCard.Text != string.Empty && txtAddress.Text != string.Empty && cbNationality.Text != string.Empty && txtPhoneNumber.Text != string.Empty)
			{
				//Saya cek IDCard Tidak Sama
				if (!IsIdCardExists(txtIDCard.Text) || txtIDCard.Text == idCard)
				{
					UpdateCustomer();

				}
				else
					MessageBox.Show("KTP/ NIK Tidak Cocok.\nSilahkan Masukkan Kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				MessageBox.Show("Silahkan Masukkan Informasi Lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			MessageBox.Show("Berhasil Memperbarui Informasi Pelanggan!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
			LoadData();

		}

		private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			BookRoomDAO.Instance.UpdateBookRoom(idBookRoom, (cbRoomType.SelectedItem as RoomType).Id, dtpDateCheckIn.Value, dtpDateCheckOut.Value);
			MessageBox.Show("Pembaruan Informasi Pemesanan Sukses!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
			LoadData();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Penghapusan Pelanggan Yang Mengarah Ke Formulir Pemesanan Juga Dihapus!\nApakah Anda Ingin Melanjutkan?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				if (BookRoomDAO.Instance.IsIDBookRoomExists(idBookRoom))
				{
					BookRoomDAO.Instance.DeleteBookRoom(idBookRoom);
					MessageBox.Show("Berhasil Menghapus Informasi Pelanggan!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
					MessageBox.Show("Gagal Menghapus Informasi Pelanggan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
