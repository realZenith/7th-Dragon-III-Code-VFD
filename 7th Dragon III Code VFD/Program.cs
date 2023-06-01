using System;
using System.Windows.Forms;

namespace _7th_Dragon_III_Code_VFD
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00010294 File Offset: 0x0000E494
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
