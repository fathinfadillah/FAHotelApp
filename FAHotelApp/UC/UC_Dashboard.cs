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
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using FAHotelApp.Forms;

namespace FAHotelApp.UC
{
	public partial class UC_Dashboard : UserControl
	{
		private int month = 1;
		private int year = 1990;
		string connectionString = @"Data Source=localhost;Initial Catalog=FAHotel;Integrated Security=True";
		public UC_Dashboard()
		{
			if (Program.IsInDesignMode()) return;
			InitializeComponent();
			LoadViewCustomer();
			LoadViewStaff();
			LoadViewRoomAvailable();
			LoadViewRoomNotAvailable();
			LoadViewRoom();
			LoadViewService();
			LoadTotalIncome();
			dataGridReport.Font = new System.Drawing.Font("Segoe UI", 9.75F);
		}

		#region Load
		private void LoadFullReport(int month, int year)
		{
			this.month = month;
			this.year = year;
			DataTable table = GetFulReport(month, year);
			BindingSource source = new BindingSource();
			ChangePrice(table);
			source.DataSource = table;
			dataGridReport.DataSource = source;
			bindingReport.BindingSource = source;
			DrawChart(source);
			GC.Collect();
		}

		private void LoadViewCustomer()
		{
			string query = "select * from ViewCustomer";

			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command))
			{
				connection.Open();
				SqlDataReader rdr = command.ExecuteReader();

				while (rdr.Read())
				{
					lbCustomer.Text = rdr["CustomerAmount"].ToString();
				}
				rdr.Close();
				connection.Close();

			}
		}

		private void LoadViewStaff()
		{
			string query = "select * from ViewStaff";

			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command))
			{
				connection.Open();
				SqlDataReader rdr = command.ExecuteReader();

				while (rdr.Read())
				{
					lbStaff.Text = rdr["StaffAmount"].ToString();
				}
				rdr.Close();
				connection.Close();

			}
		}

		private void LoadViewRoomAvailable()
		{
			string query = "select * from ViewRoomAvailable";

			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command))
			{
				connection.Open();
				SqlDataReader rdr = command.ExecuteReader();

				while (rdr.Read())
				{
					lbKamarTersedia.Text = rdr["RoomAvailable"].ToString();
				}
				rdr.Close();
				connection.Close();

			}
		}

		private void LoadViewRoomNotAvailable()
		{
			string query = "select * from ViewRoomNotAvailable";

			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command))
			{
				connection.Open();
				SqlDataReader rdr = command.ExecuteReader();

				while (rdr.Read())
				{
					lbKamarTerisi.Text = rdr["RoomNotAvailable"].ToString();
				}
				rdr.Close();
				connection.Close();

			}
		}

		private void LoadViewRoom()
		{
			string query = "select * from ViewRoom";

			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command))
			{
				connection.Open();
				SqlDataReader rdr = command.ExecuteReader();

				while (rdr.Read())
				{
					lbRoomAmount.Text = rdr["RoomAmount"].ToString();
				}
				rdr.Close();
				connection.Close();

			}
		}

		private void LoadViewService()
		{
			string query = "select * from ViewService";

			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command))
			{
				connection.Open();
				SqlDataReader rdr = command.ExecuteReader();

				while (rdr.Read())
				{
					lbService.Text = rdr["ServiceAmount"].ToString();
				}
				rdr.Close();
				connection.Close();

			}
		}

		private void LoadTotalIncome()
		{
			string query = "select * from ViewTotalIncome";

			using (SqlConnection connection = new SqlConnection(connectionString))
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command))
			{
				connection.Open();
				SqlDataReader rdr = command.ExecuteReader();

				while (rdr.Read())
				{
					decimal money = decimal.Parse(lbPendapatan.Text = rdr["TotalIncome"].ToString());
					lbPendapatan.Text = money.ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
				}
				rdr.Close();
				connection.Close();

			}
		}

		private void UC_Dashboard_Load(object sender, EventArgs e)
		{
			LoadFullReport(DateTime.Now.Month, DateTime.Now.Year);
			comboBoxMonth.Text = DateTime.Now.Month.ToString();
			numericYear.Value = DateTime.Now.Year;
		}
		#endregion

		#region Chart
		private void DrawChart(BindingSource source)
		{
			chartReport.DataSource = source;
			chartReport.DataBind();
			foreach (DataPoint item in chartReport.Series[0].Points)
			{
				if (item.YValues[0] == 0)
				{
					item.Label = " ";
				}
			}
		}
		#endregion

		#region Data
		private DataTable GetFulReport(int month, int year)
		{
			return ReportDAO.Instance.LoadFullReport(month, year);
		}

		#endregion

		#region Change Price
		private void ChangePrice(DataTable table)
		{
			table.Columns.Add("value_New", typeof(string));
			//table.Columns.Add("rate_New", typeof(string));
			int sum = 0;
			for (int i = 0; i < table.Rows.Count; i++)
			{
				int node = ((int)table.Rows[i]["value"]);
				table.Rows[i]["value_New"] = node.ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
				//table.Rows[i]["rate_New"] = (((double)table.Rows[i]["rate"]) / 100).ToString("#0.##%");
				sum += node;
			}
			table.Columns.Remove("value");
			DataRow row = table.NewRow();
			table.Columns["value_new"].ColumnName = "value";
			row["value"] = sum.ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
			//row["name"] = "Total Pendapatan";
			table.Rows.Add(row);
		}

		#endregion

		#region Click
		private void BtnViewReport_Click(object sender, EventArgs e)
		{
			LoadFullReport(int.Parse(comboBoxMonth.Text), (int)(numericYear.Value));
		}
		private void ToolStripLabel1_Click(object sender, EventArgs e)
		{
			saveReport.FileName = "Pendapatan bulanan " + month + '-' + year;
			if (saveReport.ShowDialog() == DialogResult.Cancel)
				return;
			else
			{
				bool check;
				try
				{
					switch (saveReport.FilterIndex)
					{
						case 2:
							check = ExportToExcel.Instance.Export(dataGridReport, saveReport.FileName, ModeExportToExcel.XLSX);
							break;
						case 3:
							check = ExportToExcel.Instance.Export(dataGridReport, saveReport.FileName, ModeExportToExcel.PDF);
							break;
						default:
							check = ExportToExcel.Instance.Export(dataGridReport, saveReport.FileName, ModeExportToExcel.XLS);
							break;
					}
					if (check)
						MessageBox.Show("Ekspor sukses", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show("Ekspor gagal kesalahan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch
				{
					MessageBox.Show("Error (Harus Menginstall Office)", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void lbViewEmail_Click(object sender, EventArgs e)
		{
			FormEmailManager f = new FormEmailManager();
			f.ShowDialog();
			this.Show();
		}

		private void btnReportPendapatan_Click(object sender, EventArgs e)
		{
			FormIncome f = new FormIncome();
			f.ShowDialog();
			this.Show();
		}
		private void btnReportTagihan_Click(object sender, EventArgs e)
		{
			FormBill f = new FormBill();
			f.ShowDialog();
			this.Show();
		}
		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			FormRooms f = new FormRooms();
			f.ShowDialog();
			this.Show();
		}
		#endregion


	}
}
