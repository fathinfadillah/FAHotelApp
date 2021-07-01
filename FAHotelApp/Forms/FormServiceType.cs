using FAHotelApp.DAO;
using FAHotelApp.DTO;
using FAHotelApp.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAHotelApp.Forms
{
	public partial class FormServiceType : Form
	{
		#region Properties
		DataTable _tableSerViceType;
		public DataTable TableSerViceType
		{
			get => _tableSerViceType;
			private set
			{
				_tableSerViceType = value;
				BindingSource source = new BindingSource();
				source.DataSource = _tableSerViceType;
				dataGridViewServiceType.DataSource = source;
				bindingServiceType.BindingSource = source;
				comboboxID.DataSource = source;
			}
		}

		#endregion

		#region Constructor
		public FormServiceType()
		{
			InitializeComponent();
		}
		public FormServiceType(DataTable table)
		{
			InitializeComponent();
			this.TableSerViceType = table;
			this.comboboxID.DisplayMember = "id";
			dataGridViewServiceType.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
		}
		#endregion

		#region Load
		private void LoadFullServiceType(DataTable table)
		{
			this.TableSerViceType = table;
		}
		#endregion

		#region Click
		private void BtnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void BtnUpdateServiceType_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Memperbarui Jenis Layanan Ini?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
				UpdateServiceType();
			comboboxID.Focus();
		}
		private void BtnCLose1_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void BtnInsert_Click(object sender, EventArgs e)
		{
			new FormAddServiceType().ShowDialog();
			if (btnCancel.Visible == false)
				LoadFullServiceType(GetFullServiceType());
			else
				BtnCancel_Click(null, null);
			comboboxID.SelectedIndex = dataGridViewServiceType.RowCount - 1;
		}
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			txbName.Text = string.Empty;
		}
		private void ToolStripLabel1_Click(object sender, EventArgs e)
		{
			bool check;
			if (saveServiceType.ShowDialog() == DialogResult.Cancel)
				return;
			try
			{
				switch (saveServiceType.FilterIndex)
				{
					case 2:
						check = ExportToExcel.Instance.Export(dataGridViewServiceType, saveServiceType.FileName, ModeExportToExcel.XLSX);
						break;
					case 3:
						check = ExportToExcel.Instance.Export(dataGridViewServiceType, saveServiceType.FileName, ModeExportToExcel.PDF);
						break;
					default:
						check = ExportToExcel.Instance.Export(dataGridViewServiceType, saveServiceType.FileName, ModeExportToExcel.XLS);
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
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			txtSearch.Text = txtSearch.Text.Trim();
			if (txtSearch.Text != string.Empty)
			{
				txbName.Text = string.Empty;
				Search();
				btnSearch.Visible = false;
				btnCancel.Visible = true;
			}
		}
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			LoadFullServiceType(GetFullServiceType());
			btnCancel.Visible = false;
			btnSearch.Visible = true;
		}

		#endregion

		#region GetData
		private DataTable GetFullServiceType()
		{
			return ServiceTypeDAO.Instance.LoadFullServiceType();
		}
		private ServiceType GetServiceTypeNow()
		{
			ServiceType serviceType = new ServiceType();
			if (comboboxID.Text == string.Empty)
				serviceType.Id = 0;
			else
				serviceType.Id = int.Parse(comboboxID.Text);
			txbName.Text = txbName.Text.Trim();
			serviceType.Name = txbName.Text;
			return serviceType;
		}
		private DataTable GetSearchServiceType(string text)
		{
			if (int.TryParse(text, out int id))
				return ServiceTypeDAO.Instance.Search(text, id);
			else
				return ServiceTypeDAO.Instance.Search(text, 0);
		}

		#endregion

		#region Method

		private void UpdateServiceType()
		{
			if (comboboxID.Text == string.Empty)
				MessageBox.Show("Jenis Layanan Ini Belum Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			if (!UC_Customer.CheckFillInText(new Control[] { txbName }))
			{
				MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				ServiceType serviceTypePre = groupServiceType.Tag as ServiceType;
				try
				{
					ServiceType serviceTypeNow = GetServiceTypeNow();
					if (serviceTypeNow.Equals(serviceTypePre))
						MessageBox.Show("Anda Belum Mengubah Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
					{
						bool check = ServiceTypeDAO.Instance.UpdateServiceType(serviceTypeNow);
						if (check)
						{
							MessageBox.Show("Pembaruan Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
							if (btnCancel.Visible == false)
							{
								int index = dataGridViewServiceType.SelectedRows[0].Index;
								LoadFullServiceType(GetFullServiceType());
								comboboxID.SelectedIndex = index;
							}
							else
							{
								BtnCancel_Click(null, null);
							}
							groupServiceType.Tag = serviceTypeNow;
						}
						else
						{
							MessageBox.Show("Jenis Layanan Ini Belum Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				catch
				{
					MessageBox.Show("Kesalahan Jenis Layanan Ini Sudah Ada", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void ChangeText(DataGridViewRow row)
		{
			if (row.IsNewRow)
			{
				bindingNavigatorMoveFirstItem.Enabled = false;
				bindingNavigatorMovePreviousItem.Enabled = false;
				txbName.Text = string.Empty;
			}
			else
			{
				txbName.Text = row.Cells["colName"].Value.ToString();
				ServiceType roomType = new ServiceType(((DataRowView)row.DataBoundItem).Row);
				groupServiceType.Tag = roomType;
				bindingNavigatorMoveFirstItem.Enabled = true;
				bindingNavigatorMovePreviousItem.Enabled = true;
			}
		}
		private void Search()
		{
			LoadFullServiceType(GetSearchServiceType(txtSearch.Text));
		}
		#endregion

		#region Change
		private void DataGridViewServiceType_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewServiceType.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dataGridViewServiceType.SelectedRows[0];
				ChangeText(row);
			}
		}

		#endregion

		#region Key
		private void fServiceType_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BtnUpdateServiceType_Click(sender, e);
			}
		}
		private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				BtnSearch_Click(sender, null);
			else
				if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}

		#endregion

		#region Close
		private void FServiceType_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.BtnCancel_Click(sender, null);
			this.txtSearch.Text = string.Empty;
		}

		#endregion
	}
}
