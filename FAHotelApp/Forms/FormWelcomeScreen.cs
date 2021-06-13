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
using System.Reflection;
using System.IO;

namespace FAHotelApp
{
	public partial class FormWelcomeScreen : Form
	{
		public FormWelcomeScreen()
		{
			InitializeComponent();
		}

		private void FormWelcomeScreen_Load(object sender, EventArgs e)
		{
			timer1.Start();

			lbDate.Text = DateTime.Now.ToString("dddd, MMM dd yyyy");

			lbTime.Text = DateTime.Now.ToLongTimeString();

			// temporary file path - your temp file = video.avi
			var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WelcomeScreen.mp4");

			try
			{
				// ResourceName = the resource you want to play
				File.WriteAllBytes(strTempFile, Properties.Resources.WelcomeScreen);
				axWindowsMediaPlayer1.URL = strTempFile;
				axWindowsMediaPlayer1.Ctlcontrols.play();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
		}
	}
}