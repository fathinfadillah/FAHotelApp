using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAHotelApp.DAO;

namespace FAHotelApp.Forms
{
	public partial class FormPrintBill : Form
	{
		public FormPrintBill()
		{
			InitializeComponent();
		}
		public void SetPrintBill(int idBill, string dateOfCreate)
		{
			ShowBillPreView(idBill);
			ShowInfo(idBill);
			lblIDBill.Text = idBill.ToString();
			lblDateCreate.Text = dateOfCreate;
			lblStaffSetUp.Text = AccountDAO.Instance.GetStaffSetUp(idBill).DisplayName;
		}
		public FormPrintBill(int idRoom, int idBill)
		{
			InitializeComponent();
			ShowBillPreView(idBill);
			ShowInfo(idBill);
			lblIDBill.Text = idBill.ToString();
			lblDateCreate.Text = DateTime.Now.ToString();
			lblStaffSetUp.Text = AccountDAO.Instance.GetStaffSetUp(idBill).DisplayName;
		}
		int id = 0;
		public void ShowBillPreView(int idBill)
		{
			listViewUseService.Items.Clear();
			DataTable dataTable = BillDAO.Instance.ShowBillPreView(idBill);
			CultureInfo cultureInfo = new CultureInfo("id-ID");
			int _totalPrice = 0;
			foreach (DataRow item in dataTable.Rows)
			{
				ListViewItem listViewItem = new ListViewItem(id.ToString());
				id++;

				ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(listViewItem, item["Nama Layanan"].ToString());
				ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["Harga"]).ToString("c", cultureInfo));
				ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["Jumlah"]).ToString());
				ListViewItem.ListViewSubItem subItem4 = new ListViewItem.ListViewSubItem(listViewItem, ((int)item["Total Harga"]).ToString("c", cultureInfo));


				_totalPrice += (int)item["Total Harga"];

				listViewItem.SubItems.Add(subItem1);
				listViewItem.SubItems.Add(subItem2);
				listViewItem.SubItems.Add(subItem3);
				listViewItem.SubItems.Add(subItem4);

				listViewUseService.Items.Add(listViewItem);
			}

			ListViewItem listViewItemTotalPrice = new ListViewItem();
			ListViewItem.ListViewSubItem subItemTotalPrice = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, _totalPrice.ToString("c", cultureInfo));
			ListViewItem.ListViewSubItem _subItem1 = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, "");
			ListViewItem.ListViewSubItem _subItem2 = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, "");
			ListViewItem.ListViewSubItem _subItem3 = new ListViewItem.ListViewSubItem(listViewItemTotalPrice, "");
			listViewItemTotalPrice.SubItems.Add(_subItem1);
			listViewItemTotalPrice.SubItems.Add(_subItem2);
			listViewItemTotalPrice.SubItems.Add(_subItem3);
			listViewItemTotalPrice.SubItems.Add(subItemTotalPrice);
			listViewUseService.Items.Add(listViewItemTotalPrice);

			id = 1;
		}
		public bool IsExistsBill(int idRoom)
		{
			return BillDAO.Instance.IsExistsBill(idRoom);
		}
		public void ShowInfo(int idBill)
		{
			string query = "USP_ShowBillInfo @idBill";
			DataRow data = DataProvider.Instance.ExecuteQuery(query, new object[] { idBill }).Rows[0];
			CultureInfo cultureInfo = new CultureInfo("id-ID");
			lblCustomerName.Text = data["Nama"].ToString();
			lblIDCard.Text = data["NIK/KTP"].ToString();
			lblPhoneNumber.Text = data["No"].ToString();
			lblCustomerTypeName.Text = data["CType"].ToString();
			lblAddress.Text = data["Alamat"].ToString();
			lblNationality.Text = data["Kebangsaan"].ToString();
			lblRoomName.Text = data["RName"].ToString();
			lblRoomTypeName.Text = data["RType"].ToString();
			lblRoomPrice_.Text = ((int)data["RPrice"]).ToString("c", cultureInfo);
			lblDateCheckIn.Text = ((DateTime)data["CheckIn"]).ToString().Split(' ')[0];
			DateTime dateCheckIn = (DateTime)data["CheckIn"];
			DateTime dateCheckOut = (DateTime)data["CheckOut"];
			int days = dateCheckOut.Subtract(dateCheckIn).Days;
			lblDays.Text = days.ToString();
			lblPeoples.Text = RoomDAO.Instance.GetPeoples(idBill).ToString();
			lblSurcharge.Text = ((int)data["SubC"]).ToString("c", cultureInfo);
			lblServicePrice.Text = ((int)data["SPrice"]).ToString("c", cultureInfo);
			lblRoomPrice.Text = ((int)data["RPrice"]).ToString("c", cultureInfo);
			lblTotalPrice.Text = ((int)data["TPrice"]).ToString("c", cultureInfo);
			lblFinalPrice.Text = ((int)data["TPrice"] * ((100 - (int)data["Diskon"]) / 100.0)).ToString("c", cultureInfo);
			lblDiscount.Text = ((int)data["Diskon"]).ToString() + " %";
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void btnClose__Click(object sender, EventArgs e)
		{
			Close();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(bitmap, 58, 70);
			bitmap.Dispose();
		}
		Bitmap bitmap;
		private void btnPrint_Click(object sender, EventArgs e)
		{
			Graphics graphics = this.CreateGraphics();
			bitmap = new Bitmap(705, 655, graphics);
			Graphics _graphics = Graphics.FromImage(bitmap);
			_graphics.CopyFromScreen(this.Location.X, this.Location.Y + 60, 0, 0, new Size(708, 655));
			bitmap.Save(Application.StartupPath + @"\Bill.Png", ImageFormat.Png);
			bitmap = new Bitmap(Application.StartupPath + @"\Bill.Png");
			if (printDialog1.ShowDialog() == DialogResult.OK)
				printDocument1.Print();
		}
	}
}
