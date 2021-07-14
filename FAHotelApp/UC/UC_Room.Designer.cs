namespace FAHotelApp.UC
{
	partial class UC_Room
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Room));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.saveRoom = new System.Windows.Forms.SaveFileDialog();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnAddRoom = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnRoomType = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
			this.colIDRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNameRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLimitPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colIdRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colIdStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingRoom = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.groupRoom = new System.Windows.Forms.GroupBox();
			this.cbID = new MetroFramework.Controls.MetroComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.txtLimitPerson = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label13 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbStatusRoom = new MetroFramework.Controls.MetroComboBox();
			this.txtNameRoom = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.txtPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.cbRoomType = new MetroFramework.Controls.MetroComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
			this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingRoom)).BeginInit();
			this.bindingRoom.SuspendLayout();
			this.groupRoom.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label1.Location = new System.Drawing.Point(20, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kelola Kamar";
			// 
			// saveRoom
			// 
			this.saveRoom.FileName = "Daftar Kamar";
			this.saveRoom.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnAddRoom);
			this.groupBox4.Controls.Add(this.btnRoomType);
			this.groupBox4.Controls.Add(this.btnUpdate);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox4.Location = new System.Drawing.Point(21, 471);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(444, 149);
			this.groupBox4.TabIndex = 62;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Fungsi";
			// 
			// btnAddRoom
			// 
			this.btnAddRoom.ActiveBorderThickness = 1;
			this.btnAddRoom.ActiveCornerRadius = 20;
			this.btnAddRoom.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddRoom.ActiveForecolor = System.Drawing.Color.White;
			this.btnAddRoom.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddRoom.BackColor = System.Drawing.Color.White;
			this.btnAddRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.BackgroundImage")));
			this.btnAddRoom.ButtonText = "Tambah Kamar";
			this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddRoom.IdleBorderThickness = 1;
			this.btnAddRoom.IdleCornerRadius = 15;
			this.btnAddRoom.IdleFillColor = System.Drawing.Color.White;
			this.btnAddRoom.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddRoom.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddRoom.Location = new System.Drawing.Point(22, 35);
			this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddRoom.Name = "btnAddRoom";
			this.btnAddRoom.Size = new System.Drawing.Size(175, 40);
			this.btnAddRoom.TabIndex = 8;
			this.btnAddRoom.TabStop = false;
			this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click);
			// 
			// btnRoomType
			// 
			this.btnRoomType.ActiveBorderThickness = 1;
			this.btnRoomType.ActiveCornerRadius = 20;
			this.btnRoomType.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnRoomType.ActiveForecolor = System.Drawing.Color.White;
			this.btnRoomType.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnRoomType.BackColor = System.Drawing.Color.White;
			this.btnRoomType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoomType.BackgroundImage")));
			this.btnRoomType.ButtonText = "Tipe Kamar";
			this.btnRoomType.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRoomType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnRoomType.IdleBorderThickness = 1;
			this.btnRoomType.IdleCornerRadius = 15;
			this.btnRoomType.IdleFillColor = System.Drawing.Color.White;
			this.btnRoomType.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnRoomType.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnRoomType.Location = new System.Drawing.Point(247, 35);
			this.btnRoomType.Margin = new System.Windows.Forms.Padding(4);
			this.btnRoomType.Name = "btnRoomType";
			this.btnRoomType.Size = new System.Drawing.Size(175, 40);
			this.btnRoomType.TabIndex = 50;
			this.btnRoomType.TabStop = false;
			this.btnRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnRoomType.Click += new System.EventHandler(this.BtnRoomType_Click);
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
			this.btnUpdate.ButtonText = "Update Kamar";
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdate.IdleBorderThickness = 1;
			this.btnUpdate.IdleCornerRadius = 15;
			this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
			this.btnUpdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdate.Location = new System.Drawing.Point(22, 91);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(175, 40);
			this.btnUpdate.TabIndex = 52;
			this.btnUpdate.TabStop = false;
			this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridViewRoom);
			this.groupBox1.Controls.Add(this.bindingRoom);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox1.Location = new System.Drawing.Point(471, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(728, 553);
			this.groupBox1.TabIndex = 61;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Daftar Kamar";
			// 
			// dataGridViewRoom
			// 
			this.dataGridViewRoom.AllowUserToAddRows = false;
			this.dataGridViewRoom.AllowUserToDeleteRows = false;
			this.dataGridViewRoom.AllowUserToResizeRows = false;
			this.dataGridViewRoom.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewRoom.ColumnHeadersHeight = 29;
			this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDRoom,
            this.colName,
            this.colNameRoomType,
            this.colPrice,
            this.colLimitPerson,
            this.colStatus,
            this.colIdRoomType,
            this.colIdStatus});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewRoom.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewRoom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewRoom.GridColor = System.Drawing.Color.White;
			this.dataGridViewRoom.Location = new System.Drawing.Point(3, 68);
			this.dataGridViewRoom.Name = "dataGridViewRoom";
			this.dataGridViewRoom.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewRoom.RowHeadersVisible = false;
			this.dataGridViewRoom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewRoom.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewRoom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewRoom.Size = new System.Drawing.Size(722, 482);
			this.dataGridViewRoom.TabIndex = 28;
			// 
			// colIDRoom
			// 
			this.colIDRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colIDRoom.DataPropertyName = "id";
			this.colIDRoom.FillWeight = 90F;
			this.colIDRoom.HeaderText = "Kode";
			this.colIDRoom.Name = "colIDRoom";
			this.colIDRoom.ReadOnly = true;
			this.colIDRoom.Width = 70;
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colName.DataPropertyName = "name";
			this.colName.HeaderText = "Nama";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			this.colName.Width = 77;
			// 
			// colNameRoomType
			// 
			this.colNameRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colNameRoomType.DataPropertyName = "nameRoomType";
			this.colNameRoomType.HeaderText = "Tipe Kamar";
			this.colNameRoomType.Name = "colNameRoomType";
			this.colNameRoomType.ReadOnly = true;
			this.colNameRoomType.Width = 113;
			// 
			// colPrice
			// 
			this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colPrice.DataPropertyName = "price_New";
			this.colPrice.HeaderText = "Harga";
			this.colPrice.Name = "colPrice";
			this.colPrice.ReadOnly = true;
			this.colPrice.Width = 77;
			// 
			// colLimitPerson
			// 
			this.colLimitPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colLimitPerson.DataPropertyName = "limitPerson";
			this.colLimitPerson.HeaderText = "Jumlah Maksimum Orang";
			this.colLimitPerson.Name = "colLimitPerson";
			this.colLimitPerson.ReadOnly = true;
			this.colLimitPerson.Width = 215;
			// 
			// colStatus
			// 
			this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colStatus.DataPropertyName = "nameStatusRoom";
			this.colStatus.HeaderText = "Status";
			this.colStatus.Name = "colStatus";
			this.colStatus.ReadOnly = true;
			// 
			// colIdRoomType
			// 
			this.colIdRoomType.DataPropertyName = "idRoomType";
			this.colIdRoomType.HeaderText = "";
			this.colIdRoomType.Name = "colIdRoomType";
			this.colIdRoomType.ReadOnly = true;
			this.colIdRoomType.Visible = false;
			// 
			// colIdStatus
			// 
			this.colIdStatus.DataPropertyName = "idStatusRoom";
			this.colIdStatus.HeaderText = "";
			this.colIdStatus.Name = "colIdStatus";
			this.colIdStatus.ReadOnly = true;
			this.colIdStatus.Visible = false;
			// 
			// bindingRoom
			// 
			this.bindingRoom.AddNewItem = null;
			this.bindingRoom.BackColor = System.Drawing.Color.White;
			this.bindingRoom.CountItem = this.bindingNavigatorCountItem;
			this.bindingRoom.CountItemFormat = "dari {0}";
			this.bindingRoom.DeleteItem = null;
			this.bindingRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindingRoom.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bindingRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1});
			this.bindingRoom.Location = new System.Drawing.Point(3, 25);
			this.bindingRoom.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingRoom.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingRoom.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingRoom.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingRoom.Name = "bindingRoom";
			this.bindingRoom.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingRoom.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.bindingRoom.Size = new System.Drawing.Size(722, 43);
			this.bindingRoom.TabIndex = 30;
			this.bindingRoom.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.AutoSize = false;
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(80, 40);
			this.bindingNavigatorCountItem.Text = "dari {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.AutoSize = false;
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(40, 40);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.AutoSize = false;
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(40, 40);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(80, 40);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(40, 40);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.AutoSize = false;
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(40, 40);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(48, 40);
			this.toolStripLabel1.Text = "Ekspor";
			this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
			// 
			// groupRoom
			// 
			this.groupRoom.Controls.Add(this.cbID);
			this.groupRoom.Controls.Add(this.label2);
			this.groupRoom.Controls.Add(this.label16);
			this.groupRoom.Controls.Add(this.label20);
			this.groupRoom.Controls.Add(this.txtLimitPerson);
			this.groupRoom.Controls.Add(this.label13);
			this.groupRoom.Controls.Add(this.label15);
			this.groupRoom.Controls.Add(this.label3);
			this.groupRoom.Controls.Add(this.cbStatusRoom);
			this.groupRoom.Controls.Add(this.txtNameRoom);
			this.groupRoom.Controls.Add(this.txtPrice);
			this.groupRoom.Controls.Add(this.cbRoomType);
			this.groupRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupRoom.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupRoom.Location = new System.Drawing.Point(21, 192);
			this.groupRoom.Name = "groupRoom";
			this.groupRoom.Size = new System.Drawing.Size(444, 273);
			this.groupRoom.TabIndex = 60;
			this.groupRoom.TabStop = false;
			this.groupRoom.Text = "Informasi Kamar";
			// 
			// cbID
			// 
			this.cbID.FormattingEnabled = true;
			this.cbID.ItemHeight = 23;
			this.cbID.Location = new System.Drawing.Point(22, 62);
			this.cbID.Name = "cbID";
			this.cbID.Size = new System.Drawing.Size(175, 29);
			this.cbID.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbID.TabIndex = 46;
			this.cbID.UseSelectable = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label2.Location = new System.Drawing.Point(247, 187);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 20);
			this.label2.TabIndex = 45;
			this.label2.Text = "Jumlah Maksimum Orang:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label16.Location = new System.Drawing.Point(22, 39);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(94, 20);
			this.label16.TabIndex = 22;
			this.label16.Text = "Kode Kamar:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label20.Location = new System.Drawing.Point(247, 39);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(88, 20);
			this.label20.TabIndex = 41;
			this.label20.Text = "Tipe Kamar:";
			// 
			// txtLimitPerson
			// 
			this.txtLimitPerson.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtLimitPerson.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtLimitPerson.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtLimitPerson.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtLimitPerson.BorderThickness = 1;
			this.txtLimitPerson.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtLimitPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtLimitPerson.Enabled = false;
			this.txtLimitPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLimitPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtLimitPerson.isPassword = false;
			this.txtLimitPerson.Location = new System.Drawing.Point(247, 210);
			this.txtLimitPerson.Margin = new System.Windows.Forms.Padding(0);
			this.txtLimitPerson.MaxLength = 32767;
			this.txtLimitPerson.Name = "txtLimitPerson";
			this.txtLimitPerson.Size = new System.Drawing.Size(175, 29);
			this.txtLimitPerson.TabIndex = 44;
			this.txtLimitPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label13.Location = new System.Drawing.Point(22, 187);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(52, 20);
			this.label13.TabIndex = 28;
			this.label13.Text = "Status:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label15.Location = new System.Drawing.Point(22, 111);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(99, 20);
			this.label15.TabIndex = 24;
			this.label15.Text = "Nama Kamar:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label3.Location = new System.Drawing.Point(247, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 43;
			this.label3.Text = "Harga Kamar:";
			// 
			// cbStatusRoom
			// 
			this.cbStatusRoom.BackColor = System.Drawing.Color.White;
			this.cbStatusRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbStatusRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.cbStatusRoom.FormattingEnabled = true;
			this.cbStatusRoom.ItemHeight = 23;
			this.cbStatusRoom.Location = new System.Drawing.Point(22, 210);
			this.cbStatusRoom.Name = "cbStatusRoom";
			this.cbStatusRoom.Size = new System.Drawing.Size(175, 29);
			this.cbStatusRoom.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbStatusRoom.TabIndex = 4;
			this.cbStatusRoom.UseCustomBackColor = true;
			this.cbStatusRoom.UseCustomForeColor = true;
			this.cbStatusRoom.UseSelectable = true;
			this.cbStatusRoom.UseStyleColors = true;
			// 
			// txtNameRoom
			// 
			this.txtNameRoom.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtNameRoom.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtNameRoom.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtNameRoom.BorderThickness = 1;
			this.txtNameRoom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtNameRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNameRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNameRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtNameRoom.isPassword = false;
			this.txtNameRoom.Location = new System.Drawing.Point(22, 134);
			this.txtNameRoom.Margin = new System.Windows.Forms.Padding(0);
			this.txtNameRoom.MaxLength = 32767;
			this.txtNameRoom.Name = "txtNameRoom";
			this.txtNameRoom.Size = new System.Drawing.Size(175, 29);
			this.txtNameRoom.TabIndex = 1;
			this.txtNameRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtNameRoom.Enter += new System.EventHandler(this.txtNameRoom_Enter);
			this.txtNameRoom.Leave += new System.EventHandler(this.txtNameRoom_Leave);
			// 
			// txtPrice
			// 
			this.txtPrice.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtPrice.BorderThickness = 1;
			this.txtPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPrice.Enabled = false;
			this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPrice.isPassword = false;
			this.txtPrice.Location = new System.Drawing.Point(247, 134);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(0);
			this.txtPrice.MaxLength = 32767;
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(175, 29);
			this.txtPrice.TabIndex = 42;
			this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// cbRoomType
			// 
			this.cbRoomType.BackColor = System.Drawing.Color.White;
			this.cbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.cbRoomType.FormattingEnabled = true;
			this.cbRoomType.ItemHeight = 23;
			this.cbRoomType.Location = new System.Drawing.Point(247, 62);
			this.cbRoomType.Name = "cbRoomType";
			this.cbRoomType.Size = new System.Drawing.Size(175, 29);
			this.cbRoomType.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbRoomType.TabIndex = 2;
			this.cbRoomType.UseCustomBackColor = true;
			this.cbRoomType.UseCustomForeColor = true;
			this.cbRoomType.UseSelectable = true;
			this.cbRoomType.UseStyleColors = true;
			this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnSearch);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.txtSearch);
			this.groupBox3.Controls.Add(this.btnCancel);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox3.Location = new System.Drawing.Point(21, 67);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(444, 119);
			this.groupBox3.TabIndex = 59;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Cari";
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
			this.btnSearch.Location = new System.Drawing.Point(247, 48);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(175, 40);
			this.btnSearch.TabIndex = 46;
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label5.Location = new System.Drawing.Point(22, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 20);
			this.label5.TabIndex = 28;
			this.label5.Text = "Kode Kamar:";
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
			this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtSearch.isPassword = false;
			this.txtSearch.Location = new System.Drawing.Point(22, 54);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
			this.txtSearch.MaxLength = 32767;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(175, 29);
			this.txtSearch.TabIndex = 27;
			this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
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
			this.btnCancel.Location = new System.Drawing.Point(247, 48);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(175, 40);
			this.btnCancel.TabIndex = 48;
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
			this.bunifuSeparator1.Location = new System.Drawing.Point(21, 46);
			this.bunifuSeparator1.Name = "bunifuSeparator1";
			this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
			this.bunifuSeparator1.Size = new System.Drawing.Size(1178, 15);
			this.bunifuSeparator1.TabIndex = 2;
			// 
			// UC_Room
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupRoom);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Name = "UC_Room";
			this.Size = new System.Drawing.Size(1225, 644);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRoom_KeyPress);
			this.groupBox4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingRoom)).EndInit();
			this.bindingRoom.ResumeLayout(false);
			this.bindingRoom.PerformLayout();
			this.groupRoom.ResumeLayout(false);
			this.groupRoom.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
		private System.Windows.Forms.SaveFileDialog saveRoom;
		private System.Windows.Forms.GroupBox groupBox4;
		private Bunifu.Framework.UI.BunifuThinButton2 btnAddRoom;
		private Bunifu.Framework.UI.BunifuThinButton2 btnRoomType;
		private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridViewRoom;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIDRoom;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNameRoomType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLimitPerson;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdRoomType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdStatus;
		private System.Windows.Forms.GroupBox groupRoom;
		private MetroFramework.Controls.MetroComboBox cbID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label20;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtLimitPerson;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label3;
		private MetroFramework.Controls.MetroComboBox cbStatusRoom;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtNameRoom;
		private MetroFramework.Controls.MetroComboBox cbRoomType;
		private System.Windows.Forms.GroupBox groupBox3;
		private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
		private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
		private System.Windows.Forms.BindingNavigator bindingRoom;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtPrice;
	}
}
