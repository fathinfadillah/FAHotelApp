namespace FAHotelApp
{
	partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.cbUserType = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbContactAdmin = new System.Windows.Forms.Label();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.lbDate = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbTime = new System.Windows.Forms.Label();
			this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.TargetControl = this;
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.TargetControl = this.guna2Panel2;
			this.guna2DragControl1.TransparentWhileDrag = true;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.guna2Panel2.Controls.Add(this.cbUserType);
			this.guna2Panel2.Controls.Add(this.label5);
			this.guna2Panel2.Controls.Add(this.label4);
			this.guna2Panel2.Controls.Add(this.lbContactAdmin);
			this.guna2Panel2.Controls.Add(this.btnLogin);
			this.guna2Panel2.Controls.Add(this.label2);
			this.guna2Panel2.Controls.Add(this.label1);
			this.guna2Panel2.Controls.Add(this.guna2ToggleSwitch1);
			this.guna2Panel2.Controls.Add(this.txtPassword);
			this.guna2Panel2.Controls.Add(this.txtUsername);
			this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			this.guna2Panel2.Size = new System.Drawing.Size(563, 666);
			this.guna2Panel2.TabIndex = 5;
			// 
			// cbUserType
			// 
			this.cbUserType.BackColor = System.Drawing.Color.Transparent;
			this.cbUserType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.cbUserType.BorderRadius = 6;
			this.cbUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUserType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbUserType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbUserType.FocusedState.Parent = this.cbUserType;
			this.cbUserType.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.cbUserType.HoverState.Parent = this.cbUserType;
			this.cbUserType.ItemHeight = 30;
			this.cbUserType.Items.AddRange(new object[] {
            "Receptionist",
            "Manager"});
			this.cbUserType.ItemsAppearance.Parent = this.cbUserType;
			this.cbUserType.Location = new System.Drawing.Point(114, 306);
			this.cbUserType.Name = "cbUserType";
			this.cbUserType.ShadowDecoration.Parent = this.cbUserType;
			this.cbUserType.Size = new System.Drawing.Size(336, 36);
			this.cbUserType.StartIndex = 0;
			this.cbUserType.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(111, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(323, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Please use your username and password to login";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(107, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 40);
			this.label4.TabIndex = 9;
			this.label4.Text = "Login";
			// 
			// lbContactAdmin
			// 
			this.lbContactAdmin.AutoSize = true;
			this.lbContactAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbContactAdmin.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbContactAdmin.ForeColor = System.Drawing.Color.Black;
			this.lbContactAdmin.Location = new System.Drawing.Point(422, 46);
			this.lbContactAdmin.Name = "lbContactAdmin";
			this.lbContactAdmin.Size = new System.Drawing.Size(114, 18);
			this.lbContactAdmin.TabIndex = 8;
			this.lbContactAdmin.Text = "Contact Admin";
			this.lbContactAdmin.Click += new System.EventHandler(this.lbContactAdmin_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Animated = true;
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.BorderRadius = 10;
			this.btnLogin.CheckedState.Parent = this.btnLogin;
			this.btnLogin.CustomImages.Parent = this.btnLogin;
			this.btnLogin.DisabledState.Parent = this.btnLogin;
			this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.btnLogin.Font = new System.Drawing.Font("Montserrat", 8.999999F);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnLogin.HoverState.Parent = this.btnLogin;
			this.btnLogin.Location = new System.Drawing.Point(114, 465);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
			this.btnLogin.Size = new System.Drawing.Size(336, 39);
			this.btnLogin.TabIndex = 7;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseTransparentBackground = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(274, 417);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Forgot Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(154, 417);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Remember me";
			// 
			// guna2ToggleSwitch1
			// 
			this.guna2ToggleSwitch1.Animated = true;
			this.guna2ToggleSwitch1.BackColor = System.Drawing.Color.Transparent;
			this.guna2ToggleSwitch1.Checked = true;
			this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.Black;
			this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.Black;
			this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
			this.guna2ToggleSwitch1.Location = new System.Drawing.Point(114, 415);
			this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
			this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
			this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
			this.guna2ToggleSwitch1.TabIndex = 4;
			this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.Black;
			this.guna2ToggleSwitch1.UncheckedState.BorderThickness = 2;
			this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.White;
			this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
			this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.Black;
			this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
			// 
			// txtPassword
			// 
			this.txtPassword.Animated = true;
			this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtPassword.BorderRadius = 6;
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.DefaultText = "";
			this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.DisabledState.Parent = this.txtPassword;
			this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.FocusedState.Parent = this.txtPassword;
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtPassword.ForeColor = System.Drawing.Color.Black;
			this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.HoverState.Parent = this.txtPassword;
			this.txtPassword.Location = new System.Drawing.Point(114, 360);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.PlaceholderText = "Password";
			this.txtPassword.SelectedText = "";
			this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
			this.txtPassword.Size = new System.Drawing.Size(336, 36);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtUsername
			// 
			this.txtUsername.Animated = true;
			this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtUsername.BorderRadius = 6;
			this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsername.DefaultText = "";
			this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.DisabledState.Parent = this.txtUsername;
			this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUsername.FocusedState.Parent = this.txtUsername;
			this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtUsername.ForeColor = System.Drawing.Color.Black;
			this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUsername.HoverState.Parent = this.txtUsername;
			this.txtUsername.Location = new System.Drawing.Point(114, 251);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.PlaceholderText = "Username";
			this.txtUsername.SelectedText = "";
			this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
			this.txtUsername.Size = new System.Drawing.Size(336, 36);
			this.txtUsername.TabIndex = 1;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(35, 29);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new System.Drawing.Size(128, 52);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
			this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
			this.guna2ControlBox2.Location = new System.Drawing.Point(950, 12);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.Size = new System.Drawing.Size(35, 28);
			this.guna2ControlBox2.TabIndex = 7;
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
			this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
			this.guna2ControlBox1.Location = new System.Drawing.Point(993, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.Size = new System.Drawing.Size(35, 28);
			this.guna2ControlBox1.TabIndex = 6;
			// 
			// lbDate
			// 
			this.lbDate.AutoSize = true;
			this.lbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.lbDate.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lbDate.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDate.ForeColor = System.Drawing.Color.White;
			this.lbDate.Location = new System.Drawing.Point(709, 99);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(104, 48);
			this.lbDate.TabIndex = 12;
			this.lbDate.Text = "Date";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.lbTime.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lbTime.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTime.ForeColor = System.Drawing.Color.White;
			this.lbTime.Location = new System.Drawing.Point(710, 210);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(84, 37);
			this.lbTime.TabIndex = 14;
			this.lbTime.Text = "Time";
			// 
			// guna2PictureBox2
			// 
			this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox2.Image = global::FAHotelApp.Properties.Resources._01_BGFormLogin;
			this.guna2PictureBox2.ImageRotate = 0F;
			this.guna2PictureBox2.Location = new System.Drawing.Point(-44, -11);
			this.guna2PictureBox2.Name = "guna2PictureBox2";
			this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
			this.guna2PictureBox2.Size = new System.Drawing.Size(1096, 677);
			this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox2.TabIndex = 13;
			this.guna2PictureBox2.TabStop = false;
			this.guna2PictureBox2.UseTransparentBackground = true;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(1040, 666);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.lbDate);
			this.Controls.Add(this.guna2ControlBox2);
			this.Controls.Add(this.guna2ControlBox1);
			this.Controls.Add(this.guna2PictureBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormLogin";
			this.Load += new System.EventHandler(this.FormLogin_Load);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Button btnLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
		private Guna.UI2.WinForms.Guna2TextBox txtPassword;
		private Guna.UI2.WinForms.Guna2TextBox txtUsername;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbContactAdmin;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private Guna.UI2.WinForms.Guna2ComboBox cbUserType;
		private System.Windows.Forms.Label lbDate;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbTime;
	}
}