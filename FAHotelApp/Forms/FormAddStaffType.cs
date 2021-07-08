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
	public partial class FormAddStaffType : Form
	{
		private int idStaffType = -1;
		public FormAddStaffType()
		{
			InitializeComponent();
		}

		public FormAddStaffType(int idStaffType, string name)
		{
			InitializeComponent();
			this.idStaffType = idStaffType;
			txtName.Text = name;
		}

		private void bunifuThinButton25_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void btnAddTypeStaff_Click(object sender, EventArgs e)
		{
			if (idStaffType == -1 && !string.IsNullOrWhiteSpace(txtName.Text))
			{
				if (AccountTypeDAO.Instance.Insert(txtName.Text))
				{
					MessageBox.Show("Tambah Jenis Karyawan Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("Gagal", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);

				}
			}
			else
			{
				if (AccountTypeDAO.Instance.Update(idStaffType, txtName.Text))
				{
					MessageBox.Show("Pembaruan Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("Pembaruan Gagal", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27)
				btnClose_Click(sender, e);
			else if (e.KeyChar == 13)
				btnAddTypeStaff_Click(sender, e);
		}
	}
}
