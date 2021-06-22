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
	public partial class UC_Parameter : UserControl
	{
		#region Constructor
		public UC_Parameter()
		{
			InitializeComponent();
			LoadFullParameter(GetFullParameter());
			cbName.DisplayMember = "Name";
			dataGridViewParameter.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
		}
		#endregion

		#region Load
		private void LoadFullParameter(DataTable table)
		{
			BindingSource source = new BindingSource();
			source.DataSource = table;
			dataGridViewParameter.DataSource = source;
			bindingSurcharge.BindingSource = source;
			cbName.DataSource = source;
			txtValue.Enter += txt_Enter;
			txtValue.Leave += txt_Leave;
		}
		#endregion

		#region Click
		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Ingin Memperbarui Pengaturan?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
			{
				UpdateSurcharge();
				cbName.Focus();
			}
		}
		private void ToolStripLabel1_Click(object sender, EventArgs e)
		{
			if (saveParameter.ShowDialog() == DialogResult.Cancel)
				return;
			else
			{
				bool check;
				try
				{
					switch (saveParameter.FilterIndex)
					{
						case 2:
							check = ExportToExcel.Instance.Export(dataGridViewParameter, saveParameter.FileName, ModeExportToExcel.XLSX);
							break;
						case 3:
							check = ExportToExcel.Instance.Export(dataGridViewParameter, saveParameter.FileName, ModeExportToExcel.PDF);
							break;
						default:
							check = ExportToExcel.Instance.Export(dataGridViewParameter, saveParameter.FileName, ModeExportToExcel.XLS);
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
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			txtDescribe.Text = string.Empty;
			txtValue.Text = "0";
		}
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			txtSearch.Text = txtSearch.Text.Trim();
			if (txtSearch.Text != string.Empty)
			{
				txtValue.Text = string.Empty;
				btnSearch.Visible = false;
				btnCancel.Visible = true;
				Search();
			}
		}
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			LoadFullParameter(GetFullParameter());
			btnCancel.Visible = false;
			btnSearch.Visible = true;
		}
		#endregion

		#region Method
		private void UpdateSurcharge()
		{
			if (cbName.Text == string.Empty)
			{
				MessageBox.Show("Tidak Dapat Memperbarui (Tidak Ada Biaya Tambahan Untuk Ini)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return;
			}
			bool isFill = UC_Customer.CheckFillInText(new Control[] { txtValue });
			if (isFill)
			{
				Parameter surchargePre = groupParameter.Tag as Parameter;
				try
				{
					Parameter surchargeNow = GetSurchargeNow();
					if (surchargeNow.Equals(surchargePre))
					{
						MessageBox.Show("Anda Belum Mengubah Data", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						bool check = ParameterDAO.Instance.UpdateParameter(surchargeNow);
						if (check)
						{
							MessageBox.Show("Pemberuan Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
							groupParameter.Tag = surchargeNow;
							if (btnCancel.Visible == false)
							{
								int index = dataGridViewParameter.SelectedRows[0].Index;
								LoadFullParameter(GetFullParameter());
								cbName.SelectedIndex = index;
							}
							else BtnCancel_Click(null, null);
						}
						else
							MessageBox.Show("Tidak Dapat Memperbarui (Tidak Ada Biaya Tambahan Untuk Ini)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					}
				}
				catch
				{
					MessageBox.Show("Kesalahan Yang Tidak Diketahui", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Value Tidak Boleh Dikosongkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void ChangeText(DataGridViewRow row)
		{
			if (row.IsNewRow)
			{
				txtDescribe.Text = string.Empty;
				txtValue.Text = "0";
			}
			else
			{
				txtDescribe.Text = row.Cells[colDescribe.Name].Value.ToString();
				txtValue.Text = row.Cells[colValue.Name].Value.ToString();
				Parameter parameter = new Parameter(((DataRowView)row.DataBoundItem).Row);
				groupParameter.Tag = parameter;
			}
		}
		private void Search()
		{
			LoadFullParameter(GetSearchParameter());
		}
		#endregion

		#region GetData
		private DataTable GetFullParameter()
		{
			return ParameterDAO.Instance.LoadFullParameter();
		}
		private Parameter GetSurchargeNow()
		{
			UC_Staff.Trim(new Bunifu.Framework.UI.BunifuMetroTextbox[] { txtDescribe });
			return new Parameter(cbName.Text, double.Parse(txtValue.Text), txtDescribe.Text);
		}
		private DataTable GetSearchParameter()
		{
			return ParameterDAO.Instance.Search(txtSearch.Text);
		}
		#endregion

		#region Check isDigit
		private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '.'))
				e.Handled = true;
		}

		#endregion

		#region ChangeText
		private void DataGridSurcharge_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewParameter.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridViewParameter.SelectedRows[0];
				ChangeText(row);
			}
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
		private void FParameter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		#endregion

		#region Enter & Leave
		private void txt_Enter(object sender, EventArgs e)
		{
			var textBox = sender as Bunifu.Framework.UI.BunifuMetroTextbox;
			textBox.Tag = textBox.Text;
		}
		private void txt_Leave(object sender, EventArgs e)
		{
			var textBox = sender as Bunifu.Framework.UI.BunifuMetroTextbox;
			if (textBox.Text == string.Empty)
			{
				textBox.Text = textBox.Tag as string;
			}
		}
		#endregion

		#region Close
		private void FParameter_FormClosing(object sender, FormClosingEventArgs e)
		{
			BtnCancel_Click(sender, null);
		}
		#endregion
	}
}
