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
using FAHotelApp.UC;
using System.Globalization;
using FAHotelApp.Forms;
using System.Windows;

namespace FAHotelApp.UC
{
	public partial class UC_Staff : UserControl
	{
		#region Properties
		public static readonly string HassPass = "e10adc3949ba59abbe56e057f20f883e"; // password default
		#endregion

		#region Constructor
		public UC_Staff()
		{
			InitializeComponent();
			LoadFullStaffType();
			LoadFullStaff(GetFullStaff());
			txtSearch.KeyPress += TxbSearch_KeyPress;
			KeyPress += FStaff_KeyPress;
			dataGridStaff.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
		}


		#endregion

		#region Click
		private void BtnInsert_Click(object sender, EventArgs e)
		{
			new FormAddStaff().Show();

			if (btnCancel.Visible == false)
				LoadFullStaff(GetFullStaff());
			else
				BtnCancel_Click(null, null);
		}
		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Memperbarui Karyawan Ini?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
			{
				if (CheckDate())
				{
					UpdateStaff();
				}
			}
		}
		private void ToolStripLabel1_Click(object sender, EventArgs e)
		{
			if (saveStaff.ShowDialog() == DialogResult.Cancel)
				return;
			else
			{
				bool check;
				try
				{
					switch (saveStaff.FilterIndex)
					{
						case 2:
							check = ExportToExcel.Instance.Export(dataGridStaff, saveStaff.FileName, ModeExportToExcel.XLSX);
							break;
						case 3:
							check = ExportToExcel.Instance.Export(dataGridStaff, saveStaff.FileName, ModeExportToExcel.PDF);
							break;
						default:
							check = ExportToExcel.Instance.Export(dataGridStaff, saveStaff.FileName, ModeExportToExcel.XLS);
							break;
					}
					if (check)
						MessageBox.Show("Export Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show("Export Gagal", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch
				{
					MessageBox.Show("Error (Perlu Menginstal Office)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			txtUserName.Text = string.Empty;
			txtName.Text = string.Empty;
			txtIDcard.Text = string.Empty;
			txtPhoneNumber.Text = string.Empty;
			txtAddress.Text = string.Empty;
		}
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			txtSearch.Text = txtSearch.Text.Trim();
			if (txtSearch.Text != string.Empty)
			{
				txtUserName.Text = string.Empty;
				txtName.Text = string.Empty;
				txtIDcard.Text = string.Empty;
				txtPhoneNumber.Text = string.Empty;
				txtAddress.Text = string.Empty;

				btnSearch.Visible = false;
				btnCancel.Visible = true;
				Search();
			}
		}
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			LoadFullStaff(GetFullStaff());
			btnCancel.Visible = false;
			btnSearch.Visible = true;
		}
		#endregion

		#region Method

		private void UpdateStaff()
		{
			bool isFill = UC_Customer.CheckFillInText(new Control[] { txtUserName, cbStaffType, txtName ,
															txtIDcard , cbSex , txtPhoneNumber, txtAddress});
			if (!isFill)
			{
				MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				Account accountPre = groupStaff.Tag as Account;
				try
				{
					Account accountnow = GetStaffNow();
					if (accountnow.Equals(accountPre))
					{
						MessageBox.Show("Anda Belum Mengubah Data", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						bool check = AccountDAO.Instance.UpdateAccount(accountnow);
						if (check)
						{
							MessageBox.Show("Update Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
							groupStaff.Tag = accountnow;
							if (btnCancel.Visible == false)
							{
								int index = dataGridStaff.SelectedRows[0].Index;
								LoadFullStaff(GetFullStaff());
								dataGridStaff.SelectedRows[0].Selected = false;
								dataGridStaff.Rows[index].Selected = true;
							}
							else
								BtnCancel_Click(null, null);
						}
						else
						{
							if (accountnow.UserName == accountPre.UserName)
								MessageBox.Show("Tidak Dapat Memperbarui(Nomor Identitas Yang Sama)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
							else
								MessageBox.Show("Tidak Dapat Memperbarui(Akun Tidak Ada)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
						}
					}
				}
				catch
				{
					MessageBox.Show("Kesalahan Tidak Diketahui", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}
		private void ResetPassword()
		{
			try
			{
				bool check = AccountDAO.Instance.ResetPassword(txtUserName.Text, HassPass);
				if (check)
				{
					MessageBox.Show("Reset Kata Sandi Berhasil\nKata Sandi Default Adalah: 123456", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
					MessageBox.Show("Tidak Dapat Mereset Kata Sandi(Nama Pengguna Tidak Ada)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			catch
			{
				MessageBox.Show("Kesalahan Tidak Diketahui", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Search()
		{
			LoadFullStaff(GetSearchStaff());
		}
		private void ChangeText(DataGridViewRow row)
		{
			if (row.IsNewRow)
			{
				txtUserName.Text = string.Empty;
				txtName.Text = string.Empty;
				txtIDcard.Text = string.Empty;
				txtPhoneNumber.Text = string.Empty;
				txtAddress.Text = string.Empty;
			}
			else
			{
				txtUserName.Text = row.Cells[colUserName.Name].Value as string;
				txtAddress.Text = row.Cells[colAddress.Name].Value as string;
				txtName.Text = row.Cells[colname.Name].Value as string;
				txtPhoneNumber.Text = row.Cells[colPhone.Name].Value as string;
				txtIDcard.Text = row.Cells[colIDCard.Name].Value as string;
				dtpDateOfBirth.Value = (DateTime)row.Cells["colDateOfBirth"].Value;
				dtpStartDay.Value = (DateTime)row.Cells["colStartDay"].Value;
				cbSex.Text = row.Cells[colSex.Name].Value as string;
				cbStaffType.SelectedIndex = (int)row.Cells[colIDStaffType.Name].Value - 1;


				Account staff = new Account();
				staff.UserName = txtUserName.Text;
				staff.Address = txtAddress.Text;
				staff.DisplayName = txtName.Text;
				staff.PhoneNumber = txtPhoneNumber.Text;
				staff.IdCard = txtIDcard.Text;
				staff.DateOfBirth = dtpDateOfBirth.Value;
				staff.StartDay = dtpStartDay.Value;
				staff.Sex = cbSex.Text;
				staff.IdStaffType = (int)row.Cells[colIDStaffType.Name].Value;
				groupStaff.Tag = staff;
				//bindingNavigatorMoveFirstItem.Enabled = true;
				//bindingNavigatorMovePreviousItem.Enabled = true;
			}
		}
		internal static void Trim(Bunifu.Framework.UI.BunifuMetroTextbox[] textboxes)
		{
			for (int i = 0; i < textboxes.Length; i++)
			{
				textboxes[i].Text = textboxes[i].Text.Trim();
			}
		}
		#endregion

		#region Load data
		private void LoadFullStaff(DataTable table)
		{
			BindingSource source = new BindingSource();
			source.DataSource = table;
			dataGridStaff.DataSource = source;
			bindingStaff.BindingSource = source;
		}
		private void LoadFullStaffType()
		{
			cbSex.SelectedIndex = 0;
			DataTable table = GetFullStaffType();
			cbStaffType.DataSource = table;
			cbStaffType.DisplayMember = "Name";
			if (table.Rows.Count > 0)
				cbStaffType.SelectedIndex = 0;
		}
		#endregion

		#region GetData
		private DataTable GetFullStaff()
		{
			return AccountDAO.Instance.LoadFullStaff();
		}
		private DataTable GetFullStaffType()
		{
			return AccountTypeDAO.Instance.LoadFullStaffType();
		}
		private Account GetStaffNow()
		{
			Account account = new Account();

			#region Format
			Trim(new Bunifu.Framework.UI.BunifuMetroTextbox[] { txtName, txtIDcard, txtAddress });
			#endregion

			account.UserName = txtUserName.Text.ToLower();
			int index = cbStaffType.SelectedIndex;
			account.IdStaffType = (int)((DataTable)cbStaffType.DataSource).Rows[index]["id"];
			account.DisplayName = txtName.Text;
			account.IdCard = txtIDcard.Text;
			account.Sex = cbSex.Text;
			account.DateOfBirth = dtpDateOfBirth.Value;
			account.PhoneNumber = txtPhoneNumber.Text;
			account.Address = txtAddress.Text;
			account.StartDay = dtpStartDay.Value;
			return account;
		}
		private DataTable GetSearchStaff()
		{
			if (int.TryParse(txtSearch.Text, out int phoneNumber))
				return AccountDAO.Instance.Search(txtSearch.Text, phoneNumber);
			else
				return AccountDAO.Instance.Search(txtSearch.Text, -1);
		}
		#endregion

		#region Check isDigit
		private void TxbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private bool CheckTrueDate(DateTime date1, DateTime date2)
		{
			if (date2.Subtract(date1).Days < 6574)
				return false;
			return true;
		}
		private bool CheckDate()
		{
			if (!CheckTrueDate(dtpDateOfBirth.Value, DateTime.Now))
			{
				MessageBox.Show("Tanggal Lahir Tidak Valid (Usia Harus Lebih Dari 18)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
				if (!CheckTrueDate(dtpDateOfBirth.Value, dtpStartDay.Value))
			{
				MessageBox.Show("Tanggal Masuk Kerja Tidak Valid (Lebih Dari 18 Tahun)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
		private void TxbUserName_KeyPress(object sender, KeyPressEventArgs e)
		{

		}
		#endregion

		#region ChangeText
		private void DataGridStaffType_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridStaff.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridStaff.SelectedRows[0];
				ChangeText(row);
			}
		}
		#endregion

		#region Key
		private void TxbSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				BtnSearch_Click(sender, null);
			else
				if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		private void FStaff_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		#endregion

		#region Enter & Leave
		private void Txb_Enter(object sender, EventArgs e)
		{

		}
		private void Txb_Leave(object sender, EventArgs e)
		{

		}
		#endregion

		#region Close
		private void FStaff_FormClosing(object sender, FormClosingEventArgs e)
		{
			BtnCancel_Click(null, null);
		}
		#endregion

		private void BtnAccess_Click(object sender, EventArgs e)
		{
			FormAccess f = new FormAccess();
			f.ShowDialog();
			LoadFullStaffType();
			if (btnCancel.Visible == false)
				LoadFullStaff(GetFullStaff());
			else
				BtnCancel_Click(null, null);
		}
	}
}
