﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAHotelApp.DAO;
using FAHotelApp.DTO;

namespace FAHotelApp.Forms
{
	public partial class FormUseService : Form
	{
		string staffSetUp;
		public FormUseService(string userName)
		{
			staffSetUp = userName;
			InitializeComponent();
			LoadData();
		}

		public FormUseService()
		{
		}

		private void LoadData()
		{
			LoadListServiceType();
			LoadListRoomType();
			LoadListFullRoom();
			ShowSurcharge();
		}
		public void Pay(int idBill, int discount)
		{
			BillDAO.Instance.UpdateRoomPrice(idBill);
			BillDAO.Instance.UpdateServicePrice(idBill);
			BillDAO.Instance.UpdateOther(idBill, discount);

		}
		public void LoadListRoomType()
		{
			List<RoomType> roomTypes = RoomTypeDAO.Instance.LoadListRoomType();
			switch (roomTypes.Count)
			{
				case 0:
					{
						color1.Visible = color2.Visible = color3.Visible = color4.Visible = color5.Visible = false;
						lblRoomType1.Visible = lblRoomType2.Visible = lblRoomType3.Visible = lblRoomType4.Visible = lblRoomType5.Visible = false;
						break;
					}
				case 1:
					{
						lblRoomType1.Text = roomTypes[0].Name;
						color2.Visible = color3.Visible = color4.Visible = color5.Visible = false;
						lblRoomType2.Visible = lblRoomType3.Visible = lblRoomType4.Visible = lblRoomType5.Visible = false;
						break;
					}
				case 2:
					{
						lblRoomType1.Text = roomTypes[0].Name;
						lblRoomType2.Text = roomTypes[1].Name;
						color3.Visible = color4.Visible = color5.Visible = false;
						lblRoomType3.Visible = lblRoomType4.Visible = lblRoomType5.Visible = false;
						break;
					}
				case 3:
					{
						lblRoomType1.Text = roomTypes[0].Name;
						lblRoomType2.Text = roomTypes[1].Name;
						lblRoomType3.Text = roomTypes[2].Name;
						color4.Visible = color5.Visible = false;
						lblRoomType4.Visible = lblRoomType5.Visible = false;
						break;
					}
				case 4:
					{
						lblRoomType1.Text = roomTypes[0].Name;
						lblRoomType2.Text = roomTypes[1].Name;
						lblRoomType3.Text = roomTypes[2].Name;
						lblRoomType4.Text = roomTypes[3].Name;
						color5.Visible = false;
						lblRoomType5.Visible = false;
						break;
					}
			}
		}
		public void LoadListServiceType()
		{
			cbServiceType.DataSource = ServiceTypeDAO.Instance.GetServiceTypes();
			cbServiceType.DisplayMember = "Name";
		}
		public void LoadListService(int idServiceType)
		{
			cbService.DataSource = ServiceDAO.Instance.GetServices(idServiceType);
			cbService.DisplayMember = "Name";
		}
		public void DrawControl(Room room, Bunifu.Framework.UI.BunifuTileButton button)
		{
			int idRoomTypeName = RoomTypeDAO.Instance.GetRoomTypeByIdRoom(room.Id).Id;
			switch (idRoomTypeName)
			{
				case 1:
					{
						button.BackColor = System.Drawing.Color.Tomato;
						button.color = System.Drawing.Color.Tomato;
						button.colorActive = System.Drawing.Color.LightSalmon;
						break;
					}
				case 2:
					{
						button.BackColor = System.Drawing.Color.Violet;
						button.color = System.Drawing.Color.Violet;
						button.colorActive = System.Drawing.Color.Thistle;
						break;
					}
				case 3:
					{
						button.BackColor = System.Drawing.Color.DeepSkyBlue;
						button.color = System.Drawing.Color.DeepSkyBlue;
						button.colorActive = System.Drawing.Color.LightSkyBlue;
						break;
					}
				case 4:
					{
						button.BackColor = System.Drawing.Color.LimeGreen;
						button.color = System.Drawing.Color.LimeGreen;
						button.colorActive = System.Drawing.Color.LightGreen;
						break;
					}
				default:
					{
						button.BackColor = System.Drawing.Color.Gray;
						button.color = System.Drawing.Color.Gray;
						button.colorActive = System.Drawing.Color.Silver;
						break;
					}
			}
		}
		public void LoadListFullRoom()
		{
			flowLayoutRooms.Controls.Clear();
			listViewBillRoom.Items.Clear();
			listViewUseService.Items.Clear();
			List<Room> rooms = RoomDAO.Instance.LoadListFullRoom();
			foreach (Room item in rooms)
			{
				Bunifu.Framework.UI.BunifuTileButton button = new Bunifu.Framework.UI.BunifuTileButton();
				button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				button.ForeColor = System.Drawing.Color.White;
				button.Image = global::FAHotelApp.Properties.Resources.Room;
				button.ImagePosition = 14;
				button.ImageZoom = 36;
				button.LabelPosition = 29;
				button.Size = new System.Drawing.Size(110, 95);
				button.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);

				button.Tag = item;
				button.LabelText = item.Name;
				button.Click += Button_Click;

				DrawControl(item, button);

				flowLayoutRooms.Controls.Add(button);

				//BillDAO.Instance.UpdateRoomPrice(item.Id);
			}
		}

