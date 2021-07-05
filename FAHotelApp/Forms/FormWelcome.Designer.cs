namespace FAHotelApp.Forms
{
	partial class FormWelcome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnENG = new Guna.UI2.WinForms.Guna2Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnIDN = new Guna.UI2.WinForms.Guna2Button();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.lbDate = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbTime = new System.Windows.Forms.Label();
			this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
			this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
			this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
			this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
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
			resources.ApplyResources(this.guna2Panel2, "guna2Panel2");
			this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.guna2Panel2.Controls.Add(this.label5);
			this.guna2Panel2.Controls.Add(this.label1);
			this.guna2Panel2.Controls.Add(this.btnENG);
			this.guna2Panel2.Controls.Add(this.label4);
			this.guna2Panel2.Controls.Add(this.btnIDN);
			this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
			this.epWarning.SetError(this.guna2Panel2, resources.GetString("guna2Panel2.Error"));
			this.epCorrect.SetError(this.guna2Panel2, resources.GetString("guna2Panel2.Error1"));
			this.epWrong.SetError(this.guna2Panel2, resources.GetString("guna2Panel2.Error2"));
			this.epWarning.SetIconAlignment(this.guna2Panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2Panel2.IconAlignment"))));
			this.epCorrect.SetIconAlignment(this.guna2Panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2Panel2.IconAlignment1"))));
			this.epWrong.SetIconAlignment(this.guna2Panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2Panel2.IconAlignment2"))));
			this.epCorrect.SetIconPadding(this.guna2Panel2, ((int)(resources.GetObject("guna2Panel2.IconPadding"))));
			this.epWarning.SetIconPadding(this.guna2Panel2, ((int)(resources.GetObject("guna2Panel2.IconPadding1"))));
			this.epWrong.SetIconPadding(this.guna2Panel2, ((int)(resources.GetObject("guna2Panel2.IconPadding2"))));
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.epCorrect.SetError(this.label5, resources.GetString("label5.Error"));
			this.epWrong.SetError(this.label5, resources.GetString("label5.Error1"));
			this.epWarning.SetError(this.label5, resources.GetString("label5.Error2"));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.epWrong.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
			this.epWarning.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment1"))));
			this.epCorrect.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment2"))));
			this.epCorrect.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
			this.epWrong.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding1"))));
			this.epWarning.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding2"))));
			this.label5.Name = "label5";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.epCorrect.SetError(this.label1, resources.GetString("label1.Error"));
			this.epWrong.SetError(this.label1, resources.GetString("label1.Error1"));
			this.epWarning.SetError(this.label1, resources.GetString("label1.Error2"));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.epWrong.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
			this.epWarning.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
			this.epCorrect.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment2"))));
			this.epCorrect.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
			this.epWrong.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
			this.epWarning.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding2"))));
			this.label1.Name = "label1";
			// 
			// btnENG
			// 
			resources.ApplyResources(this.btnENG, "btnENG");
			this.btnENG.Animated = true;
			this.btnENG.BackColor = System.Drawing.Color.Transparent;
			this.btnENG.BorderRadius = 10;
			this.btnENG.CheckedState.Parent = this.btnENG;
			this.btnENG.CustomImages.Parent = this.btnENG;
			this.btnENG.DisabledState.Parent = this.btnENG;
			this.epWrong.SetError(this.btnENG, resources.GetString("btnENG.Error"));
			this.epWarning.SetError(this.btnENG, resources.GetString("btnENG.Error1"));
			this.epCorrect.SetError(this.btnENG, resources.GetString("btnENG.Error2"));
			this.btnENG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnENG.ForeColor = System.Drawing.Color.White;
			this.btnENG.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnENG.HoverState.Parent = this.btnENG;
			this.epCorrect.SetIconAlignment(this.btnENG, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnENG.IconAlignment"))));
			this.epWrong.SetIconAlignment(this.btnENG, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnENG.IconAlignment1"))));
			this.epWarning.SetIconAlignment(this.btnENG, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnENG.IconAlignment2"))));
			this.epWrong.SetIconPadding(this.btnENG, ((int)(resources.GetObject("btnENG.IconPadding"))));
			this.epWarning.SetIconPadding(this.btnENG, ((int)(resources.GetObject("btnENG.IconPadding1"))));
			this.epCorrect.SetIconPadding(this.btnENG, ((int)(resources.GetObject("btnENG.IconPadding2"))));
			this.btnENG.Image = global::FAHotelApp.Properties.Resources.usa_120px;
			this.btnENG.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.btnENG.Name = "btnENG";
			this.btnENG.ShadowDecoration.Parent = this.btnENG;
			this.btnENG.UseTransparentBackground = true;
			this.btnENG.Click += new System.EventHandler(this.btnENG_Click);
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.epCorrect.SetError(this.label4, resources.GetString("label4.Error"));
			this.epWrong.SetError(this.label4, resources.GetString("label4.Error1"));
			this.epWarning.SetError(this.label4, resources.GetString("label4.Error2"));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.epWrong.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
			this.epWarning.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment1"))));
			this.epCorrect.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment2"))));
			this.epCorrect.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
			this.epWrong.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding1"))));
			this.epWarning.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding2"))));
			this.label4.Name = "label4";
			// 
			// btnIDN
			// 
			resources.ApplyResources(this.btnIDN, "btnIDN");
			this.btnIDN.Animated = true;
			this.btnIDN.BackColor = System.Drawing.Color.Transparent;
			this.btnIDN.BorderRadius = 10;
			this.btnIDN.CheckedState.Parent = this.btnIDN;
			this.btnIDN.CustomImages.Parent = this.btnIDN;
			this.btnIDN.DisabledState.Parent = this.btnIDN;
			this.epWrong.SetError(this.btnIDN, resources.GetString("btnIDN.Error"));
			this.epWarning.SetError(this.btnIDN, resources.GetString("btnIDN.Error1"));
			this.epCorrect.SetError(this.btnIDN, resources.GetString("btnIDN.Error2"));
			this.btnIDN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnIDN.ForeColor = System.Drawing.Color.White;
			this.btnIDN.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnIDN.HoverState.Parent = this.btnIDN;
			this.epCorrect.SetIconAlignment(this.btnIDN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnIDN.IconAlignment"))));
			this.epWrong.SetIconAlignment(this.btnIDN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnIDN.IconAlignment1"))));
			this.epWarning.SetIconAlignment(this.btnIDN, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnIDN.IconAlignment2"))));
			this.epWrong.SetIconPadding(this.btnIDN, ((int)(resources.GetObject("btnIDN.IconPadding"))));
			this.epWarning.SetIconPadding(this.btnIDN, ((int)(resources.GetObject("btnIDN.IconPadding1"))));
			this.epCorrect.SetIconPadding(this.btnIDN, ((int)(resources.GetObject("btnIDN.IconPadding2"))));
			this.btnIDN.Image = global::FAHotelApp.Properties.Resources.indonesia_120px;
			this.btnIDN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.btnIDN.Name = "btnIDN";
			this.btnIDN.ShadowDecoration.Parent = this.btnIDN;
			this.btnIDN.UseTransparentBackground = true;
			this.btnIDN.Click += new System.EventHandler(this.btnIDN_Click);
			// 
			// guna2PictureBox1
			// 
			resources.ApplyResources(this.guna2PictureBox1, "guna2PictureBox1");
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.epCorrect.SetError(this.guna2PictureBox1, resources.GetString("guna2PictureBox1.Error"));
			this.epWarning.SetError(this.guna2PictureBox1, resources.GetString("guna2PictureBox1.Error1"));
			this.epWrong.SetError(this.guna2PictureBox1, resources.GetString("guna2PictureBox1.Error2"));
			this.epCorrect.SetIconAlignment(this.guna2PictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2PictureBox1.IconAlignment"))));
			this.epWrong.SetIconAlignment(this.guna2PictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2PictureBox1.IconAlignment1"))));
			this.epWarning.SetIconAlignment(this.guna2PictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2PictureBox1.IconAlignment2"))));
			this.epWarning.SetIconPadding(this.guna2PictureBox1, ((int)(resources.GetObject("guna2PictureBox1.IconPadding"))));
			this.epCorrect.SetIconPadding(this.guna2PictureBox1, ((int)(resources.GetObject("guna2PictureBox1.IconPadding1"))));
			this.epWrong.SetIconPadding(this.guna2PictureBox1, ((int)(resources.GetObject("guna2PictureBox1.IconPadding2"))));
			this.guna2PictureBox1.Image = global::FAHotelApp.Properties.Resources.FAHotelTransparentLogoNavyBlue;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			// 
			// guna2ControlBox2
			// 
			resources.ApplyResources(this.guna2ControlBox2, "guna2ControlBox2");
			this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.epWrong.SetError(this.guna2ControlBox2, resources.GetString("guna2ControlBox2.Error"));
			this.epWarning.SetError(this.guna2ControlBox2, resources.GetString("guna2ControlBox2.Error1"));
			this.epCorrect.SetError(this.guna2ControlBox2, resources.GetString("guna2ControlBox2.Error2"));
			this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
			this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
			this.epWrong.SetIconAlignment(this.guna2ControlBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2ControlBox2.IconAlignment"))));
			this.epWarning.SetIconAlignment(this.guna2ControlBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2ControlBox2.IconAlignment1"))));
			this.epCorrect.SetIconAlignment(this.guna2ControlBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2ControlBox2.IconAlignment2"))));
			this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
			this.epCorrect.SetIconPadding(this.guna2ControlBox2, ((int)(resources.GetObject("guna2ControlBox2.IconPadding"))));
			this.epWarning.SetIconPadding(this.guna2ControlBox2, ((int)(resources.GetObject("guna2ControlBox2.IconPadding1"))));
			this.epWrong.SetIconPadding(this.guna2ControlBox2, ((int)(resources.GetObject("guna2ControlBox2.IconPadding2"))));
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
			// 
			// guna2ControlBox1
			// 
			resources.ApplyResources(this.guna2ControlBox1, "guna2ControlBox1");
			this.epWrong.SetError(this.guna2ControlBox1, resources.GetString("guna2ControlBox1.Error"));
			this.epWarning.SetError(this.guna2ControlBox1, resources.GetString("guna2ControlBox1.Error1"));
			this.epCorrect.SetError(this.guna2ControlBox1, resources.GetString("guna2ControlBox1.Error2"));
			this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
			this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.epWrong.SetIconAlignment(this.guna2ControlBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2ControlBox1.IconAlignment"))));
			this.epWarning.SetIconAlignment(this.guna2ControlBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2ControlBox1.IconAlignment1"))));
			this.epCorrect.SetIconAlignment(this.guna2ControlBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2ControlBox1.IconAlignment2"))));
			this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
			this.epCorrect.SetIconPadding(this.guna2ControlBox1, ((int)(resources.GetObject("guna2ControlBox1.IconPadding"))));
			this.epWarning.SetIconPadding(this.guna2ControlBox1, ((int)(resources.GetObject("guna2ControlBox1.IconPadding1"))));
			this.epWrong.SetIconPadding(this.guna2ControlBox1, ((int)(resources.GetObject("guna2ControlBox1.IconPadding2"))));
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			// 
			// lbDate
			// 
			resources.ApplyResources(this.lbDate, "lbDate");
			this.lbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.lbDate.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.epCorrect.SetError(this.lbDate, resources.GetString("lbDate.Error"));
			this.epWrong.SetError(this.lbDate, resources.GetString("lbDate.Error1"));
			this.epWarning.SetError(this.lbDate, resources.GetString("lbDate.Error2"));
			this.lbDate.ForeColor = System.Drawing.Color.White;
			this.epWrong.SetIconAlignment(this.lbDate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbDate.IconAlignment"))));
			this.epWarning.SetIconAlignment(this.lbDate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbDate.IconAlignment1"))));
			this.epCorrect.SetIconAlignment(this.lbDate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbDate.IconAlignment2"))));
			this.epCorrect.SetIconPadding(this.lbDate, ((int)(resources.GetObject("lbDate.IconPadding"))));
			this.epWrong.SetIconPadding(this.lbDate, ((int)(resources.GetObject("lbDate.IconPadding1"))));
			this.epWarning.SetIconPadding(this.lbDate, ((int)(resources.GetObject("lbDate.IconPadding2"))));
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
			this.epCorrect.SetError(this.lbTime, resources.GetString("lbTime.Error"));
			this.epWrong.SetError(this.lbTime, resources.GetString("lbTime.Error1"));
			this.epWarning.SetError(this.lbTime, resources.GetString("lbTime.Error2"));
			this.lbTime.ForeColor = System.Drawing.Color.White;
			this.epWrong.SetIconAlignment(this.lbTime, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbTime.IconAlignment"))));
			this.epWarning.SetIconAlignment(this.lbTime, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbTime.IconAlignment1"))));
			this.epCorrect.SetIconAlignment(this.lbTime, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lbTime.IconAlignment2"))));
			this.epCorrect.SetIconPadding(this.lbTime, ((int)(resources.GetObject("lbTime.IconPadding"))));
			this.epWrong.SetIconPadding(this.lbTime, ((int)(resources.GetObject("lbTime.IconPadding1"))));
			this.epWarning.SetIconPadding(this.lbTime, ((int)(resources.GetObject("lbTime.IconPadding2"))));
			this.lbTime.Name = "lbTime";
			// 
			// epWarning
			// 
			this.epWarning.ContainerControl = this;
			resources.ApplyResources(this.epWarning, "epWarning");
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
			// guna2PictureBox2
			// 
			resources.ApplyResources(this.guna2PictureBox2, "guna2PictureBox2");
			this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.epCorrect.SetError(this.guna2PictureBox2, resources.GetString("guna2PictureBox2.Error"));
			this.epWarning.SetError(this.guna2PictureBox2, resources.GetString("guna2PictureBox2.Error1"));
			this.epWrong.SetError(this.guna2PictureBox2, resources.GetString("guna2PictureBox2.Error2"));
			this.epCorrect.SetIconAlignment(this.guna2PictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2PictureBox2.IconAlignment"))));
			this.epWrong.SetIconAlignment(this.guna2PictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2PictureBox2.IconAlignment1"))));
			this.epWarning.SetIconAlignment(this.guna2PictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("guna2PictureBox2.IconAlignment2"))));
			this.epWarning.SetIconPadding(this.guna2PictureBox2, ((int)(resources.GetObject("guna2PictureBox2.IconPadding"))));
			this.epCorrect.SetIconPadding(this.guna2PictureBox2, ((int)(resources.GetObject("guna2PictureBox2.IconPadding1"))));
			this.epWrong.SetIconPadding(this.guna2PictureBox2, ((int)(resources.GetObject("guna2PictureBox2.IconPadding2"))));
			this.guna2PictureBox2.Image = global::FAHotelApp.Properties.Resources._01_BGFormLogin;
			this.guna2PictureBox2.ImageRotate = 0F;
			this.guna2PictureBox2.Name = "guna2PictureBox2";
			this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
			this.guna2PictureBox2.TabStop = false;
			this.guna2PictureBox2.UseTransparentBackground = true;
			// 
			// FormWelcome
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
			this.Name = "FormWelcome";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormLogin_Load);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Button btnIDN;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private System.Windows.Forms.Label lbDate;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbTime;
		private Guna.UI2.WinForms.Guna2Button btnENG;
		private System.Windows.Forms.ErrorProvider epWarning;
		private System.Windows.Forms.ErrorProvider epWrong;
		private System.Windows.Forms.ErrorProvider epCorrect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
	}
}