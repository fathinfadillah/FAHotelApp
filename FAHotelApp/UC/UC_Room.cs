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
	public partial class UC_Room : UserControl
	{
		#region Properties
		private FormRoomType _FormRoomtType;
		#endregion

		#region Constructor
		public UC_Room()
		{
			InitializeComponent();
			LoadFullRoomType();
			LoadFullStatusRoom();
			LoadFullRoom(GetFullRoom());
			dataGridViewRoom.SelectionChanged += DataGridViewRoom_SelectionChanged;
			cbID.DisplayMember = "id";
			dataGridViewRoom.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
		}

		#endregion

		#region Kick
		private void BtnAddRoom_Click(object sender, EventArgs e)
		{
			new FormAddRoom().ShowDialog();
			if (btnCancel.Visible == false)
				LoadFullRoom(GetFullRoom());
			else BtnCancel_Click(null, null);
		}
		private void BtnRoomType_Click(object sender, EventArgs e)
		{
			_FormRoomtType.ShowDialog();
			LoadFullRoom(GetFullRoom());
			cbRoomType.DataSource = _FormRoomtType.TableRoomType;
			txtPrice.DataBindings.Clear();
			txtLimitPerson.DataBindings.Clear();
			txtPrice.DataBindings.Add(new Binding("Text", cbRoomType.DataSource, "price_new"));
			txtLimitPerson.DataBindings.Add(new Binding("Text", cbRoomType.DataSource, "limitPerson"));
			this.Show();
		}
		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			txtNameRoom.Text = string.Empty;
		}
		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Memperbarui Kamar Lagi?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
				UpdateRoom();
			cbID.Focus();
		}
		private void ToolStripLabel1_Click(object sender, EventArgs e)
		{
			bool check;
			if (saveRoom.ShowDialog() == DialogResult.Cancel)
				return;
			switch (saveRoom.FilterIndex)
			{
				case 2:
					check = ExportToExcel.Instance.Export(dataGridViewRoom, saveRoom.FileName, ModeExportToExcel.XLSX);
					break;
				case 3:
					check = ExportToExcel.Instance.Export(dataGridViewRoom, saveRoom.FileName, ModeExportToExcel.PDF);
					break;
				default:
					check = ExportToExcel.Instance.Export(dataGridViewRoom, saveRoom.FileName, ModeExportToExcel.XLS);
					break;
			}
			if (check)
				MessageBox.Show("Ekspor Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("Error (Harus Menginstall Office)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion

		#region Load
		private void LoadFullRoom(DataTable table)
		{
			BindingSource source = new BindingSource();
			ChangePrice(table);
			source.DataSource = table;
			dataGridViewRoom.DataSource = source;
			bindingRoom.BindingSource = source;
			cbID.DataSource = source;
		}
		private void LoadFullStatusRoom()
		{
			DataTable table = GetFullStatusRoom();
			cbStatusRoom.DataSource = table;
			cbStatusRoom.DisplayMember = "Name";
			if (table.Rows.Count > 0)
				cbStatusRoom.SelectedIndex = 0;
		}
		private void LoadFullRoomType()
		{
			DataTable table = GetFullRoomType();
			cbRoomType.DataSource = table;
			cbRoomType.DisplayMember = "Name";
			if (table.Rows.Count > 0)
				cbRoomType.SelectedIndex = 0;
			_FormRoomtType = new FormRoomType(table);
			txtLimitPerson.DataBindings.Add(new Binding("Text", cbRoomType.DataSource, "limitPerson"));
		}
		#endregion

		#region Method

		private void UpdateRoom()
		{
			if (cbID.Text == string.Empty)
			{
				MessageBox.Show("Kamar Belum Ada\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else
			if (!UC_Customer.CheckFillInText(new Control[] { txtNameRoom, cbStatusRoom, cbRoomType }))
			{
				MessageBox.Show("Tidak Boleh Dikosongkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				Room roomPre = groupRoom.Tag as Room;
				try
				{
					Room roomNow = GetRoomNow();
					if (roomNow.Equals(roomPre))
					{
						MessageBox.Show("Data Anda Belum Diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						bool check = RoomDAO.Instance.UpdateCustomer(roomNow);
						if (check)
						{
							MessageBox.Show("Update Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
							groupRoom.Tag = roomNow;
							if (btnCancel.Visible == false)
							{
								int index = dataGridViewRoom.SelectedRows[0].Index;
								LoadFullRoom(GetFullRoom());
								cbID.SelectedIndex = index;
							}
							else BtnCancel_Click(null, null);
						}
						else
							MessageBox.Show("Kamar Belum Ada\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					}
				}
				catch
				{
					MessageBox.Show("Terjadi Kesalahan Saat Memperbarui Ruangan Ini", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void ChangeText(DataGridViewRow row)
		{
			if (row.IsNewRow)
			{
				txtNameRoom.Text = string.Empty;
				bindingNavigatorMoveFirstItem.Enabled = false;
				bindingNavigatorMovePreviousItem.Enabled = false;
			}
			else
			{
				bindingNavigatorMoveFirstItem.Enabled = true;
				bindingNavigatorMovePreviousItem.Enabled = true;
				txtNameRoom.Text = row.Cells["colName"].Value.ToString();
				cbRoomType.SelectedIndex = (int)row.Cells["colIdRoomType"].Value - 1;
				cbStatusRoom.SelectedIndex = (int)row.Cells["colIdStatus"].Value - 1;
				Room room = new Room(((DataRowView)row.DataBoundItem).Row);
				groupRoom.Tag = room;
			}
		}
		private void Search()
		{
			LoadFullRoom(GetSearchRoom());
		}
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			txtSearch.Text = txtSearch.Text.Trim();
			if (txtSearch.Text != string.Empty)
			{
				txtNameRoom.Text = string.Empty;
				btnSearch.Visible = false;
				btnCancel.Visible = true;
				Search();
			}
		}
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			LoadFullRoom(GetFullRoom());
			btnCancel.Visible = false;
			btnSearch.Visible = true;
		}
		#endregion

		#region Get Data
		private DataTable GetFullRoom()
		{
			return RoomDAO.Instance.LoadFullRoom();
		}
		private DataTable GetFullRoomType()
		{
			return RoomTypeDAO.Instance.LoadFullRoomType();
		}
		private DataTable GetFullStatusRoom()
		{
			return StatusRoomDAO.Instance.LoadFullStatusRoom();
		}
		private Room GetRoomNow()
		{
			Room room = new Room();
			if (cbID.Text == string.Empty)
				room.Id = 0;
			else
				room.Id = int.Parse(cbID.Text);
			UC_Staff.Trim(new Bunifu.Framework.UI.BunifuMetroTextbox[] { txtNameRoom });
			room.Name = txtNameRoom.Text;
			int index = cbRoomType.SelectedIndex;
			room.IdRoomType = (int)((DataTable)cbRoomType.DataSource).Rows[index]["id"];
			index = cbStatusRoom.SelectedIndex;
			room.IdStatusRoom = (int)((DataTable)cbStatusRoom.DataSource).Rows[index]["id"];
			return room;
		}
		private DataTable GetSearchRoom()
		{
			if (int.TryParse(txtSearch.Text, out int id))
				return RoomDAO.Instance.Search(txtSearch.Text, id);
			else
				return RoomDAO.Instance.Search(txtSearch.Text, 0);
		}

		#endregion

		#region Change
		private void DataGridViewRoom_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewRoom.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridViewRoom.SelectedRows[0];
				ChangeText(row);
			}
		}
		private void ChangePrice(DataTable table)
		{
			table.Columns.Add("price_New", typeof(string));
			for (int i = 0; i < table.Rows.Count; i++)
			{
				table.Rows[i]["price_New"] = ((int)table.Rows[i]["price"]).ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
			}
			table.Columns.Remove("price");
		}
		private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = cbRoomType.SelectedIndex;

			if (((DataTable)cbRoomType.DataSource).Rows[index]["Price"].ToString().Contains("."))
				return;
			txtPrice.Text = ((int)((DataTable)cbRoomType.DataSource).Rows[index]["Price"]).ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
		}
		#endregion

		#region Enter & leave
		private void txtNameRoom_Enter(object sender, EventArgs e)
		{
			txtNameRoom.Tag = txtNameRoom.Text;
		}
		private void txtNameRoom_Leave(object sender, EventArgs e)
		{
			if (txtNameRoom.Text == string.Empty)
				txtNameRoom.Text = txtNameRoom.Tag as string;
		}
		#endregion

		#region Key
		private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				BtnSearch_Click(sender, null);
			else
				if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		private void FRoom_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		#endregion

		#region Close
		private void FRoom_FormClosing(object sender, FormClosingEventArgs e)
		{
			BtnCancel_Click(sender, null);
		}
		#endregion
	}
}
