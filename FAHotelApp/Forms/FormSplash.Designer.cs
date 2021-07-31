namespace FAHotelApp.Forms
{
	partial class FormSplash
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplash));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.lbUser = new System.Windows.Forms.Label();
			this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 9;
			this.guna2Elipse1.TargetControl = this;
			// 
			// lbUser
			// 
			this.lbUser.AutoSize = true;
			this.lbUser.BackColor = System.Drawing.Color.Transparent;
			this.lbUser.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.lbUser.Font = new System.Drawing.Font("Montserrat SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
			this.lbUser.Location = new System.Drawing.Point(390, 156);
			this.lbUser.Name = "lbUser";
			this.lbUser.Size = new System.Drawing.Size(230, 66);
			this.lbUser.TabIndex = 13;
			this.lbUser.Text = "Loading";
			// 
			// guna2PictureBox2
			// 
			this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
			this.guna2PictureBox2.ImageRotate = 0F;
			this.guna2PictureBox2.Location = new System.Drawing.Point(21, 115);
			this.guna2PictureBox2.Name = "guna2PictureBox2";
			this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
			this.guna2PictureBox2.Size = new System.Drawing.Size(337, 264);
			this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox2.TabIndex = 14;
			this.guna2PictureBox2.TabStop = false;
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
			this.guna2PictureBox1.TabIndex = 1;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// guna2ProgressBar1
			// 
			this.guna2ProgressBar1.Location = new System.Drawing.Point(401, 299);
			this.guna2ProgressBar1.Name = "guna2ProgressBar1";
			this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(71)))));
			this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
			this.guna2ProgressBar1.Size = new System.Drawing.Size(300, 30);
			this.guna2ProgressBar1.TabIndex = 15;
			this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// FormSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(774, 435);
			this.Controls.Add(this.guna2ProgressBar1);
			this.Controls.Add(this.guna2PictureBox2);
			this.Controls.Add(this.lbUser);
			this.Controls.Add(this.guna2PictureBox1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormSplash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label lbUser;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
	}
}