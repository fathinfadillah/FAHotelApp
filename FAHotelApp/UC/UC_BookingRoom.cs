using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAHotelApp.DAO;
using FAHotelApp.DTO;
using System.Globalization;
using FAHotelApp.Forms;

namespace FAHotelApp.UC
{
	public partial class UC_BookingRoom : UserControl
	{
		public UC_BookingRoom()
		{
			InitializeComponent();
			LoadData();
		}
		public void LoadData()
		{
			LoadRoomType();
			LoadCustomerType();
			LoadDate();
			LoadDays();
			LoadListBookRoom();
		}
		public void LoadRoomType()
		{
			cbRoomType.DataSource = RoomTypeDAO.Instance.LoadListRoomType();
			cbRoomType.DisplayMember = "Name";
		}
		public void LoadRoomTypeInfo(int id)
		{
			RoomType roomType = RoomTypeDAO.Instance.LoadRoomTypeInfo(id);
			txtRoomTypeID.Text = roomType.Id.ToString();
			txtRoomTypeName.Text = roomType.Name;
			CultureInfo cultureInfo = new CultureInfo("id-ID");
			txtPrice.Text = roomType.Price.ToString("c", cultureInfo);
			txtAmountPeople.Text = roomType.LimitPerson.ToString();
		}
		public void LoadDate()
		{
			dtpDateOfBirth.Value = new DateTime(1998, 4, 6);
			dtpDateCheckIn.Value = DateTime.Now;
			dtpDateCheckOut.Value = DateTime.Now.AddDays(1);
		}
		public void LoadDays()
		{
			txtDays.Text = (dtpDateCheckOut.Value.Date - dtpDateCheckIn.Value.Date).Days.ToString();
		}
		public void LoadCustomerType()
		{
			cbCustomerType.DataSource = CustomerTypeDAO.Instance.LoadListCustomerType();
			cbCustomerType.DisplayMember = "Name";
		}
		public void LoadListBookRoom()
		{
			dataGridViewBookRoom.DataSource = BookRoomDAO.Instance.LoadListBookRoom(DateTime.Now.Date);
		}
		public bool IsIdCardExists(string idCard)
		{
			return CustomerDAO.Instance.IsIdCardExists(idCard);
		}
		public void InsertCustomer(string idCard, string name, int idCustomerType, DateTime dateofBirth, string address, string phonenumber, string sex, string nationality)
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
		public void InsertBookRoom(int idCustomer, int idRoomType, DateTime datecheckin, DateTime datecheckout, DateTime datebookroom)
		{
			BookRoomDAO.Instance.InsertBookRoom(idCustomer, idRoomType, datecheckin, datecheckout, datebookroom);
		}
		public int GetCurrentIDBookRoom(DateTime dateTime)
		{
			return BookRoomDAO.Instance.GetCurrentIDBookRoom(dateTime);
		}
	
		private void txtDays_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadRoomTypeInfo((cbRoomType.SelectedItem as RoomType).Id);
		}

		private void dpkDateCheckOut_onValueChanged(object sender, EventArgs e)
		{
			if (dtpDateCheckOut.Value < DateTime.Now)
				LoadDate();
			if (dtpDateCheckOut.Value <= dtpDateCheckIn.Value)
				LoadDate();
			LoadDays();
		}

		private void dpkDateCheckIn_onValueChanged(object sender, EventArgs e)
		{
			if (dtpDateCheckIn.Value <= DateTime.Now)
				LoadDate();
			if (dtpDateCheckOut.Value <= dtpDateCheckIn.Value)
				LoadDate();
			LoadDays();
		}

		private void txtIDCardSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
			if (e.KeyChar == 13)
				btnSearch_Click(sender, null);
		}

		private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (txtIDCardSearch.Text != String.Empty)
			{
				if (IsIdCardExists(txtIDCardSearch.Text))
					GetInfoByIdCard(txtIDCardSearch.Text);
				else
					MessageBox.Show("KTP Tidak Ada.\nMasukkan Kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void ClearData()
		{
			txtIDCardSearch.Text = txtIDCard.Text = txtFullName.Text = txtAddress.Text = txtPhoneNumber.Text = cbNationality.Text = String.Empty;
			LoadDate();
		}
		private void btnBookRoom_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Apakah Anda Ingin Membuat Reservasi?", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (txtIDCard.Text != String.Empty && txtFullName.Text != String.Empty && txtAddress.Text != String.Empty && txtPhoneNumber.Text != String.Empty && cbNationality.Text != String.Empty)
				{
					if (!IsIdCardExists(txtIDCard.Text))
					{
						int idCustomerType = (cbCustomerType.SelectedItem as CustomerType).Id;
						InsertCustomer(txtIDCard.Text, txtFullName.Text, idCustomerType, dtpDateOfBirth.Value, txtAddress.Text, txtPhoneNumber.Text, cbSex.Text, cbNationality.Text);
					}
					InsertBookRoom(CustomerDAO.Instance.GetInfoByIdCard(txtIDCard.Text).Id, (cbRoomType.SelectedItem as RoomType).Id, dtpDateCheckIn.Value, dtpDateCheckOut.Value, DateTime.Now);
					MessageBox.Show("Pemesanan Berhasil!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClearData();
					LoadListBookRoom();
				}
				else
					MessageBox.Show("Silahkan Masukkan Informasi Yang Lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearData();
		}

		private void btnDetails_Click(object sender, EventArgs e)
		{
			int idBookRoom = (int)dataGridViewBookRoom.SelectedRows[0].Cells[0].Value;
			string idCard = dataGridViewBookRoom.SelectedRows[0].Cells[2].Value.ToString();
			FormBookRoomDetails f = new FormBookRoomDetails(idBookRoom, idCard);
			f.ShowDialog();
			Show();
			LoadListBookRoom();
		}

		private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}
	}
}
