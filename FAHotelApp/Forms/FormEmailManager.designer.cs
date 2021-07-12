namespace FAHotelApp.Forms
{
	partial class FormEmailManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmailManager));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnBack = new Guna.UI2.WinForms.Guna2Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rtxtReceive = new System.Windows.Forms.RichTextBox();
			this.btnReceive = new Guna.UI2.WinForms.Guna2Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtEmailRecipient = new Guna.UI2.WinForms.Guna2TextBox();
			this.cbSubject = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtBody = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
			this.tsSubjectManual = new Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSend = new Guna.UI2.WinForms.Guna2Button();
			this.txtSubject = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbTime = new System.Windows.Forms.Label();
			this.lbDate = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
			this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
			this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
			this.guna2Panel2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
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
			this.guna2Panel2.Controls.Add(this.btnBack);
			this.guna2Panel2.Controls.Add(this.groupBox2);
			this.guna2Panel2.Controls.Add(this.groupBox1);
			this.guna2Panel2.Controls.Add(this.lbTime);
			this.guna2Panel2.Controls.Add(this.lbDate);
			this.guna2Panel2.Controls.Add(this.label5);
			this.guna2Panel2.Controls.Add(this.label4);
			this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			this.guna2Panel2.Size = new System.Drawing.Size(1040, 895);
			this.guna2Panel2.TabIndex = 5;
			// 
			// btnBack
			// 
			this.btnBack.Animated = true;
			this.btnBack.BackColor = System.Drawing.Color.Transparent;
			this.btnBack.BorderRadius = 10;
			this.btnBack.CheckedState.Parent = this.btnBack;
			this.btnBack.CustomImages.Parent = this.btnBack;
			this.btnBack.DisabledState.Parent = this.btnBack;
			this.btnBack.FillColor = System.Drawing.Color.DarkOrange;
			this.btnBack.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.ForeColor = System.Drawing.Color.White;
			this.btnBack.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnBack.HoverState.Parent = this.btnBack;
			this.btnBack.Location = new System.Drawing.Point(154, 819);
			this.btnBack.Name = "btnBack";
			this.btnBack.ShadowDecoration.Parent = this.btnBack;
			this.btnBack.Size = new System.Drawing.Size(336, 39);
			this.btnBack.TabIndex = 30;
			this.btnBack.Text = "Kembali";
			this.btnBack.UseTransparentBackground = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox2.Controls.Add(this.rtxtReceive);
			this.groupBox2.Controls.Add(this.btnReceive);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox2.Location = new System.Drawing.Point(560, 238);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(403, 545);
			this.groupBox2.TabIndex = 77;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Terima";
			// 
			// rtxtReceive
			// 
			this.rtxtReceive.Location = new System.Drawing.Point(30, 51);
			this.rtxtReceive.Name = "rtxtReceive";
			this.rtxtReceive.Size = new System.Drawing.Size(336, 400);
			this.rtxtReceive.TabIndex = 12;
			this.rtxtReceive.Text = "";
			// 
			// btnReceive
			// 
			this.btnReceive.Animated = true;
			this.btnReceive.BackColor = System.Drawing.Color.Transparent;
			this.btnReceive.BorderRadius = 10;
			this.btnReceive.CheckedState.Parent = this.btnReceive;
			this.btnReceive.CustomImages.Parent = this.btnReceive;
			this.btnReceive.DisabledState.Parent = this.btnReceive;
			this.btnReceive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnReceive.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReceive.ForeColor = System.Drawing.Color.White;
			this.btnReceive.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnReceive.HoverState.Parent = this.btnReceive;
			this.btnReceive.Location = new System.Drawing.Point(30, 479);
			this.btnReceive.Name = "btnReceive";
			this.btnReceive.ShadowDecoration.Parent = this.btnReceive;
			this.btnReceive.Size = new System.Drawing.Size(336, 39);
			this.btnReceive.TabIndex = 11;
			this.btnReceive.Text = "Terima";
			this.btnReceive.UseTransparentBackground = true;
			this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox1.Controls.Add(this.txtEmailRecipient);
			this.groupBox1.Controls.Add(this.cbSubject);
			this.groupBox1.Controls.Add(this.txtBody);
			this.groupBox1.Controls.Add(this.btnBrowse);
			this.groupBox1.Controls.Add(this.tsSubjectManual);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnSend);
			this.groupBox1.Controls.Add(this.txtSubject);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.groupBox1.Location = new System.Drawing.Point(121, 238);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(403, 545);
			this.groupBox1.TabIndex = 76;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Kirim";
			// 
			// txtEmailRecipient
			// 
			this.txtEmailRecipient.Animated = true;
			this.txtEmailRecipient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtEmailRecipient.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEmailRecipient.DefaultText = "";
			this.txtEmailRecipient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtEmailRecipient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtEmailRecipient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmailRecipient.DisabledState.Parent = this.txtEmailRecipient;
			this.txtEmailRecipient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmailRecipient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmailRecipient.FocusedState.Parent = this.txtEmailRecipient;
			this.txtEmailRecipient.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtEmailRecipient.ForeColor = System.Drawing.Color.Black;
			this.txtEmailRecipient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.txtEmailRecipient.HoverState.Parent = this.txtEmailRecipient;
			this.txtEmailRecipient.Location = new System.Drawing.Point(33, 51);
			this.txtEmailRecipient.Name = "txtEmailRecipient";
			this.txtEmailRecipient.PasswordChar = '\0';
			this.txtEmailRecipient.PlaceholderText = "Email Penerima";
			this.txtEmailRecipient.SelectedText = "";
			this.txtEmailRecipient.ShadowDecoration.Parent = this.txtEmailRecipient;
			this.txtEmailRecipient.Size = new System.Drawing.Size(336, 36);
			this.txtEmailRecipient.TabIndex = 1;
			this.txtEmailRecipient.Leave += new System.EventHandler(this.txtSenderEmail_Leave);
			// 
			// cbSubject
			// 
			this.cbSubject.BackColor = System.Drawing.Color.Transparent;
			this.cbSubject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.cbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSubject.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSubject.FocusedState.Parent = this.cbSubject;
			this.cbSubject.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.cbSubject.HoverState.Parent = this.cbSubject;
			this.cbSubject.ItemHeight = 30;
			this.cbSubject.Items.AddRange(new object[] {
            "INTERNAL",
            "EKSTERNAL",
            "PUBLIC"});
			this.cbSubject.ItemsAppearance.Parent = this.cbSubject;
			this.cbSubject.Location = new System.Drawing.Point(33, 93);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.ShadowDecoration.Parent = this.cbSubject;
			this.cbSubject.Size = new System.Drawing.Size(336, 36);
			this.cbSubject.StartIndex = 0;
			this.cbSubject.TabIndex = 21;
			// 
			// txtBody
			// 
			this.txtBody.Animated = true;
			this.txtBody.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
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
			this.txtBody.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.txtBody.HoverState.Parent = this.txtBody;
			this.txtBody.Location = new System.Drawing.Point(33, 203);
			this.txtBody.Multiline = true;
			this.txtBody.Name = "txtBody";
			this.txtBody.PasswordChar = '\0';
			this.txtBody.PlaceholderText = "Isi";
			this.txtBody.SelectedText = "";
			this.txtBody.ShadowDecoration.Parent = this.txtBody;
			this.txtBody.Size = new System.Drawing.Size(336, 194);
			this.txtBody.TabIndex = 9;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Animated = true;
			this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
			this.btnBrowse.BorderRadius = 10;
			this.btnBrowse.CheckedState.Parent = this.btnBrowse;
			this.btnBrowse.CustomImages.Parent = this.btnBrowse;
			this.btnBrowse.DisabledState.Parent = this.btnBrowse;
			this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnBrowse.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowse.ForeColor = System.Drawing.Color.White;
			this.btnBrowse.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnBrowse.HoverState.Parent = this.btnBrowse;
			this.btnBrowse.Location = new System.Drawing.Point(151, 412);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.ShadowDecoration.Parent = this.btnBrowse;
			this.btnBrowse.Size = new System.Drawing.Size(108, 39);
			this.btnBrowse.TabIndex = 29;
			this.btnBrowse.Text = "Cari";
			this.btnBrowse.UseTransparentBackground = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// tsSubjectManual
			// 
			this.tsSubjectManual.Animated = true;
			this.tsSubjectManual.BackColor = System.Drawing.Color.Transparent;
			this.tsSubjectManual.CheckedState.BorderColor = System.Drawing.Color.Black;
			this.tsSubjectManual.CheckedState.FillColor = System.Drawing.Color.Black;
			this.tsSubjectManual.CheckedState.InnerBorderColor = System.Drawing.Color.White;
			this.tsSubjectManual.CheckedState.InnerColor = System.Drawing.Color.White;
			this.tsSubjectManual.CheckedState.Parent = this.tsSubjectManual;
			this.tsSubjectManual.Location = new System.Drawing.Point(33, 177);
			this.tsSubjectManual.Name = "tsSubjectManual";
			this.tsSubjectManual.ShadowDecoration.Parent = this.tsSubjectManual;
			this.tsSubjectManual.Size = new System.Drawing.Size(35, 20);
			this.tsSubjectManual.TabIndex = 23;
			this.tsSubjectManual.UncheckedState.BorderColor = System.Drawing.Color.Black;
			this.tsSubjectManual.UncheckedState.BorderThickness = 2;
			this.tsSubjectManual.UncheckedState.FillColor = System.Drawing.Color.White;
			this.tsSubjectManual.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
			this.tsSubjectManual.UncheckedState.InnerColor = System.Drawing.Color.Black;
			this.tsSubjectManual.UncheckedState.Parent = this.tsSubjectManual;
			this.tsSubjectManual.CheckedChanged += new System.EventHandler(this.tsSubjectManual_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(30, 422);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 18);
			this.label3.TabIndex = 28;
			this.label3.Text = "Lampirkan File:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(74, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 15);
			this.label1.TabIndex = 24;
			this.label1.Text = "Input Subject Manual";
			// 
			// btnSend
			// 
			this.btnSend.Animated = true;
			this.btnSend.BackColor = System.Drawing.Color.Transparent;
			this.btnSend.BorderRadius = 10;
			this.btnSend.CheckedState.Parent = this.btnSend;
			this.btnSend.CustomImages.Parent = this.btnSend;
			this.btnSend.DisabledState.Parent = this.btnSend;
			this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(219)))));
			this.btnSend.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSend.ForeColor = System.Drawing.Color.White;
			this.btnSend.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnSend.HoverState.Parent = this.btnSend;
			this.btnSend.Location = new System.Drawing.Point(33, 479);
			this.btnSend.Name = "btnSend";
			this.btnSend.ShadowDecoration.Parent = this.btnSend;
			this.btnSend.Size = new System.Drawing.Size(336, 39);
			this.btnSend.TabIndex = 10;
			this.btnSend.Text = "Kirim";
			this.btnSend.UseTransparentBackground = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtSubject
			// 
			this.txtSubject.Animated = true;
			this.txtSubject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
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
			this.txtSubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.txtSubject.HoverState.Parent = this.txtSubject;
			this.txtSubject.Location = new System.Drawing.Point(33, 135);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.PasswordChar = '\0';
			this.txtSubject.PlaceholderText = "Subjek";
			this.txtSubject.SelectedText = "";
			this.txtSubject.ShadowDecoration.Parent = this.txtSubject;
			this.txtSubject.Size = new System.Drawing.Size(336, 36);
			this.txtSubject.TabIndex = 25;
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.lbTime.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lbTime.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTime.ForeColor = System.Drawing.Color.Black;
			this.lbTime.Location = new System.Drawing.Point(921, 47);
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
			this.lbDate.Location = new System.Drawing.Point(755, 47);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(41, 18);
			this.lbDate.TabIndex = 15;
			this.lbDate.Text = "Date";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(118, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(293, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Silahkan mengisi email penerima dan isinya";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(114, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 40);
			this.label4.TabIndex = 9;
			this.label4.Text = "Email\r\n";
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = global::FAHotelApp.Properties.Resources.FAHotelTransparentLogoNavyBlue;
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
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// epWarning
			// 
			this.epWarning.ContainerControl = this;
			this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
			// 
			// epWrong
			// 
			this.epWrong.ContainerControl = this;
			this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
			// 
			// epCorrect
			// 
			this.epCorrect.ContainerControl = this;
			this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
			// 
			// FormEmailManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(1040, 895);
			this.Controls.Add(this.guna2Panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormEmailManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contact Admin";
			this.Load += new System.EventHandler(this.FormContactAdmin_Load);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Button btnSend;
		private Guna.UI2.WinForms.Guna2TextBox txtEmailRecipient;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.ErrorProvider epWarning;
		private System.Windows.Forms.ErrorProvider epWrong;
		private System.Windows.Forms.ErrorProvider epCorrect;
		private Guna.UI2.WinForms.Guna2ComboBox cbSubject;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ToggleSwitch tsSubjectManual;
		private Guna.UI2.WinForms.Guna2TextBox txtSubject;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox txtBody;
		private Guna.UI2.WinForms.Guna2Button btnBrowse;
		private Guna.UI2.WinForms.Guna2Button btnBack;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private Guna.UI2.WinForms.Guna2Button btnReceive;
		private System.Windows.Forms.RichTextBox rtxtReceive;
	}
}