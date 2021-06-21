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
	public partial class FormAddServiceType : Form
	{
		public FormAddServiceType()
		{
			InitializeComponent();
		}
		private ServiceType GetServiceTypeNow()
		{
			ServiceType serviceType = new ServiceType();
			serviceType.Name = txtName.Text.Trim();
			return serviceType;
		}
		private void InsertServiceType()
		{
			if (UC_Customer.CheckFillInText(new Control[] { txtName }))
			{
				try
				{
					ServiceType serviceTypeNow = GetServiceTypeNow();
					if (ServiceTypeDAO.Instance.InsertServiceType(serviceTypeNow))
					{
						MessageBox.Show("Tambah Tipe Pelayanan Sukses", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtName.Text = string.Empty;
					}
					else
						MessageBox.Show("Kesalahan Memasukkan Data", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch
				{
					MessageBox.Show("Kesalahan Jenis Layanan Sudah Ada", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
				MessageBox.Show("Kesalahan Tidak Diketahui", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}
		private void btnAddServiceType_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Menambahkan Jenis Layanan Baru?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
				InsertServiceType();
		}

		private void btnBackClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
