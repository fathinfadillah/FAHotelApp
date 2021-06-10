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

namespace FAHotelApp
{
	public partial class FormContactAdmin : Form
	{
		public FormContactAdmin()
		{
			InitializeComponent();
		}

		private void FormContactAdmin_Load(object sender, EventArgs e)
		{
			timer1.Start();

			lbDate.Text = DateTime.Now.ToString("dddd, MMM dd yyyy");

			lbTime.Text = DateTime.Now.ToLongTimeString();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			try
			{
				SmtpClient clientDetails = new SmtpClient();
				clientDetails.Port = Convert.ToInt32(cbServerPortNo.Text.Trim());
				clientDetails.Host = cbSMPTServer.Text.Trim();
				clientDetails.EnableSsl = tsSSL.Checked;
				clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
				clientDetails.UseDefaultCredentials = false;
				clientDetails.Credentials = new NetworkCredential(txtSenderEmail.Text.Trim(), txtSenderPassword.Text.Trim());

				MailMessage mailDetails = new MailMessage();
				mailDetails.From = new MailAddress(txtSenderEmail.Text.Trim());
				mailDetails.To.Add(txtRecipientEmail.Text.Trim());
				mailDetails.Subject = txtSubject.Text.Trim();
				mailDetails.IsBodyHtml = tsSSL.Checked;
				mailDetails.Body = txtBody.Text.Trim();

				clientDetails.Send(mailDetails);

				MessageBox.Show("Email Sent!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			FormLogin f = new FormLogin();
			f.Show();
			this.Hide();
		}
	}
}