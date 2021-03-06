namespace FAHotelApp.Forms
{
	partial class FormServiceType
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServiceType));
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupServiceType = new System.Windows.Forms.GroupBox();
			this.comboboxID = new MetroFramework.Controls.MetroComboBox();
			this.txbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridViewServiceType = new System.Windows.Forms.DataGridView();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingServiceType = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.saveServiceType = new System.Windows.Forms.SaveFileDialog();
			this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnInsert = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnCLose1 = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnUpdateServiceType = new Bunifu.Framework.UI.BunifuThinButton2();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
			this.groupBox4.SuspendLayout();
			this.groupServiceType.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingServiceType)).BeginInit();
			this.bindingServiceType.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.TransparentWhileDrag = true;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 8;
			this.guna2Elipse1.TargetControl = this;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label1.Location = new System.Drawing.Point(20, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(282, 37);
			this.label1.TabIndex = 55;
			this.label1.Text = "Kelola Jenis Pelayanan";
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
			this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new System.Drawing.Point(1195, 12);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.Size = new System.Drawing.Size(35, 28);
			this.guna2ControlBox2.TabIndex = 57;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtSearch);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.btnSearch);
			this.groupBox4.Controls.Add(this.btnCancel);
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox4.Location = new System.Drawing.Point(21, 67);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(444, 115);
			this.groupBox4.TabIndex = 87;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Cari";
			// 
			// txtSearch
			// 
			this.txtSearch.BackColor = System.Drawing.Color.White;
			this.txtSearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtSearch.BorderThickness = 1;
			this.txtSearch.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtSearch.isPassword = false;
			this.txtSearch.Location = new System.Drawing.Point(19, 58);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
			this.txtSearch.MaxLength = 32767;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(175, 29);
			this.txtSearch.TabIndex = 27;
			this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label5.Location = new System.Drawing.Point(15, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(199, 20);
			this.label5.TabIndex = 28;
			this.label5.Text = "Kode/ Nama Jenis Pelayanan";
			// 
			// groupServiceType
			// 
			this.groupServiceType.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupServiceType.Controls.Add(this.comboboxID);
			this.groupServiceType.Controls.Add(this.txbName);
			this.groupServiceType.Controls.Add(this.label16);
			this.groupServiceType.Controls.Add(this.label15);
			this.groupServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupServiceType.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupServiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupServiceType.Location = new System.Drawing.Point(21, 198);
			this.groupServiceType.Name = "groupServiceType";
			this.groupServiceType.Size = new System.Drawing.Size(220, 224);
			this.groupServiceType.TabIndex = 86;
			this.groupServiceType.TabStop = false;
			this.groupServiceType.Text = "Informasi Jenis Pelayanan";
			// 
			// comboboxID
			// 
			this.comboboxID.FormattingEnabled = true;
			this.comboboxID.ItemHeight = 23;
			this.comboboxID.Location = new System.Drawing.Point(23, 64);
			this.comboboxID.Name = "comboboxID";
			this.comboboxID.Size = new System.Drawing.Size(175, 29);
			this.comboboxID.Style = MetroFramework.MetroColorStyle.Yellow;
			this.comboboxID.TabIndex = 68;
			this.comboboxID.UseSelectable = true;
			// 
			// txbName
			// 
			this.txbName.BackColor = System.Drawing.Color.White;
			this.txbName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbName.BorderThickness = 1;
			this.txbName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txbName.isPassword = false;
			this.txbName.Location = new System.Drawing.Point(23, 140);
			this.txbName.Margin = new System.Windows.Forms.Padding(0);
			this.txbName.MaxLength = 32767;
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(175, 29);
			this.txbName.TabIndex = 61;
			this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label16.Location = new System.Drawing.Point(23, 41);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(152, 20);
			this.label16.TabIndex = 62;
			this.label16.Text = "Kode Jenis Pelayanan:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label15.Location = new System.Drawing.Point(23, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(157, 20);
			this.label15.TabIndex = 63;
			this.label15.Text = "Nama Jenis Pelayanan:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox2.Controls.Add(this.btnInsert);
			this.groupBox2.Controls.Add(this.btnCLose1);
			this.groupBox2.Controls.Add(this.btnUpdateServiceType);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox2.Location = new System.Drawing.Point(245, 198);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(220, 224);
			this.groupBox2.TabIndex = 85;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Menu";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox1.Controls.Add(this.dataGridViewServiceType);
			this.groupBox1.Controls.Add(this.bindingServiceType);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox1.Location = new System.Drawing.Point(491, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(731, 355);
			this.groupBox1.TabIndex = 84;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Daftar Jenis Pelayanan";
			// 
			// dataGridViewServiceType
			// 
			this.dataGridViewServiceType.AllowUserToAddRows = false;
			this.dataGridViewServiceType.AllowUserToDeleteRows = false;
			this.dataGridViewServiceType.AllowUserToResizeRows = false;
			this.dataGridViewServiceType.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewServiceType.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewServiceType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewServiceType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewServiceType.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewServiceType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewServiceType.GridColor = System.Drawing.Color.White;
			this.dataGridViewServiceType.Location = new System.Drawing.Point(3, 68);
			this.dataGridViewServiceType.Name = "dataGridViewServiceType";
			this.dataGridViewServiceType.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewServiceType.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewServiceType.RowHeadersVisible = false;
			this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewServiceType.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewServiceType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewServiceType.Size = new System.Drawing.Size(725, 284);
			this.dataGridViewServiceType.TabIndex = 30;
			this.dataGridViewServiceType.SelectionChanged += new System.EventHandler(this.DataGridViewServiceType_SelectionChanged);
			// 
			// colID
			// 
			this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colID.DataPropertyName = "id";
			this.colID.HeaderText = "Kode Jenis Pelayanan";
			this.colID.Name = "colID";
			this.colID.ReadOnly = true;
			this.colID.Width = 166;
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.DataPropertyName = "name";
			this.colName.FillWeight = 90F;
			this.colName.HeaderText = "Nama Jenis Pelayanan";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// bindingServiceType
			// 
			this.bindingServiceType.AddNewItem = null;
			this.bindingServiceType.AutoSize = false;
			this.bindingServiceType.BackColor = System.Drawing.Color.Transparent;
			this.bindingServiceType.CountItem = this.bindingNavigatorCountItem;
			this.bindingServiceType.CountItemFormat = "Dari {0}";
			this.bindingServiceType.DeleteItem = null;
			this.bindingServiceType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindingServiceType.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bindingServiceType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripLabel1});
			this.bindingServiceType.Location = new System.Drawing.Point(3, 25);
			this.bindingServiceType.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingServiceType.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingServiceType.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingServiceType.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingServiceType.Name = "bindingServiceType";
			this.bindingServiceType.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingServiceType.Size = new System.Drawing.Size(725, 43);
			this.bindingServiceType.TabIndex = 29;
			this.bindingServiceType.Text = "binding";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(51, 40);
			this.bindingNavigatorCountItem.Text = "Dari {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Tổng số khách hàng";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Vị trí khách hàng";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(48, 40);
			this.toolStripLabel1.Text = "Ekspor";
			this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
			// 
			// saveServiceType
			// 
			this.saveServiceType.FileName = "Danh sách loại dịch vụ";
			this.saveServiceType.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
			// 
			// btnSearch
			// 
			this.btnSearch.ActiveBorderThickness = 1;
			this.btnSearch.ActiveCornerRadius = 20;
			this.btnSearch.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
			this.btnSearch.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
			this.btnSearch.ButtonText = "Cari";
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSearch.IdleBorderThickness = 1;
			this.btnSearch.IdleCornerRadius = 20;
			this.btnSearch.IdleFillColor = System.Drawing.Color.White;
			this.btnSearch.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSearch.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSearch.Location = new System.Drawing.Point(247, 50);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(175, 40);
			this.btnSearch.TabIndex = 46;
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancel
			// 
			this.btnCancel.ActiveBorderThickness = 1;
			this.btnCancel.ActiveCornerRadius = 20;
			this.btnCancel.ActiveFillColor = System.Drawing.Color.Red;
			this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
			this.btnCancel.ActiveLineColor = System.Drawing.Color.Red;
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
			this.btnCancel.ButtonText = "Batalkan Pencarian";
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnCancel.IdleBorderThickness = 1;
			this.btnCancel.IdleCornerRadius = 20;
			this.btnCancel.IdleFillColor = System.Drawing.Color.White;
			this.btnCancel.IdleForecolor = System.Drawing.Color.Red;
			this.btnCancel.IdleLineColor = System.Drawing.Color.Red;
			this.btnCancel.Location = new System.Drawing.Point(247, 50);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(175, 40);
			this.btnCancel.TabIndex = 47;
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.Visible = false;
			// 
			// btnInsert
			// 
			this.btnInsert.ActiveBorderThickness = 1;
			this.btnInsert.ActiveCornerRadius = 20;
			this.btnInsert.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnInsert.ActiveForecolor = System.Drawing.Color.White;
			this.btnInsert.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
			this.btnInsert.ButtonText = "Tambah";
			this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnInsert.IdleBorderThickness = 1;
			this.btnInsert.IdleCornerRadius = 20;
			this.btnInsert.IdleFillColor = System.Drawing.Color.White;
			this.btnInsert.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnInsert.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnInsert.Location = new System.Drawing.Point(23, 29);
			this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(175, 40);
			this.btnInsert.TabIndex = 53;
			this.btnInsert.TabStop = false;
			this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
			// 
			// btnCLose1
			// 
			this.btnCLose1.ActiveBorderThickness = 1;
			this.btnCLose1.ActiveCornerRadius = 20;
			this.btnCLose1.ActiveFillColor = System.Drawing.Color.DarkOrange;
			this.btnCLose1.ActiveForecolor = System.Drawing.Color.White;
			this.btnCLose1.ActiveLineColor = System.Drawing.Color.DarkOrange;
			this.btnCLose1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.btnCLose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCLose1.BackgroundImage")));
			this.btnCLose1.ButtonText = "Kembali";
			this.btnCLose1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCLose1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCLose1.ForeColor = System.Drawing.Color.DarkOrange;
			this.btnCLose1.IdleBorderThickness = 1;
			this.btnCLose1.IdleCornerRadius = 20;
			this.btnCLose1.IdleFillColor = System.Drawing.Color.White;
			this.btnCLose1.IdleForecolor = System.Drawing.Color.DarkOrange;
			this.btnCLose1.IdleLineColor = System.Drawing.Color.DarkOrange;
			this.btnCLose1.Location = new System.Drawing.Point(23, 160);
			this.btnCLose1.Margin = new System.Windows.Forms.Padding(4);
			this.btnCLose1.Name = "btnCLose1";
			this.btnCLose1.Size = new System.Drawing.Size(175, 40);
			this.btnCLose1.TabIndex = 56;
			this.btnCLose1.TabStop = false;
			this.btnCLose1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCLose1.Click += new System.EventHandler(this.BtnCLose1_Click);
			// 
			// btnUpdateServiceType
			// 
			this.btnUpdateServiceType.ActiveBorderThickness = 1;
			this.btnUpdateServiceType.ActiveCornerRadius = 20;
			this.btnUpdateServiceType.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdateServiceType.ActiveForecolor = System.Drawing.Color.White;
			this.btnUpdateServiceType.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdateServiceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.btnUpdateServiceType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateServiceType.BackgroundImage")));
			this.btnUpdateServiceType.ButtonText = "Update";
			this.btnUpdateServiceType.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdateServiceType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateServiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdateServiceType.IdleBorderThickness = 1;
			this.btnUpdateServiceType.IdleCornerRadius = 20;
			this.btnUpdateServiceType.IdleFillColor = System.Drawing.Color.White;
			this.btnUpdateServiceType.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdateServiceType.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdateServiceType.Location = new System.Drawing.Point(23, 94);
			this.btnUpdateServiceType.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdateServiceType.Name = "btnUpdateServiceType";
			this.btnUpdateServiceType.Size = new System.Drawing.Size(175, 40);
			this.btnUpdateServiceType.TabIndex = 55;
			this.btnUpdateServiceType.TabStop = false;
			this.btnUpdateServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnUpdateServiceType.Click += new System.EventHandler(this.BtnUpdateServiceType_Click);
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.AutoSize = false;
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(50, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			this.bindingNavigatorMoveFirstItem.ToolTipText = "Khách hàng đầu tiên";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.AutoSize = false;
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(50, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			this.bindingNavigatorMovePreviousItem.ToolTipText = "Khách hàng trước đó";
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.AutoSize = false;
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(50, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			this.bindingNavigatorMoveNextItem.ToolTipText = "Khách hàng kế tiếp";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.AutoSize = false;
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(50, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			this.bindingNavigatorMoveLastItem.ToolTipText = "Khách hàng cuối cùng";
			// 
			// bunifuSeparator1
			// 
			this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
			this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
			this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
			this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
			this.bunifuSeparator1.LineThickness = 1;
			this.bunifuSeparator1.Location = new System.Drawing.Point(21, 46);
			this.bunifuSeparator1.Name = "bunifuSeparator1";
			this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
			this.bunifuSeparator1.Size = new System.Drawing.Size(1201, 15);
			this.bunifuSeparator1.TabIndex = 56;
			// 
			// FormServiceType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(1242, 445);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupServiceType);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.guna2ControlBox2);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormServiceType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormServiceType";
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupServiceType.ResumeLayout(false);
			this.groupServiceType.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingServiceType)).EndInit();
			this.bindingServiceType.ResumeLayout(false);
			this.bindingServiceType.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
		private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
		private System.Windows.Forms.GroupBox groupServiceType;
		private MetroFramework.Controls.MetroComboBox comboboxID;
		private Bunifu.Framework.UI.BunifuMetroTextbox txbName;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.GroupBox groupBox2;
		private Bunifu.Framework.UI.BunifuThinButton2 btnInsert;
		private Bunifu.Framework.UI.BunifuThinButton2 btnCLose1;
		private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateServiceType;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.BindingNavigator bindingServiceType;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.DataGridView dataGridViewServiceType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.SaveFileDialog saveServiceType;
	}
}