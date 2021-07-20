namespace FAHotelApp.Forms
{
	partial class FormIncome
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncome));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.label1 = new System.Windows.Forms.Label();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.label2 = new System.Windows.Forms.Label();
			this.numericYear = new System.Windows.Forms.NumericUpDown();
			this.comboBoxMonth = new MetroFramework.Controls.MetroComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnViewReport = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnBack = new Bunifu.Framework.UI.BunifuThinButton2();
			this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
			this.dt_IncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fAHotelDataSet = new FAHotelApp.DataSet.FAHotelDataSet();
			this.dtIncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dt_incomeTableAdapter = new FAHotelApp.DataSet.FAHotelDataSetTableAdapters.dt_incomeTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_IncomeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fAHotelDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtIncomeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 8;
			this.guna2Elipse1.TargetControl = this;
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.TransparentWhileDrag = true;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
			this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new System.Drawing.Point(717, 12);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.Size = new System.Drawing.Size(35, 28);
			this.guna2ControlBox2.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(244, 37);
			this.label1.TabIndex = 17;
			this.label1.Text = "Report Pendapatan";
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "FAHotelDataSet";
			reportDataSource1.Value = this.dt_IncomeBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "FAHotelApp.Report.ReportIncome.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(64, 172);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(640, 368);
			this.reportViewer1.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label2.Location = new System.Drawing.Point(60, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 20);
			this.label2.TabIndex = 69;
			this.label2.Text = "Bulan:";
			// 
			// numericYear
			// 
			this.numericYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.numericYear.Location = new System.Drawing.Point(408, 105);
			this.numericYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
			this.numericYear.Name = "numericYear";
			this.numericYear.Size = new System.Drawing.Size(73, 29);
			this.numericYear.TabIndex = 71;
			this.numericYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
			// 
			// comboBoxMonth
			// 
			this.comboBoxMonth.BackColor = System.Drawing.Color.White;
			this.comboBoxMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.comboBoxMonth.FormattingEnabled = true;
			this.comboBoxMonth.ItemHeight = 23;
			this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.comboBoxMonth.Location = new System.Drawing.Point(119, 103);
			this.comboBoxMonth.Name = "comboBoxMonth";
			this.comboBoxMonth.Size = new System.Drawing.Size(175, 29);
			this.comboBoxMonth.Style = MetroFramework.MetroColorStyle.Yellow;
			this.comboBoxMonth.TabIndex = 68;
			this.comboBoxMonth.UseCustomBackColor = true;
			this.comboBoxMonth.UseCustomForeColor = true;
			this.comboBoxMonth.UseSelectable = true;
			this.comboBoxMonth.UseStyleColors = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label9.Location = new System.Drawing.Point(347, 108);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 20);
			this.label9.TabIndex = 70;
			this.label9.Text = "Tahun:";
			// 
			// btnViewReport
			// 
			this.btnViewReport.ActiveBorderThickness = 1;
			this.btnViewReport.ActiveCornerRadius = 20;
			this.btnViewReport.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnViewReport.ActiveForecolor = System.Drawing.Color.White;
			this.btnViewReport.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.btnViewReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewReport.BackgroundImage")));
			this.btnViewReport.ButtonText = "Lihat Laporan";
			this.btnViewReport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnViewReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnViewReport.IdleBorderThickness = 1;
			this.btnViewReport.IdleCornerRadius = 20;
			this.btnViewReport.IdleFillColor = System.Drawing.Color.White;
			this.btnViewReport.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnViewReport.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnViewReport.Location = new System.Drawing.Point(529, 98);
			this.btnViewReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnViewReport.Name = "btnViewReport";
			this.btnViewReport.Size = new System.Drawing.Size(175, 40);
			this.btnViewReport.TabIndex = 72;
			this.btnViewReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
			// 
			// btnBack
			// 
			this.btnBack.ActiveBorderThickness = 1;
			this.btnBack.ActiveCornerRadius = 20;
			this.btnBack.ActiveFillColor = System.Drawing.Color.DarkOrange;
			this.btnBack.ActiveForecolor = System.Drawing.Color.White;
			this.btnBack.ActiveLineColor = System.Drawing.Color.DarkOrange;
			this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
			this.btnBack.ButtonText = "Kembali";
			this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.DarkOrange;
			this.btnBack.IdleBorderThickness = 1;
			this.btnBack.IdleCornerRadius = 20;
			this.btnBack.IdleFillColor = System.Drawing.Color.White;
			this.btnBack.IdleForecolor = System.Drawing.Color.DarkOrange;
			this.btnBack.IdleLineColor = System.Drawing.Color.DarkOrange;
			this.btnBack.Location = new System.Drawing.Point(68, 569);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(175, 40);
			this.btnBack.TabIndex = 52;
			this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// bunifuSeparator1
			// 
			this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
			this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
			this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
			this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
			this.bunifuSeparator1.LineThickness = 1;
			this.bunifuSeparator1.Location = new System.Drawing.Point(15, 52);
			this.bunifuSeparator1.Name = "bunifuSeparator1";
			this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
			this.bunifuSeparator1.Size = new System.Drawing.Size(737, 15);
			this.bunifuSeparator1.TabIndex = 18;
			// 
			// dt_IncomeBindingSource
			// 
			this.dt_IncomeBindingSource.DataMember = "dt_Income";
			this.dt_IncomeBindingSource.DataSource = this.fAHotelDataSet;
			// 
			// fAHotelDataSet
			// 
			this.fAHotelDataSet.DataSetName = "FAHotelDataSet";
			this.fAHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dtIncomeBindingSource
			// 
			this.dtIncomeBindingSource.DataMember = "dt_Income";
			this.dtIncomeBindingSource.DataSource = this.fAHotelDataSet;
			// 
			// dt_incomeTableAdapter
			// 
			this.dt_incomeTableAdapter.ClearBeforeFill = true;
			// 
			// FormIncome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(764, 639);
			this.Controls.Add(this.btnViewReport);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericYear);
			this.Controls.Add(this.comboBoxMonth);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2ControlBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormIncome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hak Akses";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormIncome_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt_IncomeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fAHotelDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtIncomeBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private System.Windows.Forms.Label label1;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private Bunifu.Framework.UI.BunifuThinButton2 btnBack;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericYear;
		private MetroFramework.Controls.MetroComboBox comboBoxMonth;
		private System.Windows.Forms.Label label9;
		private Bunifu.Framework.UI.BunifuThinButton2 btnViewReport;
		private System.Windows.Forms.BindingSource dtIncomeBindingSource;
		private DataSet.FAHotelDataSet fAHotelDataSet;
		private DataSet.FAHotelDataSetTableAdapters.dt_incomeTableAdapter dt_incomeTableAdapter;
		private System.Windows.Forms.BindingSource dt_IncomeBindingSource;
	}
}