using FAHotelApp.DAO;
using FAHotelApp.DTO;
using FAHotelApp.Forms;
using System;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace FAHotelApp.UC
{
	public partial class UC_Service : UserControl
	{
		#region Properties
		FormServiceType _FormServiceType;
		#endregion

		#region Constructor
		public UC_Service()
		{
			this.DoubleBuffered = true;
			InitializeComponent();
			LoadFullServiceType();
			LoadFullService(GetFullService());
			cbID.DisplayMember = "id";
			txtSearch.KeyPress += TxbSearch_KeyPress;
			btnCancel.Click += BtnCancel_Click;
			//KeyPreview = true;
			KeyPress += FService_KeyPress;
			dataGridViewService.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
		}


		#endregion

		#region Load
		private void LoadFullService(DataTable table)
		{
			BindingSource source = new BindingSource();
			ChangePrice(table);
			source.DataSource = table;
			dataGridViewService.DataSource = source;
			bindingService.BindingSource = source;
			cbID.DataSource = source;
		}
		private void LoadFullServiceType()
		{
			DataTable table = GetFullServiceType();
			cbServiceType.DataSource = table;
			cbServiceType.DisplayMember = "name";
			;
			if (table.Rows.Count > 0)
				cbServiceType.SelectedIndex = 0;
			_FormServiceType = new FormServiceType(table);
		}
		#endregion

		#region Click
		private void BtnInsertService_Click(object sender, EventArgs e)
		{
			new FormAddService().ShowDialog();
			if (btnCancel.Visible == false)
				LoadFullService(GetFullService());
			else
				BtnCancel_Click(null, null);
		}
		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Memperbarui Layanan Lagi?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
				UpdateService();
			cbID.Focus();
		}
		private void BtnServiceType_Click(object sender, EventArgs e)
		{
			_FormServiceType.ShowDialog();
			this.LoadFullService(GetFullService());
			cbServiceType.DataSource = _FormServiceType.TableSerViceType;
			this.Show();
		}
		private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			txtName.Text = string.Empty;
			txtPrice.Text = string.Empty;
		}
		private void ToolStripLabel1_Click(object sender, EventArgs e)
		{
			if (saveService.ShowDialog() == DialogResult.Cancel)
				return;
			else
			{
				bool check;
				try
				{
					switch (saveService.FilterIndex)
					{
						case 2:
							check = ExportToExcel.Instance.Export(dataGridViewService, saveService.FileName, ModeExportToExcel.XLSX);
							break;
						case 3:
							check = ExportToExcel.Instance.Export(dataGridViewService, saveService.FileName, ModeExportToExcel.PDF);
							break;
						default:
							check = ExportToExcel.Instance.Export(dataGridViewService, saveService.FileName, ModeExportToExcel.XLS);
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
			LoadFullService(GetFullService());
			btnCancel.Visible = false;
			btnSearch.Visible = true;
		}
		#endregion

		#region Method
		private void ChangeText(DataGridViewRow row)
		{
			if (row.IsNewRow)
			{
				bindingNavigatorMoveFirstItem.Enabled = false;
				bindingNavigatorMovePreviousItem.Enabled = false;
				txtName.Text = string.Empty;
				txtPrice.Text = string.Empty;
			}
			else
			{
				txtName.Text = row.Cells["colName"].Value.ToString();
				cbServiceType.SelectedIndex = (int)row.Cells["colIdServiceType"].Value - 1;
				txtPrice.Text = ((int)row.Cells[col.Name].Value).ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
				Service room = new Service(((DataRowView)row.DataBoundItem).Row);
				groupService.Tag = room;
				bindingNavigatorMoveFirstItem.Enabled = true;
				bindingNavigatorMovePreviousItem.Enabled = true;
			}
		}

		private void UpdateService()
		{
			if (cbID.Text == string.Empty)
				MessageBox.Show("Layanan Tidak Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			else
			if (!UC_Customer.CheckFillInText(new Control[] { txtName, cbServiceType, txtPrice }))
			{
				MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				Service servicePre = groupService.Tag as Service;
				try
				{
					Service serviceNow = GetServiceNow();
					if (serviceNow.Equals(servicePre))
					{
						MessageBox.Show("Anda Belum Mengubah Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						bool check = ServiceDAO.Instance.UpdateService(serviceNow, servicePre);
						if (check)
						{
							MessageBox.Show("Update Layanan Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
							groupService.Tag = serviceNow;
							if (btnCancel.Visible == false)
							{
								int index = dataGridViewService.SelectedRows[0].Index;
								LoadFullService(GetFullService());
								cbID.SelectedIndex = index;
							}
							else
								BtnCancel_Click(null, null);
						}
						else
							MessageBox.Show("Layanan Tidak Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					}
				}
				catch
				{
					MessageBox.Show("Error", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void Search()
		{
			LoadFullService(GetSearchService());
		}
		#endregion

		#region Get Data
		private DataTable GetFullService()
		{
			return ServiceDAO.Instance.LoadFullService();
		}
		private DataTable GetFullServiceType()
		{
			return ServiceTypeDAO.Instance.LoadFullServiceType();
		}
		private Service GetServiceNow()
		{
			Service service = new Service();
			if (cbID.Text == string.Empty)
				service.Id = 0;
			else
				service.Id = int.Parse(cbID.Text);
			txtName.Text = txtName.Text.Trim();
			service.Name = txtName.Text;
			service.Price = int.Parse(StringToInt(txtPrice.Text));
			int index = cbServiceType.SelectedIndex;
			service.IdServiceType = (int)((DataTable)cbServiceType.DataSource).Rows[index]["id"];
			return service;
		}
		private DataTable GetSearchService()
		{
			if (int.TryParse(txtSearch.Text, out int id))
				return ServiceDAO.Instance.Search(txtSearch.Text, id);
			else
				return ServiceDAO.Instance.Search(txtSearch.Text, 0);
		}
		#endregion

		#region Change
		private void DataGridViewService_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewService.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridViewService.SelectedRows[0];
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
				return 0.ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
			if (text.Contains(".") || text.Contains(" "))
				return text;
			else
				return (int.Parse(text).ToString("c", CultureInfo.CreateSpecificCulture("id-ID")));
		}
		#endregion

		#region Key
		private void TxbPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}
		private void TxbSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				BtnSearch_Click(sender, null);
			else
				if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		private void FService_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		#endregion

		#region Enter
		private void TxbPrice_Enter(object sender, EventArgs e)
		{
			txtPrice.Tag = txtPrice.Text;
			txtPrice.Text = StringToInt(txtPrice.Text);
		}
		private void TxbName_Enter(object sender, EventArgs e)
		{
			txtName.Tag = txtName.Text;
		}

		#endregion

		#region Leave
		private void TxbPrice_Leave(object sender, EventArgs e)
		{
			if (txtPrice.Text == string.Empty)
				txtPrice.Text = txtPrice.Tag as string;
			else
				txtPrice.Text = IntToString(txtPrice.Text);
		}
		private void TxbName_Leave(object sender, EventArgs e)
		{
			if (txtName.Text == string.Empty)
				txtName.Text = txtName.Tag as string;
		}
		#endregion

		#region Close
		private void FService_FormClosing(object sender, FormClosingEventArgs e)
		{
			BtnCancel_Click(sender, null);
		}
		#endregion

	}
}
