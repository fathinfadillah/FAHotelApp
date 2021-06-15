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

namespace FAHotelApp.Forms
{
	public partial class FormWelcomeScreen : Form
	{
		public FormWelcomeScreen()
		{
			InitializeComponent();
			timeBeginPeriod(timerAccuracy);
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			timeEndPeriod(timerAccuracy);
			base.OnFormClosed(e);
		}

		// Pinvoke:
		private const int timerAccuracy = 1;
		[System.Runtime.InteropServices.DllImport("winmm.dll")]
		private static extern int timeBeginPeriod(int msec);
		[System.Runtime.InteropServices.DllImport("winmm.dll")]
		public static extern int timeEndPeriod(int msec);

		private void FormWelcomeScreen_Load(object sender, EventArgs e)
		{
			timer1.Start();

			lbDate.Text = DateTime.Now.ToString("dddd, MMM dd yyyy");

			lbTime.Text = DateTime.Now.ToLongTimeString();

			this.Opacity = 0.0;
			timer2.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToLongTimeString();

			timer1.Start();
		}

		int cont = 0;

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (this.Opacity < 1) this.Opacity += 0.05;
			cont  += 1;
			if (cont == 100)
			{
				timer2.Stop();
				timer3.Start();
			}
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			this.Opacity -= 0.1;
			if (this.Opacity == 0)
			{
				timer3.Stop();
				this.Close();
			}
		}
	}
}