namespace FAHotelApp.Forms
{
	partial class FormAddService
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddService));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
			this.groupRoom = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.txtPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
			this.cbServiceType = new MetroFramework.Controls.MetroComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnBack = new Bunifu.Framework.UI.BunifuThinButton2();
			this.btnAddService = new Bunifu.Framework.UI.BunifuThinButton2();
			this.groupRoom.SuspendLayout();
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
			this.guna2ControlBox2.Location = new System.Drawing.Point(456, 12);
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
			this.label1.Size = new System.Drawing.Size(237, 37);
			this.label1.TabIndex = 17;
			this.label1.Text = "Tambah Pelayanan";
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
			this.bunifuSeparator1.Size = new System.Drawing.Size(472, 15);
			this.bunifuSeparator1.TabIndex = 18;
			// 
			// groupRoom
			// 
			this.groupRoom.Controls.Add(this.label20);
			this.groupRoom.Controls.Add(this.label15);
			this.groupRoom.Controls.Add(this.label3);
			this.groupRoom.Controls.Add(this.txtName);
			this.groupRoom.Controls.Add(this.txtPrice);
			this.groupRoom.Controls.Add(this.cbServiceType);
			this.groupRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupRoom.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupRoom.Location = new System.Drawing.Point(15, 73);
			this.groupRoom.Name = "groupRoom";
			this.groupRoom.Size = new System.Drawing.Size(472, 223);
			this.groupRoom.TabIndex = 55;
			this.groupRoom.TabStop = false;
			this.groupRoom.Text = "Informasi Layanan";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label20.Location = new System.Drawing.Point(36, 126);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(99, 20);
			this.label20.TabIndex = 41;
			this.label20.Text = "Tipe Layanan:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label15.Location = new System.Drawing.Point(36, 33);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(107, 20);
			this.label15.TabIndex = 24;
			this.label15.Text = "Nama Layanan";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.label3.Location = new System.Drawing.Point(261, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 20);
			this.label3.TabIndex = 43;
			this.label3.Text = "Harga:";
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
			this.txtName.Location = new System.Drawing.Point(36, 56);
			this.txtName.Margin = new System.Windows.Forms.Padding(0);
			this.txtName.MaxLength = 32767;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(175, 29);
			this.txtName.TabIndex = 0;
			this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
			this.txtPrice.Location = new System.Drawing.Point(261, 56);
			this.txtPrice.Margin = new System.Windows.Forms.Padding(0);
			this.txtPrice.MaxLength = 32767;
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(175, 29);
			this.txtPrice.TabIndex = 42;
			this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
			this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
			this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
			// 
			// cbServiceType
			// 
			this.cbServiceType.BackColor = System.Drawing.Color.White;
			this.cbServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbServiceType.ForeColor = System.Drawing.Color.SeaGreen;
			this.cbServiceType.FormattingEnabled = true;
			this.cbServiceType.ItemHeight = 23;
			this.cbServiceType.Location = new System.Drawing.Point(36, 149);
			this.cbServiceType.Name = "cbServiceType";
			this.cbServiceType.Size = new System.Drawing.Size(175, 29);
			this.cbServiceType.Style = MetroFramework.MetroColorStyle.Yellow;
			this.cbServiceType.TabIndex = 1;
			this.cbServiceType.UseCustomBackColor = true;
			this.cbServiceType.UseCustomForeColor = true;
			this.cbServiceType.UseSelectable = true;
			this.cbServiceType.UseStyleColors = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnBack);
			this.groupBox1.Controls.Add(this.btnAddService);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox1.Location = new System.Drawing.Point(15, 302);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(472, 111);
			this.groupBox1.TabIndex = 54;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Menu";
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
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnBack.IdleBorderThickness = 1;
			this.btnBack.IdleCornerRadius = 20;
			this.btnBack.IdleFillColor = System.Drawing.Color.White;
			this.btnBack.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnBack.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnBack.Location = new System.Drawing.Point(259, 40);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(175, 40);
			this.btnBack.TabIndex = 51;
			this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnAddService
			// 
			this.btnAddService.ActiveBorderThickness = 1;
			this.btnAddService.ActiveCornerRadius = 20;
			this.btnAddService.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddService.ActiveForecolor = System.Drawing.Color.White;
			this.btnAddService.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddService.BackColor = System.Drawing.Color.White;
			this.btnAddService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddService.BackgroundImage")));
			this.btnAddService.ButtonText = "Tambah Pelayanan";
			this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddService.IdleBorderThickness = 1;
			this.btnAddService.IdleCornerRadius = 20;
			this.btnAddService.IdleFillColor = System.Drawing.Color.White;
			this.btnAddService.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddService.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnAddService.Location = new System.Drawing.Point(38, 40);
			this.btnAddService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAddService.Name = "btnAddService";
			this.btnAddService.Size = new System.Drawing.Size(175, 40);
			this.btnAddService.TabIndex = 48;
			this.btnAddService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
			// 
			// FormAddService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(503, 432);
			this.Controls.Add(this.groupRoom);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.bunifuSeparator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2ControlBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAddService";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Forgot Password";
			this.TopMost = true;
			this.groupRoom.ResumeLayout(false);
			this.groupRoom.PerformLayout();
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
		private System.Windows.Forms.GroupBox groupRoom;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtPrice;
		private System.Windows.Forms.GroupBox groupBox1;
		private Bunifu.Framework.UI.BunifuThinButton2 btnBack;
		private Bunifu.Framework.UI.BunifuThinButton2 btnAddService;
		private MetroFramework.Controls.MetroComboBox cbServiceType;
	}
}