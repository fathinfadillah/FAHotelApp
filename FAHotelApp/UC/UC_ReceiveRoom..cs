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
	public partial class UC_ReceiveRoom : UserControl
	{
		List<int> ListIDCustomer = new List<int>();
		int IDBookRoom = -1;
		DateTime dateCheckIn;
		public UC_ReceiveRoom(int idBookRoom)
		{
			IDBookRoom = idBookRoom;
			InitializeComponent();
			LoadData();
			ShowBookRoomInfo(IDBookRoom);
		}
		public UC_ReceiveRoom()
		{
			InitializeComponent();
			LoadData();

		}
		public void LoadData()
		{
			LoadListRoomType();
			LoadReceiveRoomInfo();
		}
		public void LoadListRoomType()
		{
			List<RoomType> rooms = RoomTypeDAO.Instance.LoadListRoomType();
			cbRoomType.DataSource = rooms;
			cbRoomType.DisplayMember = "Name";
		}
		public void LoadEmptyRoom(int idRoomType)
		{
			List<Room> rooms = RoomDAO.Instance.LoadEmptyRoom(idRoomType);
			cbRoom.DataSource = rooms;
			cbRoom.DisplayMember = "Name";
		}
		public bool IsIDBookRoomExists(int idBookRoom)
		{
			return BookRoomDAO.Instance.IsIDBookRoomExists(idBookRoom);
		}
		public void ShowBookRoomInfo(int idBookRoom)
		{
			DataRow dataRow = BookRoomDAO.Instance.ShowBookRoomInfo(idBookRoom);
			txtFullName.Text = dataRow["FullName"].ToString();
			txtIDCard.Text = dataRow["IDCard"].ToString();
			txtRoomTypeName.Text = dataRow["RoomTypeName"].ToString();
			cbRoomType.Text = dataRow["RoomTypeName"].ToString();//*
			txtDateCheckIn.Text = dataRow["DateCheckIn"].ToString().Split(' ')[0];
			dateCheckIn = (DateTime)dataRow["DateCheckIn"];
			txtDateCheckOut.Text = dataRow["DateCheckOut"].ToString().Split(' ')[0];
			txtAmountPeople.Text = dataRow["LimitPerson"].ToString();
			CultureInfo cultureInfo = new CultureInfo("id-ID");
			//txtPrice.Text = dataRow["Price"].ToString().ToString("c", cultureInfo);
			decimal money = decimal.Parse(txtPrice.Text = dataRow["Price"].ToString());
			txtPrice.Text = money.ToString("c");
		}
		public bool InsertReceiveRoom(int idBookRoom, int idRoom)
		{
			return ReceiveRoomDAO.Instance.InsertReceiveRoom(idBookRoom, idRoom);
		}
		public bool InsertReceiveRoomDetails(int idReceiveRoom, int idCustomerOther)
		{
			return ReceiveRoomDetailsDAO.Instance.InsertReceiveRoomDetails(idReceiveRoom, idCustomerOther);
		}
		public void LoadReceiveRoomInfo()
		{
			dataGridViewReceiveRoom.DataSource = ReceiveRoomDAO.Instance.LoadReceiveRoomInfo();
		}
		private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtRoomTypeName.Text = (cbRoomType.SelectedItem as RoomType).Name;
			LoadEmptyRoom((cbRoomType.SelectedItem as RoomType).Id);
		}

		private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtRoomName.Text = cbRoom.Text;
		}

		private void txtIDBookRoom_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
			if (e.KeyChar == 13)
				btnSearch_Click(sender, null);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (txtIDBookRoom.Text != string.Empty)
			{
				if (IsIDBookRoomExists(int.Parse(txtIDBookRoom.Text)))
				{
					btnSearch.Tag = txtIDBookRoom.Text;
					ShowBookRoomInfo(int.Parse(txtIDBookRoom.Text));
				}
				else
					MessageBox.Show("Kode Reservasi Tidak Ada.\nSilahkan Masukkan Kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtIDBookRoom.Text = string.Empty;
			}
		}

		//private void btnAddCustomer_Click(object sender, EventArgs e)
		//{
		//	if (txtRoomName.Text != string.Empty && txtRoomTypeName.Text != string.Empty && txtFullName.Text != string.Empty && txtIDCard.Text != string.Empty && txtDateCheckIn.Text != string.Empty && txtDateCheckOut.Text != string.Empty && txtAmountPeople.Text != string.Empty && txtPrice.Text != string.Empty)
		//	{
		//		FormAddCustomerInfo fAddCustomerInfo = new FormAddCustomerInfo();
		//		fAddCustomerInfo.ShowDialog();
		//		this.Show();
		//	}
		//	else
		//		MessageBox.Show("Harap Masukkan Kembali Semua Informasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//}

		private void btnReceiveRoom_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Apakah Anda Ingin Check-In?", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (txtRoomName.Text != string.Empty && txtRoomTypeName.Text != string.Empty && txtFullName.Text != string.Empty && txtIDCard.Text != string.Empty && txtDateCheckIn.Text != string.Empty && txtDateCheckOut.Text != string.Empty && txtAmountPeople.Text != string.Empty && txtPrice.Text != string.Empty)
				{
					if (dateCheckIn == DateTime.Now.Date)
					{
						int idBookRoom;
						if (IDBookRoom != -1) idBookRoom = IDBookRoom;
						else idBookRoom = int.Parse(btnSearch.Tag.ToString());
						int idRoom = (cbRoom.SelectedItem as Room).Id;
						if (InsertReceiveRoom(idBookRoom, idRoom))
						{
							if (FormAddCustomerInfo.ListIdCustomer != null)
							{
								foreach (int item in FormAddCustomerInfo.ListIdCustomer)
								{
									if (item != int.Parse(txtIDCard.Text))
										InsertReceiveRoomDetails(ReceiveRoomDAO.Instance.GetIDCurrent(), item);
								}
							}
							MessageBox.Show("Check-In Berhasil.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
							LoadEmptyRoom((cbRoomType.SelectedItem as RoomType).Id);
						}
						else
							MessageBox.Show("Gagal Membuat Tiket Check-In.\nSilahkan Masuk Kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
						MessageBox.Show("Tanggal Check-In Tidak Valid.\nSilahkan Masukkan Kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					ClearData();
					LoadReceiveRoomInfo();
				}
				else
					MessageBox.Show("Silahkan Masukkan Kembali Semua Informasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void ClearData()
		{
			txtFullName.Text = txtIDCard.Text = txtRoomTypeName.Text = txtDateCheckIn.Text = txtDateCheckOut.Text = txtAmountPeople.Text = txtPrice.Text = string.Empty;

		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearData();
		}
		private void btnDetails_Click(object sender, EventArgs e)
		{
			FormReceiveRoomDetails f = new FormReceiveRoomDetails((int)dataGridViewReceiveRoom.SelectedRows[0].Cells[0].Value);
			f.ShowDialog();
			Show();
			LoadReceiveRoomInfo();
		}
	}
}
