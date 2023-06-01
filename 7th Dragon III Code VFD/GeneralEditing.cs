using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _7th_Dragon_III_Code_VFD
{
	// Token: 0x02000006 RID: 6
	public partial class GeneralEditing : Form
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
		public GeneralEditing()
		{
			this.InitializeComponent();
			this.azNumericUpDown.Value = BitConverter.ToUInt32(Main.SaveData, 23248);
			this.dzNumericUpDown.Value = BitConverter.ToUInt32(Main.SaveData, 23252);
			(new byte[2])[1] = 1;
			if (Convert.ToInt16(Main.SaveData[1057]) == 1)
			{
				this.standardRadioButton.Checked = true;
				return;
			}
			this.casualRadioButton.Checked = true;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000FD48 File Offset: 0x0000DF48
		public void SaveGeneral()
		{
			int num = (int)this.azNumericUpDown.Value;
			Main.SaveData[23248] = (byte)(num & 255);
			Main.SaveData[23249] = (byte)((num >> 8) & 255);
			Main.SaveData[23250] = (byte)((num >> 16) & 255);
			int num2 = (int)this.dzNumericUpDown.Value;
			Main.SaveData[23252] = (byte)(num2 & 255);
			Main.SaveData[23253] = (byte)((num2 >> 8) & 255);
			Main.SaveData[23254] = 0;
			if (this.casualRadioButton.Checked)
			{
				Main.SaveData[1057] = 0;
				return;
			}
			Main.SaveData[1057] = 1;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000FE0F File Offset: 0x0000E00F
		private void GeneralEditing_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SaveGeneral();
		}
	}
}
