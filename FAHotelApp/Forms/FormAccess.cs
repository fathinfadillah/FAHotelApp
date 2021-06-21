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
	public partial class FormAccess : Form
	{
		private int idStaffType = -1;
		public FormAccess()
		{
			InitializeComponent();
			cbStaffType.DisplayMember = "Name";
			LoadFullStaffType();
		}

		#region Load
		private void LoadFullStaffType()
		{
			cbStaffType.DataSource = GetFullStaffType();
		}
		private void LoadAccess()
		{
			dataGridViewAccessNow.DataSource = GetFullAccessNow(idStaffType);
			dataGridViewAccessRest.DataSource = GetFullAccessRest(idStaffType);
		}
		#endregion

		#region click
		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void btnLeft_Click(object sender, EventArgs e)
		{
			int count = dataGridViewAccessRest.SelectedRows.Count;
			for (int i = 0; i < count; i++)
			{
				int idJob = (int)dataGridViewAccessRest.SelectedRows[i].Cells[colIdRest.Name].Value;
				AccessInsert(idJob, idStaffType);
			}
			LoadAccess();
		}
		private void btnLeftAll_Click(object sender, EventArgs e)
		{
			int count = dataGridViewAccessRest.RowCount;
			for (int i = 0; i < count; i++)
			{
				int idJob = (int)dataGridViewAccessRest.Rows[i].Cells[colIdRest.Name].Value;
				AccessInsert(idJob, idStaffType);
			}
			LoadAccess();
		}
		private void btnRight_Click(object sender, EventArgs e)
		{
			int count = dataGridViewAccessNow.SelectedRows.Count;
			for (int i = 0; i < count; i++)
			{
				int idJob = (int)dataGridViewAccessNow.SelectedRows[i].Cells[colIdNow.Name].Value;
				AcccessDelete(idJob, idStaffType);
			}
			LoadAccess();
		}
		private void btnRightAll_Click(object sender, EventArgs e)
		{
			int count = dataGridViewAccessNow.RowCount;
			for (int i = 0; i < count; i++)
			{
				int idJob = (int)dataGridViewAccessNow.Rows[i].Cells[colIdNow.Name].Value;
				AcccessDelete(idJob, idStaffType);
			}
			LoadAccess();
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (cbStaffType.SelectedIndex == -1) return;
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Menghapus Karyawan Ini?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				if (AccountTypeDAO.Instance.Delete(idStaffType))
				{
					MessageBox.Show("Penghapusan Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
					MessageBox.Show("Penghapusan Gagal, Jenis Karyawan Ini Sudah Ada", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			LoadFullStaffType();
		}
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int index = cbStaffType.SelectedIndex;
			new FormAddStaffType(idStaffType, cbStaffType.Text).ShowDialog();
			LoadFullStaffType();
			cbStaffType.SelectedIndex = index;
		}
		private void btnInsertStaffType_Click(object sender, EventArgs e)
		{
			new FormAddStaffType().ShowDialog();
			LoadFullStaffType();
			cbStaffType.SelectedIndex = (cbStaffType.DataSource as DataTable).Rows.Count - 1;
		}
		#endregion

		#region Get Data
		private DataTable GetFullStaffType()
		{
			return AccountTypeDAO.Instance.LoadFullStaffType();
		}
		private DataTable GetFullAccessNow(int idStaffType)
		{
			return AccessDAO.Instance.GetFullAccessNow(idStaffType);
		}
		private DataTable GetFullAccessRest(int idStaffType)
		{
			return AccessDAO.Instance.GetFullAccessRest(idStaffType);
		}
		#endregion

		#region Change StaffType
		private void cbStaffType_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = cbStaffType.SelectedIndex;
			idStaffType = (int)((DataTable)cbStaffType.DataSource).Rows[index]["id"];
			LoadAccess();
		}
		#endregion

		#region Method

		private void AccessInsert(int idJob, int idStaffType)
		{
			AccessDAO.Instance.Insert(idJob, idStaffType);
		}
		private void AcccessDelete(int idJob, int idStaffType)
		{
			AccessDAO.Instance.Delete(idJob, idStaffType);
		}



		#endregion


	}
}
