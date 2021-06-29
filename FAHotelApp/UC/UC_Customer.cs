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

namespace FAHotelApp.UC
{
	public partial class UC_Customer : UserControl
	{
		#region Constructor
		public UC_Customer()
		{
			InitializeComponent();
			cbCustomerSearch.SelectedIndex = 3;
			LoadFullCustomerType();
			LoadFullCustomer(GetFullCustomer());
			cbSex.SelectedIndex = 0;
			SaveCustomer.OverwritePrompt = true;
			cbID.DisplayMember = "id";
			txtSearch.KeyPress += TxtSearch_KeyPress;
			dataGridViewCustomer.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
		}

		#endregion

		#region Load
		private void LoadFullCustomer(DataTable table)
		{
			BindingSource source = new BindingSource();
			source.DataSource = table;
			dataGridViewCustomer.DataSource = source;
			bindingCustomer.BindingSource = source;
			cbID.DataSource = source;
		}
		private void LoadFullCustomerType()
		{
			DataTable table = GetFullCustomerType();
			cbCustomerType.DataSource = table;
			cbCustomerType.DisplayMember = "Name";
			if (table.Rows.Count > 0)
				cbCustomerType.SelectedIndex = 0;
		}
		#endregion

		#region Click

		private void ToolStripLabel1_Click(object sender, EventArgs e)
		{
			bool check;
			if (SaveCustomer.ShowDialog() == DialogResult.Cancel)
				return;
			switch (SaveCustomer.FilterIndex)
			{
				case 2:
					check = ExportToExcel.Instance.Export(dataGridViewCustomer, SaveCustomer.FileName, ModeExportToExcel.XLSX);
					break;
				case 3:
					check = ExportToExcel.Instance.Export(dataGridViewCustomer, SaveCustomer.FileName, ModeExportToExcel.PDF);
					break;
				default:
					check = ExportToExcel.Instance.Export(dataGridViewCustomer, SaveCustomer.FileName, ModeExportToExcel.XLS);
					break;
			}
			if (check)
				MessageBox.Show("Ekspor Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show("Error (Harus Menginstall Office)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void BtnAddCustomer_Click(object sender, EventArgs e)
		{
			new FormAddCustomer().ShowDialog();
			if (btnCancel.Visible == false)
				LoadFullCustomer(GetFullCustomer());
			else
				BtnCancel_Click(null, null);
		}
		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			txtFullName.Text = string.Empty;
			txtAddress.Text = string.Empty;
			txtIDCard.Text = string.Empty;
			cbNationality.Text = string.Empty;
			txtPhoneNumber.Text = string.Empty;
		}
		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Memperbarui Customer Ini?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
				if (CheckDate())
				{
					UpdateCustomer();
					cbID.Focus();
				}
				else
					MessageBox.Show("Tanggal Lahir Harus Kurang Dari Tanggal Sekarangs", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			txtSearch.Text = txtSearch.Text.Trim();
			if (txtSearch.Text != string.Empty)
			{
				txtAddress.Text = string.Empty;
				txtFullName.Text = string.Empty;
				txtIDCard.Text = string.Empty;
				txtPhoneNumber.Text = string.Empty;
				cbNationality.Text = string.Empty;

				btnSearch.Visible = false;
				btnCancel.Visible = true;
				Search();
			}
		}
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			LoadFullCustomer(GetFullCustomer());
			btnCancel.Visible = false;
			btnSearch.Visible = true;
		}
		#endregion

