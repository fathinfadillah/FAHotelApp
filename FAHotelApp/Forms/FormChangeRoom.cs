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

namespace FAHotelApp.Forms
{
	public partial class FormChangeRoom : Form
	{
		int idRoom, idReceiveRoom;
		public FormChangeRoom(int _idRoom, int _idReceiveRoom)
		{
			InitializeComponent();
			idRoom = _idRoom;
			idReceiveRoom = _idReceiveRoom;
			LoadListRoomType();
			LoadRoomTypeInfo(_idRoom);
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
		public void LoadRoomTypeInfo(int idRoom)
		{
			CultureInfo cultureInfo = new CultureInfo("id-ID");
			RoomType roomType = RoomTypeDAO.Instance.GetRoomTypeByIdRoom(idRoom);
			txtLimitPerson.Text = roomType.LimitPerson.ToString();
			txtPrice.Text = roomType.Price.ToString("Rp.", cultureInfo);
			txtRoomTypeName.Text = roomType.Name;
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtRoomTypeName.Text = (cbRoomType.SelectedItem as RoomType).Name;
			LoadEmptyRoom((cbRoomType.SelectedItem as RoomType).Id);
			LoadRoomTypeInfo((cbRoom.SelectedItem as Room).Id);
		}

		private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
		{
			txbRoomName.Text = (cbRoom.SelectedItem as Room).Name;
		}

		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			//Harus memperbarui status kamar lama
			RoomDAO.Instance.UpdateStatusRoom(idRoom);
			ReceiveRoomDAO.Instance.UpdateReceiveRoom(idReceiveRoom, (cbRoom.SelectedItem as Room).Id);
			MessageBox.Show("Berhasil Mengubah Kamar!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
