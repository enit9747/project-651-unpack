using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Project_GrowZ.Properties
{
	// Token: 0x02000006 RID: 6
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002300 File Offset: 0x00000500
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002308 File Offset: 0x00000508
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Project_GrowZ.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002334 File Offset: 0x00000534
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000233B File Offset: 0x0000053B
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002343 File Offset: 0x00000543
		internal static string Main
		{
			get
			{
				return Resources.ResourceManager.GetString("Main", Resources.resourceCulture);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002359 File Offset: 0x00000559
		internal static byte[] probably
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("probably", Resources.resourceCulture);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002374 File Offset: 0x00000574
		internal static byte[] proxy
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("proxy", Resources.resourceCulture);
			}
		}

		// Token: 0x04000049 RID: 73
		private static ResourceManager resourceMan;

		// Token: 0x0400004A RID: 74
		private static CultureInfo resourceCulture;
	}
}
