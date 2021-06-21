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
			this.label1 = new System.Windows.Forms.Label();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
			this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
			this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnContactAdmin = new Guna.UI2.WinForms.Guna2Button();
			this.btnBack = new Guna.UI2.WinForms.Guna2Button();
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(102, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(291, 40);
			this.label1.TabIndex = 11;
			this.label1.Text = "Forgot Password?";
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(106, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(290, 18);
			this.label5.TabIndex = 12;
			this.label5.Text = "Please contact to admin. Click button below";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(106, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 18);
			this.label2.TabIndex = 14;
			this.label2.Text = "to get password";
			// 
			// btnContactAdmin
			// 
			this.btnContactAdmin.Animated = true;
			this.btnContactAdmin.BackColor = System.Drawing.Color.Transparent;
			this.btnContactAdmin.BorderRadius = 10;
			this.btnContactAdmin.CheckedState.Parent = this.btnContactAdmin;
			this.btnContactAdmin.CustomImages.Parent = this.btnContactAdmin;
			this.btnContactAdmin.DisabledState.Parent = this.btnContactAdmin;
			this.btnContactAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.btnContactAdmin.Font = new System.Drawing.Font("Montserrat", 8.999999F);
			this.btnContactAdmin.ForeColor = System.Drawing.Color.White;
			this.btnContactAdmin.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.btnContactAdmin.HoverState.Parent = this.btnContactAdmin;
			this.btnContactAdmin.Location = new System.Drawing.Point(109, 249);
			this.btnContactAdmin.Name = "btnContactAdmin";
			this.btnContactAdmin.ShadowDecoration.Parent = this.btnContactAdmin;
			this.btnContactAdmin.Size = new System.Drawing.Size(165, 39);
			this.btnContactAdmin.TabIndex = 16;
			this.btnContactAdmin.Text = "Contact Admin";
			this.btnContactAdmin.UseTransparentBackground = true;
			this.btnContactAdmin.Click += new System.EventHandler(this.btnContactAdmin_Click);
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
			this.btnBack.Location = new System.Drawing.Point(109, 294);
			this.btnBack.Name = "btnBack";
			this.btnBack.ShadowDecoration.Parent = this.btnBack;
			this.btnBack.Size = new System.Drawing.Size(165, 39);
			this.btnBack.TabIndex = 17;
			this.btnBack.Text = "Back";
			this.btnBack.UseTransparentBackground = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// FormForgotPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
			this.ClientSize = new System.Drawing.Size(498, 428);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnContactAdmin);
			this.Controls.Add(this.guna2ControlBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormForgotPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Forgot Password";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private System.Windows.Forms.ErrorProvider epWarning;
		private System.Windows.Forms.ErrorProvider epWrong;
		private System.Windows.Forms.ErrorProvider epCorrect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2Button btnContactAdmin;
		private Guna.UI2.WinForms.Guna2Button btnBack;
	}
}