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
	public partial class FormAddService : Form
	{
		public FormAddService()
		{
			InitializeComponent();
			LoadFullServiceType();
			txtPrice.Text = IntToString("100000");
		}

		private void LoadFullServiceType()
		{
			DataTable table = GetFullServiceType();
			cbServiceType.DataSource = table;
			cbServiceType.DisplayMember = "name";
			;
			if (table.Rows.Count > 0)
				cbServiceType.SelectedIndex = 0;
		}
		private DataTable GetFullServiceType()
		{
			return ServiceTypeDAO.Instance.LoadFullServiceType();
		}
		private Service GetServiceNow()
		{
			Service service = new Service();
			txtName.Text = txtName.Text.Trim();
			service.Name = txtName.Text;
			service.Price = int.Parse(StringToInt(txtPrice.Text));
			int index = cbServiceType.SelectedIndex;
			service.IdServiceType = (int)((DataTable)cbServiceType.DataSource).Rows[index]["id"];
			return service;
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

		private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		private void txtPrice_Leave(object sender, EventArgs e)
		{
			if (txtPrice.Text == string.Empty)
				txtPrice.Text = txtPrice.Tag as string;
			else
				txtPrice.Text = IntToString(txtPrice.Text);
		}
		private void txtPrice_Enter(object sender, EventArgs e)
		{
			txtPrice.Tag = txtPrice.Text;
			txtPrice.Text = StringToInt(txtPrice.Text);
		}
		private void InsertService()
		{
			if (!UC_Customer.CheckFillInText(new Control[] { txtName, cbServiceType, txtPrice }))
			{
				DialogResult result = MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				Service serviceNow = GetServiceNow();
				if (ServiceDAO.Instance.InsertService(serviceNow))
				{
					MessageBox.Show("Tambah Pelayanan Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtName.Text = string.Empty;
					txtPrice.Text = IntToString("100000");
				}
				else
					MessageBox.Show("Layanan Sudah Ada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				//MessageBox.Show("Error", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnAddService_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Menambahkan Layanan Baru?", "Pembaritahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
				InsertService();

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void groupRoom_Enter(object sender, EventArgs e)
		{

		}
	}
}
