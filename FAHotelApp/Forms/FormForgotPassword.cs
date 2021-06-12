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

namespace FAHotelApp.Forms
{
	public partial class FormForgotPassword : Form
	{
		public FormForgotPassword()
		{
			InitializeComponent();
		}

		private void btnGetPassword_Click(object sender, EventArgs e)
		{
			if (txtEmployeeID.Text == "" || txtUsername.Text == "")
			{
				MessageBox.Show("Mohon masukkan username dan password anda terlebih dahulu !");
			}
			else
			{
				SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-LHKUU3D; Initial Catalog = FAHotel; Integrated Security = True");
				con.Open();
				SqlCommand cmd = new SqlCommand("select * from Tabel_User where employeeid='" + txtEmployeeID.Text + "' and username='" + txtUsername.Text + "'", con);
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					MessageBox.Show("Password anda adalah " + dr.GetValue(5).ToString());
				}
				else
				{
					MessageBox.Show("Employee ID/Username Salah !");
				}
			}
			
		}

		private void txtEmployeeID_Leave(object sender, EventArgs e)
		{
			if (txtEmployeeID.Text == "")
			{
				epWarning.SetError(txtEmployeeID, "TextBox Employee ID tidak boleh kosong !");
				epWrong.SetError(txtEmployeeID, "");
				epCorrect.SetError(txtEmployeeID, "");
			}
			else
			{
				epWarning.SetError(txtEmployeeID, "");
				epWrong.SetError(txtEmployeeID, "");
				epCorrect.SetError(txtEmployeeID, "Terisi!");
			}
		}

		private void txtUsername_Leave(object sender, EventArgs e)
		{
			if (txtUsername.Text == "")
			{
				epWarning.SetError(txtUsername, "TextBox Username tidak boleh kosong !");
				epWrong.SetError(txtUsername, "");
				epCorrect.SetError(txtUsername, "");
			}
			else
			{
				epWarning.SetError(txtUsername, "");
				epWrong.SetError(txtUsername, "");
				epCorrect.SetError(txtUsername, "Terisi!");
			}
		}
	}
}
