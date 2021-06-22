namespace FAHotelApp.Forms
{
	partial class FormRoomType
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomType));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.label1 = new System.Windows.Forms.Label();
			this.saveRoomType = new System.Windows.Forms.SaveFileDialog();
			this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridViewRoomType = new System.Windows.Forms.DataGridView();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLimitPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingRoomType = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnBack = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
			this.groupRoomType = new System.Windows.Forms.GroupBox();
			this.cbID = new MetroFramework.Controls.MetroComboBox();
			this.txtLimitPerson = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingRoomType)).BeginInit();
			this.bindingRoomType.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupRoomType.SuspendLayout();
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
			this.guna2ControlBox2.Location = new System.Drawing.Point(1102, 12);
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
			this.label1.Size = new System.Drawing.Size(151, 37);
			this.label1.TabIndex = 17;
			this.label1.Text = "Tipe Kamar";
			// 
			// saveRoomType
			// 
			this.saveRoomType.FileName = "Danh sách loại phòng";
			this.saveRoomType.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
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
			this.bunifuSeparator1.Size = new System.Drawing.Size(1122, 15);
			this.bunifuSeparator1.TabIndex = 18;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridViewRoomType);
			this.groupBox1.Controls.Add(this.bindingRoomType);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox1.Location = new System.Drawing.Point(283, 73);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(854, 718);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Daftar Tipe Kamar";
			// 
			// dataGridViewRoomType
			// 
			this.dataGridViewRoomType.AllowUserToAddRows = false;
			this.dataGridViewRoomType.AllowUserToDeleteRows = false;
			this.dataGridViewRoomType.AllowUserToResizeRows = false;
			this.dataGridViewRoomType.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewRoomType.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewRoomType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewRoomType.ColumnHeadersHeight = 29;
			this.dataGridViewRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewRoomType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colLimitPerson,
            this.colPrice,
            this.col});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewRoomType.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewRoomType.GridColor = System.Drawing.Color.White;
			this.dataGridViewRoomType.Location = new System.Drawing.Point(3, 68);
			this.dataGridViewRoomType.Name = "dataGridViewRoomType";
			this.dataGridViewRoomType.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewRoomType.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewRoomType.RowHeadersVisible = false;
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.dataGridViewRoomType.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewRoomType.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewRoomType.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewRoomType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewRoomType.Size = new System.Drawing.Size(848, 647);
			this.dataGridViewRoomType.TabIndex = 28;
			this.dataGridViewRoomType.SelectionChanged += new System.EventHandler(this.DataGridViewRoomType_SelectionChanged);
			// 
			// colID
			// 
			this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colID.DataPropertyName = "id";
			this.colID.HeaderText = "Kode";
			this.colID.Name = "colID";
			this.colID.ReadOnly = true;
			this.colID.Width = 70;
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colName.DataPropertyName = "name";
			this.colName.FillWeight = 90F;
			this.colName.HeaderText = "Nama Tipe Kamar";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			this.colName.Width = 159;
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
			// colPrice
			// 
			this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPrice.DataPropertyName = "price_New";
			this.colPrice.HeaderText = "Harga";
			this.colPrice.Name = "colPrice";
			this.colPrice.ReadOnly = true;
			// 
			// col
			// 
			this.col.DataPropertyName = "price";
			this.col.HeaderText = "price";
			this.col.Name = "col";
			this.col.ReadOnly = true;
			this.col.Visible = false;
			// 
			// bindingRoomType
			// 
			this.bindingRoomType.AddNewItem = null;
			this.bindingRoomType.CountItem = this.bindingNavigatorCountItem;
			this.bindingRoomType.CountItemFormat = "dari {0}";
			this.bindingRoomType.DeleteItem = null;
			this.bindingRoomType.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bindingRoomType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.bindingRoomType.Location = new System.Drawing.Point(3, 25);
			this.bindingRoomType.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingRoomType.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingRoomType.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingRoomType.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingRoomType.Name = "bindingRoomType";
			this.bindingRoomType.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingRoomType.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.bindingRoomType.Size = new System.Drawing.Size(848, 43);
			this.bindingRoomType.TabIndex = 31;
			this.bindingRoomType.Text = "bindingNavigator1";
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
			this.toolStripLabel1.Size = new System.Drawing.Size(42, 40);
			this.toolStripLabel1.Text = "Ekspor";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnBack);
			this.groupBox2.Controls.Add(this.btnUpdate);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox2.Location = new System.Drawing.Point(15, 632);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(239, 159);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fungsi";
			// 
			// btnBack
			// 
			this.btnBack.ActiveBorderThickness = 1;
			this.btnBack.ActiveCornerRadius = 20;
			this.btnBack.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnBack.ActiveForecolor = System.Drawing.Color.White;
			this.btnBack.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnBack.BackColor = System.Drawing.Color.White;
			this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
			this.btnBack.ButtonText = "Kembali";
			this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnBack.IdleBorderThickness = 1;
			this.btnBack.IdleCornerRadius = 20;
			this.btnBack.IdleFillColor = System.Drawing.Color.White;
			this.btnBack.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnBack.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnBack.Location = new System.Drawing.Point(32, 98);
			this.btnBack.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(175, 40);
			this.btnBack.TabIndex = 13;
			this.btnBack.TabStop = false;
			this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnBack.Click += new System.EventHandler(this.BtnClose_Click);
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
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdate.IdleBorderThickness = 1;
			this.btnUpdate.IdleCornerRadius = 20;
			this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
			this.btnUpdate.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnUpdate.Location = new System.Drawing.Point(32, 45);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(175, 40);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.TabStop = false;
			this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtSearch);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.btnSearch);
			this.groupBox3.Controls.Add(this.btnCancel);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox3.Location = new System.Drawing.Point(15, 73);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(239, 180);
			this.groupBox3.TabIndex = 19;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Cari";
			// 
			// txtSearch
			// 
			this.txtSearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtSearch.BorderThickness = 1;
			this.txtSearch.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtSearch.isPassword = false;
			this.txtSearch.Location = new System.Drawing.Point(34, 63);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
			this.txtSearch.MaxLength = 32767;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(175, 29);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label5.Location = new System.Drawing.Point(30, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(173, 20);
			this.label5.TabIndex = 28;
			this.label5.Text = "Kode/Nama Tipe Kamar:";
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
			this.btnSearch.Location = new System.Drawing.Point(34, 117);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
			this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnCancel.IdleBorderThickness = 1;
			this.btnCancel.IdleCornerRadius = 20;
			this.btnCancel.IdleFillColor = System.Drawing.Color.White;
			this.btnCancel.IdleForecolor = System.Drawing.Color.Red;
			this.btnCancel.IdleLineColor = System.Drawing.Color.Red;
			this.btnCancel.Location = new System.Drawing.Point(34, 117);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(175, 40);
			this.btnCancel.TabIndex = 48;
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// groupRoomType
			// 
			this.groupRoomType.Controls.Add(this.cbID);
			this.groupRoomType.Controls.Add(this.txtLimitPerson);
			this.groupRoomType.Controls.Add(this.label2);
			this.groupRoomType.Controls.Add(this.label3);
			this.groupRoomType.Controls.Add(this.txtPrice);
			this.groupRoomType.Controls.Add(this.label4);
			this.groupRoomType.Controls.Add(this.txtName);
			this.groupRoomType.Controls.Add(this.label16);
			this.groupRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupRoomType.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupRoomType.Location = new System.Drawing.Point(15, 273);
			this.groupRoomType.Name = "groupRoomType";
			this.groupRoomType.Size = new System.Drawing.Size(239, 334);
			this.groupRoomType.TabIndex = 20;
			this.groupRoomType.TabStop = false;
			this.groupRoomType.Text = "Informasi Tipe Kamar";
			// 
			// cbID
			// 
			this.cbID.FormattingEnabled = true;
			this.cbID.ItemHeight = 23;
			this.cbID.Location = new System.Drawing.Point(32, 55);
			this.cbID.Name = "cbID";
			this.cbID.Size = new System.Drawing.Size(175, 29);
			this.cbID.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbID.TabIndex = 30;
			this.cbID.UseSelectable = true;
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
			this.txtLimitPerson.Location = new System.Drawing.Point(32, 200);
			this.txtLimitPerson.Margin = new System.Windows.Forms.Padding(0);
			this.txtLimitPerson.MaxLength = 32767;
			this.txtLimitPerson.Name = "txtLimitPerson";
			this.txtLimitPerson.Size = new System.Drawing.Size(175, 29);
			this.txtLimitPerson.TabIndex = 29;
			this.txtLimitPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label2.Location = new System.Drawing.Point(30, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 20);
			this.label2.TabIndex = 28;
			this.label2.Text = "Jumlah Maksimum Orang:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label3.Location = new System.Drawing.Point(32, 253);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 20);
			this.label3.TabIndex = 26;
			this.label3.Text = "Harga:";
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
			this.txtPrice.Location = new System.Drawing.Point(32, 273);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(0);
			this.txtPrice.MaxLength = 32767;
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(175, 29);
			this.txtPrice.TabIndex = 2;
			this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPrice.Enter += new System.EventHandler(this.TxtPrice_Enter);
			this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrice_KeyPress);
			this.txtPrice.Leave += new System.EventHandler(this.TxtPrice_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label4.Location = new System.Drawing.Point(32, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 20);
			this.label4.TabIndex = 24;
			this.label4.Text = "Nama Tipe Kamar:";
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
			this.txtName.Location = new System.Drawing.Point(32, 127);
			this.txtName.Margin = new System.Windows.Forms.Padding(0);
			this.txtName.MaxLength = 32767;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(175, 29);
			this.txtName.TabIndex = 0;
			this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtName.Enter += new System.EventHandler(this.TxtName_Enter);
			this.txtName.Leave += new System.EventHandler(this.TxtName_Leave);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label16.Location = new System.Drawing.Point(32, 32);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(94, 20);
			this.label16.TabIndex = 22;
			this.label16.Text = "Kode Kamar:";
			// 
			// FormRoomType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1149, 807);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupRoomType);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2ControlBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormRoomType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Forgot Password";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRoomType_FormClosing);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRoomType_KeyPress);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingRoomType)).EndInit();
			this.bindingRoomType.ResumeLayout(false);
			this.bindingRoomType.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupRoomType.ResumeLayout(false);
			this.groupRoomType.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private System.Windows.Forms.Label label1;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
		private System.Windows.Forms.SaveFileDialog saveRoomType;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridViewRoomType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLimitPerson;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn col;
		private System.Windows.Forms.GroupBox groupBox2;
		private Bunifu.Framework.UI.BunifuThinButton2 btnBack;
		private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
		private System.Windows.Forms.GroupBox groupBox3;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
		private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
		private System.Windows.Forms.GroupBox groupRoomType;
		private MetroFramework.Controls.MetroComboBox cbID;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtLimitPerson;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtPrice;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.BindingNavigator bindingRoomType;
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
	}
}