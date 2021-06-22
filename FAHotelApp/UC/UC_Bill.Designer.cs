namespace FAHotelApp.UC
{
	partial class UC_Bill
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

		#region Component Designer generated code

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Bill));
			this.SaveCustomer = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridViewBill = new System.Windows.Forms.DataGridView();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colIdReciveRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStaffsetUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.coldDateOfCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingBill = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
			this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
			this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.cbBillSearch = new MetroFramework.Controls.MetroComboBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btnSeenBill = new Bunifu.Framework.UI.BunifuThinButton2();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.comboboxID = new MetroFramework.Controls.MetroComboBox();
			this.txbUser = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label6 = new System.Windows.Forms.Label();
			this.txbDateCreate = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.groupCustomer = new System.Windows.Forms.GroupBox();
			this.txbFinalPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbDiscount = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbStatusRoom = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label4 = new System.Windows.Forms.Label();
			this.txbPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingBill)).BeginInit();
			this.bindingBill.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupCustomer.SuspendLayout();
			this.SuspendLayout();
			// 
			// SaveCustomer
			// 
			this.SaveCustomer.FileName = "Danh Sách Khách hàng";
			this.SaveCustomer.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox1.Controls.Add(this.dataGridViewBill);
			this.groupBox1.Controls.Add(this.bindingBill);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox1.Location = new System.Drawing.Point(491, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(731, 661);
			this.groupBox1.TabIndex = 39;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Daftar Pelanggan";
			// 
			// dataGridViewBill
			// 
			this.dataGridViewBill.AllowUserToAddRows = false;
			this.dataGridViewBill.AllowUserToDeleteRows = false;
			this.dataGridViewBill.AllowUserToResizeRows = false;
			this.dataGridViewBill.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewBill.ColumnHeadersHeight = 29;
			this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colIdReciveRoom,
            this.colCustomerName,
            this.colStaffsetUp,
            this.coldDateOfCreate,
            this.colStatus,
            this.colPrice,
            this.Column1,
            this.Column2});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewBill.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewBill.GridColor = System.Drawing.Color.White;
			this.dataGridViewBill.Location = new System.Drawing.Point(3, 68);
			this.dataGridViewBill.Name = "dataGridViewBill";
			this.dataGridViewBill.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewBill.RowHeadersVisible = false;
			this.dataGridViewBill.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewBill.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dataGridViewBill.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewBill.Size = new System.Drawing.Size(725, 590);
			this.dataGridViewBill.TabIndex = 30;
			// 
			// colID
			// 
			this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.colID.DataPropertyName = "id";
			this.colID.FillWeight = 30F;
			this.colID.HeaderText = "Kode Tagihan";
			this.colID.Name = "colID";
			this.colID.ReadOnly = true;
			this.colID.Width = 127;
			// 
			// colIdReciveRoom
			// 
			this.colIdReciveRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.colIdReciveRoom.DataPropertyName = "roomName";
			this.colIdReciveRoom.FillWeight = 30F;
			this.colIdReciveRoom.HeaderText = "Nama Kamar";
			this.colIdReciveRoom.Name = "colIdReciveRoom";
			this.colIdReciveRoom.ReadOnly = true;
			this.colIdReciveRoom.Width = 126;
			// 
			// colCustomerName
			// 
			this.colCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.colCustomerName.DataPropertyName = "customername";
			this.colCustomerName.HeaderText = "Nama Customer";
			this.colCustomerName.Name = "colCustomerName";
			this.colCustomerName.ReadOnly = true;
			this.colCustomerName.Width = 149;
			// 
			// colStaffsetUp
			// 
			this.colStaffsetUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colStaffsetUp.DataPropertyName = "StaffSetUp";
			this.colStaffsetUp.FillWeight = 30F;
			this.colStaffsetUp.HeaderText = "Tanggal Dibuat";
			this.colStaffsetUp.Name = "colStaffsetUp";
			this.colStaffsetUp.ReadOnly = true;
			this.colStaffsetUp.Visible = false;
			this.colStaffsetUp.Width = 138;
			// 
			// coldDateOfCreate
			// 
			this.coldDateOfCreate.DataPropertyName = "DateOfCreate";
			this.coldDateOfCreate.FillWeight = 30F;
			this.coldDateOfCreate.HeaderText = "Status";
			this.coldDateOfCreate.Name = "coldDateOfCreate";
			this.coldDateOfCreate.ReadOnly = true;
			// 
			// colStatus
			// 
			this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colStatus.DataPropertyName = "name";
			this.colStatus.HeaderText = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.ReadOnly = true;
			this.colStatus.Width = 77;
			// 
			// colPrice
			// 
			this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colPrice.DataPropertyName = "TotalPrice";
			this.colPrice.FillWeight = 30F;
			this.colPrice.HeaderText = "Harga Awal";
			this.colPrice.Name = "colPrice";
			this.colPrice.ReadOnly = true;
			this.colPrice.Width = 115;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "discount";
			this.Column1.HeaderText = "Diskon";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 50;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.DataPropertyName = "finalPrice";
			this.Column2.HeaderText = "Harga Akhir";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// bindingBill
			// 
			this.bindingBill.AddNewItem = null;
			this.bindingBill.AutoSize = false;
			this.bindingBill.BackColor = System.Drawing.Color.Transparent;
			this.bindingBill.CountItem = this.bindingNavigatorCountItem;
			this.bindingBill.CountItemFormat = "Dari {0}";
			this.bindingBill.DeleteItem = null;
			this.bindingBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindingBill.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bindingBill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
			this.bindingBill.Location = new System.Drawing.Point(3, 25);
			this.bindingBill.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingBill.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingBill.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingBill.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingBill.Name = "bindingBill";
			this.bindingBill.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingBill.Size = new System.Drawing.Size(725, 43);
			this.bindingBill.TabIndex = 29;
			this.bindingBill.Text = "binding";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(51, 40);
			this.bindingNavigatorCountItem.Text = "Dari {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Tổng số khách hàng";
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
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label1.Location = new System.Drawing.Point(20, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 37);
			this.label1.TabIndex = 53;
			this.label1.Text = "Kelola Tagihan";
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
			this.bunifuSeparator1.TabIndex = 54;
			// 
			// btnCancel
			// 
			this.btnCancel.ActiveBorderThickness = 1;
			this.btnCancel.ActiveCornerRadius = 20;
			this.btnCancel.ActiveFillColor = System.Drawing.Color.Red;
			this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
			this.btnCancel.ActiveLineColor = System.Drawing.Color.Red;
			this.btnCancel.BackColor = System.Drawing.Color.White;
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
			this.btnCancel.Location = new System.Drawing.Point(235, 67);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(175, 40);
			this.btnCancel.TabIndex = 49;
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label5.Location = new System.Drawing.Point(27, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 26);
			this.label5.TabIndex = 28;
			this.label5.Text = "Cari Menurut:";
			// 
			// btnSearch
			// 
			this.btnSearch.ActiveBorderThickness = 1;
			this.btnSearch.ActiveCornerRadius = 20;
			this.btnSearch.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
			this.btnSearch.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSearch.BackColor = System.Drawing.Color.White;
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
			this.btnSearch.Location = new System.Drawing.Point(235, 71);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(175, 40);
			this.btnSearch.TabIndex = 46;
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtSearch.BorderThickness = 1;
			this.txtSearch.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtSearch.isPassword = false;
			this.txtSearch.Location = new System.Drawing.Point(235, 29);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearch.MaxLength = 32767;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(175, 29);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbSearch_KeyPress);
			// 
			// cbBillSearch
			// 
			this.cbBillSearch.BackColor = System.Drawing.Color.White;
			this.cbBillSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbBillSearch.FormattingEnabled = true;
			this.cbBillSearch.ItemHeight = 23;
			this.cbBillSearch.Items.AddRange(new object[] {
            "Kode Customer",
            "Nama Customer",
            "NIK",
            "Nomor Telepon"});
			this.cbBillSearch.Location = new System.Drawing.Point(31, 71);
			this.cbBillSearch.Name = "cbBillSearch";
			this.cbBillSearch.Size = new System.Drawing.Size(175, 29);
			this.cbBillSearch.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbBillSearch.TabIndex = 50;
			this.cbBillSearch.UseCustomBackColor = true;
			this.cbBillSearch.UseCustomForeColor = true;
			this.cbBillSearch.UseSelectable = true;
			this.cbBillSearch.UseStyleColors = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox5.Controls.Add(this.cbBillSearch);
			this.groupBox5.Controls.Add(this.txtSearch);
			this.groupBox5.Controls.Add(this.btnSearch);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.btnCancel);
			this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox5.Location = new System.Drawing.Point(21, 67);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(444, 119);
			this.groupBox5.TabIndex = 61;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Cari";
			// 
			// btnSeenBill
			// 
			this.btnSeenBill.ActiveBorderThickness = 1;
			this.btnSeenBill.ActiveCornerRadius = 20;
			this.btnSeenBill.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSeenBill.ActiveForecolor = System.Drawing.Color.White;
			this.btnSeenBill.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSeenBill.BackColor = System.Drawing.Color.White;
			this.btnSeenBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeenBill.BackgroundImage")));
			this.btnSeenBill.ButtonText = "Detail Tagihan";
			this.btnSeenBill.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSeenBill.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeenBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSeenBill.IdleBorderThickness = 1;
			this.btnSeenBill.IdleCornerRadius = 20;
			this.btnSeenBill.IdleFillColor = System.Drawing.Color.White;
			this.btnSeenBill.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSeenBill.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSeenBill.Location = new System.Drawing.Point(34, 48);
			this.btnSeenBill.Margin = new System.Windows.Forms.Padding(4);
			this.btnSeenBill.Name = "btnSeenBill";
			this.btnSeenBill.Size = new System.Drawing.Size(175, 40);
			this.btnSeenBill.TabIndex = 51;
			this.btnSeenBill.TabStop = false;
			this.btnSeenBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSeenBill.Click += new System.EventHandler(this.BtnSeenBill_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox4.Controls.Add(this.btnSeenBill);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox4.Location = new System.Drawing.Point(21, 605);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(444, 123);
			this.groupBox4.TabIndex = 62;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Menu";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label20.Location = new System.Drawing.Point(31, 205);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(160, 20);
			this.label20.TabIndex = 75;
			this.label20.Text = "Dibuat Oleh Karyawan:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label15.Location = new System.Drawing.Point(31, 119);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(114, 20);
			this.label15.TabIndex = 73;
			this.label15.Text = "Nama Ruangan:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label16.Location = new System.Drawing.Point(31, 41);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(102, 20);
			this.label16.TabIndex = 72;
			this.label16.Text = "Kode Tagihan:";
			// 
			// txbName
			// 
			this.txbName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbName.BorderThickness = 1;
			this.txbName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbName.Enabled = false;
			this.txbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txbName.isPassword = false;
			this.txbName.Location = new System.Drawing.Point(31, 140);
			this.txbName.Margin = new System.Windows.Forms.Padding(0);
			this.txbName.MaxLength = 32767;
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(175, 29);
			this.txbName.TabIndex = 71;
			this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// comboboxID
			// 
			this.comboboxID.FormattingEnabled = true;
			this.comboboxID.ItemHeight = 23;
			this.comboboxID.Location = new System.Drawing.Point(31, 64);
			this.comboboxID.Name = "comboboxID";
			this.comboboxID.Size = new System.Drawing.Size(175, 29);
			this.comboboxID.Style = MetroFramework.MetroColorStyle.Yellow;
			this.comboboxID.TabIndex = 77;
			this.comboboxID.UseSelectable = true;
			// 
			// txbUser
			// 
			this.txbUser.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbUser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbUser.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbUser.BorderThickness = 1;
			this.txbUser.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbUser.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbUser.Enabled = false;
			this.txbUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txbUser.isPassword = false;
			this.txbUser.Location = new System.Drawing.Point(31, 229);
			this.txbUser.Margin = new System.Windows.Forms.Padding(0);
			this.txbUser.MaxLength = 32767;
			this.txbUser.Name = "txbUser";
			this.txbUser.Size = new System.Drawing.Size(175, 29);
			this.txbUser.TabIndex = 78;
			this.txbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label6.Location = new System.Drawing.Point(31, 300);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(113, 20);
			this.label6.TabIndex = 79;
			this.label6.Text = "Tanggal Dibuat:";
			// 
			// txbDateCreate
			// 
			this.txbDateCreate.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbDateCreate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbDateCreate.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbDateCreate.BorderThickness = 1;
			this.txbDateCreate.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbDateCreate.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbDateCreate.Enabled = false;
			this.txbDateCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbDateCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txbDateCreate.isPassword = false;
			this.txbDateCreate.Location = new System.Drawing.Point(31, 320);
			this.txbDateCreate.Margin = new System.Windows.Forms.Padding(0);
			this.txbDateCreate.MaxLength = 32767;
			this.txbDateCreate.Name = "txbDateCreate";
			this.txbDateCreate.Size = new System.Drawing.Size(175, 29);
			this.txbDateCreate.TabIndex = 80;
			this.txbDateCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// groupCustomer
			// 
			this.groupCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupCustomer.Controls.Add(this.txbFinalPrice);
			this.groupCustomer.Controls.Add(this.label3);
			this.groupCustomer.Controls.Add(this.txbDiscount);
			this.groupCustomer.Controls.Add(this.label2);
			this.groupCustomer.Controls.Add(this.txbStatusRoom);
			this.groupCustomer.Controls.Add(this.label4);
			this.groupCustomer.Controls.Add(this.txbDateCreate);
			this.groupCustomer.Controls.Add(this.label6);
			this.groupCustomer.Controls.Add(this.txbUser);
			this.groupCustomer.Controls.Add(this.comboboxID);
			this.groupCustomer.Controls.Add(this.txbName);
			this.groupCustomer.Controls.Add(this.txbPrice);
			this.groupCustomer.Controls.Add(this.label16);
			this.groupCustomer.Controls.Add(this.label15);
			this.groupCustomer.Controls.Add(this.label13);
			this.groupCustomer.Controls.Add(this.label20);
			this.groupCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupCustomer.Location = new System.Drawing.Point(21, 192);
			this.groupCustomer.Name = "groupCustomer";
			this.groupCustomer.Size = new System.Drawing.Size(444, 400);
			this.groupCustomer.TabIndex = 38;
			this.groupCustomer.TabStop = false;
			this.groupCustomer.Text = "Informasi Tagihan";
			// 
			// txbFinalPrice
			// 
			this.txbFinalPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbFinalPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbFinalPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbFinalPrice.BorderThickness = 1;
			this.txbFinalPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbFinalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbFinalPrice.Enabled = false;
			this.txbFinalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbFinalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txbFinalPrice.isPassword = false;
			this.txbFinalPrice.Location = new System.Drawing.Point(230, 320);
			this.txbFinalPrice.Margin = new System.Windows.Forms.Padding(0);
			this.txbFinalPrice.MaxLength = 32767;
			this.txbFinalPrice.Name = "txbFinalPrice";
			this.txbFinalPrice.Size = new System.Drawing.Size(175, 29);
			this.txbFinalPrice.TabIndex = 86;
			this.txbFinalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label3.Location = new System.Drawing.Point(230, 297);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 20);
			this.label3.TabIndex = 85;
			this.label3.Text = "Harga Akhir:";
			// 
			// txbDiscount
			// 
			this.txbDiscount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbDiscount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbDiscount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbDiscount.BorderThickness = 1;
			this.txbDiscount.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbDiscount.Enabled = false;
			this.txbDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txbDiscount.isPassword = false;
			this.txbDiscount.Location = new System.Drawing.Point(230, 229);
			this.txbDiscount.Margin = new System.Windows.Forms.Padding(0);
			this.txbDiscount.MaxLength = 32767;
			this.txbDiscount.Name = "txbDiscount";
			this.txbDiscount.Size = new System.Drawing.Size(175, 29);
			this.txbDiscount.TabIndex = 84;
			this.txbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label2.Location = new System.Drawing.Point(230, 206);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 20);
			this.label2.TabIndex = 83;
			this.label2.Text = "Diskon:";
			// 
			// txbStatusRoom
			// 
			this.txbStatusRoom.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbStatusRoom.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbStatusRoom.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbStatusRoom.BorderThickness = 1;
			this.txbStatusRoom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbStatusRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbStatusRoom.Enabled = false;
			this.txbStatusRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbStatusRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txbStatusRoom.isPassword = false;
			this.txbStatusRoom.Location = new System.Drawing.Point(230, 61);
			this.txbStatusRoom.Margin = new System.Windows.Forms.Padding(0);
			this.txbStatusRoom.MaxLength = 32767;
			this.txbStatusRoom.Name = "txbStatusRoom";
			this.txbStatusRoom.Size = new System.Drawing.Size(175, 29);
			this.txbStatusRoom.TabIndex = 82;
			this.txbStatusRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label4.Location = new System.Drawing.Point(230, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 20);
			this.label4.TabIndex = 81;
			this.label4.Text = "Status:";
			// 
			// txbPrice
			// 
			this.txbPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txbPrice.BorderThickness = 1;
			this.txbPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txbPrice.Enabled = false;
			this.txbPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txbPrice.isPassword = false;
			this.txbPrice.Location = new System.Drawing.Point(230, 140);
			this.txbPrice.Margin = new System.Windows.Forms.Padding(0);
			this.txbPrice.MaxLength = 32767;
			this.txbPrice.Name = "txbPrice";
			this.txbPrice.Size = new System.Drawing.Size(175, 29);
			this.txbPrice.TabIndex = 76;
			this.txbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label13.Location = new System.Drawing.Point(230, 117);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(90, 20);
			this.label13.TabIndex = 74;
			this.label13.Text = "Harga Awal:";
			// 
			// UC_Bill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupCustomer);
			this.Name = "UC_Bill";
			this.Size = new System.Drawing.Size(1242, 745);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FBill_KeyPress);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingBill)).EndInit();
			this.bindingBill.ResumeLayout(false);
			this.bindingBill.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupCustomer.ResumeLayout(false);
			this.groupCustomer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.SaveFileDialog SaveCustomer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.BindingNavigator bindingBill;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
		private System.Windows.Forms.Label label1;
		private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
		private MetroFramework.Controls.MetroComboBox cbBillSearch;
		private System.Windows.Forms.GroupBox groupBox5;
		private Bunifu.Framework.UI.BunifuThinButton2 btnSeenBill;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private Bunifu.Framework.UI.BunifuMetroTextbox txbName;
		private MetroFramework.Controls.MetroComboBox comboboxID;
		private Bunifu.Framework.UI.BunifuMetroTextbox txbUser;
		private System.Windows.Forms.Label label6;
		private Bunifu.Framework.UI.BunifuMetroTextbox txbDateCreate;
		private System.Windows.Forms.GroupBox groupCustomer;
		private Bunifu.Framework.UI.BunifuMetroTextbox txbFinalPrice;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMetroTextbox txbDiscount;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuMetroTextbox txbStatusRoom;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuMetroTextbox txbPrice;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridView dataGridViewBill;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdReciveRoom;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStaffsetUp;
		private System.Windows.Forms.DataGridViewTextBoxColumn coldDateOfCreate;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
	}
}
