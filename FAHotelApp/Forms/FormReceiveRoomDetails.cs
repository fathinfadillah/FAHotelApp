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
	public partial class FormReceiveRoomDetails : Form
	{
		int idReceiveRoom;
		public FormReceiveRoomDetails(int _idReceiRoom)
		{
			InitializeComponent();
			idReceiveRoom = _idReceiRoom;
			ShowReceiveRoom(_idReceiRoom);
			ShowCustomers(_idReceiRoom);
		}
		public void ShowReceiveRoom(int idReceiveRoom)
		{
			DataRow data = ReceiveRoomDAO.Instance.ShowReceiveRoom(idReceiveRoom).Rows[0];
			txtIDReceiveRoom.Text = ((int)data["Kode Check-In"]).ToString();
			txtRoomName.Text = data["Nama Kamar"].ToString();
			txtDateCheckIn.Text = ((DateTime)data["Tanggal Check-In"]).ToString().Split(' ')[0];
			txtDateCheckOut.Text = ((DateTime)data["Tanggal Check-Out"]).ToString().Split(' ')[0];
		}
		public void ShowCustomers(int idReceiveRoom)
		{
			dataGridView.DataSource = ReceiveRoomDAO.Instance.ShowCusomers(idReceiveRoom);
		}
		
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			FormAddCustomerInfo f = new FormAddCustomerInfo();
			f.ShowDialog();
			Show();
			if (FormAddCustomerInfo.ListIdCustomer.Count > 0)
				foreach (var item in FormAddCustomerInfo.ListIdCustomer)
				{
					ReceiveRoomDetailsDAO.Instance.InsertReceiveRoomDetails(idReceiveRoom, item);
				}
			ShowCustomers(idReceiveRoom);
		}

		private void btnDeleteCustomer_Click(object sender, EventArgs e)
		{
			string idCard = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
			int idCustomer = CustomerDAO.Instance.GetInfoByIdCard(idCard).Id;
			if (idCustomer != CustomerDAO.Instance.GetIDCustomerFromBookRoom(idReceiveRoom))
			{
				ReceiveRoomDetailsDAO.Instance.DeleteReceiveRoomDetails(idReceiveRoom, idCustomer);
				MessageBox.Show("Pelanggan Berhasil Dihapus!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ShowCustomers(idReceiveRoom);
			}
			else
				MessageBox.Show("Tidak Bisa Dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnUpdateCustomer_Click(object sender, EventArgs e)
		{
			string idCard = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
			int idCustomer = CustomerDAO.Instance.GetInfoByIdCard(idCard).Id;
			FormUpdateCustomerInfo f = new FormUpdateCustomerInfo(idCard);
			f.ShowDialog();
			Show();
			ShowCustomers(idReceiveRoom);
		}

		private void btnChangeRoom_Click(object sender, EventArgs e)
		{
			FormChangeRoom f = new FormChangeRoom(RoomDAO.Instance.GetIdRoomFromReceiveRoom(idReceiveRoom), idReceiveRoom);
			f.ShowDialog();
			Show();
			ShowReceiveRoom(idReceiveRoom);
		}
	}
}
