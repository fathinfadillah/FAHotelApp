namespace FAHotelApp.Forms
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
			this.cbDepartement = new Guna.UI2.WinForms.Guna2ComboBox();
			this.tsShowPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label6 = new System.Windows.Forms.Label();
			this.lbTermCon = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnExit = new Guna.UI2.WinForms.Guna2Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbContactAdmin = new System.Windows.Forms.Label();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.lbForgotPassword = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tsRememberMe = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.lbDate = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbTime = new System.Windows.Forms.Label();
			this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
			this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
			this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
			this.guna2Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 8;
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
			this.guna2Panel2.Controls.Add(this.cbDepartement);
			this.guna2Panel2.Controls.Add(this.tsShowPassword);
			this.guna2Panel2.Controls.Add(this.label6);
			this.guna2Panel2.Controls.Add(this.lbTermCon);
			this.guna2Panel2.Controls.Add(this.label3);
			this.guna2Panel2.Controls.Add(this.btnExit);
			this.guna2Panel2.Controls.Add(this.label5);
			this.guna2Panel2.Controls.Add(this.label4);
			this.guna2Panel2.Controls.Add(this.lbContactAdmin);
			this.guna2Panel2.Controls.Add(this.btnLogin);
			this.guna2Panel2.Controls.Add(this.lbForgotPassword);
			this.guna2Panel2.Controls.Add(this.label1);
			this.guna2Panel2.Controls.Add(this.tsRememberMe);
			this.guna2Panel2.Controls.Add(this.txtPassword);
			this.guna2Panel2.Controls.Add(this.txtUsername);
			this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
			resources.ApplyResources(this.guna2Panel2, "guna2Panel2");
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			// 
			// cbDepartement
			// 
			this.cbDepartement.BackColor = System.Drawing.Color.Transparent;
			this.cbDepartement.BorderColor = System.Drawing.Color.Black;
			this.cbDepartement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDepartement.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbDepartement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbDepartement.FocusedState.Parent = this.cbDepartement;
			resources.ApplyResources(this.cbDepartement, "cbDepartement");
			this.cbDepartement.ForeColor = System.Drawing.Color.Black;
			this.cbDepartement.HoverState.Parent = this.cbDepartement;
			this.cbDepartement.Items.AddRange(new object[] {
            resources.GetString("cbDepartement.Items")});
			this.cbDepartement.ItemsAppearance.Parent = this.cbDepartement;
			this.cbDepartement.Name = "cbDepartement";
			this.cbDepartement.ShadowDecoration.Parent = this.cbDepartement;
			this.cbDepartement.StartIndex = 0;
			this.cbDepartement.Leave += new System.EventHandler(this.cbDepartement_Leave);
			// 
			// tsShowPassword
			// 
			this.tsShowPassword.Animated = true;
			this.tsShowPassword.BackColor = System.Drawing.Color.Transparent;
			this.tsShowPassword.CheckedState.BorderColor = System.Drawing.Color.Black;
			this.tsShowPassword.CheckedState.FillColor = System.Drawing.Color.Black;
			this.tsShowPassword.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.tsShowPassword.CheckedState.InnerColor = System.Drawing.Color.White;
			this.tsShowPassword.CheckedState.Parent = this.tsShowPassword;
			resources.ApplyResources(this.tsShowPassword, "tsShowPassword");
			this.tsShowPassword.Name = "tsShowPassword";
			this.tsShowPassword.ShadowDecoration.Parent = this.tsShowPassword;
			this.tsShowPassword.UncheckedState.BorderColor = System.Drawing.Color.Black;
			this.tsShowPassword.UncheckedState.BorderThickness = 2;
			this.tsShowPassword.UncheckedState.FillColor = System.Drawing.Color.White;
			this.tsShowPassword.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
			this.tsShowPassword.UncheckedState.InnerColor = System.Drawing.Color.Black;
			this.tsShowPassword.UncheckedState.Parent = this.tsShowPassword;
			this.tsShowPassword.CheckedChanged += new System.EventHandler(this.tsShowPassword_CheckedChanged);
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Name = "label6";
			// 
			// lbTermCon
			// 
			resources.ApplyResources(this.lbTermCon, "lbTermCon");
			this.lbTermCon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbTermCon.ForeColor = System.Drawing.Color.Black;
			this.lbTermCon.Name = "lbTermCon";
			this.lbTermCon.Click += new System.EventHandler(this.lbTermCon_Click);
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Name = "label3";
			// 
			// btnExit
			// 
			this.btnExit.Animated = true;
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.BorderRadius = 10;
			this.btnExit.CheckedState.Parent = this.btnExit;
			this.btnExit.CustomImages.Parent = this.btnExit;
			this.btnExit.DisabledState.Parent = this.btnExit;
			this.btnExit.FillColor = System.Drawing.Color.Red;
			resources.ApplyResources(this.btnExit, "btnExit");
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnExit.HoverState.Parent = this.btnExit;
			this.btnExit.Name = "btnExit";
			this.btnExit.ShadowDecoration.Parent = this.btnExit;
			this.btnExit.UseTransparentBackground = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Name = "label5";
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Name = "label4";
			// 
			// lbContactAdmin
			// 
			resources.ApplyResources(this.lbContactAdmin, "lbContactAdmin");
			this.lbContactAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbContactAdmin.ForeColor = System.Drawing.Color.Black;
			this.lbContactAdmin.Name = "lbContactAdmin";
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
			this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			resources.ApplyResources(this.btnLogin, "btnLogin");
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnLogin.HoverState.Parent = this.btnLogin;
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
			this.btnLogin.UseTransparentBackground = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lbForgotPassword
			// 
			resources.ApplyResources(this.lbForgotPassword, "lbForgotPassword");
			this.lbForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbForgotPassword.ForeColor = System.Drawing.Color.Black;
			this.lbForgotPassword.Name = "lbForgotPassword";
			this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Name = "label1";
			// 
			// tsRememberMe
			// 
			this.tsRememberMe.Animated = true;
			this.tsRememberMe.BackColor = System.Drawing.Color.Transparent;
			this.tsRememberMe.CheckedState.BorderColor = System.Drawing.Color.Black;
			this.tsRememberMe.CheckedState.FillColor = System.Drawing.Color.Black;
			this.tsRememberMe.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.tsRememberMe.CheckedState.InnerColor = System.Drawing.Color.White;
			this.tsRememberMe.CheckedState.Parent = this.tsRememberMe;
			resources.ApplyResources(this.tsRememberMe, "tsRememberMe");
			this.tsRememberMe.Name = "tsRememberMe";
			this.tsRememberMe.ShadowDecoration.Parent = this.tsRememberMe;
			this.tsRememberMe.UncheckedState.BorderColor = System.Drawing.Color.Black;
			this.tsRememberMe.UncheckedState.BorderThickness = 2;
			this.tsRememberMe.UncheckedState.FillColor = System.Drawing.Color.White;
			this.tsRememberMe.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
			this.tsRememberMe.UncheckedState.InnerColor = System.Drawing.Color.Black;
			this.tsRememberMe.UncheckedState.Parent = this.tsRememberMe;
			// 
			// txtPassword
			// 
			this.txtPassword.Animated = true;
			this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.DefaultText = "";
			this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.DisabledState.Parent = this.txtPassword;
			this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.FocusedState.Parent = this.txtPassword;
			resources.ApplyResources(this.txtPassword, "txtPassword");
			this.txtPassword.ForeColor = System.Drawing.Color.Black;
			this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPassword.HoverState.Parent = this.txtPassword;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '\0';
			this.txtPassword.PlaceholderText = "Password";
			this.txtPassword.SelectedText = "";
			this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// txtUsername
			// 
			this.txtUsername.Animated = true;
			this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsername.DefaultText = "";
			this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.DisabledState.Parent = this.txtUsername;
			this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUsername.FocusedState.Parent = this.txtUsername;
			resources.ApplyResources(this.txtUsername, "txtUsername");
			this.txtUsername.ForeColor = System.Drawing.Color.Black;
			this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUsername.HoverState.Parent = this.txtUsername;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.PlaceholderText = "Username";
			this.txtUsername.SelectedText = "";
			this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
			this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = global::FAHotelApp.Properties.Resources.FAHotelTransparentLogoNavyBlue;
			this.guna2PictureBox1.ImageRotate = 0F;
			resources.ApplyResources(this.guna2PictureBox1, "guna2PictureBox1");
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			// 
			// guna2ControlBox2
			// 
			resources.ApplyResources(this.guna2ControlBox2, "guna2ControlBox2");
			this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
			this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
			// 
			// guna2ControlBox1
			// 
			resources.ApplyResources(this.guna2ControlBox1, "guna2ControlBox1");
			this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
			this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			// 
			// lbDate
			// 
			resources.ApplyResources(this.lbDate, "lbDate");
			this.lbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.lbDate.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lbDate.ForeColor = System.Drawing.Color.White;
			this.lbDate.Name = "lbDate";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbTime
			// 
			resources.ApplyResources(this.lbTime, "lbTime");
			this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.lbTime.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lbTime.ForeColor = System.Drawing.Color.White;
			this.lbTime.Name = "lbTime";
			// 
			// epWarning
			// 
			this.epWarning.ContainerControl = this;
			resources.ApplyResources(this.epWarning, "epWarning");
			// 
			// guna2PictureBox2
			// 
			this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox2.Image = global::FAHotelApp.Properties.Resources._01_BGFormLogin;
			this.guna2PictureBox2.ImageRotate = 0F;
			resources.ApplyResources(this.guna2PictureBox2, "guna2PictureBox2");
			this.guna2PictureBox2.Name = "guna2PictureBox2";
			this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
			this.guna2PictureBox2.TabStop = false;
			this.guna2PictureBox2.UseTransparentBackground = true;
			// 
			// epWrong
			// 
			this.epWrong.ContainerControl = this;
			resources.ApplyResources(this.epWrong, "epWrong");
			// 
			// epCorrect
			// 
			this.epCorrect.ContainerControl = this;
			resources.ApplyResources(this.epCorrect, "epCorrect");
			// 
			// FormLogin
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.lbDate);
			this.Controls.Add(this.guna2ControlBox2);
			this.Controls.Add(this.guna2ControlBox1);
			this.Controls.Add(this.guna2PictureBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormLogin";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormLogin_Load);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Button btnLogin;
		private System.Windows.Forms.Label lbForgotPassword;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ToggleSwitch tsRememberMe;
		private Guna.UI2.WinForms.Guna2TextBox txtPassword;
		private Guna.UI2.WinForms.Guna2TextBox txtUsername;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbContactAdmin;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private System.Windows.Forms.Label lbDate;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbTime;
		private Guna.UI2.WinForms.Guna2Button btnExit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ErrorProvider epWarning;
		private System.Windows.Forms.ErrorProvider epWrong;
		private System.Windows.Forms.ErrorProvider epCorrect;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbTermCon;
		private Guna.UI2.WinForms.Guna2ToggleSwitch tsShowPassword;
		private Guna.UI2.WinForms.Guna2ComboBox cbDepartement;
	}
}