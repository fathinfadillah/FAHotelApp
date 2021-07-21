using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FAHotelApp.Forms
{
	public partial class FormTC : Form
	{
		public FormTC()
		{
			InitializeComponent();
			TopMost = true;
		}

		private void FormTC_Load(object sender, EventArgs e)
		{
			try
			{
				// temporary file path - your temp file = Terms-and-Conditions-FAHotel.pdf
				var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Terms-and-Conditions-FAHotel.pdf");

				// ResourceName = the resource you want to play
				File.WriteAllBytes(strTempFile, Properties.Resources.Terms_and_Conditions_FAHotel);
				axAcroPDF1.src = strTempFile;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
