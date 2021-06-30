namespace FAHotelApp.UC
{
	partial class UC_Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customer));
            this.SaveCustomer = new System.Windows.Forms.SaveFileDialog();
            this.cbCustomerSearch = new MetroFramework.Controls.MetroComboBox();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameCustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingCustomer = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupCustomer = new System.Windows.Forms.GroupBox();
            this.dtpDateOfBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cbNationality = new MetroFramework.Controls.MetroComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSex = new MetroFramework.Controls.MetroComboBox();
            this.cbCustomerType = new MetroFramework.Controls.MetroComboBox();
            this.cbID = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDCard = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingCustomer)).BeginInit();
            this.bindingCustomer.SuspendLayout();
            this.groupCustomer.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveCustomer
            // 
            this.SaveCustomer.FileName = "Daftar Pelanggan";
            this.SaveCustomer.Filter = "Excel File(*.xls)|*.xls|Excel File (*.xlsx) |.xlsx|PDF File(*.pdf)|*.pdf";
            // 
            // cbCustomerSearch
            // 
            this.cbCustomerSearch.BackColor = System.Drawing.Color.White;
            this.cbCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCustomerSearch.FormattingEnabled = true;
            this.cbCustomerSearch.ItemHeight = 23;
            this.cbCustomerSearch.Items.AddRange(new object[] {
            "Kode Customer",
            "Nama Customer",
            "NIK",
            "Nomor Telepon"});
            this.cbCustomerSearch.Location = new System.Drawing.Point(31, 71);
            this.cbCustomerSearch.Name = "cbCustomerSearch";
            this.cbCustomerSearch.Size = new System.Drawing.Size(175, 29);
            this.cbCustomerSearch.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbCustomerSearch.TabIndex = 50;
            this.cbCustomerSearch.UseCustomBackColor = true;
            this.cbCustomerSearch.UseCustomForeColor = true;
            this.cbCustomerSearch.UseSelectable = true;
            this.cbCustomerSearch.UseStyleColors = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCustomer);
            this.groupBox1.Controls.Add(this.bindingCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.groupBox1.Location = new System.Drawing.Point(471, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 745);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daftar Pelanggan";
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.dataGridViewCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomer.ColumnHeadersHeight = 25;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNameCustomer,
            this.colIDCard,
            this.colNameCustomerType,
            this.colSex,
            this.colDateOfBirth,
            this.colPhone,
            this.colAddress,
            this.colNationality,
            this.colIdCustomerType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomer.GridColor = System.Drawing.Color.White;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(3, 68);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCustomer.RowHeadersVisible = false;
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewCustomer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(725, 674);
            this.dataGridViewCustomer.TabIndex = 3;
            this.dataGridViewCustomer.SelectionChanged += new System.EventHandler(this.DataGridViewCustomer_SelectionChanged);
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
            // colNameCustomer
            // 
            this.colNameCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNameCustomer.DataPropertyName = "Name";
            this.colNameCustomer.HeaderText = "Nama";
            this.colNameCustomer.Name = "colNameCustomer";
            this.colNameCustomer.ReadOnly = true;
            this.colNameCustomer.Width = 77;
            // 
            // colIDCard
            // 
            this.colIDCard.DataPropertyName = "idcard";
            this.colIDCard.FillWeight = 90F;
            this.colIDCard.HeaderText = "KTP";
            this.colIDCard.Name = "colIDCard";
            this.colIDCard.ReadOnly = true;
            this.colIDCard.Width = 90;
            // 
            // colNameCustomerType
            // 
            this.colNameCustomerType.DataPropertyName = "NameCustomerType";
            this.colNameCustomerType.FillWeight = 70F;
            this.colNameCustomerType.HeaderText = "Jenis Customer";
            this.colNameCustomerType.Name = "colNameCustomerType";
            this.colNameCustomerType.ReadOnly = true;
            this.colNameCustomerType.Width = 70;
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "sex";
            this.colSex.FillWeight = 85F;
            this.colSex.HeaderText = "Jenis Kelamin";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.Visible = false;
            this.colSex.Width = 85;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.DataPropertyName = "dateofbirth";
            this.colDateOfBirth.FillWeight = 90F;
            this.colDateOfBirth.HeaderText = "TTL";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.ReadOnly = true;
            this.colDateOfBirth.Visible = false;
            this.colDateOfBirth.Width = 90;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "phoneNumber";
            this.colPhone.HeaderText = "No Telp";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAddress.DataPropertyName = "address";
            this.colAddress.HeaderText = "Alamat";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colNationality
            // 
            this.colNationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNationality.DataPropertyName = "nationality";
            this.colNationality.HeaderText = "Kebangsaan";
            this.colNationality.Name = "colNationality";
            this.colNationality.ReadOnly = true;
            this.colNationality.Width = 119;
            // 
            // colIdCustomerType
            // 
            this.colIdCustomerType.DataPropertyName = "idCustomerType";
            this.colIdCustomerType.HeaderText = "";
            this.colIdCustomerType.Name = "colIdCustomerType";
            this.colIdCustomerType.ReadOnly = true;
            this.colIdCustomerType.Visible = false;
            // 
            // bindingCustomer
            // 
            this.bindingCustomer.AddNewItem = null;
            this.bindingCustomer.AutoSize = false;
            this.bindingCustomer.BackColor = System.Drawing.Color.Transparent;
            this.bindingCustomer.CountItem = this.bindingNavigatorCountItem;
            this.bindingCustomer.CountItemFormat = "Dari {0}";
            this.bindingCustomer.DeleteItem = null;
            this.bindingCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingCustomer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingCustomer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripLabel1});
            this.bindingCustomer.Location = new System.Drawing.Point(3, 25);
            this.bindingCustomer.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingCustomer.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingCustomer.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingCustomer.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingCustomer.Name = "bindingCustomer";
            this.bindingCustomer.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingCustomer.Size = new System.Drawing.Size(725, 43);
            this.bindingCustomer.TabIndex = 29;
            this.bindingCustomer.Text = "binding";
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
            this.toolStripLabel1.ToolTipText = "Export";
            this.toolStripLabel1.Click += new System.EventHandler(this.ToolStripLabel1_Click);
            // 
            // groupCustomer
            // 
            this.groupCustomer.Controls.Add(this.dtpDateOfBirth);
            this.groupCustomer.Controls.Add(this.cbNationality);
            this.groupCustomer.Controls.Add(this.label14);
            this.groupCustomer.Controls.Add(this.txtAddress);
            this.groupCustomer.Controls.Add(this.txtPhoneNumber);
            this.groupCustomer.Controls.Add(this.label11);
            this.groupCustomer.Controls.Add(this.label12);
            this.groupCustomer.Controls.Add(this.cbSex);
            this.groupCustomer.Controls.Add(this.cbCustomerType);
            this.groupCustomer.Controls.Add(this.cbID);
            this.groupCustomer.Controls.Add(this.label2);
            this.groupCustomer.Controls.Add(this.txtFullName);
            this.groupCustomer.Controls.Add(this.label13);
            this.groupCustomer.Controls.Add(this.label20);
            this.groupCustomer.Controls.Add(this.label15);
            this.groupCustomer.Controls.Add(this.label3);
            this.groupCustomer.Controls.Add(this.txtIDCard);
            this.groupCustomer.Controls.Add(this.label16);
            this.groupCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCustomer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.groupCustomer.Location = new System.Drawing.Point(21, 186);
            this.groupCustomer.Name = "groupCustomer";
            this.groupCustomer.Size = new System.Drawing.Size(444, 497);
            this.groupCustomer.TabIndex = 38;
            this.groupCustomer.TabStop = false;
            this.groupCustomer.Text = "Informasi Customer";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.dtpDateOfBirth.BorderRadius = 0;
            this.dtpDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.FormatCustom = null;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(235, 71);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(255, 754, 255, 683);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDateOfBirth.Size = new System.Drawing.Size(175, 29);
            this.dtpDateOfBirth.TabIndex = 60;
            this.dtpDateOfBirth.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
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
            this.cbNationality.Location = new System.Drawing.Point(235, 332);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(175, 29);
            this.cbNationality.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbNationality.TabIndex = 58;
            this.cbNationality.UseCustomBackColor = true;
            this.cbNationality.UseCustomForeColor = true;
            this.cbNationality.UseSelectable = true;
            this.cbNationality.UseStyleColors = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label14.Location = new System.Drawing.Point(235, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 20);
            this.label14.TabIndex = 55;
            this.label14.Text = "Nomor Telepon:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtAddress.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtAddress.BorderThickness = 1;
            this.txtAddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.isPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(235, 242);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(175, 29);
            this.txtAddress.TabIndex = 53;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtPhoneNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtPhoneNumber.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtPhoneNumber.BorderThickness = 1;
            this.txtPhoneNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhoneNumber.isPassword = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(235, 154);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhoneNumber.MaxLength = 13;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(175, 29);
            this.txtPhoneNumber.TabIndex = 52;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhoneNumber_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label11.Location = new System.Drawing.Point(235, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Alamat:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label12.Location = new System.Drawing.Point(235, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "Kebangsaan:";
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.Color.White;
            this.cbSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.ItemHeight = 23;
            this.cbSex.Items.AddRange(new object[] {
            "Laki -Laki",
            "Perempuan"});
            this.cbSex.Location = new System.Drawing.Point(31, 421);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(175, 29);
            this.cbSex.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbSex.TabIndex = 4;
            this.cbSex.UseCustomBackColor = true;
            this.cbSex.UseCustomForeColor = true;
            this.cbSex.UseSelectable = true;
            this.cbSex.UseStyleColors = true;
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.BackColor = System.Drawing.Color.White;
            this.cbCustomerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCustomerType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.ItemHeight = 23;
            this.cbCustomerType.Location = new System.Drawing.Point(31, 332);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(175, 29);
            this.cbCustomerType.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbCustomerType.TabIndex = 3;
            this.cbCustomerType.UseCustomBackColor = true;
            this.cbCustomerType.UseCustomForeColor = true;
            this.cbCustomerType.UseSelectable = true;
            this.cbCustomerType.UseStyleColors = true;
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.ItemHeight = 23;
            this.cbID.Location = new System.Drawing.Point(31, 71);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(175, 29);
            this.cbID.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbID.TabIndex = 0;
            this.cbID.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(31, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Kode Pelanggan:";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtFullName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtFullName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtFullName.BorderThickness = 1;
            this.txtFullName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFullName.isPassword = false;
            this.txtFullName.Location = new System.Drawing.Point(31, 154);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(175, 29);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFullName.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label13.Location = new System.Drawing.Point(31, 398);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Jenis Kelamin:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label20.Location = new System.Drawing.Point(31, 309);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(110, 20);
            this.label20.TabIndex = 41;
            this.label20.Text = "Jenis Customer:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label15.Location = new System.Drawing.Point(31, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "KTP/Kartu Tanda Penduduk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label3.Location = new System.Drawing.Point(235, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tanggal Lahir:";
            // 
            // txtIDCard
            // 
            this.txtIDCard.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtIDCard.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtIDCard.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.txtIDCard.BorderThickness = 1;
            this.txtIDCard.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIDCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDCard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDCard.isPassword = false;
            this.txtIDCard.Location = new System.Drawing.Point(31, 242);
            this.txtIDCard.Margin = new System.Windows.Forms.Padding(0);
            this.txtIDCard.MaxLength = 16;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(175, 29);
            this.txtIDCard.TabIndex = 2;
            this.txtIDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIDCard.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtIDCard.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label16.Location = new System.Drawing.Point(31, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Nama Lengkap:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 37);
            this.label1.TabIndex = 53;
            this.label1.Text = "Kelola Customer";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbCustomerSearch);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddCustomer);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.groupBox4.Location = new System.Drawing.Point(21, 689);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 123);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menu";
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
            this.btnAddCustomer.ButtonText = "Tambah Customer";
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnAddCustomer.IdleBorderThickness = 1;
            this.btnAddCustomer.IdleCornerRadius = 20;
            this.btnAddCustomer.IdleFillColor = System.Drawing.Color.White;
            this.btnAddCustomer.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnAddCustomer.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnAddCustomer.Location = new System.Drawing.Point(238, 48);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(175, 40);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.TabStop = false;
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(34, 48);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 40);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
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
            this.bunifuSeparator1.Size = new System.Drawing.Size(1181, 15);
            this.bunifuSeparator1.TabIndex = 54;
            // 
            // UC_Customer
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
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1224, 839);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingCustomer)).EndInit();
            this.bindingCustomer.ResumeLayout(false);
            this.bindingCustomer.PerformLayout();
            this.groupCustomer.ResumeLayout(false);
            this.groupCustomer.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.SaveFileDialog SaveCustomer;
		private MetroFramework.Controls.MetroComboBox cbCustomerSearch;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
		private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
		private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
		private Bunifu.Framework.UI.BunifuThinButton2 btnAddCustomer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridViewCustomer;
		private System.Windows.Forms.BindingNavigator bindingCustomer;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.GroupBox groupCustomer;
		private MetroFramework.Controls.MetroComboBox cbNationality;
		private System.Windows.Forms.Label label14;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtAddress;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtPhoneNumber;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private MetroFramework.Controls.MetroComboBox cbSex;
		private MetroFramework.Controls.MetroComboBox cbCustomerType;
		private MetroFramework.Controls.MetroComboBox cbID;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtFullName;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtIDCard;
		private System.Windows.Forms.Label label16;
		private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox5;
		private Bunifu.Framework.UI.BunifuDatepicker dtpDateOfBirth;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridViewTextBoxColumn colID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNameCustomer;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIDCard;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNameCustomerType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNationality;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIdCustomerType;
	}
}
