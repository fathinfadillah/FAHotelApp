namespace FAHotelApp.Forms
{
	partial class FormAddCustomer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCustomer));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnAddCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbNationality = new MetroFramework.Controls.MetroComboBox();
			this.dtpDateOfBirth = new Bunifu.Framework.UI.BunifuDatepicker();
			this.label6 = new System.Windows.Forms.Label();
			this.cbCustomerType = new MetroFramework.Controls.MetroComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.DatepickerDateOfReceive = new Bunifu.Framework.UI.BunifuDatepicker();
			this.txtAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label11 = new System.Windows.Forms.Label();
			this.cbSex = new MetroFramework.Controls.MetroComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtIDCard = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtFullName = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label16 = new System.Windows.Forms.Label();
			this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
			this.guna2ControlBox2.Location = new System.Drawing.Point(456, 12);
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
			this.label1.Size = new System.Drawing.Size(231, 37);
			this.label1.TabIndex = 17;
			this.label1.Text = "Tambah Customer";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClose);
			this.groupBox1.Controls.Add(this.btnAddCustomer);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox1.Location = new System.Drawing.Point(15, 496);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(472, 122);
			this.groupBox1.TabIndex = 53;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Menu";
			// 
			// btnClose
			// 
			this.btnClose.ActiveBorderThickness = 1;
			this.btnClose.ActiveCornerRadius = 20;
			this.btnClose.ActiveFillColor = System.Drawing.Color.DarkOrange;
			this.btnClose.ActiveForecolor = System.Drawing.Color.White;
			this.btnClose.ActiveLineColor = System.Drawing.Color.DarkOrange;
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.ButtonText = "Kembali";
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.DarkOrange;
			this.btnClose.IdleBorderThickness = 1;
			this.btnClose.IdleCornerRadius = 20;
			this.btnClose.IdleFillColor = System.Drawing.Color.White;
			this.btnClose.IdleForecolor = System.Drawing.Color.DarkOrange;
			this.btnClose.IdleLineColor = System.Drawing.Color.DarkOrange;
			this.btnClose.Location = new System.Drawing.Point(247, 47);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(203, 40);
			this.btnClose.TabIndex = 51;
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAddCustomer
			// 
			this.btnAddCustomer.ActiveBorderThickness = 1;
			this.btnAddCustomer.ActiveCornerRadius = 20;
			this.btnAddCustomer.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddCustomer.ActiveForecolor = System.Drawing.Color.White;
			this.btnAddCustomer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
			this.btnAddCustomer.ButtonText = "Tambah Customer";
			this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddCustomer.IdleBorderThickness = 1;
			this.btnAddCustomer.IdleCornerRadius = 20;
			this.btnAddCustomer.IdleFillColor = System.Drawing.Color.White;
			this.btnAddCustomer.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddCustomer.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddCustomer.Location = new System.Drawing.Point(19, 47);
			this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAddCustomer.Name = "btnAddCustomer";
			this.btnAddCustomer.Size = new System.Drawing.Size(203, 40);
			this.btnAddCustomer.TabIndex = 48;
			this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbNationality);
			this.groupBox2.Controls.Add(this.dtpDateOfBirth);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.cbCustomerType);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.DatepickerDateOfReceive);
			this.groupBox2.Controls.Add(this.txtAddress);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.cbSex);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtPhoneNumber);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.txtIDCard);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.txtFullName);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox2.Location = new System.Drawing.Point(15, 73);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(472, 392);
			this.groupBox2.TabIndex = 52;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Informasi Customer";
			// 
			// cbNationality
			// 
			this.cbNationality.BackColor = System.Drawing.Color.White;
			this.cbNationality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbNationality.FormattingEnabled = true;
			this.cbNationality.ItemHeight = 23;
			this.cbNationality.Items.AddRange(new object[] {
            "Indonesia",
            "Korea",
            "Jepang",
            "Taiwan",
            "Malaysia",
            "Thailand",
            "Singapura",
            "Benua Eropa",
            "Rusia",
            "Inggris",
            "Australia",
            "Arab Saudi",
            "Kanada"});
			this.cbNationality.Location = new System.Drawing.Point(251, 302);
			this.cbNationality.Name = "cbNationality";
			this.cbNationality.Size = new System.Drawing.Size(203, 29);
			this.cbNationality.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbNationality.TabIndex = 59;
			this.cbNationality.UseCustomBackColor = true;
			this.cbNationality.UseCustomForeColor = true;
			this.cbNationality.UseSelectable = true;
			this.cbNationality.UseStyleColors = true;
			// 
			// dtpDateOfBirth
			// 
			this.dtpDateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.dtpDateOfBirth.BorderRadius = 0;
			this.dtpDateOfBirth.ForeColor = System.Drawing.Color.White;
			this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateOfBirth.FormatCustom = null;
			this.dtpDateOfBirth.Location = new System.Drawing.Point(250, 57);
			this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(14, 21, 14, 21);
			this.dtpDateOfBirth.Name = "dtpDateOfBirth";
			this.dtpDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dtpDateOfBirth.Size = new System.Drawing.Size(202, 29);
			this.dtpDateOfBirth.TabIndex = 47;
			this.dtpDateOfBirth.Value = new System.DateTime(1998, 4, 6, 0, 0, 0, 0);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label6.Location = new System.Drawing.Point(249, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 46;
			this.label6.Text = "Tanggal Lahir:";
			// 
			// cbCustomerType
			// 
			this.cbCustomerType.BackColor = System.Drawing.Color.White;
			this.cbCustomerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbCustomerType.FormattingEnabled = true;
			this.cbCustomerType.ItemHeight = 23;
			this.cbCustomerType.Location = new System.Drawing.Point(21, 220);
			this.cbCustomerType.Name = "cbCustomerType";
			this.cbCustomerType.Size = new System.Drawing.Size(203, 29);
			this.cbCustomerType.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbCustomerType.TabIndex = 2;
			this.cbCustomerType.UseCustomBackColor = true;
			this.cbCustomerType.UseCustomForeColor = true;
			this.cbCustomerType.UseSelectable = true;
			this.cbCustomerType.UseStyleColors = true;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label20.Location = new System.Drawing.Point(19, 196);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(108, 20);
			this.label20.TabIndex = 41;
			this.label20.Text = "Tipe Customer:";
			// 
			// DatepickerDateOfReceive
			// 
			this.DatepickerDateOfReceive.BackColor = System.Drawing.Color.SeaGreen;
			this.DatepickerDateOfReceive.BorderRadius = 0;
			this.DatepickerDateOfReceive.ForeColor = System.Drawing.Color.White;
			this.DatepickerDateOfReceive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DatepickerDateOfReceive.FormatCustom = "";
			this.DatepickerDateOfReceive.Location = new System.Drawing.Point(42, 766);
			this.DatepickerDateOfReceive.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.DatepickerDateOfReceive.Name = "DatepickerDateOfReceive";
			this.DatepickerDateOfReceive.Size = new System.Drawing.Size(304, 47);
			this.DatepickerDateOfReceive.TabIndex = 30;
			this.DatepickerDateOfReceive.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
			// 
			// txtAddress
			// 
			this.txtAddress.BackColor = System.Drawing.Color.White;
			this.txtAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtAddress.BorderThickness = 1;
			this.txtAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtAddress.isPassword = false;
			this.txtAddress.Location = new System.Drawing.Point(251, 140);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
			this.txtAddress.MaxLength = 32767;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(203, 29);
			this.txtAddress.TabIndex = 4;
			this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label11.Location = new System.Drawing.Point(249, 119);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 20);
			this.label11.TabIndex = 35;
			this.label11.Text = "Alamat:";
			// 
			// cbSex
			// 
			this.cbSex.BackColor = System.Drawing.Color.White;
			this.cbSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbSex.FormattingEnabled = true;
			this.cbSex.ItemHeight = 23;
			this.cbSex.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
			this.cbSex.Location = new System.Drawing.Point(251, 217);
			this.cbSex.Name = "cbSex";
			this.cbSex.Size = new System.Drawing.Size(203, 29);
			this.cbSex.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbSex.TabIndex = 5;
			this.cbSex.UseCustomBackColor = true;
			this.cbSex.UseCustomForeColor = true;
			this.cbSex.UseSelectable = true;
			this.cbSex.UseStyleColors = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label12.Location = new System.Drawing.Point(249, 277);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 20);
			this.label12.TabIndex = 29;
			this.label12.Text = "Kebangsaan:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label13.Location = new System.Drawing.Point(249, 196);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(101, 20);
			this.label13.TabIndex = 28;
			this.label13.Text = "Jenis Kelamin:";
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
			this.txtPhoneNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtPhoneNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtPhoneNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtPhoneNumber.BorderThickness = 1;
			this.txtPhoneNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPhoneNumber.isPassword = false;
			this.txtPhoneNumber.Location = new System.Drawing.Point(21, 302);
			this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
			this.txtPhoneNumber.MaxLength = 13;
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(203, 29);
			this.txtPhoneNumber.TabIndex = 3;
			this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPhoneNumber_KeyPress);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label14.Location = new System.Drawing.Point(19, 282);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(116, 20);
			this.label14.TabIndex = 26;
			this.label14.Text = "Nomor Telepon:";
			// 
			// txtIDCard
			// 
			this.txtIDCard.BackColor = System.Drawing.Color.White;
			this.txtIDCard.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtIDCard.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtIDCard.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtIDCard.BorderThickness = 1;
			this.txtIDCard.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtIDCard.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtIDCard.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtIDCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtIDCard.isPassword = false;
			this.txtIDCard.Location = new System.Drawing.Point(21, 138);
			this.txtIDCard.Margin = new System.Windows.Forms.Padding(4);
			this.txtIDCard.MaxLength = 16;
			this.txtIDCard.Name = "txtIDCard";
			this.txtIDCard.Size = new System.Drawing.Size(203, 29);
			this.txtIDCard.TabIndex = 1;
			this.txtIDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label15.Location = new System.Drawing.Point(19, 116);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(189, 20);
			this.label15.TabIndex = 24;
			this.label15.Text = "KTP/Kartu Tanda Penduduk:";
			// 
			// txtFullName
			// 
			this.txtFullName.BackColor = System.Drawing.Color.White;
			this.txtFullName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtFullName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtFullName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtFullName.BorderThickness = 1;
			this.txtFullName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtFullName.isPassword = false;
			this.txtFullName.Location = new System.Drawing.Point(21, 57);
			this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
			this.txtFullName.MaxLength = 32767;
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(203, 29);
			this.txtFullName.TabIndex = 0;
			this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label16.Location = new System.Drawing.Point(19, 35);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(52, 20);
			this.label16.TabIndex = 22;
			this.label16.Text = "Nama:";
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
			this.bunifuSeparator1.Size = new System.Drawing.Size(472, 15);
			this.bunifuSeparator1.TabIndex = 18;
			// 
			// FormAddCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(503, 644);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2ControlBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAddCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Forgot Password";
			this.TopMost = true;
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private System.Windows.Forms.Label label1;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
		private System.Windows.Forms.GroupBox groupBox1;
		private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
		private Bunifu.Framework.UI.BunifuThinButton2 btnAddCustomer;
		private System.Windows.Forms.GroupBox groupBox2;
		private Bunifu.Framework.UI.BunifuDatepicker dtpDateOfBirth;
		private System.Windows.Forms.Label label6;
		private MetroFramework.Controls.MetroComboBox cbCustomerType;
		private System.Windows.Forms.Label label20;
		private Bunifu.Framework.UI.BunifuDatepicker DatepickerDateOfReceive;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtAddress;
		private System.Windows.Forms.Label label11;
		private MetroFramework.Controls.MetroComboBox cbSex;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtPhoneNumber;
		private System.Windows.Forms.Label label14;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtIDCard;
		private System.Windows.Forms.Label label15;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtFullName;
		private System.Windows.Forms.Label label16;
		private MetroFramework.Controls.MetroComboBox cbNationality;
	}
}