		private void Button_Click(object sender, EventArgs e)
		{
			listViewBillRoom.Items.Clear();
			totalPrice = 0;
			Bunifu.Framework.UI.BunifuTileButton button = sender as Bunifu.Framework.UI.BunifuTileButton;
			flowLayoutRooms.Tag = button.Tag;
			button.BackColor = System.Drawing.Color.SeaGreen;
			button.color = System.Drawing.Color.SeaGreen;
			button.colorActive = System.Drawing.Color.MediumSeaGreen;
			foreach (var item in flowLayoutRooms.Controls)
			{
				if (item != button)
					DrawControl((item as Bunifu.Framework.UI.BunifuTileButton).Tag as Room, item as Bunifu.Framework.UI.BunifuTileButton);
			}
			Room room = button.Tag as Room;
			ShowBill(room.Id);
			if (!BillDAO.Instance.IsExistsBill(room.Id))
			{
				int idReceiveRoom = ReceiveRoomDAO.Instance.GetIdReceiveRoomFromIdRoom(room.Id);
				InsertBill(idReceiveRoom, staffSetUp);
			}
			BillDAO.Instance.UpdateRoomPrice(BillDAO.Instance.GetIdBillFromIdRoom(room.Id));
			ShowBillRoom(room.Id);

			txbTotalPrice.Text = totalPrice.ToString("c", new CultureInfo("id-ID"));
		}

