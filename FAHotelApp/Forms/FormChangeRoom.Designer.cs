namespace FAHotelApp.Forms
{
	partial class FormChangeRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeRoom));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxReceiveRoom = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLimitPerson = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRoomTypeName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRoom = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRoomType = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(516, 12);
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
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ganti Kamar";
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(527, 15);
            this.bunifuSeparator1.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxReceiveRoom);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtLimitPerson);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRoomTypeName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtRoomName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.groupBox2.Location = new System.Drawing.Point(290, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 374);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informasi Tipe Kamar";
            // 
            // checkBoxReceiveRoom
            // 
            this.checkBoxReceiveRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBoxReceiveRoom.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.checkBoxReceiveRoom.Checked = false;
            this.checkBoxReceiveRoom.CheckedOnColor = System.Drawing.Color.SeaGreen;
            this.checkBoxReceiveRoom.ForeColor = System.Drawing.Color.White;
            this.checkBoxReceiveRoom.Location = new System.Drawing.Point(58, 1213);
            this.checkBoxReceiveRoom.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.checkBoxReceiveRoom.Name = "checkBoxReceiveRoom";
            this.checkBoxReceiveRoom.Size = new System.Drawing.Size(20, 20);
            this.checkBoxReceiveRoom.TabIndex = 38;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtPrice.BorderThickness = 1;
            this.txtPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.isPassword = false;
            this.txtPrice.Location = new System.Drawing.Point(26, 308);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(203, 29);
            this.txtPrice.TabIndex = 35;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label10.Location = new System.Drawing.Point(22, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Harga:";
            // 
            // txtLimitPerson
            // 
            this.txtLimitPerson.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtLimitPerson.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtLimitPerson.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtLimitPerson.BorderThickness = 1;
            this.txtLimitPerson.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLimitPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLimitPerson.Enabled = false;
            this.txtLimitPerson.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLimitPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLimitPerson.isPassword = false;
            this.txtLimitPerson.Location = new System.Drawing.Point(26, 221);
            this.txtLimitPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtLimitPerson.MaxLength = 32767;
            this.txtLimitPerson.Name = "txtLimitPerson";
            this.txtLimitPerson.Size = new System.Drawing.Size(203, 29);
            this.txtLimitPerson.TabIndex = 30;
            this.txtLimitPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label8.Location = new System.Drawing.Point(22, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Jumlah Maksimum Orang:";
            // 
            // txtRoomTypeName
            // 
            this.txtRoomTypeName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtRoomTypeName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtRoomTypeName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtRoomTypeName.BorderThickness = 1;
            this.txtRoomTypeName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRoomTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomTypeName.Enabled = false;
            this.txtRoomTypeName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRoomTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomTypeName.isPassword = false;
            this.txtRoomTypeName.Location = new System.Drawing.Point(26, 139);
            this.txtRoomTypeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomTypeName.MaxLength = 32767;
            this.txtRoomTypeName.Name = "txtRoomTypeName";
            this.txtRoomTypeName.Size = new System.Drawing.Size(203, 29);
            this.txtRoomTypeName.TabIndex = 23;
            this.txtRoomTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label4.Location = new System.Drawing.Point(22, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nama Tipe Kamar:";
            // 
            // txtRoomName
            // 
            this.txtRoomName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtRoomName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtRoomName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtRoomName.BorderThickness = 1;
            this.txtRoomName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomName.Enabled = false;
            this.txtRoomName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomName.isPassword = false;
            this.txtRoomName.Location = new System.Drawing.Point(26, 62);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomName.MaxLength = 32767;
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(203, 29);
            this.txtRoomName.TabIndex = 21;
            this.txtRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label5.Location = new System.Drawing.Point(22, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nama Ruangan:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbRoom);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbRoomType);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.groupBox3.Location = new System.Drawing.Point(15, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 199);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Daftar Kamar Yang Tersedia";
            // 
            // cbRoom
            // 
            this.cbRoom.BackColor = System.Drawing.Color.White;
            this.cbRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.ItemHeight = 23;
            this.cbRoom.Location = new System.Drawing.Point(27, 138);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(203, 29);
            this.cbRoom.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbRoom.TabIndex = 54;
            this.cbRoom.UseCustomBackColor = true;
            this.cbRoom.UseCustomForeColor = true;
            this.cbRoom.UseSelectable = true;
            this.cbRoom.UseStyleColors = true;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Kamar:";
            // 
            // cbRoomType
            // 
            this.cbRoomType.BackColor = System.Drawing.Color.White;
            this.cbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.ItemHeight = 23;
            this.cbRoomType.Location = new System.Drawing.Point(27, 62);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(203, 29);
            this.cbRoomType.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbRoomType.TabIndex = 52;
            this.cbRoomType.UseCustomBackColor = true;
            this.cbRoomType.UseCustomForeColor = true;
            this.cbRoomType.UseSelectable = true;
            this.cbRoomType.UseStyleColors = true;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tipe Kamar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose_);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.groupBox1.Location = new System.Drawing.Point(15, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 168);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnClose_
            // 
            this.btnClose_.ActiveBorderThickness = 1;
            this.btnClose_.ActiveCornerRadius = 20;
            this.btnClose_.ActiveFillColor = System.Drawing.Color.Red;
            this.btnClose_.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose_.ActiveLineColor = System.Drawing.Color.Red;
            this.btnClose_.BackColor = System.Drawing.Color.White;
            this.btnClose_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose_.BackgroundImage")));
            this.btnClose_.ButtonText = "Kembali";
            this.btnClose_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose_.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose_.ForeColor = System.Drawing.Color.Red;
            this.btnClose_.IdleBorderThickness = 1;
            this.btnClose_.IdleCornerRadius = 20;
            this.btnClose_.IdleFillColor = System.Drawing.Color.White;
            this.btnClose_.IdleForecolor = System.Drawing.Color.Red;
            this.btnClose_.IdleLineColor = System.Drawing.Color.Red;
            this.btnClose_.Location = new System.Drawing.Point(24, 96);
            this.btnClose_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(203, 40);
            this.btnClose_.TabIndex = 51;
            this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose_.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.ActiveBorderThickness = 1;
            this.btnAddCustomer.ActiveCornerRadius = 20;
            this.btnAddCustomer.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnAddCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCustomer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnAddCustomer.BackColor = System.Drawing.Color.White;
            this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
            this.btnAddCustomer.ButtonText = "Simpan Perubahan";
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnAddCustomer.IdleBorderThickness = 1;
            this.btnAddCustomer.IdleCornerRadius = 20;
            this.btnAddCustomer.IdleFillColor = System.Drawing.Color.White;
            this.btnAddCustomer.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnAddCustomer.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnAddCustomer.Location = new System.Drawing.Point(24, 47);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(203, 40);
            this.btnAddCustomer.TabIndex = 48;
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // FormChangeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChangeRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.TopMost = true;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private System.Windows.Forms.Label label1;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
		private System.Windows.Forms.GroupBox groupBox2;
		private Bunifu.Framework.UI.BunifuCheckbox checkBoxReceiveRoom;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtPrice;
		private System.Windows.Forms.Label label10;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtLimitPerson;
		private System.Windows.Forms.Label label8;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtRoomTypeName;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtRoomName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private MetroFramework.Controls.MetroComboBox cbRoom;
		private System.Windows.Forms.Label label2;
		private MetroFramework.Controls.MetroComboBox cbRoomType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
		private Bunifu.Framework.UI.BunifuThinButton2 btnAddCustomer;
	}
}