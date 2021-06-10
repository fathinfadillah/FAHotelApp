namespace FAHotelApp
{
	partial class FormContactAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContactAdmin));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.txtBody = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbTime = new System.Windows.Forms.Label();
			this.lbDate = new System.Windows.Forms.Label();
			this.txtServerPortNo = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtSMPTServer = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSend = new Guna.UI2.WinForms.Guna2Button();
			this.txtSenderEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.txtSenderPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnBack = new Guna.UI2.WinForms.Guna2Button();
			this.txtSubject = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtRecipientEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.tsSSL = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
			this.guna2Panel2.Controls.Add(this.label1);
			this.guna2Panel2.Controls.Add(this.tsSSL);
			this.guna2Panel2.Controls.Add(this.txtRecipientEmail);
			this.guna2Panel2.Controls.Add(this.txtSubject);
			this.guna2Panel2.Controls.Add(this.btnBack);
			this.guna2Panel2.Controls.Add(this.txtSenderPassword);
			this.guna2Panel2.Controls.Add(this.txtBody);
			this.guna2Panel2.Controls.Add(this.lbTime);
			this.guna2Panel2.Controls.Add(this.lbDate);
			this.guna2Panel2.Controls.Add(this.txtServerPortNo);
			this.guna2Panel2.Controls.Add(this.txtSMPTServer);
			this.guna2Panel2.Controls.Add(this.label5);
			this.guna2Panel2.Controls.Add(this.label4);
			this.guna2Panel2.Controls.Add(this.btnSend);
			this.guna2Panel2.Controls.Add(this.txtSenderEmail);
			this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			this.guna2Panel2.Size = new System.Drawing.Size(1040, 666);
			this.guna2Panel2.TabIndex = 5;
			// 
			// txtBody
			// 
			this.txtBody.Animated = true;
			this.txtBody.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtBody.BorderRadius = 6;
			this.txtBody.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtBody.DefaultText = "";
			this.txtBody.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtBody.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtBody.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtBody.DisabledState.Parent = this.txtBody;
			this.txtBody.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtBody.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBody.FocusedState.Parent = this.txtBody;
			this.txtBody.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtBody.ForeColor = System.Drawing.Color.Black;
			this.txtBody.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtBody.HoverState.Parent = this.txtBody;
			this.txtBody.Location = new System.Drawing.Point(584, 218);
			this.txtBody.Name = "txtBody";
			this.txtBody.PasswordChar = '\0';
			this.txtBody.PlaceholderText = "Body";
			this.txtBody.SelectedText = "";
			this.txtBody.ShadowDecoration.Parent = this.txtBody;
			this.txtBody.Size = new System.Drawing.Size(336, 295);
			this.txtBody.TabIndex = 8;
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.lbTime.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lbTime.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTime.ForeColor = System.Drawing.Color.Black;
			this.lbTime.Location = new System.Drawing.Point(878, 44);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(42, 18);
			this.lbTime.TabIndex = 16;
			this.lbTime.Text = "Time";
			// 
			// lbDate
			// 
			this.lbDate.AutoSize = true;
			this.lbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.lbDate.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lbDate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDate.ForeColor = System.Drawing.Color.Black;
			this.lbDate.Location = new System.Drawing.Point(706, 44);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(41, 18);
			this.lbDate.TabIndex = 15;
			this.lbDate.Text = "Date";
			// 
			// txtServerPortNo
			// 
			this.txtServerPortNo.Animated = true;
			this.txtServerPortNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtServerPortNo.BorderRadius = 6;
			this.txtServerPortNo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtServerPortNo.DefaultText = "";
			this.txtServerPortNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtServerPortNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtServerPortNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtServerPortNo.DisabledState.Parent = this.txtServerPortNo;
			this.txtServerPortNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtServerPortNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtServerPortNo.FocusedState.Parent = this.txtServerPortNo;
			this.txtServerPortNo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtServerPortNo.ForeColor = System.Drawing.Color.Black;
			this.txtServerPortNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtServerPortNo.HoverState.Parent = this.txtServerPortNo;
			this.txtServerPortNo.Location = new System.Drawing.Point(114, 344);
			this.txtServerPortNo.Name = "txtServerPortNo";
			this.txtServerPortNo.PasswordChar = '\0';
			this.txtServerPortNo.PlaceholderText = "Server Port No";
			this.txtServerPortNo.SelectedText = "";
			this.txtServerPortNo.ShadowDecoration.Parent = this.txtServerPortNo;
			this.txtServerPortNo.Size = new System.Drawing.Size(336, 36);
			this.txtServerPortNo.TabIndex = 4;
			// 
			// txtSMPTServer
			// 
			this.txtSMPTServer.Animated = true;
			this.txtSMPTServer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtSMPTServer.BorderRadius = 6;
			this.txtSMPTServer.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSMPTServer.DefaultText = "";
			this.txtSMPTServer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSMPTServer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSMPTServer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSMPTServer.DisabledState.Parent = this.txtSMPTServer;
			this.txtSMPTServer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSMPTServer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSMPTServer.FocusedState.Parent = this.txtSMPTServer;
			this.txtSMPTServer.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtSMPTServer.ForeColor = System.Drawing.Color.Black;
			this.txtSMPTServer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSMPTServer.HoverState.Parent = this.txtSMPTServer;
			this.txtSMPTServer.Location = new System.Drawing.Point(114, 302);
			this.txtSMPTServer.Name = "txtSMPTServer";
			this.txtSMPTServer.PasswordChar = '\0';
			this.txtSMPTServer.PlaceholderText = "SMPT Server";
			this.txtSMPTServer.SelectedText = "";
			this.txtSMPTServer.ShadowDecoration.Parent = this.txtSMPTServer;
			this.txtSMPTServer.Size = new System.Drawing.Size(336, 36);
			this.txtSMPTServer.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(111, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(331, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Please use your email and password to send email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(107, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(336, 40);
			this.label4.TabIndex = 9;
			this.label4.Text = "Send Email to Admin";
			// 
			// btnSend
			// 
			this.btnSend.Animated = true;
			this.btnSend.BackColor = System.Drawing.Color.Transparent;
			this.btnSend.BorderRadius = 10;
			this.btnSend.CheckedState.Parent = this.btnSend;
			this.btnSend.CustomImages.Parent = this.btnSend;
			this.btnSend.DisabledState.Parent = this.btnSend;
			this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.btnSend.Font = new System.Drawing.Font("Montserrat", 8.999999F);
			this.btnSend.ForeColor = System.Drawing.Color.White;
			this.btnSend.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSend.HoverState.Parent = this.btnSend;
			this.btnSend.Location = new System.Drawing.Point(584, 559);
			this.btnSend.Name = "btnSend";
			this.btnSend.ShadowDecoration.Parent = this.btnSend;
			this.btnSend.Size = new System.Drawing.Size(336, 39);
			this.btnSend.TabIndex = 9;
			this.btnSend.Text = "Send";
			this.btnSend.UseTransparentBackground = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtSenderEmail
			// 
			this.txtSenderEmail.Animated = true;
			this.txtSenderEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtSenderEmail.BorderRadius = 6;
			this.txtSenderEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSenderEmail.DefaultText = "";
			this.txtSenderEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSenderEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSenderEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSenderEmail.DisabledState.Parent = this.txtSenderEmail;
			this.txtSenderEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSenderEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSenderEmail.FocusedState.Parent = this.txtSenderEmail;
			this.txtSenderEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtSenderEmail.ForeColor = System.Drawing.Color.Black;
			this.txtSenderEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSenderEmail.HoverState.Parent = this.txtSenderEmail;
			this.txtSenderEmail.Location = new System.Drawing.Point(114, 218);
			this.txtSenderEmail.Name = "txtSenderEmail";
			this.txtSenderEmail.PasswordChar = '\0';
			this.txtSenderEmail.PlaceholderText = "Sender Email";
			this.txtSenderEmail.SelectedText = "";
			this.txtSenderEmail.ShadowDecoration.Parent = this.txtSenderEmail;
			this.txtSenderEmail.Size = new System.Drawing.Size(336, 36);
			this.txtSenderEmail.TabIndex = 1;
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
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// txtSenderPassword
			// 
			this.txtSenderPassword.Animated = true;
			this.txtSenderPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtSenderPassword.BorderRadius = 6;
			this.txtSenderPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSenderPassword.DefaultText = "";
			this.txtSenderPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSenderPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSenderPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSenderPassword.DisabledState.Parent = this.txtSenderPassword;
			this.txtSenderPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSenderPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSenderPassword.FocusedState.Parent = this.txtSenderPassword;
			this.txtSenderPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtSenderPassword.ForeColor = System.Drawing.Color.Black;
			this.txtSenderPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSenderPassword.HoverState.Parent = this.txtSenderPassword;
			this.txtSenderPassword.Location = new System.Drawing.Point(114, 260);
			this.txtSenderPassword.Name = "txtSenderPassword";
			this.txtSenderPassword.PasswordChar = '\0';
			this.txtSenderPassword.PlaceholderText = "Sender Password";
			this.txtSenderPassword.SelectedText = "";
			this.txtSenderPassword.ShadowDecoration.Parent = this.txtSenderPassword;
			this.txtSenderPassword.Size = new System.Drawing.Size(336, 36);
			this.txtSenderPassword.TabIndex = 2;
			this.txtSenderPassword.UseSystemPasswordChar = true;
			// 
			// btnBack
			// 
			this.btnBack.Animated = true;
			this.btnBack.BackColor = System.Drawing.Color.Transparent;
			this.btnBack.BorderRadius = 10;
			this.btnBack.CheckedState.Parent = this.btnBack;
			this.btnBack.CustomImages.Parent = this.btnBack;
			this.btnBack.DisabledState.Parent = this.btnBack;
			this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.btnBack.Font = new System.Drawing.Font("Montserrat", 8.999999F);
			this.btnBack.ForeColor = System.Drawing.Color.White;
			this.btnBack.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnBack.HoverState.Parent = this.btnBack;
			this.btnBack.Location = new System.Drawing.Point(114, 559);
			this.btnBack.Name = "btnBack";
			this.btnBack.ShadowDecoration.Parent = this.btnBack;
			this.btnBack.Size = new System.Drawing.Size(336, 39);
			this.btnBack.TabIndex = 10;
			this.btnBack.Text = "Back";
			this.btnBack.UseTransparentBackground = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// txtSubject
			// 
			this.txtSubject.Animated = true;
			this.txtSubject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtSubject.BorderRadius = 6;
			this.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSubject.DefaultText = "";
			this.txtSubject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSubject.DisabledState.Parent = this.txtSubject;
			this.txtSubject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSubject.FocusedState.Parent = this.txtSubject;
			this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtSubject.ForeColor = System.Drawing.Color.Black;
			this.txtSubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSubject.HoverState.Parent = this.txtSubject;
			this.txtSubject.Location = new System.Drawing.Point(114, 477);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.PasswordChar = '\0';
			this.txtSubject.PlaceholderText = "Subject";
			this.txtSubject.SelectedText = "";
			this.txtSubject.ShadowDecoration.Parent = this.txtSubject;
			this.txtSubject.Size = new System.Drawing.Size(336, 36);
			this.txtSubject.TabIndex = 7;
			// 
			// txtRecipientEmail
			// 
			this.txtRecipientEmail.Animated = true;
			this.txtRecipientEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtRecipientEmail.BorderRadius = 6;
			this.txtRecipientEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRecipientEmail.DefaultText = "fahotel.management@gmail.com";
			this.txtRecipientEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtRecipientEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtRecipientEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtRecipientEmail.DisabledState.Parent = this.txtRecipientEmail;
			this.txtRecipientEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtRecipientEmail.Enabled = false;
			this.txtRecipientEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtRecipientEmail.FocusedState.Parent = this.txtRecipientEmail;
			this.txtRecipientEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtRecipientEmail.ForeColor = System.Drawing.Color.Black;
			this.txtRecipientEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtRecipientEmail.HoverState.Parent = this.txtRecipientEmail;
			this.txtRecipientEmail.Location = new System.Drawing.Point(114, 435);
			this.txtRecipientEmail.Name = "txtRecipientEmail";
			this.txtRecipientEmail.PasswordChar = '\0';
			this.txtRecipientEmail.PlaceholderText = "Recipient Email";
			this.txtRecipientEmail.SelectedText = "";
			this.txtRecipientEmail.ShadowDecoration.Parent = this.txtRecipientEmail;
			this.txtRecipientEmail.Size = new System.Drawing.Size(336, 36);
			this.txtRecipientEmail.TabIndex = 6;
			// 
			// tsSSL
			// 
			this.tsSSL.Animated = true;
			this.tsSSL.BackColor = System.Drawing.Color.Transparent;
			this.tsSSL.Checked = true;
			this.tsSSL.CheckedState.BorderColor = System.Drawing.Color.Black;
			this.tsSSL.CheckedState.FillColor = System.Drawing.Color.Black;
			this.tsSSL.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.tsSSL.CheckedState.InnerColor = System.Drawing.Color.White;
			this.tsSSL.CheckedState.Parent = this.tsSSL;
			this.tsSSL.Location = new System.Drawing.Point(114, 392);
			this.tsSSL.Name = "tsSSL";
			this.tsSSL.ShadowDecoration.Parent = this.tsSSL;
			this.tsSSL.Size = new System.Drawing.Size(35, 20);
			this.tsSSL.TabIndex = 17;
			this.tsSSL.UncheckedState.BorderColor = System.Drawing.Color.Black;
			this.tsSSL.UncheckedState.BorderThickness = 2;
			this.tsSSL.UncheckedState.FillColor = System.Drawing.Color.White;
			this.tsSSL.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
			this.tsSSL.UncheckedState.InnerColor = System.Drawing.Color.Black;
			this.tsSSL.UncheckedState.Parent = this.tsSSL;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(155, 392);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 18);
			this.label1.TabIndex = 18;
			this.label1.Text = "SSL";
			// 
			// FormContactAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(1040, 666);
			this.Controls.Add(this.guna2ControlBox2);
			this.Controls.Add(this.guna2ControlBox1);
			this.Controls.Add(this.guna2Panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormContactAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormLogin";
			this.Load += new System.EventHandler(this.FormContactAdmin_Load);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Button btnSend;
		private Guna.UI2.WinForms.Guna2TextBox txtSenderEmail;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private System.Windows.Forms.Timer timer1;
		private Guna.UI2.WinForms.Guna2TextBox txtServerPortNo;
		private Guna.UI2.WinForms.Guna2TextBox txtSMPTServer;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Label lbDate;
		private Guna.UI2.WinForms.Guna2TextBox txtBody;
		private Guna.UI2.WinForms.Guna2TextBox txtSenderPassword;
		private Guna.UI2.WinForms.Guna2Button btnBack;
		private Guna.UI2.WinForms.Guna2TextBox txtSubject;
		private Guna.UI2.WinForms.Guna2TextBox txtRecipientEmail;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ToggleSwitch tsSSL;
	}
}