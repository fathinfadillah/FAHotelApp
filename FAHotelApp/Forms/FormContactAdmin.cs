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
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace FAHotelApp.Forms
{
	public partial class FormContactAdmin : Form
	{
		OpenFileDialog ofdAttachment;
		String fileName = "";

		public FormContactAdmin()
		{
			InitializeComponent();
		}

		private void FormContactAdmin_Load(object sender, EventArgs e)
		{
			timer1.Start();

			lbDate.Text = DateTime.Now.ToString("dddd, MMM dd yyyy");

			lbTime.Text = DateTime.Now.ToLongTimeString();

			txtSubject.Enabled = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (tsSubjectManual.Checked == true)
			{
				try
				{
					SmtpClient clientDetails = new SmtpClient();
					clientDetails.Port = 587;
					clientDetails.Host = "smtp.gmail.com";
					clientDetails.EnableSsl = true;
					clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
					clientDetails.UseDefaultCredentials = false;
					clientDetails.Credentials = new NetworkCredential(txtSenderEmail.Text.Trim(), txtSenderPassword.Text.Trim());

					MailMessage mailDetails = new MailMessage();
					mailDetails.From = new MailAddress(txtSenderEmail.Text.Trim());
					mailDetails.To.Add("fahotel.management@gmail.com");
					mailDetails.Subject = txtSubject.Text.Trim();
					mailDetails.IsBodyHtml = true;
					mailDetails.Body = txtBody.Text.Trim();

					if (fileName.Length > 0)
					{
						Attachment attachment = new Attachment(fileName);
						mailDetails.Attachments.Add(attachment);
					}

					clientDetails.Send(mailDetails);

					MessageBox.Show("Email Sent!");

					fileName = "";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			if (tsSubjectManual.Checked == false)
			{
				try
				{
					SmtpClient clientDetails = new SmtpClient();
					clientDetails.Port = 587;
					clientDetails.Host = "smtp.gmail.com";
					clientDetails.EnableSsl = true;
					clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
					clientDetails.UseDefaultCredentials = false;
					clientDetails.Credentials = new NetworkCredential(txtSenderEmail.Text.Trim(), txtSenderPassword.Text.Trim());

					MailMessage mailDetails = new MailMessage();
					mailDetails.From = new MailAddress(txtSenderEmail.Text.Trim());
					mailDetails.To.Add("fahotel.management@gmail.com");
					mailDetails.Subject = cbSubject.Text.Trim();
					mailDetails.IsBodyHtml = true;
					mailDetails.Body = txtBody.Text.Trim();

					if (fileName.Length > 0)
					{
						Attachment attachment = new Attachment(fileName);
						mailDetails.Attachments.Add(attachment);
					}

					clientDetails.Send(mailDetails);

					MessageBox.Show("Email Sent!");

					fileName = "";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
			
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			try
			{
				ofdAttachment = new OpenFileDialog();
				ofdAttachment.Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf";
				if (ofdAttachment.ShowDialog() == DialogResult.OK)
				{
					fileName = ofdAttachment.FileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			FormLogin2 f = new FormLogin2();
			f.Show();
			this.Hide();
		}

		private void tsShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (tsShowPassword.Checked == true)
			{
				txtSenderPassword.UseSystemPasswordChar = false;
			}
			if (tsShowPassword.Checked == false)
			{
				txtSenderPassword.UseSystemPasswordChar = true;
			}
		}

		private void txtSenderEmail_Leave(object sender, EventArgs e)
		{
			if (txtSenderEmail.Text == "")
			{
				epWarning.SetError(txtSenderEmail, "TextBox Email tidak boleh kosong!");
				epWrong.SetError(txtSenderEmail, "");
				epCorrect.SetError(txtSenderEmail, "");
			}
			else
			{
				if (Regex.IsMatch(txtSenderEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
				{
					epWarning.SetError(txtSenderEmail, "");
					epWrong.SetError(txtSenderEmail, "");
					epCorrect.SetError(txtSenderEmail, "Betul!");
				}
				else
				{
					epWarning.SetError(txtSenderEmail, "");
					epWrong.SetError(txtSenderEmail, "Format email salah!\nContoh: a@b.c");
					epCorrect.SetError(txtSenderEmail, "");
				}
			}
		}

		private void txtSenderPassword_Leave(object sender, EventArgs e)
		{
			if (txtSenderPassword.Text == "")
			{
				epWarning.SetError(txtSenderPassword, "TextBox Password tidak boleh kosong!");
				epWrong.SetError(txtSenderPassword, "");
				epCorrect.SetError(txtSenderPassword, "");
			}
			else
			{
				epWarning.SetError(txtSenderPassword, "");
				epWrong.SetError(txtSenderPassword, "");
				epCorrect.SetError(txtSenderPassword, "Terisi!");
			}
		}

		private void tsSubjectManual_CheckedChanged(object sender, EventArgs e)
		{
			if (tsSubjectManual.Checked == true)
			{
				cbSubject.Enabled = false;
				txtSubject.Enabled = true;
			}
			if (tsSubjectManual.Checked == false)
			{
				cbSubject.Enabled = true;
				txtSubject.Enabled = false;
			}
		}
	}
}