using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using _7th_Dragon_III_Code_VFD.Properties;

namespace _7th_Dragon_III_Code_VFD
{
	// Token: 0x02000005 RID: 5
	public partial class Main : Form
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000F26E File Offset: 0x0000D46E
		public Main()
		{
			this.InitializeComponent();
			if (Settings.Default.makeBackup)
			{
				this.makeBackupsToolStripMenuItem.Checked = true;
				return;
			}
			this.makeBackupsToolStripMenuItem.Checked = false;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000F2A1 File Offset: 0x0000D4A1
		private void enableButtons()
		{
			this.saveToolStripMenuItem1.Enabled = true;
			this.generalButton.Enabled = true;
			this.characterButton.Enabled = true;
			this.inventoryButton.Enabled = true;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000F2D3 File Offset: 0x0000D4D3
		private void generalButton_Click(object sender, EventArgs e)
		{
			new GeneralEditing().ShowDialog();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000F2E0 File Offset: 0x0000D4E0
		private void characterButton_Click(object sender, EventArgs e)
		{
			new CharacterEditing().ShowDialog();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000F2ED File Offset: 0x0000D4ED
		private void inventoryButton_Click(object sender, EventArgs e)
		{
			new ItemEditing1().ShowDialog();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		private void openToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All files (*.*)|*.*";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			long length = new FileInfo(openFileDialog.FileName).Length;
			if (length > 39936L)
			{
				MessageBox.Show("Invalid save file", "Error");
				return;
			}
			if (length == 39936L)
			{
				Main.SaveData = File.ReadAllBytes(openFileDialog.FileName);
			}
			if (Main.SaveData[1088] == 0)
			{
				MessageBox.Show("This save file seems empty, please play the game and use this slot first.");
				return;
			}
			this.label1.Text = "Filename: " + Path.GetFileNameWithoutExtension(openFileDialog.FileName);
			this.label1.ForeColor = Color.Green;
			this.enableButtons();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000F3B8 File Offset: 0x0000D5B8
		private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "All files (*.*)|*.*";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			if (this.makeBackupsToolStripMenuItem.Checked)
			{
				string fileName = saveFileDialog.FileName;
				File.Copy(fileName, Path.Combine(Path.GetDirectoryName(fileName), Path.GetFileNameWithoutExtension(fileName) + DateTime.Now.ToString(" - h mm ss tt.bak")));
			}
			File.WriteAllBytes(saveFileDialog.FileName, Main.SaveData);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000F432 File Offset: 0x0000D632
		private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000F439 File Offset: 0x0000D639
		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Made by Ukee from GBATemp\nVersion 0.1");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000F448 File Offset: 0x0000D648
		private void makeBackupsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.makeBackupsToolStripMenuItem.Checked)
			{
				this.makeBackupsToolStripMenuItem.Checked = false;
				Settings.Default.makeBackup = false;
			}
			else
			{
				this.makeBackupsToolStripMenuItem.Checked = true;
				Settings.Default.makeBackup = true;
			}
			Settings.Default.Save();
		}

		// Token: 0x04000066 RID: 102
		private const long saveLength = 39936L;

		// Token: 0x04000067 RID: 103
		public static byte[] SaveData;
	}
}
