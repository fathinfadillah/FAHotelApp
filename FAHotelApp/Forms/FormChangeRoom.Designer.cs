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
			this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.cbRoom = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLimitPerson = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRoomTypeName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbRoomName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.guna2GroupBox3.SuspendLayout();
			this.guna2GroupBox2.SuspendLayout();
			this.guna2GroupBox1.SuspendLayout();
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
			this.guna2ControlBox2.Location = new System.Drawing.Point(467, 12);
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
			this.bunifuSeparator1.Size = new System.Drawing.Size(483, 15);
			this.bunifuSeparator1.TabIndex = 18;
			// 
			// guna2GroupBox3
			// 
			this.guna2GroupBox3.Controls.Add(this.cbRoom);
			this.guna2GroupBox3.Controls.Add(this.cbRoomType);
			this.guna2GroupBox3.Controls.Add(this.label8);
			this.guna2GroupBox3.Controls.Add(this.label10);
			this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox3.Location = new System.Drawing.Point(15, 73);
			this.guna2GroupBox3.Name = "guna2GroupBox3";
			this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
			this.guna2GroupBox3.Size = new System.Drawing.Size(244, 244);
			this.guna2GroupBox3.TabIndex = 20;
			this.guna2GroupBox3.Text = "Daftar Kamar Yang Tersedia";
			// 
			// cbRoom
			// 
			this.cbRoom.BackColor = System.Drawing.Color.Transparent;
			this.cbRoom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.cbRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbRoom.FocusedState.Parent = this.cbRoom;
			this.cbRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRoom.ForeColor = System.Drawing.Color.Black;
			this.cbRoom.HoverState.Parent = this.cbRoom;
			this.cbRoom.ItemHeight = 30;
			this.cbRoom.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
			this.cbRoom.ItemsAppearance.Parent = this.cbRoom;
			this.cbRoom.Location = new System.Drawing.Point(22, 171);
			this.cbRoom.Name = "cbRoom";
			this.cbRoom.ShadowDecoration.Parent = this.cbRoom;
			this.cbRoom.Size = new System.Drawing.Size(200, 36);
			this.cbRoom.TabIndex = 19;
			this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
			// 
			// cbRoomType
			// 
			this.cbRoomType.BackColor = System.Drawing.Color.Transparent;
			this.cbRoomType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.cbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbRoomType.FocusedState.Parent = this.cbRoomType;
			this.cbRoomType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRoomType.ForeColor = System.Drawing.Color.Black;
			this.cbRoomType.HoverState.Parent = this.cbRoomType;
			this.cbRoomType.ItemHeight = 30;
			this.cbRoomType.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
			this.cbRoomType.ItemsAppearance.Parent = this.cbRoomType;
			this.cbRoomType.Location = new System.Drawing.Point(22, 84);
			this.cbRoomType.Name = "cbRoomType";
			this.cbRoomType.ShadowDecoration.Parent = this.cbRoomType;
			this.cbRoomType.Size = new System.Drawing.Size(200, 36);
			this.cbRoomType.TabIndex = 15;
			this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label8.Location = new System.Drawing.Point(18, 147);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 21);
			this.label8.TabIndex = 5;
			this.label8.Text = "Kamar:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label10.Location = new System.Drawing.Point(18, 60);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(91, 21);
			this.label10.TabIndex = 4;
			this.label10.Text = "Tipe Kamar:";
			// 
			// guna2GroupBox2
			// 
			this.guna2GroupBox2.Controls.Add(this.btnClose);
			this.guna2GroupBox2.Controls.Add(this.btnAddCustomer);
			this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox2.Location = new System.Drawing.Point(15, 323);
			this.guna2GroupBox2.Name = "guna2GroupBox2";
			this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
			this.guna2GroupBox2.Size = new System.Drawing.Size(244, 202);
			this.guna2GroupBox2.TabIndex = 20;
			this.guna2GroupBox2.Text = "Cari Pelanggan";
			// 
			// btnClose
			// 
			this.btnClose.Animated = true;
			this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnClose.BorderRadius = 10;
			this.btnClose.CheckedState.Parent = this.btnClose;
			this.btnClose.CustomImages.Parent = this.btnClose;
			this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClose.DisabledState.Parent = this.btnClose;
			this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.HoverState.Parent = this.btnClose;
			this.btnClose.Location = new System.Drawing.Point(22, 135);
			this.btnClose.Name = "btnClose";
			this.btnClose.ShadowDecoration.Parent = this.btnClose;
			this.btnClose.Size = new System.Drawing.Size(200, 36);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "Kembali";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnAddCustomer
			// 
			this.btnAddCustomer.Animated = true;
			this.btnAddCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddCustomer.BorderRadius = 10;
			this.btnAddCustomer.CheckedState.Parent = this.btnAddCustomer;
			this.btnAddCustomer.CustomImages.Parent = this.btnAddCustomer;
			this.btnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddCustomer.DisabledState.Parent = this.btnAddCustomer;
			this.btnAddCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
			this.btnAddCustomer.HoverState.Parent = this.btnAddCustomer;
			this.btnAddCustomer.Location = new System.Drawing.Point(22, 72);
			this.btnAddCustomer.Name = "btnAddCustomer";
			this.btnAddCustomer.ShadowDecoration.Parent = this.btnAddCustomer;
			this.btnAddCustomer.Size = new System.Drawing.Size(200, 36);
			this.btnAddCustomer.TabIndex = 10;
			this.btnAddCustomer.Text = "Simpan Perubahan";
			this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.txtPrice);
			this.guna2GroupBox1.Controls.Add(this.label5);
			this.guna2GroupBox1.Controls.Add(this.txtLimitPerson);
			this.guna2GroupBox1.Controls.Add(this.label4);
			this.guna2GroupBox1.Controls.Add(this.txtRoomTypeName);
			this.guna2GroupBox1.Controls.Add(this.label3);
			this.guna2GroupBox1.Controls.Add(this.txbRoomName);
			this.guna2GroupBox1.Controls.Add(this.label2);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox1.Location = new System.Drawing.Point(265, 73);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
			this.guna2GroupBox1.Size = new System.Drawing.Size(233, 452);
			this.guna2GroupBox1.TabIndex = 21;
			this.guna2GroupBox1.Text = "Informasi Tipe Kamar";
			// 
			// txtPrice
			// 
			this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPrice.DefaultText = "";
			this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPrice.DisabledState.Parent = this.txtPrice;
			this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPrice.Enabled = false;
			this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPrice.FocusedState.Parent = this.txtPrice;
			this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.ForeColor = System.Drawing.Color.Black;
			this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPrice.HoverState.Parent = this.txtPrice;
			this.txtPrice.Location = new System.Drawing.Point(17, 356);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.PasswordChar = '\0';
			this.txtPrice.PlaceholderText = "";
			this.txtPrice.SelectedText = "";
			this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
			this.txtPrice.Size = new System.Drawing.Size(200, 36);
			this.txtPrice.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label5.Location = new System.Drawing.Point(13, 332);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 21);
			this.label5.TabIndex = 11;
			this.label5.Text = "Harga:";
			// 
			// txtLimitPerson
			// 
			this.txtLimitPerson.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtLimitPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtLimitPerson.DefaultText = "";
			this.txtLimitPerson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtLimitPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtLimitPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLimitPerson.DisabledState.Parent = this.txtLimitPerson;
			this.txtLimitPerson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLimitPerson.Enabled = false;
			this.txtLimitPerson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtLimitPerson.FocusedState.Parent = this.txtLimitPerson;
			this.txtLimitPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLimitPerson.ForeColor = System.Drawing.Color.Black;
			this.txtLimitPerson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtLimitPerson.HoverState.Parent = this.txtLimitPerson;
			this.txtLimitPerson.Location = new System.Drawing.Point(17, 263);
			this.txtLimitPerson.Name = "txtLimitPerson";
			this.txtLimitPerson.PasswordChar = '\0';
			this.txtLimitPerson.PlaceholderText = "";
			this.txtLimitPerson.SelectedText = "";
			this.txtLimitPerson.ShadowDecoration.Parent = this.txtLimitPerson;
			this.txtLimitPerson.Size = new System.Drawing.Size(200, 36);
			this.txtLimitPerson.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label4.Location = new System.Drawing.Point(13, 239);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(193, 21);
			this.label4.TabIndex = 9;
			this.label4.Text = "Jumlah Maksimum Orang:";
			// 
			// txtRoomTypeName
			// 
			this.txtRoomTypeName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtRoomTypeName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRoomTypeName.DefaultText = "";
			this.txtRoomTypeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtRoomTypeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtRoomTypeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtRoomTypeName.DisabledState.Parent = this.txtRoomTypeName;
			this.txtRoomTypeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtRoomTypeName.Enabled = false;
			this.txtRoomTypeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtRoomTypeName.FocusedState.Parent = this.txtRoomTypeName;
			this.txtRoomTypeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRoomTypeName.ForeColor = System.Drawing.Color.Black;
			this.txtRoomTypeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtRoomTypeName.HoverState.Parent = this.txtRoomTypeName;
			this.txtRoomTypeName.Location = new System.Drawing.Point(17, 172);
			this.txtRoomTypeName.Name = "txtRoomTypeName";
			this.txtRoomTypeName.PasswordChar = '\0';
			this.txtRoomTypeName.PlaceholderText = "";
			this.txtRoomTypeName.SelectedText = "";
			this.txtRoomTypeName.ShadowDecoration.Parent = this.txtRoomTypeName;
			this.txtRoomTypeName.Size = new System.Drawing.Size(200, 36);
			this.txtRoomTypeName.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label3.Location = new System.Drawing.Point(13, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 21);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nama Tipe Kamar:";
			// 
			// txbRoomName
			// 
			this.txbRoomName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbRoomName.DefaultText = "";
			this.txbRoomName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txbRoomName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txbRoomName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txbRoomName.DisabledState.Parent = this.txbRoomName;
			this.txbRoomName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txbRoomName.Enabled = false;
			this.txbRoomName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txbRoomName.FocusedState.Parent = this.txbRoomName;
			this.txbRoomName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbRoomName.ForeColor = System.Drawing.Color.Black;
			this.txbRoomName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txbRoomName.HoverState.Parent = this.txbRoomName;
			this.txbRoomName.Location = new System.Drawing.Point(17, 84);
			this.txbRoomName.Name = "txbRoomName";
			this.txbRoomName.PasswordChar = '\0';
			this.txbRoomName.PlaceholderText = "";
			this.txbRoomName.SelectedText = "";
			this.txbRoomName.ShadowDecoration.Parent = this.txbRoomName;
			this.txbRoomName.Size = new System.Drawing.Size(200, 36);
			this.txbRoomName.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label2.Location = new System.Drawing.Point(13, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nama Kamar:";
			// 
			// FormChangeRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(514, 541);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.guna2GroupBox2);
			this.Controls.Add(this.guna2GroupBox3);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2ControlBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormChangeRoom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Forgot Password";
			this.TopMost = true;
			this.guna2GroupBox3.ResumeLayout(false);
			this.guna2GroupBox3.PerformLayout();
			this.guna2GroupBox2.ResumeLayout(false);
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private System.Windows.Forms.Label label1;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
		private Guna.UI2.WinForms.Guna2ComboBox cbRoomType;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
		private Guna.UI2.WinForms.Guna2Button btnClose;
		private Guna.UI2.WinForms.Guna2Button btnAddCustomer;
		private Guna.UI2.WinForms.Guna2ComboBox cbRoom;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private Guna.UI2.WinForms.Guna2TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2TextBox txtLimitPerson;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox txtRoomTypeName;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txbRoomName;
		private System.Windows.Forms.Label label2;
	}
}