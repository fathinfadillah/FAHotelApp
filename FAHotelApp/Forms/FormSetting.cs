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
using System.IO;

namespace FAHotelApp.Forms
{
	public partial class FormSetting : Form
	{
		public FormSetting(string userName)
		{
			InitializeComponent();
			LoadProfile(userName);
		}
		string Password;
		String fileName = "";
		public void LoadProfile(string username)
		{
			Account staff = AccountDAO.Instance.LoadStaffInforByUserName(username);
			lblUserName.Text = txbUserName.Text = staff.UserName;
			lblDisplayName.Text = txbDisplayName.Text = staff.DisplayName;
			txbStaffType.Text = AccountTypeDAO.Instance.GetStaffTypeByUserName(username).Name;
			txbIDCard.Text = staff.IdCard.ToString();
			txbPhoneNumber.Text = staff.PhoneNumber.ToString();
			txbAddress.Text = staff.Address;
			dpkDateOfBirth.Value = staff.DateOfBirth;
			cbSex.Text = staff.Sex;
			txbStartDay.Text = staff.StartDay.ToShortDateString();
			Password = staff.PassWord;
			if (staff != null)
			{
				if (!string.IsNullOrEmpty(staff.ImageUrl))
					pictureBox.Image = Image.FromFile(staff.ImageUrl);
			}

			System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
			gp.AddEllipse(0, 0, pictureBox.Width - 3, pictureBox.Height - 3);
			Region rg = new Region(gp);
			pictureBox.Region = rg;

			txtFileName.Text = staff.ImageUrl;
		}
		public void UpdateDisplayName(string username, string displayname)
		{
			AccountDAO.Instance.UpdateDisplayName(username, displayname);
		}
		public void UpdatePassword(string username, string password)
		{
			AccountDAO.Instance.UpdatePassword(username, password);
		}
		public void UpdateInfo(string username, string address, string phonenumber, string idCard, DateTime dateOfBirth, string sex)
		{
			AccountDAO.Instance.UpdateInfo(username, address, phonenumber, idCard, dateOfBirth, sex);
		}
		public void UpdatePhotoProfile(string username, string imageurl)
		{
			AccountDAO.Instance.UpdatePhotoProfile(username, imageurl);
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//byte[] ConvertImageToBytes(Image img)
		//{
		//	using(MemoryStream ms= new MemoryStream())
		//	{
		//		img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
		//		return ms.ToArray();
		//	}
		//}
		//public Image ConvertByteArrayToImage(byte [] data)
		//{
		//	using(MemoryStream ms=new MemoryStream())
		//	{
		//		return Image.FromStream(ms);
		//	}
		//}
	
		private void btnBookRoom_Click(object sender, EventArgs e)
		{
			if (txbDisplayName.Text != String.Empty)
			{
				UpdateDisplayName(txbUserName.Text, txbDisplayName.Text);
				MessageBox.Show("Pembaruan informasi akun berhasil.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MessageBox.Show("Jika ingin memperbarui informasi nama ditampilan menu\nPengguna diharapkan melakukan login ulang.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadProfile(txbUserName.Text);
			}
			else
				MessageBox.Show("Nama tampilan tidak valid.\nSilahkan masukkan kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void btnSecurity_Click(object sender, EventArgs e)
		{
			if (AccountDAO.Instance.HashPass(txbPass.Text) == Password && txbNewPass.Text != String.Empty && txbReNewPass.Text != String.Empty)
			{
				if (txbNewPass.Text == txbReNewPass.Text)
				{
					UpdatePassword(txbUserName.Text, txbNewPass.Text);
					MessageBox.Show("Berhail melakukan pembaruan.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txbPass.Text = txbNewPass.Text = txbReNewPass.Text = String.Empty;
					LoadProfile(txbUserName.Text);
				}
				else
				{
					MessageBox.Show("Kata sandi baru tidak valid.\nSilahkan masukkan kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txbNewPass.Text = txbReNewPass.Text = String.Empty;
				}
			}
			else
			{
				MessageBox.Show("Kata sandi tidak cocok.\nSilahkan masukkan kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txbPass.Text = txbNewPass.Text = txbReNewPass.Text = String.Empty;
			}
		}

		private void btnInformation_Click(object sender, EventArgs e)
		{
			if (txbAddress.Text != String.Empty && txbPhoneNumber.Text != String.Empty && cbSex.Text != string.Empty && dpkDateOfBirth.Value < DateTime.Now.Date)
			{
				if (AccountDAO.Instance.IsIdCardExists(txbIDCard.Text))
				{
					UpdateInfo(txbUserName.Text, txbAddress.Text, txbPhoneNumber.Text, txbIDCard.Text, dpkDateOfBirth.Value, cbSex.Text);
					MessageBox.Show("Pemberitahuan informasi dasar berhasil.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadProfile(txbUserName.Text);
				}
				else
					MessageBox.Show("KTP/ NIK tidak ada.\nSilahkan masukkan kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				MessageBox.Show("Informasi dasar tidak valid.\nSilahkan masukkan kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
				e.Handled = true;
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			FormLogin2 f = new FormLogin2();
			f.Show();
			this.Hide();
		}

		private void btnBrowseImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg;*.jpeg|PNG|*.png", ValidateNames = true, Multiselect = false })
			{
				try
				{
					if (ofd.ShowDialog() == DialogResult.OK)
					{
						//tampilin gambar ke picturebox
						pictureBox.Image = Image.FromFile(ofd.FileName);
						//set path
						txtFileName.Text = ofd.FileName;
						//masukan nama file ke public nama file
						fileName = ofd.FileName;
						//LoadProfile(txbUserName.Text);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btnSaveImage_Click(object sender, EventArgs e)
		{
			if (pictureBox.Image != null)
			{
				if (fileName != "")
				{
					pictureBox.Image = Image.FromFile(fileName);
					UpdatePhotoProfile(txbUserName.Text, fileName);
					MessageBox.Show("Pembaruan foto profil akun berhasil.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					MessageBox.Show("Jika ingin memperbarui informasi foto profil ditampilan menu\nPengguna diharapkan melakukan login ulang.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadProfile(txbUserName.Text);
				}
				else
					MessageBox.Show("Tambah foto profil terlebih dahulu.\nSilahkan tambahkan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else
				MessageBox.Show("Foto profil tidak valid.\nSilahkan masukkan kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
