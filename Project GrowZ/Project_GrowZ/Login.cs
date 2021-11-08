using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Project_GrowZ
{
	// Token: 0x02000004 RID: 4
	public partial class Login : MetroForm
	{
		// Token: 0x0600002B RID: 43
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002C RID: 44
		private void Login_Load(object sender, EventArgs e)
		{
			this.metroLabel1.Text = "Welcome to project 651 " + this.pcname;
			this.timer1.Start();
		}

		// Token: 0x0600002D RID: 45
		private void timer1_Tick(object sender, EventArgs e)
		{
			base.Hide();
			new Builder().Show();
			this.timer1.Stop();
		}

		// Token: 0x0600002E RID: 46
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCBjFO-AFCnJ4cG-r5ktZdmg");
		}

		// Token: 0x04000043 RID: 67
		private string pcname = SystemInformation.ComputerName;
	}
}
