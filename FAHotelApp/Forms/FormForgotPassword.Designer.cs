namespace FAHotelApp.Forms
{
	partial class FormForgotPassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPassword));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.btnGetPassword = new Guna.UI2.WinForms.Guna2Button();
			this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEmployeeID = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
			this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
			this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
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
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.TransparentWhileDrag = true;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// btnGetPassword
			// 
			this.btnGetPassword.Animated = true;
			this.btnGetPassword.BackColor = System.Drawing.Color.Transparent;
			this.btnGetPassword.BorderRadius = 10;
			this.btnGetPassword.CheckedState.Parent = this.btnGetPassword;
			this.btnGetPassword.CustomImages.Parent = this.btnGetPassword;
			this.btnGetPassword.DisabledState.Parent = this.btnGetPassword;
			this.btnGetPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.btnGetPassword.Font = new System.Drawing.Font("Montserrat", 8.999999F);
			this.btnGetPassword.ForeColor = System.Drawing.Color.White;
			this.btnGetPassword.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnGetPassword.HoverState.Parent = this.btnGetPassword;
			this.btnGetPassword.Location = new System.Drawing.Point(111, 305);
			this.btnGetPassword.Name = "btnGetPassword";
			this.btnGetPassword.ShadowDecoration.Parent = this.btnGetPassword;
			this.btnGetPassword.Size = new System.Drawing.Size(141, 39);
			this.btnGetPassword.TabIndex = 3;
			this.btnGetPassword.Text = "Get Password";
			this.btnGetPassword.UseTransparentBackground = true;
			this.btnGetPassword.Click += new System.EventHandler(this.btnGetPassword_Click);
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
			this.txtUsername.Location = new System.Drawing.Point(111, 241);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.PlaceholderText = "Username";
			this.txtUsername.SelectedText = "";
			this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
			this.txtUsername.Size = new System.Drawing.Size(281, 36);
			this.txtUsername.TabIndex = 2;
			this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(108, 137);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(273, 18);
			this.label5.TabIndex = 12;
			this.label5.Text = "Please use your employee id && username";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(104, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(291, 40);
			this.label1.TabIndex = 11;
			this.label1.Text = "Forgot Password?";
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.Animated = true;
			this.txtEmployeeID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.txtEmployeeID.BorderRadius = 6;
			this.txtEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEmployeeID.DefaultText = "";
			this.txtEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmployeeID.DisabledState.Parent = this.txtEmployeeID;
			this.txtEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmployeeID.FocusedState.Parent = this.txtEmployeeID;
			this.txtEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtEmployeeID.ForeColor = System.Drawing.Color.Black;
			this.txtEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmployeeID.HoverState.Parent = this.txtEmployeeID;
			this.txtEmployeeID.Location = new System.Drawing.Point(111, 199);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.PasswordChar = '\0';
			this.txtEmployeeID.PlaceholderText = "Employee ID";
			this.txtEmployeeID.SelectedText = "";
			this.txtEmployeeID.ShadowDecoration.Parent = this.txtEmployeeID;
			this.txtEmployeeID.Size = new System.Drawing.Size(281, 36);
			this.txtEmployeeID.TabIndex = 1;
			this.txtEmployeeID.Leave += new System.EventHandler(this.txtEmployeeID_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(108, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 18);
			this.label2.TabIndex = 14;
			this.label2.Text = "to get password";
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
			this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new System.Drawing.Point(451, 12);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
			this.guna2ControlBox2.Size = new System.Drawing.Size(35, 28);
			this.guna2ControlBox2.TabIndex = 15;
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
			// FormForgotPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(498, 428);
			this.Controls.Add(this.guna2ControlBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmployeeID);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGetPassword);
			this.Controls.Add(this.txtUsername);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormForgotPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormForgotPassword";
			((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2Button btnGetPassword;
		private Guna.UI2.WinForms.Guna2TextBox txtUsername;
		private Guna.UI2.WinForms.Guna2TextBox txtEmployeeID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private System.Windows.Forms.ErrorProvider epWarning;
		private System.Windows.Forms.ErrorProvider epWrong;
		private System.Windows.Forms.ErrorProvider epCorrect;
	}
}