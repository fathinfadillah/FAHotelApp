namespace FAHotelApp.Forms
{
	partial class FormDashboardtemp
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
			this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbUser = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbUserType = new System.Windows.Forms.Label();
			this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "";
			this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
			this.guna2TextBox1.Location = new System.Drawing.Point(356, 28);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderText = "";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
			this.guna2TextBox1.Size = new System.Drawing.Size(200, 35);
			this.guna2TextBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(590, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Welcome";
			// 
			// lbUser
			// 
			this.lbUser.AutoSize = true;
			this.lbUser.Location = new System.Drawing.Point(672, 28);
			this.lbUser.Name = "lbUser";
			this.lbUser.Size = new System.Drawing.Size(69, 13);
			this.lbUser.TabIndex = 2;
			this.lbUser.Text = "DisplayName";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(590, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "User Type";
			// 
			// lbUserType
			// 
			this.lbUserType.AutoSize = true;
			this.lbUserType.Location = new System.Drawing.Point(672, 50);
			this.lbUserType.Name = "lbUserType";
			this.lbUserType.Size = new System.Drawing.Size(53, 13);
			this.lbUserType.TabIndex = 4;
			this.lbUserType.Text = "UserType";
			// 
			// btnLogOut
			// 
			this.btnLogOut.Animated = true;
			this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
			this.btnLogOut.BorderRadius = 10;
			this.btnLogOut.CheckedState.Parent = this.btnLogOut;
			this.btnLogOut.CustomImages.Parent = this.btnLogOut;
			this.btnLogOut.DisabledState.Parent = this.btnLogOut;
			this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.btnLogOut.Font = new System.Drawing.Font("Montserrat", 8.999999F);
			this.btnLogOut.ForeColor = System.Drawing.Color.White;
			this.btnLogOut.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnLogOut.HoverState.Parent = this.btnLogOut;
			this.btnLogOut.Location = new System.Drawing.Point(593, 101);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
			this.btnLogOut.Size = new System.Drawing.Size(181, 39);
			this.btnLogOut.TabIndex = 12;
			this.btnLogOut.Text = "LogOut";
			this.btnLogOut.UseTransparentBackground = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// FormDashboardtemp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1166, 752);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.lbUserType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2TextBox1);
			this.Name = "FormDashboardtemp";
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbUser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbUserType;
		private Guna.UI2.WinForms.Guna2Button btnLogOut;
	}
}