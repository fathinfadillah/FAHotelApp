namespace FAHotelApp.UC
{
	partial class UC_Service
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Service));
			this.SaveCustomer = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridViewService = new System.Windows.Forms.DataGridView();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNameServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colIdServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingService = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnServiceType = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnInsert = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
			this.groupService = new System.Windows.Forms.GroupBox();
			this.cbID = new MetroFramework.Controls.MetroComboBox();
			this.cbServiceType = new MetroFramework.Controls.MetroComboBox();
			this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.txtPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
			this.saveService = new System.Windows.Forms.SaveFileDialog();
			this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
			this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingService)).BeginInit();
			this.bindingService.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupService.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			this.groupBox1.Controls.Add(this.dataGridViewService);
			this.groupBox1.Controls.Add(this.bindingService);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox1.Location = new System.Drawing.Point(491, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(731, 531);
			this.groupBox1.TabIndex = 39;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Daftar Pelayanan";
			// 
			// dataGridViewService
			// 
			this.dataGridViewService.AllowUserToAddRows = false;
			this.dataGridViewService.AllowUserToDeleteRows = false;
			this.dataGridViewService.AllowUserToResizeRows = false;
			this.dataGridViewService.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewService.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewService.ColumnHeadersHeight = 29;
			this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colPrice,
            this.col,
            this.colNameServiceType,
            this.colIdServiceType});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewService.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewService.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewService.GridColor = System.Drawing.Color.White;
			this.dataGridViewService.Location = new System.Drawing.Point(3, 68);
			this.dataGridViewService.Name = "dataGridViewService";
			this.dataGridViewService.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewService.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewService.RowHeadersVisible = false;
			this.dataGridViewService.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewService.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dataGridViewService.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewService.Size = new System.Drawing.Size(725, 460);
			this.dataGridViewService.TabIndex = 30;
			// 
			// colID
			// 
			this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colID.DataPropertyName = "id";
			this.colID.FillWeight = 30F;
			this.colID.HeaderText = "Kode";
			this.colID.Name = "colID";
			this.colID.ReadOnly = true;
			this.colID.Width = 70;
			// 
			// colName
			// 
			this.colName.DataPropertyName = "name";
			this.colName.FillWeight = 30F;
			this.colName.HeaderText = "Nama";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			this.colName.Width = 250;
			// 
			// colPrice
			// 
			this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colPrice.DataPropertyName = "price_new";
			this.colPrice.FillWeight = 30F;
			this.colPrice.HeaderText = "Harga";
			this.colPrice.Name = "colPrice";
			this.colPrice.ReadOnly = true;
			this.colPrice.Width = 77;
			// 
			// col
			// 
			this.col.DataPropertyName = "price";
			this.col.FillWeight = 30F;
			this.col.HeaderText = "price";
			this.col.Name = "col";
			this.col.ReadOnly = true;
			this.col.Visible = false;
			// 
			// colNameServiceType
			// 
			this.colNameServiceType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colNameServiceType.DataPropertyName = "nameServiceType";
			this.colNameServiceType.FillWeight = 30F;
			this.colNameServiceType.HeaderText = "Jenis Pelayanan";
			this.colNameServiceType.Name = "colNameServiceType";
			this.colNameServiceType.ReadOnly = true;
			// 
			// colIdServiceType
			// 
			this.colIdServiceType.DataPropertyName = "idServiceType";
			this.colIdServiceType.FillWeight = 30F;
			this.colIdServiceType.HeaderText = "";
			this.colIdServiceType.Name = "colIdServiceType";
			this.colIdServiceType.ReadOnly = true;
			this.colIdServiceType.Visible = false;
			// 
			// bindingService
			// 
			this.bindingService.AddNewItem = null;
			this.bindingService.AutoSize = false;
			this.bindingService.BackColor = System.Drawing.Color.Transparent;
			this.bindingService.CountItem = this.bindingNavigatorCountItem;
			this.bindingService.CountItemFormat = "Dari {0}";
			this.bindingService.DeleteItem = null;
			this.bindingService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindingService.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bindingService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripLabel1});
			this.bindingService.Location = new System.Drawing.Point(3, 25);
			this.bindingService.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingService.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingService.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingService.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingService.Name = "bindingService";
			this.bindingService.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingService.Size = new System.Drawing.Size(725, 43);
			this.bindingService.TabIndex = 29;
			this.bindingService.Text = "binding";
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
			this.bindingNavigatorMoveLastItem.ToolTipText = "Daftar Layanan";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(48, 40);
			this.toolStripLabel1.Text = "Ekspor";
			this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label1.Location = new System.Drawing.Point(20, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(218, 37);
			this.label1.TabIndex = 53;
			this.label1.Text = "Kelola Pelayanan";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox2.Controls.Add(this.bunifuThinButton21);
			this.groupBox2.Controls.Add(this.btnServiceType);
			this.groupBox2.Controls.Add(this.btnInsert);
			this.groupBox2.Controls.Add(this.btnUpdate);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox2.Location = new System.Drawing.Point(245, 198);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(220, 400);
			this.groupBox2.TabIndex = 81;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Menu";
			// 
			// btnServiceType
			// 
			this.btnServiceType.ActiveBorderThickness = 1;
			this.btnServiceType.ActiveCornerRadius = 20;
			this.btnServiceType.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnServiceType.ActiveForecolor = System.Drawing.Color.White;
			this.btnServiceType.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnServiceType.BackColor = System.Drawing.Color.White;
			this.btnServiceType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServiceType.BackgroundImage")));
			this.btnServiceType.ButtonText = "Hapus";
			this.btnServiceType.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnServiceType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnServiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnServiceType.IdleBorderThickness = 1;
			this.btnServiceType.IdleCornerRadius = 20;
			this.btnServiceType.IdleFillColor = System.Drawing.Color.White;
			this.btnServiceType.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnServiceType.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnServiceType.Location = new System.Drawing.Point(23, 280);
			this.btnServiceType.Margin = new System.Windows.Forms.Padding(4);
			this.btnServiceType.Name = "btnServiceType";
			this.btnServiceType.Size = new System.Drawing.Size(175, 40);
			this.btnServiceType.TabIndex = 54;
			this.btnServiceType.TabStop = false;
			this.btnServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnServiceType.Click += new System.EventHandler(this.BtnServiceType_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.ActiveBorderThickness = 1;
			this.btnInsert.ActiveCornerRadius = 20;
			this.btnInsert.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnInsert.ActiveForecolor = System.Drawing.Color.White;
			this.btnInsert.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnInsert.BackColor = System.Drawing.Color.White;
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
			this.btnInsert.Location = new System.Drawing.Point(23, 151);
			this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(175, 40);
			this.btnInsert.TabIndex = 53;
			this.btnInsert.TabStop = false;
			this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnInsert.Click += new System.EventHandler(this.BtnInsertService_Click);
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
			this.btnUpdate.Location = new System.Drawing.Point(23, 216);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(175, 40);
			this.btnUpdate.TabIndex = 55;
			this.btnUpdate.TabStop = false;
			this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// groupService
			// 
			this.groupService.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupService.Controls.Add(this.cbID);
			this.groupService.Controls.Add(this.cbServiceType);
			this.groupService.Controls.Add(this.txtName);
			this.groupService.Controls.Add(this.txtPrice);
			this.groupService.Controls.Add(this.label16);
			this.groupService.Controls.Add(this.label15);
			this.groupService.Controls.Add(this.label13);
			this.groupService.Controls.Add(this.label20);
			this.groupService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupService.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupService.Location = new System.Drawing.Point(21, 198);
			this.groupService.Name = "groupService";
			this.groupService.Size = new System.Drawing.Size(220, 400);
			this.groupService.TabIndex = 82;
			this.groupService.TabStop = false;
			this.groupService.Text = "Informasi Pelayanan";
			// 
			// cbID
			// 
			this.cbID.FormattingEnabled = true;
			this.cbID.ItemHeight = 23;
			this.cbID.Location = new System.Drawing.Point(23, 64);
			this.cbID.Name = "cbID";
			this.cbID.Size = new System.Drawing.Size(175, 29);
			this.cbID.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbID.TabIndex = 68;
			this.cbID.UseSelectable = true;
			// 
			// cbServiceType
			// 
			this.cbServiceType.BackColor = System.Drawing.Color.White;
			this.cbServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbServiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.cbServiceType.FormattingEnabled = true;
			this.cbServiceType.ItemHeight = 23;
			this.cbServiceType.Location = new System.Drawing.Point(23, 228);
			this.cbServiceType.Name = "cbServiceType";
			this.cbServiceType.Size = new System.Drawing.Size(175, 29);
			this.cbServiceType.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbServiceType.TabIndex = 64;
			this.cbServiceType.UseCustomBackColor = true;
			this.cbServiceType.UseCustomForeColor = true;
			this.cbServiceType.UseSelectable = true;
			this.cbServiceType.UseStyleColors = true;
			// 
			// txtName
			// 
			this.txtName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtName.BorderThickness = 1;
			this.txtName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtName.isPassword = false;
			this.txtName.Location = new System.Drawing.Point(23, 140);
			this.txtName.Margin = new System.Windows.Forms.Padding(0);
			this.txtName.MaxLength = 32767;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(175, 29);
			this.txtName.TabIndex = 61;
			this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtName.Enter += new System.EventHandler(this.TxbName_Enter);
			this.txtName.Leave += new System.EventHandler(this.TxbName_Leave);
			// 
			// txtPrice
			// 
			this.txtPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtPrice.BorderThickness = 1;
			this.txtPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPrice.isPassword = false;
			this.txtPrice.Location = new System.Drawing.Point(23, 320);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(0);
			this.txtPrice.MaxLength = 32767;
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(175, 29);
			this.txtPrice.TabIndex = 67;
			this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label16.Location = new System.Drawing.Point(23, 41);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(117, 20);
			this.label16.TabIndex = 62;
			this.label16.Text = "Kode Pelayanan:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label15.Location = new System.Drawing.Point(23, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(122, 20);
			this.label15.TabIndex = 63;
			this.label15.Text = "Nama Pelayanan:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label13.Location = new System.Drawing.Point(23, 300);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 20);
			this.label13.TabIndex = 65;
			this.label13.Text = "Harga:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label20.Location = new System.Drawing.Point(23, 205);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(101, 20);
			this.label20.TabIndex = 66;
			this.label20.Text = "Jenis Layanan:";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox4.Controls.Add(this.txtSearch);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.btnSearch);
			this.groupBox4.Controls.Add(this.btnCancel);
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox4.Location = new System.Drawing.Point(21, 67);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(444, 115);
			this.groupBox4.TabIndex = 83;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Cari";
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
			this.txtSearch.Location = new System.Drawing.Point(19, 58);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
			this.txtSearch.MaxLength = 32767;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(175, 29);
			this.txtSearch.TabIndex = 27;
			this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label5.Location = new System.Drawing.Point(15, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(167, 20);
			this.label5.TabIndex = 28;
			this.label5.Text = "Kode/ Nama Pelayanan:";
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
			this.btnSearch.Location = new System.Drawing.Point(247, 50);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(175, 40);
			this.btnSearch.TabIndex = 46;
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
			this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
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
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// saveService
			// 
			this.saveService.FileName = "Daftar Pelayanan";
			this.saveService.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
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
			// bunifuThinButton21
			// 
			this.bunifuThinButton21.ActiveBorderThickness = 1;
			this.bunifuThinButton21.ActiveCornerRadius = 20;
			this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
			this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
			this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
			this.bunifuThinButton21.ButtonText = "Tambah Jenis Layanan";
			this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.bunifuThinButton21.IdleBorderThickness = 1;
			this.bunifuThinButton21.IdleCornerRadius = 20;
			this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
			this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.bunifuThinButton21.Location = new System.Drawing.Point(23, 86);
			this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4);
			this.bunifuThinButton21.Name = "bunifuThinButton21";
			this.bunifuThinButton21.Size = new System.Drawing.Size(175, 40);
			this.bunifuThinButton21.TabIndex = 56;
			this.bunifuThinButton21.TabStop = false;
			this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
			// 
			// UC_Service
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupService);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "UC_Service";
			this.Size = new System.Drawing.Size(1242, 624);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingService)).EndInit();
			this.bindingService.ResumeLayout(false);
			this.bindingService.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupService.ResumeLayout(false);
			this.groupService.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.SaveFileDialog SaveCustomer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.BindingNavigator bindingService;
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
		private System.Windows.Forms.DataGridView dataGridViewService;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn col;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNameServiceType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdServiceType;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupService;
		private System.Windows.Forms.GroupBox groupBox4;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
		private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
		private MetroFramework.Controls.MetroComboBox cbID;
		private MetroFramework.Controls.MetroComboBox cbServiceType;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtPrice;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label20;
		private Bunifu.Framework.UI.BunifuThinButton2 btnServiceType;
		private Bunifu.Framework.UI.BunifuThinButton2 btnInsert;
		private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
		private System.Windows.Forms.SaveFileDialog saveService;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
	}
}
