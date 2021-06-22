namespace FAHotelApp.UC
{
	partial class UC_Parameter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Parameter));
			this.SaveCustomer = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridViewParameter = new System.Windows.Forms.DataGridView();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSurcharge = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
			this.groupParameter = new System.Windows.Forms.GroupBox();
			this.cbName = new MetroFramework.Controls.MetroComboBox();
			this.txtValue = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.txtDescribe = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
			this.saveParameter = new System.Windows.Forms.SaveFileDialog();
			this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewParameter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSurcharge)).BeginInit();
			this.bindingSurcharge.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupParameter.SuspendLayout();
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
			this.groupBox1.Controls.Add(this.dataGridViewParameter);
			this.groupBox1.Controls.Add(this.bindingSurcharge);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox1.Location = new System.Drawing.Point(491, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(731, 418);
			this.groupBox1.TabIndex = 39;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Daftar Peraturan";
			// 
			// dataGridViewParameter
			// 
			this.dataGridViewParameter.AllowUserToAddRows = false;
			this.dataGridViewParameter.AllowUserToDeleteRows = false;
			this.dataGridViewParameter.AllowUserToResizeRows = false;
			this.dataGridViewParameter.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewParameter.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewParameter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewParameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colValue,
            this.colDescribe,
            this.Column1});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewParameter.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewParameter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewParameter.GridColor = System.Drawing.Color.White;
			this.dataGridViewParameter.Location = new System.Drawing.Point(3, 68);
			this.dataGridViewParameter.Name = "dataGridViewParameter";
			this.dataGridViewParameter.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewParameter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewParameter.RowHeadersVisible = false;
			this.dataGridViewParameter.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridViewParameter.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewParameter.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewParameter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewParameter.Size = new System.Drawing.Size(725, 347);
			this.dataGridViewParameter.TabIndex = 30;
			this.dataGridViewParameter.SelectionChanged += new System.EventHandler(this.DataGridSurcharge_SelectionChanged);
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
			// colValue
			// 
			this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colValue.DataPropertyName = "value";
			this.colValue.HeaderText = "Value";
			this.colValue.Name = "colValue";
			this.colValue.ReadOnly = true;
			this.colValue.Width = 73;
			// 
			// colDescribe
			// 
			this.colDescribe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colDescribe.DataPropertyName = "describe";
			this.colDescribe.HeaderText = "Deskripsi";
			this.colDescribe.Name = "colDescribe";
			this.colDescribe.ReadOnly = true;
			this.colDescribe.Width = 99;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.DataPropertyName = "datemodify";
			this.Column1.HeaderText = "Tangan Pembaruan";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// bindingSurcharge
			// 
			this.bindingSurcharge.AddNewItem = null;
			this.bindingSurcharge.AutoSize = false;
			this.bindingSurcharge.BackColor = System.Drawing.Color.Transparent;
			this.bindingSurcharge.CountItem = this.bindingNavigatorCountItem;
			this.bindingSurcharge.CountItemFormat = "Dari {0}";
			this.bindingSurcharge.DeleteItem = null;
			this.bindingSurcharge.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bindingSurcharge.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bindingSurcharge.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripLabel1});
			this.bindingSurcharge.Location = new System.Drawing.Point(3, 25);
			this.bindingSurcharge.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingSurcharge.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingSurcharge.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingSurcharge.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingSurcharge.Name = "bindingSurcharge";
			this.bindingSurcharge.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingSurcharge.Size = new System.Drawing.Size(725, 43);
			this.bindingSurcharge.TabIndex = 29;
			this.bindingSurcharge.Text = "binding";
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
			this.label1.Size = new System.Drawing.Size(202, 37);
			this.label1.TabIndex = 53;
			this.label1.Text = "Peraturan Hotel";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox2.Controls.Add(this.btnUpdate);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox2.Location = new System.Drawing.Point(245, 198);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(220, 287);
			this.groupBox2.TabIndex = 81;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Menu";
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
			this.btnUpdate.Location = new System.Drawing.Point(23, 134);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(175, 40);
			this.btnUpdate.TabIndex = 55;
			this.btnUpdate.TabStop = false;
			this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// groupParameter
			// 
			this.groupParameter.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupParameter.Controls.Add(this.cbName);
			this.groupParameter.Controls.Add(this.txtValue);
			this.groupParameter.Controls.Add(this.txtDescribe);
			this.groupParameter.Controls.Add(this.label16);
			this.groupParameter.Controls.Add(this.label15);
			this.groupParameter.Controls.Add(this.label20);
			this.groupParameter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupParameter.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupParameter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupParameter.Location = new System.Drawing.Point(21, 198);
			this.groupParameter.Name = "groupParameter";
			this.groupParameter.Size = new System.Drawing.Size(220, 287);
			this.groupParameter.TabIndex = 82;
			this.groupParameter.TabStop = false;
			this.groupParameter.Text = "Informasi Peraturan";
			// 
			// cbName
			// 
			this.cbName.FormattingEnabled = true;
			this.cbName.ItemHeight = 23;
			this.cbName.Location = new System.Drawing.Point(23, 64);
			this.cbName.Name = "cbName";
			this.cbName.Size = new System.Drawing.Size(175, 29);
			this.cbName.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbName.TabIndex = 68;
			this.cbName.UseSelectable = true;
			// 
			// txtValue
			// 
			this.txtValue.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtValue.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtValue.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtValue.BorderThickness = 1;
			this.txtValue.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtValue.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtValue.isPassword = false;
			this.txtValue.Location = new System.Drawing.Point(23, 140);
			this.txtValue.Margin = new System.Windows.Forms.Padding(0);
			this.txtValue.MaxLength = 32767;
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(175, 29);
			this.txtValue.TabIndex = 61;
			this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
			// 
			// txtDescribe
			// 
			this.txtDescribe.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtDescribe.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtDescribe.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.txtDescribe.BorderThickness = 1;
			this.txtDescribe.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtDescribe.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDescribe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescribe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtDescribe.isPassword = false;
			this.txtDescribe.Location = new System.Drawing.Point(23, 225);
			this.txtDescribe.Margin = new System.Windows.Forms.Padding(0);
			this.txtDescribe.MaxLength = 32767;
			this.txtDescribe.Name = "txtDescribe";
			this.txtDescribe.Size = new System.Drawing.Size(175, 29);
			this.txtDescribe.TabIndex = 67;
			this.txtDescribe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label16.Location = new System.Drawing.Point(23, 41);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(52, 20);
			this.label16.TabIndex = 62;
			this.label16.Text = "Nama:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label15.Location = new System.Drawing.Point(23, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(48, 20);
			this.label15.TabIndex = 63;
			this.label15.Text = "Value:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label20.Location = new System.Drawing.Point(23, 205);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(72, 20);
			this.label20.TabIndex = 66;
			this.label20.Text = "Deskripsi:";
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
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label5.Location = new System.Drawing.Point(15, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 20);
			this.label5.TabIndex = 28;
			this.label5.Text = "Nama:";
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
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// saveParameter
			// 
			this.saveParameter.FileName = "Peraturan Hotel";
			this.saveParameter.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
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
			// UC_Parameter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupParameter);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "UC_Parameter";
			this.Size = new System.Drawing.Size(1242, 507);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewParameter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSurcharge)).EndInit();
			this.bindingSurcharge.ResumeLayout(false);
			this.bindingSurcharge.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupParameter.ResumeLayout(false);
			this.groupParameter.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.SaveFileDialog SaveCustomer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.BindingNavigator bindingSurcharge;
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
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupParameter;
		private System.Windows.Forms.GroupBox groupBox4;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
		private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
		private MetroFramework.Controls.MetroComboBox cbName;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtValue;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtDescribe;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label20;
		private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
		private System.Windows.Forms.SaveFileDialog saveParameter;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.DataGridView dataGridViewParameter;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDescribe;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
	}
}