		#region Method
		public static bool CheckFillInText(Control[] controls)
		{
			foreach (var control in controls)
			{
				if (control.Text == string.Empty)
					return false;
			}
			return true;
		}
		private void InsertCustomer()
		{
			if (!CheckFillInText(new Control[] { txtPhoneNumber, txtFullName, txtIDCard, cbNationality, txtAddress, cbCustomerType }))
			{
				MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				Customer customer = GetCustomerNow();
				if (CustomerDAO.Instance.InsertCustomer(customer))
				{
					MessageBox.Show("Menambah Customer Sukses", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (btnCancel.Visible == false)
						LoadFullCustomer(GetFullCustomer());
					else
						BtnCancel_Click(null, null);
					cbID.SelectedIndex = dataGridViewCustomer.RowCount - 1;
				}
				else
					MessageBox.Show("Customer Sudah Ada\nNIK Duplikat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			catch
			{
				MessageBox.Show("Kesalahan Menambahkan Pelanggan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void UpdateCustomer()
		{
			if (cbID.Text == string.Empty)
			{
				MessageBox.Show("Customer Ini Belum Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else
			if (!CheckFillInText(new Control[] { txtPhoneNumber, txtFullName, txtIDCard, cbNationality, txtAddress, cbCustomerType }))
			{
				MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				Customer customerPre = groupCustomer.Tag as Customer;
				try
				{
					Customer customerNow = GetCustomerNow();
					if (customerNow.Equals(customerPre))
						MessageBox.Show("Anda Belum Mengubah Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
					{
						bool check = CustomerDAO.Instance.UpdateCustomer(customerNow, customerPre);
						if (check)
						{
							MessageBox.Show("Berhasil Memperbarui Customer", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
							groupCustomer.Tag = customerNow;
							int index = dataGridViewCustomer.SelectedRows[0].Index;
							LoadFullCustomer(GetFullCustomer());
							cbID.SelectedIndex = index;
						}
						else
							MessageBox.Show("Customer Sudah Ada(NIK Ganda)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					}
				}
				catch
				{
					MessageBox.Show("Kesalahan Tidak Diketahui", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void ChangeText(DataGridViewRow row)
		{
			if (row.IsNewRow)
			{
				txtFullName.Text = string.Empty;
				txtAddress.Text = string.Empty;
				txtIDCard.Text = string.Empty;
				cbNationality.Text = string.Empty;
				txtPhoneNumber.Text = string.Empty;
				bindingNavigatorMoveFirstItem.Enabled = false;
				bindingNavigatorMovePreviousItem.Enabled = false;
			}
			else
			{
				bindingNavigatorMoveFirstItem.Enabled = true;
				bindingNavigatorMovePreviousItem.Enabled = true;
				txtFullName.Text = row.Cells["colNameCustomer"].Value.ToString();
				txtAddress.Text = row.Cells["colAddress"].Value.ToString();
				txtIDCard.Text = row.Cells["colIDCard"].Value.ToString();
				cbNationality.Text = row.Cells["colNationality"].Value.ToString();
				txtPhoneNumber.Text = row.Cells["colPhone"].Value.ToString();
				cbCustomerType.SelectedIndex = (int)row.Cells["colIdCustomerType"].Value - 1;
				cbSex.SelectedItem = row.Cells["colSex"].Value;
				dtpDateOfBirth.Value = (DateTime)row.Cells["colDateOfBirth"].Value;
				Customer customer = new Customer(((DataRowView)row.DataBoundItem).Row);
				groupCustomer.Tag = customer;
			}
		}
		private void Search()
		{
			string @string = txtSearch.Text;
			int mode = cbCustomerSearch.SelectedIndex;
			LoadFullCustomer(GetSearchCustomer(@string, mode));
		}

		#endregion

		#region GetData
		private Customer GetCustomerNow()
		{
			UC_Staff.Trim(new Bunifu.Framework.UI.BunifuMetroTextbox[] { txtAddress, txtFullName, txtIDCard });
			Customer customer = new Customer();
			if (cbID.Text == string.Empty)
				customer.Id = 0;
			else
				customer.Id = int.Parse(cbID.Text);
			customer.IdCard = txtIDCard.Text;
			int id = cbCustomerType.SelectedIndex;
			customer.IdCustomerType = (int)((DataTable)cbCustomerType.DataSource).Rows[id]["id"];
			customer.Name = txtFullName.Text;
			customer.Sex = cbSex.Text;
			customer.PhoneNumber = txtPhoneNumber.Text;
			customer.DateOfBirth = dtpDateOfBirth.Value;
			customer.Nationality = cbNationality.Text;
			customer.Address = txtAddress.Text;
			return customer;
		}
		private DataTable GetFullCustomer()
		{
			return CustomerDAO.Instance.LoadFullCustomer();
		}
		private DataTable GetFullCustomerType()
		{
			return CustomerTypeDAO.Instance.LoadFullCustomerType();
		}
		/// <summary>
		/// --Mode is
		//--- 0 --- find along id
		//--- 1 --- find along name
		//--- 2 --- find along idCard
		//--- 3 --- find along NumberPhone
		/// </summary>
		/// <param name="string"></param>
		/// <param name="mode"></param>
		/// <returns></returns>
		private DataTable GetSearchCustomer(string @string, int mode)
		{
			return CustomerDAO.Instance.Search(@string, mode);
		}

		#endregion

		#region Seclection Change
		private void DataGridViewCustomer_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewCustomer.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridViewCustomer.SelectedRows[0];
				ChangeText(row);
			}
		}
		#endregion

		#region Check isDigit

		private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
				e.Handled = true;
		}
		private bool CheckDate()
		{
			if (DateTime.Now.Subtract(dtpDateOfBirth.Value).Days <= 0)
				return false;
			else return true;
		}

		#endregion

		#region Enter
		private void Txt_Enter(object sender, EventArgs e)
		{
			Bunifu.Framework.UI.BunifuMetroTextbox text = sender as Bunifu.Framework.UI.BunifuMetroTextbox;
			text.Tag = text.Text;
		}
		#endregion

		#region Leave
		private void Txt_Leave(object sender, EventArgs e)
		{
			Bunifu.Framework.UI.BunifuMetroTextbox text = sender as Bunifu.Framework.UI.BunifuMetroTextbox;
			if (text.Text == string.Empty)
				text.Text = text.Tag as string;
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
		private void FCustomer_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		#endregion

		#region Close
		private void FCustomer_FormClosing(object sender, FormClosingEventArgs e)
		{
			LoadFullCustomer(GetFullCustomer());
		}
		#endregion

	}
}
