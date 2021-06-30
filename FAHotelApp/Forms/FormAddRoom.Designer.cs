namespace FAHotelApp.Forms
{
	partial class FormAddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRoom));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.groupRoom = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLimitPerson = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameRoom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbRoomType = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddRoom = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tambah Kamar";
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
            this.groupRoom.Controls.Add(this.label2);
            this.groupRoom.Controls.Add(this.label20);
            this.groupRoom.Controls.Add(this.txtLimitPerson);
            this.groupRoom.Controls.Add(this.label15);
            this.groupRoom.Controls.Add(this.label3);
            this.groupRoom.Controls.Add(this.txtNameRoom);
            this.groupRoom.Controls.Add(this.txtPrice);
            this.groupRoom.Controls.Add(this.cbRoomType);
            this.groupRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRoom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.groupRoom.Location = new System.Drawing.Point(15, 73);
            this.groupRoom.Name = "groupRoom";
            this.groupRoom.Size = new System.Drawing.Size(472, 223);
            this.groupRoom.TabIndex = 55;
            this.groupRoom.TabStop = false;
            this.groupRoom.Text = "Informasi Kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(261, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Jumlah Maksimum Orang:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label20.Location = new System.Drawing.Point(36, 126);
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
            this.txtLimitPerson.Location = new System.Drawing.Point(261, 149);
            this.txtLimitPerson.Margin = new System.Windows.Forms.Padding(0);
            this.txtLimitPerson.MaxLength = 32767;
            this.txtLimitPerson.Name = "txtLimitPerson";
            this.txtLimitPerson.Size = new System.Drawing.Size(175, 29);
            this.txtLimitPerson.TabIndex = 44;
            this.txtLimitPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.label15.Location = new System.Drawing.Point(36, 33);
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
            this.label3.Location = new System.Drawing.Point(261, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Harga Kamar:";
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
            this.txtNameRoom.Location = new System.Drawing.Point(36, 56);
            this.txtNameRoom.Margin = new System.Windows.Forms.Padding(0);
            this.txtNameRoom.MaxLength = 32767;
            this.txtNameRoom.Name = "txtNameRoom";
            this.txtNameRoom.Size = new System.Drawing.Size(175, 29);
            this.txtNameRoom.TabIndex = 0;
            this.txtNameRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // 
            // cbRoomType
            // 
            this.cbRoomType.BackColor = System.Drawing.Color.White;
            this.cbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoomType.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.ItemHeight = 23;
            this.cbRoomType.Location = new System.Drawing.Point(36, 149);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(175, 29);
            this.cbRoomType.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cbRoomType.TabIndex = 1;
            this.cbRoomType.UseCustomBackColor = true;
            this.cbRoomType.UseCustomForeColor = true;
            this.cbRoomType.UseSelectable = true;
            this.cbRoomType.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnAddRoom);
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
            this.btnBack.Location = new System.Drawing.Point(259, 40);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 40);
            this.btnBack.TabIndex = 51;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnAddRoom.IdleCornerRadius = 20;
            this.btnAddRoom.IdleFillColor = System.Drawing.Color.White;
            this.btnAddRoom.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnAddRoom.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
            this.btnAddRoom.Location = new System.Drawing.Point(38, 40);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(175, 40);
            this.btnAddRoom.TabIndex = 48;
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // FormAddRoom
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
            this.Name = "FormAddRoom";
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label20;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtLimitPerson;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtNameRoom;
		private Bunifu.Framework.UI.BunifuMetroTextbox txtPrice;
		private MetroFramework.Controls.MetroComboBox cbRoomType;
		private System.Windows.Forms.GroupBox groupBox1;
		private Bunifu.Framework.UI.BunifuThinButton2 btnBack;
		private Bunifu.Framework.UI.BunifuThinButton2 btnAddRoom;
	}
}