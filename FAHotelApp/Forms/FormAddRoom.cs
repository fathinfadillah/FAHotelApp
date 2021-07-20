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
	public partial class FormAddRoom : Form
	{
		public FormAddRoom()
		{
			InitializeComponent();
			LoadFullRoomType();
			txtNameRoom.Text = generateid();
		}
		string connectionstring = @"Integrated Security=True;Data Source=localhost;Initial Catalog=FAHotel";
		private void LoadFullRoomType()
		{
			DataTable table = GetFullRoomType();
			ChangePrice(table);
			cbRoomType.DataSource = table;
			cbRoomType.DisplayMember = "Name";
			if (table.Rows.Count > 0)
				cbRoomType.SelectedIndex = 0;
			txtPrice.DataBindings.Add("Text", cbRoomType.DataSource, "price_New");
			txtLimitPerson.DataBindings.Add(new Binding("Text", cbRoomType.DataSource, "limitPerson"));
		}
		private DataTable GetFullRoomType()
		{
			return RoomTypeDAO.Instance.LoadFullRoomType();
		}
		private Room GetRoomNow()
		{
			Room room = new Room();
			UC_Staff.Trim(new Bunifu.Framework.UI.BunifuMetroTextbox[] { txtNameRoom });
			room.Name = txtNameRoom.Text;
			int index = cbRoomType.SelectedIndex;
			room.IdStatusRoom = 1;
			room.IdRoomType = (int)((DataTable)cbRoomType.DataSource).Rows[index]["id"];
			return room;
		}
		private void InsertRoom()
		{
			if (!UC_Customer.CheckFillInText(new Control[] { txtNameRoom, cbRoomType }))
			{
				MessageBox.Show("Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				Room roomNow = GetRoomNow();
				if (RoomDAO.Instance.InsertRoom(roomNow))
				{
					txtNameRoom.Text = string.Empty;
					MessageBox.Show("Sukses", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
					MessageBox.Show("Ruang Ini Sudah Ada(Duplikat Kode Kamar)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			catch
			{
				MessageBox.Show("Kesalahan Tidak Dapat Menambahkan Ruangan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnAddRoom_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Apakah Anda Ingin Menambahkan Kamar Baru?", "Pemberitahuan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			if (result == DialogResult.OK)
				InsertRoom();
			txtNameRoom.Text = generateid();
		}
		private void ChangePrice(DataTable table)
		{
			table.Columns.Add("price_New", typeof(string));
			for (int i = 0; i < table.Rows.Count; i++)
			{
				table.Rows[i]["price_New"] = ((int)table.Rows[i]["price"]).ToString("Rp.", CultureInfo.CreateSpecificCulture("id-ID"));
			}
			table.Columns.Remove("price");
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		private string generateid()
		{
			SqlConnection connection = new SqlConnection(connectionstring);

			string autoid = null;

			connection.Open();

			string sqlQuery = "SELECT TOP 1 name FROM Room ORDER BY name DESC";
			SqlCommand cmd = new SqlCommand(sqlQuery, connection);
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				string input = dr["name"].ToString();
				string angka = input.Substring(input.Length - Math.Min(3, input.Length));
				int number = Convert.ToInt32(angka);
				number += 1;
				string str = number.ToString("D3");

				autoid = "Kamar " + str;
			}

			if (autoid == null)
			{
				autoid = "Kamar 101";
			}

			connection.Close();

			return autoid;
		}
	}
}
