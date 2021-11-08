namespace Project_GrowZ
{
	// Token: 0x02000004 RID: 4
	public partial class Login : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x0600002F RID: 47
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000030 RID: 48
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Project_GrowZ.Login));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.metroLabel1 = new global::MetroFramework.Controls.MetroLabel();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.metroStyleManager1 = new global::MetroFramework.Components.MetroStyleManager(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.metroStyleManager1).BeginInit();
			base.SuspendLayout();
//			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(23, 63);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(105, 69);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new global::System.Drawing.Point(23, 141);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new global::System.Drawing.Size(172, 19);
			this.metroLabel1.Style = global::MetroFramework.MetroColorStyle.Yellow;
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "Welcome to project 651 ";
			this.metroLabel1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.metroStyleManager1.Owner = this;
			this.metroStyleManager1.Style = global::MetroFramework.MetroColorStyle.Yellow;
			this.metroStyleManager1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(381, 172);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.metroLabel1);
			base.MaximizeBox = false;
			base.Name = "Login";
			base.ShowIcon = false;
			base.Style = global::MetroFramework.MetroColorStyle.Red;
			this.Text = "project 651 v1.5 - retardpasteridiotgrowtopiakid";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.Login_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.metroStyleManager1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000044 RID: 68
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000046 RID: 70
		private global::MetroFramework.Controls.MetroLabel metroLabel1;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000048 RID: 72
		private global::MetroFramework.Components.MetroStyleManager metroStyleManager1;
	}
}