		public bool IsExistsBill(int idRoom)
		{
			return BillDAO.Instance.IsExistsBill(idRoom);
		}
		public bool IsExistsBillDetails(int idRoom, int idService)
		{
			return BillDetailsDAO.Instance.IsExistsBillDetails(idRoom, idService);
		}
		public bool InsertBill(int idReceiveRoom, string staffSetUp)
		{
			return BillDAO.Instance.InsertBill(idReceiveRoom, staffSetUp);
		}
		public bool InsertBillDetails(int idBill, int idService, int count)
		{
			return BillDetailsDAO.Instance.InsertBillDetails(idBill, idService, count);
		}
		public bool UpdateBillDetails(int idBill, int idService, int _count)
		{
			return BillDetailsDAO.Instance.UpdateBillDetails(idBill, idService, _count);
		}
		public void AddBill(int idRoom, int idService, int count)
		{
			if (IsExistsBill(idRoom))
			{
				//Sudah Ada Bill
				if (!IsExistsBillDetails(idRoom, idService))
				{
					//Belum Ada BillDetails
					if (count > 0)
					{
						int idBill = BillDAO.Instance.GetIdBillFromIdRoom(idRoom);
						InsertBillDetails(idBill, idService, count);
					}
					else
						MetroFramework.MetroMessageBox.Show(this, "Nomor Tidak Valid.\nSilahkan Masukkan Kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					//Sudah Ada BillDetails
					int idBill = BillDAO.Instance.GetIdBillFromIdRoom(idRoom);
					UpdateBillDetails(idBill, idService, count);
				}
			}
			else
			{
				//Belum Ada Bill
				if (count > 0)
				{
					int idReceiveRoom = ReceiveRoomDAO.Instance.GetIdReceiveRoomFromIdRoom(idRoom);
					InsertBill(idReceiveRoom, staffSetUp);
					int idBill = BillDAO.Instance.GetIdBillMax();
					InsertBillDetails(idBill, idService, count);
				}
				else
					MetroFramework.MetroMessageBox.Show(this, "Jumlah Tidak Valid.\nSilahkan Masukkan Kembali.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		int id = 1;
		int totalPrice = 0;
		public void ShowSurcharge()
		{
			string query = "select * from Parameter";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				ListViewItem listViewItem = new ListViewItem(id.ToString());
				id++;

				ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(listViewItem, item["Name"].ToString());
				ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(listViewItem, ((double)item["Value"]).ToString());
				ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(listViewItem, (item["Describe"]).ToString());

				listViewItem.SubItems.Add(subItem1);
				listViewItem.SubItems.Add(subItem2);
				listViewItem.SubItems.Add(subItem3);

				listViewSurcharge.Items.Add(listViewItem);
			}
			id = 0;
		}
		public void ShowBill(int idRoom)
		{
			listViewUseService.Items.Clear();
			DataTable dataTable = BillDAO.Instance.ShowBill(idRoom);
			CultureInfo cultureInfo = new CultureInfo("id-ID");
			int _totalPrice = 0;
			foreach (DataRow item in dataTable.Rows)
			{
				ListViewItem listViewItem = new ListViewItem(id.ToString());
				id++;

				ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(listViewItem, item["Nama Layanan"].ToString());
				ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["Harga"]).ToString("c", cultureInfo));
				ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["Jumlah"]).ToString());
				ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["Total Harga"]).ToString("c", cultureInfo));


				_totalPrice += (int)item["Total Harga"];

				listViewItem.SubItems.Add(subItem1);
				listViewItem.SubItems.Add(subItem2);
				listViewItem.SubItems.Add(subItem3);
				listViewItem.SubItems.Add(subItem4);

				listViewUseService.Items.Add(listViewItem);
			}
			totalPrice += _totalPrice;

			ListViewItem listViewItemTotalPrice = new ListViewItem();
			ListViewItem.ListViewSubItem subItemTotalPrice = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, _totalPrice.ToString("c", cultureInfo));
			ListViewItem.ListViewSubItem _subItem1 = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, "");
			ListViewItem.ListViewSubItem _subItem2 = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, "");
			ListViewItem.ListViewSubItem _subItem3 = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, "");
			listViewItemTotalPrice.SubItems.Add(_subItem1);
			listViewItemTotalPrice.SubItems.Add(_subItem2);
			listViewItemTotalPrice.SubItems.Add(_subItem3);
			listViewItemTotalPrice.SubItems.Add(subItemTotalPrice);
			listViewUseService.Items.Add(listViewItemTotalPrice);

			id = 1;
		}
		public void ShowBillRoom(int idRoom)
		{
			CultureInfo cultureInfo = new CultureInfo("id-ID");
			listViewBillRoom.Items.Clear();
			if (IsExistsBill(idRoom))
			{
				DataRow data = BillDAO.Instance.ShowBillRoom(idRoom);

				ListViewItem listViewItem = new ListViewItem(data["Nama Kamar"].ToString());

				ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(listViewItem, ((int)data["Harga"]).ToString("c", cultureInfo));
				ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(listViewItem, ((DateTime)data["Tanggal CheckIn"]).ToString().Split(' ')[0]);
				ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(listViewItem, ((DateTime)data["Tanggal CheckOut"]).ToString().Split(' ')[0]);
				ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem(listViewItem, ((int)data["Biaya Kamar"]).ToString("c", cultureInfo));
				ListViewItem.ListViewSubItem subItem5 = new ListViewItem.ListViewSubItem(listViewItem, ((int)data["Biaya Tambahan"]).ToString("c", cultureInfo));
				int roomPrice = (int)data["Biaya Kamar"] + (int)data["Biaya Tambahan"];
				ListViewItem.ListViewSubItem subItem6 = new ListViewItem.ListViewSubItem(listViewItem, roomPrice.ToString("c", cultureInfo));

				totalPrice += roomPrice;

				listViewItem.SubItems.Add(subItem1);
				listViewItem.SubItems.Add(subItem2);
				listViewItem.SubItems.Add(subItem3);
				listViewItem.SubItems.Add(subItem4);
				listViewItem.SubItems.Add(subItem5);
				listViewItem.SubItems.Add(subItem6);

				listViewBillRoom.Items.Add(listViewItem);
			}
		}

		private void cbServiceType_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadListService((cbServiceType.SelectedItem as ServiceType).Id);
		}
		private void cbService_SelectedIndexChanged(object sender, EventArgs e)
		{
			CultureInfo cultureInfo = new CultureInfo("id-ID");
			if (cbService.SelectedItem != null)
				txbPrice.Text = (cbService.SelectedItem as Service).Price.ToString("c", cultureInfo);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			totalPrice = 0;
			Room room = flowLayoutRooms.Tag as Room;
			AddBill(room.Id, (cbService.SelectedItem as Service).Id, int.Parse(numericUpDownCount.Value.ToString()));
			ShowBill(room.Id);
			numericUpDownCount.Value = 1;

			ShowBillRoom(room.Id);
			txbTotalPrice.Text = totalPrice.ToString("c", new CultureInfo("id-ID"));
		}

		private void txbIDRoom_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			Room room = flowLayoutRooms.Tag as Room;
			if (MessageBox.Show("Apakah anda yakin untuk membayar " + room.Name + " tidak?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				int idBill = BillDAO.Instance.GetIdBillFromIdRoom(room.Id);
				Pay(idBill, int.Parse(numericUpDown1.Value.ToString()));
				ReportDAO.Instance.InsertReport(idBill);
				MessageBox.Show("Pembayaran Berhasil!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Hide();
				FormPrintBill FormPrintBill = new FormPrintBill(room.Id, idBill);
				FormPrintBill.ShowDialog();
				this.Show();
				LoadListFullRoom();
				listViewBillRoom.Items.Clear();
				listViewUseService.Items.Clear();
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
