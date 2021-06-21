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
	public partial class FormAddStaff : Form
	{
		public FormAddStaff()
		{
			InitializeComponent();
			LoadFullStaffType();
		}

		private void btnAddStaff_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Menambah Karyawan Baru?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
			{

				if (CheckDate())
				{
					InsertStaff();
				}
			}

		}
		private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '.' || e.KeyChar == '-' ||
				e.KeyChar == '_' || e.KeyChar == '@'))
				e.Handled = true;
			// ^ ([a - zA - Z0 - 9\.\-_ ?@] +)$

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
		private DataTable GetFullStaffType()
		{
			return AccountTypeDAO.Instance.LoadFullStaffType();
		}

		private void InsertStaff()
		{
			bool isFill = UC_Customer.CheckFillInText(new Control[] { txtName, cbStaffType, txtName ,
															txtIDcard , cbSex , txtPhoneNumber, txtAddress});
			if (isFill)
			{
				try
				{
					Account accountNow = GetStaffNow();
					accountNow.PassWord = UC_Staff.HassPass;
					if (AccountDAO.Instance.InsertAccount(accountNow))
					{
						MessageBox.Show("Berhasil Ditambahkan\n Kata Sandi Default Untuk Akun " + txtName.Text +
							": 123456", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
						MessageBox.Show("Karyawan Sudah Ada(Nama Pengguna Atau NIK/KTP Sama)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
				catch (Exception e)
				{
					//MessageBox.Show("Lỗi Không xác định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					MessageBox.Show(e.Message);
				}
			}
			else
			{
				MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private Account GetStaffNow()
		{
			Account account = new Account();

			#region Format
			UC_Staff.Trim(new Bunifu.Framework.UI.BunifuMetroTextbox[] { txtName, txtIDcard, txtAddress });
			#endregion

			account.UserName = txtName.Text.ToLower();
			int index = cbStaffType.SelectedIndex;
			account.IdStaffType = (int)((DataTable)cbStaffType.DataSource).Rows[index]["id"];
			account.DisplayName = txtName.Text;
			account.IdCard = txtIDcard.Text;
			account.Sex = cbSex.Text;
			account.DateOfBirth = dtpDateOfBirth.Value;
			account.PhoneNumber = int.Parse(txtPhoneNumber.Text);
			account.Address = txtAddress.Text;
			account.StartDay = stpStartDay.Value;
			return account;
		}

		private bool CheckDate()
		{
			if (!CheckTrueDate(dtpDateOfBirth.Value, DateTime.Now))
			{
				MessageBox.Show("Tanggal Lahir Tidak Valid (Usia Harus Lebih Dari 18)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
				if (!CheckTrueDate(dtpDateOfBirth.Value, stpStartDay.Value))
			{
				MessageBox.Show("Tanggal Masuk Kerja Tidak Valid (Lebih Dari 18 Tahun)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
		private bool CheckTrueDate(DateTime date1, DateTime date2)
		{
			if (date2.Subtract(date1).Days < 6574)
				return false;
			return true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void fAddStaff_Load(object sender, EventArgs e)
		{
			stpStartDay.Value = DateTime.Now;
			cbSex.SelectedIndex = 1;
		}
	}
}
