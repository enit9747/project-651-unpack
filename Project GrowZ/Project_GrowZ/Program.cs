using System;
using System.Windows.Forms;

namespace Project_GrowZ
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000022E9 File Offset: 0x000004E9
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
