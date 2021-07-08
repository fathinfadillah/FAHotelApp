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
	public partial class UC_Bill : UserControl
	{
		#region Constructor & Properties
		private readonly FormPrintBill fPrintBill = new FormPrintBill();

		public UC_Bill()
		{
			InitializeComponent();
			dataGridViewBill.Font = new Font("Segoe UI", 9.75F);
			LoadFullBill(GetFullBill());
			comboboxID.DisplayMember = "ID";
			cbBillSearch.SelectedIndex = 0;
		}

		#endregion

		#region Load
		private void LoadFullBill(DataTable table)
		{
			BindingSource source = new BindingSource();
			ChangePrice(table);
			source.DataSource = table;
			dataGridViewBill.DataSource = source;
			bindingBill.BindingSource = source;
			comboboxID.DataSource = source;

			txbDateCreate.DataBindings.Clear();
			txbName.DataBindings.Clear();
			txbPrice.DataBindings.Clear();
			txbStatusRoom.DataBindings.Clear();
			txbUser.DataBindings.Clear();
			txbDiscount.DataBindings.Clear();
			txbFinalPrice.DataBindings.Clear();

			txbDateCreate.DataBindings.Add("Text", source, "DateOfCreate");
			txbName.DataBindings.Add("Text", source, "roomName");
			txbPrice.DataBindings.Add("Text", source, "totalPrice");
			txbStatusRoom.DataBindings.Add("Text", source, "Name");
			txbUser.DataBindings.Add("Text", source, "StaffSetUp");
			txbDiscount.DataBindings.Add("Text", source, "discount");
			txbFinalPrice.DataBindings.Add("Text", source, "finalprice");
		}

		#endregion

		#region Change Text
		private void ChangePrice(DataTable table)
		{
			table.Columns.Add("totalPrice_New", typeof(string));
			table.Columns.Add("finalprice_New", typeof(string));
			for (int i = 0; i < table.Rows.Count; i++)
			{
				table.Rows[i]["finalprice_New"] = ((int)table.Rows[i]["finalprice"]).ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
				table.Rows[i]["totalPrice_New"] = ((int)table.Rows[i]["totalPrice"]).ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
			}
			table.Columns.Remove("finalprice");
			table.Columns.Remove("totalPrice");
			table.Columns["totalPrice_New"].ColumnName = "totalPrice";
			table.Columns["finalprice_New"].ColumnName = "finalprice";

		}
		private void BtnSeenBill_Click(object sender, EventArgs e)
		{
			if (comboboxID.Text != string.Empty)
			{
				if (!txbStatusRoom.Text.Contains("Ch"))
				{
					fPrintBill.SetPrintBill(int.Parse(comboboxID.Text), txbDateCreate.Text);
					fPrintBill.ShowDialog();
				}
				else
					MessageBox.Show("Invoice Belum Dibayar\nAnda Tidak Memiliki Akses", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		#endregion

		#region Click
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			txtSearch.Text = txtSearch.Text.Trim();
			if (txtSearch.Text != string.Empty)
			{
				txbDateCreate.Text = string.Empty;
				txbName.Text = string.Empty;
				txbPrice.Text = string.Empty;
				txbStatusRoom.Text = string.Empty;
				txbUser.Text = string.Empty;

				btnSearch.Visible = false;
				btnCancel.Visible = true;
				Search();
			}
		}
		private void BtnCancel_Click(object sender, EventArgs e)
		{
			LoadFullBill(GetFullBill());
			btnCancel.Visible = false;
			btnSearch.Visible = true;
		}
		private void btnSendEmail_Click(object sender, EventArgs e)
		{
			FormSendEmailCustomer f = new FormSendEmailCustomer();
			f.ShowDialog();
			this.Show();

		}
		#endregion

		#region Method

		private void Search()
		{
			LoadFullBill(GetSearchBill(txtSearch.Text, cbBillSearch.SelectedIndex));
		}
		#endregion

		#region Get Data
		private DataTable GetFullBill()
		{
			return BillDAO.Instance.LoaddFullBill();
		}
		private DataTable GetSearchBill(string text, int mode)
		{
			return BillDAO.Instance.SearchBill(text, mode);
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
		private void FBill_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27 && btnCancel.Visible == true)
				BtnCancel_Click(sender, null);
		}
		#endregion

		
	}
}
