namespace FAHotelApp.Forms
{
	partial class FormAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccess));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeftAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeft = new Guna.UI2.WinForms.Guna2Button();
            this.btnRight = new Guna.UI2.WinForms.Guna2Button();
            this.btnRightAll = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnInsertStaffType = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbStaffType = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAccessRest = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupService = new System.Windows.Forms.GroupBox();
            this.dataGridViewAccessNow = new System.Windows.Forms.DataGridView();
            this.colAccessNow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdNow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessRest)).BeginInit();
            this.groupService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessNow)).BeginInit();
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(673, 12);
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
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hak Akses";
            // 
            // btnLeftAll
            // 
            this.btnLeftAll.Animated = true;
            this.btnLeftAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnLeftAll.BorderRadius = 10;
            this.btnLeftAll.CheckedState.Parent = this.btnLeftAll;
            this.btnLeftAll.CustomImages.Parent = this.btnLeftAll;
            this.btnLeftAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeftAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeftAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeftAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeftAll.DisabledState.Parent = this.btnLeftAll;
            this.btnLeftAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnLeftAll.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnLeftAll.ForeColor = System.Drawing.Color.White;
            this.btnLeftAll.HoverState.Parent = this.btnLeftAll;
            this.btnLeftAll.Location = new System.Drawing.Point(334, 324);
            this.btnLeftAll.Name = "btnLeftAll";
            this.btnLeftAll.ShadowDecoration.Parent = this.btnLeftAll;
            this.btnLeftAll.Size = new System.Drawing.Size(53, 36);
            this.btnLeftAll.TabIndex = 27;
            this.btnLeftAll.Text = "<<";
            this.btnLeftAll.Click += new System.EventHandler(this.btnLeftAll_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Animated = true;
            this.btnLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnLeft.BorderRadius = 10;
            this.btnLeft.CheckedState.Parent = this.btnLeft;
            this.btnLeft.CustomImages.Parent = this.btnLeft;
            this.btnLeft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeft.DisabledState.Parent = this.btnLeft;
            this.btnLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.HoverState.Parent = this.btnLeft;
            this.btnLeft.Location = new System.Drawing.Point(334, 366);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.ShadowDecoration.Parent = this.btnLeft;
            this.btnLeft.Size = new System.Drawing.Size(53, 36);
            this.btnLeft.TabIndex = 28;
            this.btnLeft.Text = "<";
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Animated = true;
            this.btnRight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnRight.BorderRadius = 10;
            this.btnRight.CheckedState.Parent = this.btnRight;
            this.btnRight.CustomImages.Parent = this.btnRight;
            this.btnRight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRight.DisabledState.Parent = this.btnRight;
            this.btnRight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.HoverState.Parent = this.btnRight;
            this.btnRight.Location = new System.Drawing.Point(334, 476);
            this.btnRight.Name = "btnRight";
            this.btnRight.ShadowDecoration.Parent = this.btnRight;
            this.btnRight.Size = new System.Drawing.Size(53, 36);
            this.btnRight.TabIndex = 30;
            this.btnRight.Text = ">";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRightAll
            // 
            this.btnRightAll.Animated = true;
            this.btnRightAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnRightAll.BorderRadius = 10;
            this.btnRightAll.CheckedState.Parent = this.btnRightAll;
            this.btnRightAll.CustomImages.Parent = this.btnRightAll;
            this.btnRightAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRightAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRightAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRightAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRightAll.DisabledState.Parent = this.btnRightAll;
            this.btnRightAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnRightAll.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnRightAll.ForeColor = System.Drawing.Color.White;
            this.btnRightAll.HoverState.Parent = this.btnRightAll;
            this.btnRightAll.Location = new System.Drawing.Point(334, 518);
            this.btnRightAll.Name = "btnRightAll";
            this.btnRightAll.ShadowDecoration.Parent = this.btnRightAll;
            this.btnRightAll.Size = new System.Drawing.Size(53, 36);
            this.btnRightAll.TabIndex = 29;
            this.btnRightAll.Text = ">>";
            this.btnRightAll.Click += new System.EventHandler(this.btnRightAll_Click);
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(689, 15);
            this.bunifuSeparator1.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.btnInsertStaffType);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.cbStaffType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.groupBox3.Location = new System.Drawing.Point(15, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(689, 158);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipe Karyawan";
            // 
            // btnBack
            // 
            this.btnBack.ActiveBorderThickness = 1;
            this.btnBack.ActiveCornerRadius = 20;
            this.btnBack.ActiveFillColor = System.Drawing.Color.Red;
            this.btnBack.ActiveForecolor = System.Drawing.Color.White;
            this.btnBack.ActiveLineColor = System.Drawing.Color.Red;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.ButtonText = "Kembali";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.IdleBorderThickness = 1;
            this.btnBack.IdleCornerRadius = 20;
            this.btnBack.IdleFillColor = System.Drawing.Color.White;
            this.btnBack.IdleForecolor = System.Drawing.Color.Red;
            this.btnBack.IdleLineColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(470, 95);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 40);
            this.btnBack.TabIndex = 55;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsertStaffType
            // 
            this.btnInsertStaffType.ActiveBorderThickness = 1;
            this.btnInsertStaffType.ActiveCornerRadius = 20;
            this.btnInsertStaffType.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnInsertStaffType.ActiveForecolor = System.Drawing.Color.White;
            this.btnInsertStaffType.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnInsertStaffType.BackColor = System.Drawing.Color.White;
            this.btnInsertStaffType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertStaffType.BackgroundImage")));
            this.btnInsertStaffType.ButtonText = "Tambah Baru";
            this.btnInsertStaffType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertStaffType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertStaffType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnInsertStaffType.IdleBorderThickness = 1;
            this.btnInsertStaffType.IdleCornerRadius = 20;
            this.btnInsertStaffType.IdleFillColor = System.Drawing.Color.White;
            this.btnInsertStaffType.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnInsertStaffType.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnInsertStaffType.Location = new System.Drawing.Point(470, 31);
            this.btnInsertStaffType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertStaffType.Name = "btnInsertStaffType";
            this.btnInsertStaffType.Size = new System.Drawing.Size(175, 40);
            this.btnInsertStaffType.TabIndex = 54;
            this.btnInsertStaffType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsertStaffType.Click += new System.EventHandler(this.btnInsertStaffType_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnUpdate.Location = new System.Drawing.Point(254, 31);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 40);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbStaffType
            // 
            this.cbStaffType.BackColor = System.Drawing.Color.White;
            this.cbStaffType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStaffType.FormattingEnabled = true;
            this.cbStaffType.ItemHeight = 23;
            this.cbStaffType.Location = new System.Drawing.Point(42, 77);
            this.cbStaffType.Name = "cbStaffType";
            this.cbStaffType.Size = new System.Drawing.Size(175, 29);
            this.cbStaffType.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbStaffType.TabIndex = 51;
            this.cbStaffType.UseCustomBackColor = true;
            this.cbStaffType.UseCustomForeColor = true;
            this.cbStaffType.UseSelectable = true;
            this.cbStaffType.UseStyleColors = true;
            this.cbStaffType.SelectedIndexChanged += new System.EventHandler(this.cbStaffType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label5.Location = new System.Drawing.Point(38, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nama Tipe Karyawan:";
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Hapus";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDelete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnDelete.Location = new System.Drawing.Point(254, 95);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(175, 40);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAccessRest);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.groupBox1.Location = new System.Drawing.Point(420, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 374);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hak Yang Tersisa";
            // 
            // dataGridViewAccessRest
            // 
            this.dataGridViewAccessRest.AllowUserToAddRows = false;
            this.dataGridViewAccessRest.AllowUserToDeleteRows = false;
            this.dataGridViewAccessRest.AllowUserToResizeRows = false;
            this.dataGridViewAccessRest.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAccessRest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccessRest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccessRest.ColumnHeadersHeight = 29;
            this.dataGridViewAccessRest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAccessRest.ColumnHeadersVisible = false;
            this.dataGridViewAccessRest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colIdRest});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccessRest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAccessRest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccessRest.GridColor = System.Drawing.Color.White;
            this.dataGridViewAccessRest.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewAccessRest.Name = "dataGridViewAccessRest";
            this.dataGridViewAccessRest.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccessRest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAccessRest.RowHeadersVisible = false;
            this.dataGridViewAccessRest.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewAccessRest.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewAccessRest.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewAccessRest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccessRest.Size = new System.Drawing.Size(282, 346);
            this.dataGridViewAccessRest.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colIdRest
            // 
            this.colIdRest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIdRest.DataPropertyName = "Id";
            this.colIdRest.HeaderText = "Column1";
            this.colIdRest.Name = "colIdRest";
            this.colIdRest.ReadOnly = true;
            this.colIdRest.Visible = false;
            // 
            // groupService
            // 
            this.groupService.Controls.Add(this.dataGridViewAccessNow);
            this.groupService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupService.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.groupService.Location = new System.Drawing.Point(15, 247);
            this.groupService.Name = "groupService";
            this.groupService.Size = new System.Drawing.Size(286, 374);
            this.groupService.TabIndex = 69;
            this.groupService.TabStop = false;
            this.groupService.Text = "Hak Saat Ini";
            // 
            // dataGridViewAccessNow
            // 
            this.dataGridViewAccessNow.AllowUserToAddRows = false;
            this.dataGridViewAccessNow.AllowUserToDeleteRows = false;
            this.dataGridViewAccessNow.AllowUserToResizeRows = false;
            this.dataGridViewAccessNow.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAccessNow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccessNow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAccessNow.ColumnHeadersHeight = 29;
            this.dataGridViewAccessNow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAccessNow.ColumnHeadersVisible = false;
            this.dataGridViewAccessNow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccessNow,
            this.colIdNow});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccessNow.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAccessNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccessNow.GridColor = System.Drawing.Color.White;
            this.dataGridViewAccessNow.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewAccessNow.Name = "dataGridViewAccessNow";
            this.dataGridViewAccessNow.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccessNow.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAccessNow.RowHeadersVisible = false;
            this.dataGridViewAccessNow.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewAccessNow.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewAccessNow.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewAccessNow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccessNow.Size = new System.Drawing.Size(280, 346);
            this.dataGridViewAccessNow.TabIndex = 29;
            // 
            // colAccessNow
            // 
            this.colAccessNow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAccessNow.DataPropertyName = "name";
            this.colAccessNow.HeaderText = "Column1";
            this.colAccessNow.Name = "colAccessNow";
            this.colAccessNow.ReadOnly = true;
            // 
            // colIdNow
            // 
            this.colIdNow.DataPropertyName = "id";
            this.colIdNow.HeaderText = "Column2";
            this.colIdNow.Name = "colIdNow";
            this.colIdNow.ReadOnly = true;
            this.colIdNow.Visible = false;
            // 
            // FormAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupService);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnRightAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnLeftAll);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hak Akses";
            this.TopMost = true;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessRest)).EndInit();
            this.groupService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessNow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private System.Windows.Forms.Label label1;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
		private Guna.UI2.WinForms.Guna2Button btnRight;
		private Guna.UI2.WinForms.Guna2Button btnRightAll;
		private Guna.UI2.WinForms.Guna2Button btnLeft;
		private Guna.UI2.WinForms.Guna2Button btnLeftAll;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridViewAccessRest;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdRest;
		private System.Windows.Forms.GroupBox groupService;
		private System.Windows.Forms.DataGridView dataGridViewAccessNow;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAccessNow;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdNow;
		private System.Windows.Forms.GroupBox groupBox3;
		private Bunifu.Framework.UI.BunifuThinButton2 btnBack;
		private Bunifu.Framework.UI.BunifuThinButton2 btnInsertStaffType;
		private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
		private MetroFramework.Controls.MetroComboBox cbStaffType;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
	}
}