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
using FAHotelApp.Forms;
using System.Threading;

namespace FAHotelApp.Forms
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			Thread trd = new Thread(new ThreadStart(formRun));
			trd.SetApartmentState(ApartmentState.STA);
			trd.Start();
			Thread.Sleep(8000);
			InitializeComponent();
			//trd.Abort();
			TopMost = true;
		}

		private void formRun()
		{
			Application.Run(new FormWelcomeScreen());
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{
			timer1.Start();

			lbDate.Text = DateTime.Now.ToString("dddd,\nMMM dd yyyy");

			lbTime.Text = DateTime.Now.ToLongTimeString();

			if (Properties.Settings.Default.Username != string.Empty)
			{
				txtUsername.Text = Properties.Settings.Default.Username;
				cbUserType.Text = Properties.Settings.Default.UserType;
				txtPassword.Text = Properties.Settings.Default.Password;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.UsernameView = txtUsername.Text;
			Properties.Settings.Default.UserTypeView = cbUserType.Text;

			if (txtUsername.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Mohon masukkan username dan password anda terlebih dahulu !");
			}
			else
			{
				SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-LHKUU3D; Initial Catalog = FAHotel; Integrated Security = True");
				SqlCommand cmd = new SqlCommand("select * from Tabel_User where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "' COLLATE Latin1_General_CS_AS", con);
				//SqlCommand cmd = new SqlCommand("select COUNT(*) from Tabel_User where (CAST(username as varbinary(50))=cast('" + txtUsername.Text + "' as varbinary)) and (CAST(password as varbinary(50))=cast('" + txtPassword.Text + "' as varbinary))",con);
				//SqlCommand cmd = new SqlCommand("select  count (*) from Tabel_User where username='" + txtUsername.Text +
				//"' and password='" + txtPassword.Text + "' COLLATE Latin1_General_CS_AS", con);

				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				string cmbItemValue = cbUserType.SelectedItem.ToString();
				if (dt.Rows.Count > 0)
				{
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						if (dt.Rows[i]["usertype"].ToString() == cmbItemValue) //you can use 2 instead of usertype in that index because usertype column is in 2 index
						{
							MessageBox.Show("Anda Login Sebagai " + dt.Rows[i][7]);
							if (cbUserType.SelectedIndex == 0)
							{
								this.Hide();
								FormSplash splash = new FormSplash();
								splash.ShowDialog();
								Form1 f = new Form1();
								f.Show();
							}
							else if (cbUserType.SelectedIndex == 1)
							{
								FormSplash ff = new FormSplash();
								ff.Show();
								this.Hide();
							}
						}
						else
						{
							MessageBox.Show("Departement Salah !");
						}
					}
				}
				else
				{
					MessageBox.Show("Username/Password Salah !");
				}
			}

			if (tsRememberMe.Checked == true)
			{
				Properties.Settings.Default.Username = txtUsername.Text;
				Properties.Settings.Default.UserType = cbUserType.Text;
				Properties.Settings.Default.Password = txtPassword.Text;
				Properties.Settings.Default.Save();
			}
			if (tsRememberMe.Checked == false)
			{
				Properties.Settings.Default.Username = "";
				Properties.Settings.Default.UserType = "";
				Properties.Settings.Default.Password= "";
				Properties.Settings.Default.Save();
			}
		}

		private void lbContactAdmin_Click(object sender, EventArgs e)
		{
			FormContactAdmin f = new FormContactAdmin();
			f.Show();
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void tsShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (tsShowPassword.Checked == true)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			if (tsShowPassword.Checked == false)
			{
				txtPassword.UseSystemPasswordChar = true;
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
				epCorrect.SetError(txtUsername, "Terisi !");
			}
			
		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (txtPassword.Text == "")
			{
				epWarning.SetError(txtPassword, "TextBox Password tidak boleh kosong !");
				epWrong.SetError(txtPassword, "");
				epCorrect.SetError(txtPassword, "");
			}
			else
			{
				epWarning.SetError(txtPassword, "");
				epWrong.SetError(txtPassword, "");
				epCorrect.SetError(txtPassword, "Terisi !");
			}
			
		}

		private void lbForgotPassword_Click(object sender, EventArgs e)
		{
			FormForgotPassword f = new FormForgotPassword();
			f.Show();
		}

		private void lbTermCon_Click(object sender, EventArgs e)
		{
			FormTC f = new FormTC();
			f.Show();
		}
	}
}