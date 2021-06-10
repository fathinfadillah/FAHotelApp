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

		string AbsoluteRef = null;

		private void FormWelcomeScreen_Load(object sender, EventArgs e)
		{
			timer1.Start();

			lbDate.Text = DateTime.Now.ToString("dddd, MMM dd yyyy");

			lbTime.Text = DateTime.Now.ToLongTimeString();

			axWindowsMediaPlayer1.settings.autoStart = true;

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
		}

		private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
		{
			if (System.Diagnostics.Debugger.IsAttached)
			{
				AbsoluteRef = Path.GetFullPath(Application.StartupPath + "\\..\\..\\..\\Resources\\");
			}
			else
			{
				AbsoluteRef = Application.StartupPath + "\\Resources\\";
			}
			string vlcVideo = AbsoluteRef + "WelcomeScreen.mp4";
			axWindowsMediaPlayer1.URL = @"D:\Personal\Kuliah\OneDrive - polman.astra.ac.id\Semester 2\Pemrograman 2\Tugas\SI_PRG2_20202_PROYEKAKHIR\Source Code\FAHotelApp\FAHotelApp\Resources\WelcomeScreen.mp4";
		}
	}
}