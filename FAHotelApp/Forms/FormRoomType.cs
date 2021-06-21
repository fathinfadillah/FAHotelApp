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
	public partial class FormRoomType : Form
	{
		#region Property
		private DataTable _tableRoomType;
		public DataTable TableRoomType
		{
			get => _tableRoomType;
			private set
			{
				_tableRoomType = value;
				BindingSource source = new BindingSource();
				ChangePrice(_tableRoomType);
				source.DataSource = _tableRoomType;
				dataGridViewRoomType.DataSource = source;
				bindingRoomType.BindingSource = source;
				cbID.DataSource = source;
			}
		}

		#endregion

		#region Constructor
		public FormRoomType()
		{
			InitializeComponent();
		}
		public FormRoomType(DataTable table)
		{
			InitializeComponent();
			TableRoomType = table;
			cbID.DisplayMember = "id";
			dataGridViewRoomType.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
		}
		#endregion

		#region Load
		private void LoadFullRoomType(DataTable table)
		{
			this.TableRoomType = table;
		}
		#endregion

		#region Click
		private void BunifuImageButton1_Click(object sender, EventArgs e)
		{
			Close();
		}
		//private void BtnAddRoomType_Click(object sender, EventArgs e)
		//{
		//    DialogResult result = MessageBox.Show( "Bạn có muốn thêm loại phòng mới?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
		//    if(result == DialogResult.OK)
		//        InsertRoomType();
		//}
		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			cbID.Text = "Automatis";
			txtName.Text = string.Empty;
			txtPrice.Text = "0";
		}
		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Memperbarui Kamar Ini?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
				UpdateRoomType();
			cbID.Focus();
		}
		private void BtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void ToolStripLabel1_Click(object sender, EventArgs e)
		{
			if (saveRoomType.ShowDialog() == DialogResult.Cancel)
				return;
			else
			{
				bool check;
				try
				{
					switch (saveRoomType.FilterIndex)
					{
						case 2:
							check = ExportToExcel.Instance.Export(dataGridViewRoomType, saveRoomType.FileName, ModeExportToExcel.XLSX);
							break;
						case 3:
							check = ExportToExcel.Instance.Export(dataGridViewRoomType, saveRoomType.FileName, ModeExportToExcel.PDF);
							break;
						default:
							check = ExportToExcel.Instance.Export(dataGridViewRoomType, saveRoomType.FileName, ModeExportToExcel.XLS);
							break;
					}
					if (check)
						MessageBox.Show("Export Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show("Export Gagal", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch
				{
					MessageBox.Show("Error (Perlu Menginstall Office)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			txtSearch.Text = txtSearch.Text.Trim();
			if (txtSearch.Text != string.Empty)
			{
				txtName.Text = string.Empty;
				txtPrice.Text = string.Empty;
				btnSearch.Visible = false;
				btnCancel.Visible = true;
				Search();
			}
		}
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			LoadFullRoomType(GetFullRoomType());
			btnCancel.Visible = false;
			btnSearch.Visible = true;
		}
		#endregion

		#region GetData
		private DataTable GetFullRoomType()
		{
			return RoomTypeDAO.Instance.LoadFullRoomType();
		}
		private RoomType GetRoomTypeNow()
		{
			RoomType roomType = new RoomType();
			if (cbID.Text == string.Empty)
				roomType.Id = 0;
			else
				roomType.Id = int.Parse(cbID.Text);

			roomType.Name = txtName.Text;
			roomType.Price = int.Parse(StringToInt(txtPrice.Text));
			roomType.LimitPerson = int.Parse(txtLimitPerson.Text);
			return roomType;
		}
		private DataTable GetSearchRoomType()
		{
			if (int.TryParse(txtSearch.Text, out int id))
				return RoomTypeDAO.Instance.Search(txtSearch.Text, id);
			else
				return RoomTypeDAO.Instance.Search(txtSearch.Text, 0);
		}

		#endregion

		#region Method
		//private void InsertRoomType()
		//{
		//    if (fCustomer.CheckFillInText(new Control[] { txtName, txtPrice, txtLimitPerson }))
		//    {
		//        try
		//        {
		//            RoomType roomTypeNow = GetRoomTypeNow();
		//            if (RoomTypeDAO.Instance.InsertRoomType(roomTypeNow))
		//            {
		//                MessageBox.Show( "Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//                this.LoadFullRoomType();
		//            }
		//            else
		//                MessageBox.Show( "Loại phòng này đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//        }
		//        catch
		//        {
		//            MessageBox.Show( "Lỗi loại phòng này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		//        }
		//    }
		//    else
		//        MessageBox.Show( "Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//}
		private void UpdateRoomType()
		{
			if (cbID.Text == string.Empty)
			{
				MessageBox.Show("Tipe Kamar Ini Belum Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else
			if (!UC_Customer.CheckFillInText(new Control[] { txtName, txtPrice }))
			{
				MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				RoomType roomTypePre = groupRoomType.Tag as RoomType;
				try
				{
					RoomType roomTypeNow = GetRoomTypeNow();
					if (roomTypeNow.Equals(roomTypePre))
						MessageBox.Show("Anda Belum Mengubah Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
					{
						bool check = RoomTypeDAO.Instance.UpdateRoomType(roomTypeNow, roomTypePre);
						if (check)
						{
							MessageBox.Show("Pembaruan Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
							groupRoomType.Tag = roomTypeNow;
							if (btnCancel.Visible == false)
							{
								int index = dataGridViewRoomType.SelectedRows[0].Index;
								LoadFullRoomType(GetFullRoomType());
								cbID.SelectedIndex = index;
							}
							else
								BtnCancel_Click(null, null);
						}
						else
							MessageBox.Show("Tipe Kamar Ini Belum Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					}
				}
				catch
				{

					MessageBox.Show("Kesalahan Memasukkan Data", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void ChangeText(DataGridViewRow row)
		{
			if (row.IsNewRow)
			{
				txtName.Text = string.Empty;
				txtPrice.Text = "0";
				txtLimitPerson.Text = "0";
			}
			else
			{
				txtName.Text = row.Cells["colName"].Value.ToString();
				txtPrice.Text = (string)row.Cells["colPrice"].Value;
				txtLimitPerson.Text = row.Cells["colLimitPerson"].Value.ToString();
				RoomType roomType = new RoomType(((DataRowView)row.DataBoundItem).Row);
				groupRoomType.Tag = roomType;
			}
		}
		private void Search()
		{
			LoadFullRoomType(GetSearchRoomType());
		}

		#endregion

		#region Change
		private void DataGridViewRoomType_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewRoomType.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridViewRoomType.SelectedRows[0];
				ChangeText(row);
			}
		}
		private void ChangePrice(DataTable table)
		{
			table.Columns.Add("price_New", typeof(string));
			for (int i = 0; i < table.Rows.Count; i++)
			{
				table.Rows[i]["price_New"] = ((int)table.Rows[i]["price"]).ToString("Rp.", CultureInfo.CreateSpecificCulture("id-ID"));
			}
		}
		private string StringToInt(string text)
		{
			if (text.Contains(".") || text.Contains(" "))
			{
				string[] vs = text.Split(new char[] { '.', ' ' });
				StringBuilder textNow = new StringBuilder();
				for (int i = 0; i < vs.Length - 1; i++)
				{
					textNow.Append(vs[i]);
				}
				return textNow.ToString();
			}
			else return text;
		}
		private string IntToString(string text)
		{
			if (text == string.Empty)
				return 0.ToString("Rp.", CultureInfo.CreateSpecificCulture("id-ID"));
			if (text.Contains(".") || text.Contains(" "))
				return text;
			else
				return (int.Parse(text).ToString("Rp.", CultureInfo.CreateSpecificCulture("id-ID")));
		}

		#endregion

		#region Check Idigit
		private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}

		}
		#endregion

		#region Key
		private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				BtnSearch_Click(sender, null);
			else
				if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		private void FRoomType_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		#endregion

		#region Leave
		private void TxtName_Leave(object sender, EventArgs e)
		{
			if (txtName.Text == string.Empty)
				txtName.Text = txtName.Tag as String;

		}
		private void TxtPrice_Leave(object sender, EventArgs e)
		{

		}
		private void TxtLimitPerson_Leave(object sender, EventArgs e)
		{
			if (txtLimitPerson.Text == string.Empty)
				txtLimitPerson.Text = txtLimitPerson.Tag as String;
		}
		#endregion

		#region Enter
		private void TxtPrice_Enter(object sender, EventArgs e)
		{
			txtPrice.Tag = txtPrice.Text;
			txtPrice.Text = StringToInt(txtPrice.Text);
		}
		private void TxtName_Enter(object sender, EventArgs e)
		{
			txtName.Tag = txtName.Text;
		}
		private void TxtLimitPerson_Enter(object sender, EventArgs e)
		{
			txtLimitPerson.Tag = txtLimitPerson.Text;
		}

		#endregion

		#region Close
		private void FRoomType_FormClosing(object sender, FormClosingEventArgs e)
		{
			BtnCancel_Click(sender, null);
		}
		#endregion
	}
}
