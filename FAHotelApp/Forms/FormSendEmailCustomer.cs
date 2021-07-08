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
using System.Globalization;

namespace FAHotelApp.Forms
{
	public partial class FormSendEmailCustomer : Form
	{
		OpenFileDialog ofdAttachment;
		String fileName = "";

		public FormSendEmailCustomer()
		{
			InitializeComponent();
		}

		private void FormContactAdmin_Load(object sender, EventArgs e)
		{
			timer1.Start();

			CultureInfo culture = new CultureInfo("id-ID");
			lbDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", culture);

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
					clientDetails.Credentials = new NetworkCredential("fahotel.management@gmail.com", "Fahotel@2021");

					MailMessage mailDetails = new MailMessage();
					mailDetails.From = new MailAddress("fahotel.management@gmail.com");
					mailDetails.To.Add(txtEmailRecipient.Text.Trim());
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
					clientDetails.Credentials = new NetworkCredential("fahotel.management@gmail.com", "Fahotel@2021");

					MailMessage mailDetails = new MailMessage();
					mailDetails.From = new MailAddress("fahotel.management@gmail.com");
					mailDetails.To.Add(txtEmailRecipient.Text.Trim());
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
			this.Close();
		}

		private void txtSenderEmail_Leave(object sender, EventArgs e)
		{
			if (txtEmailRecipient.Text == "")
			{
				epWarning.SetError(txtEmailRecipient, "TextBox Email tidak boleh kosong!");
				epWrong.SetError(txtEmailRecipient, "");
				epCorrect.SetError(txtEmailRecipient, "");
			}
			else
			{
				if (Regex.IsMatch(txtEmailRecipient.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
				{
					epWarning.SetError(txtEmailRecipient, "");
					epWrong.SetError(txtEmailRecipient, "");
					epCorrect.SetError(txtEmailRecipient, "Betul!");
				}
				else
				{
					epWarning.SetError(txtEmailRecipient, "");
					epWrong.SetError(txtEmailRecipient, "Format email salah!\nContoh: a@b.c");
					epCorrect.SetError(txtEmailRecipient, "");
				}
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